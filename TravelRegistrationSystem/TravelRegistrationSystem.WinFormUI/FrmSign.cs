using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//add
using CCWin;
using TravelRegistrationSystem.Domain.Abstract;
using TravelRegistrationSystem.Domain.Entities;
using System.Drawing.Imaging;
using CCWin.SkinControl;
using System.Text.RegularExpressions;
using System.Threading;
using TravelRegistrationSystem.WinFormUI.Infrastructure;

namespace TravelRegistrationSystem.WinFormUI
{
    
    public partial class FrmSign :Skin_Metro
    {
        private IUserInfoRepository uInfoRepository;
        private UserInfo uInfo;

        public event SendUserInfoToFrmDetail sendUser_Event;                //实例化SendUserInfoToFrmDetail委托类型的事件

        //ID处理
        public int FillID
        {
            get
            {
                return Convert.ToInt32(this.lblID.Text);
            }
            set
            {
                this.lblID.Text = value.ToString();
            }
        }
        public string FillName { get { return this.txtName.Text.ToString().Trim().Replace(" ", ""); } }
        public string FillSubject { get { return this.cboModality.SelectedItem.ToString(); } }
        public string FillPhoneNum { get { return this.txtPhoneNum.Text.ToString().Trim().Replace(" ", ""); } }
        public string FillPersonIDNum { get { return this.txtPersonIDNum.Text.ToString().Trim().Replace(" ", ""); } }
        //性别特殊处理
        public string FillGender
        {
            get
            {
                return this.rdoMale.Checked ? "男" : "女";
            }
        }
        //年龄特殊处理
        public int FillAge
        {
            get
            {
                return Convert.ToInt32(this.cboAge.SelectedItem.ToString());
            }
        }
        //照片特殊处理
        public  byte []  FillPhoto
        {
            get
            {
                return ImageHelper.ImageToBytes(this.picMyPhoto.Image,ImageFormat.Jpeg);
            }
        }
        public string FillComment { get { return this.txtComment.Text.ToString(); } }

        public DateTime FillDateTime { get { return DateTime.Now; } }

        //默认构造函数
        public FrmSign()
        {
            InitializeComponent();
        }
        //重载构造函数
        public FrmSign(IUserInfoRepository userInfoRepository)
        {
            uInfoRepository = userInfoRepository;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //处理窗口跳转
            this.Tag = WinTag.frmDetail;
            //验证文本框内容是否为空
            bool isTextBoxNull = false; 
            foreach (Control cur in Controls)
            {
                if (cur is SkinTextBox && cur.Text == String.Empty)
                {
                    isTextBoxNull = true;
                }
            }
            if (isTextBoxNull)
            {
                MessageBox.Show("亲，文本框是空的！");
                return;
            }
            //验证手机号、身份证号
            if((!Regex.IsMatch(FillPersonIDNum,RegExpression.ID))
                || !Regex.IsMatch(FillPhoneNum, RegExpression.Phone))
            {
                MessageBox.Show("身份证、手机号输入有误!");
                return;
            }
            if (!(FillID > 0))          //判断是修改还是添加，修改不用检索是否存在这个记录。
            {
                //判定是否已经存在该记录了
                int isHaveMask = uInfoRepository.UserInfoes.Where(p => p.personIDNum == FillPersonIDNum).ToList().Count;
                if (isHaveMask > 0)
                {
                    MessageBox.Show("该人已经报名过了！");
                    return;
                }
            }
            //判定照片是否为空
            if (ImageHelper.ImageToBytes(picMyPhoto.Image, ImageFormat.Jpeg) == null)
            {
                MessageBox.Show("没有选择头像，亲！");
                return;
            }
            //存储数据到实体模型
            uInfo = new UserInfo()
            {
                ID=FillID,
                uName = FillName,
                modality = FillSubject,
                phoneNum = FillPhoneNum,
                personIDNum = FillPersonIDNum,
                gender = FillGender,
                age = FillAge,
                photo = FillPhoto,
                comment = FillComment,
                registrationDeadline=FillDateTime
            };
           //调用EF相关方法
            try 
            { 
                uInfoRepository.SaveUserInfo(uInfo);
                MessageBox.Show("保存成功了   " + uInfo.uName);
             }
            catch
            {
                throw;
            }
            this.Close();
        }

        private void FrmSign_Load(object sender, EventArgs e)
        {
            //处理配置文件
            this.lblModality.Text = ModalityConfig.getXmlCate()+":";
            //处理下拉选择框
            this.Tag = WinTag.frmMain;
            foreach (DataRowView dr in ModalityConfig.getXmlSubjectData().Tables[0].DefaultView)
            {
                this.cboModality.Items.Add(dr["name"].ToString());
            }
            for (int i = 70; i >= 3; i--)
            {
                this.cboAge.Items.Add("" + i);
            }
            //判断是增加还是修改。
            if (FillID == 0) 
            { 
                //增加时的窗体处理
                this.cboAge.SelectedIndex = 0;
                this.cboModality.SelectedIndex = 0;
            }
            else
            {
                //修改时的窗体处理
                uInfo = uInfoRepository.UserInfoes.FirstOrDefault(p => p.ID == FillID);
                this.cboModality.Text = uInfo.modality;
                this.txtName.Text = uInfo.uName;
                this.txtComment.Text = uInfo.comment;
                this.txtPhoneNum.Text = uInfo.phoneNum;
                this.txtPersonIDNum.Text = uInfo.personIDNum;
                //性别显示
                if (uInfo.gender == "男")
                {
                    rdoMale.Checked = true;
                }
                else
                {
                    rdoFemale.Checked = true;
                }
                this.cboAge.Text = uInfo.age.ToString();
                this.picMyPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                this.picMyPhoto.Image = ImageHelper.BytesToImage(uInfo.photo);
            }
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            //图片处理
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择要上传的图片";
            ofd.InitialDirectory = @"C:\Users\Administrator\Desktop\";
            ofd.Multiselect = false;
            ofd.Filter = "图片文件|*.jpg|所有文件|*.*";
            ofd.ShowDialog();
            picMyPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                picMyPhoto.Image = Image.FromFile(ofd.FileName);
            }
            catch
            {
                return;
            }
        }

        private void FrmSign_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Tag.ToString() == WinTag.frmDetail.ToString())
            {
                //WinTag.frmDetail
                //详情页（委托传值）
                uInfo = uInfoRepository.UserInfoes.FirstOrDefault(p => p.personIDNum == FillPersonIDNum);
                var frmDetail = NinjectControllerFactory.Resolve<FrmDetail>();
                //使用委托把该记录的ID传送到详情窗口
                sendUser_Event +=
                new SendUserInfoToFrmDetail(frmDetail.ToShowGetUserInfo);
                //触发委托
                sendUser_Event.Invoke(uInfo.ID);

                //LoadController——加载窗口控制类，在这里调用Show方法
                //然后在将要显示的窗口 load事件里，设置它的setter——State及加载成功后隐藏该窗口
                LoadController.Show(typeof(FrmLoading));

                DialogHelper.ShowNextDlg(new Thread(delegate() { frmDetail.ShowDialog(); }));
            }
            else
            {
                //WinTag.Main
                //主窗口
                DialogHelper.ShowNextDlg(new Thread(delegate() { NinjectControllerFactory.Resolve<FrmMain>().ShowDialog(); }));
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
