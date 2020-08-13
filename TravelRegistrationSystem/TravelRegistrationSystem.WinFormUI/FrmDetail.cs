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
using System.Threading;
using TravelRegistrationSystem.WinFormUI.Infrastructure;

namespace TravelRegistrationSystem.WinFormUI
{
    public partial class FrmDetail : Skin_Metro
    {
        private IUserInfoRepository uInfoRepository;

        public FrmDetail(IUserInfoRepository userInfoRepository)
        {
            uInfoRepository = userInfoRepository;
            InitializeComponent();
        }
        private int currentID;
        //定义委托具体执行的方法
        public void ToShowGetUserInfo(int id)
        {
            currentID = id;
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            this.Tag = WinTag.frmSign;
            this.Close();
        }

        private void FrmDetail_Load(object sender, EventArgs e)
        {
            //加载数据开始
            LoadController.State = "正在加载...";
            Thread.Sleep(500);
            //处理配置文件
            this.lblModality.Text = ModalityConfig.getXmlCate()+":";
            //标记跳转到主窗口
            this.Tag = WinTag.frmSignQuery;
            var uInfo = uInfoRepository.UserInfoes.FirstOrDefault(p => p.ID == currentID);
            if (uInfo == null)
            {
                MessageBox.Show("跳转失败了");
                DialogHelper.ShowNextDlg(new Thread(delegate() { NinjectControllerFactory.Resolve<FrmSignQuery>().ShowDialog(); }));
                return;
            }
            //赋值操作
            this.lblShowModality.Text = uInfo.modality;
            this.lblShowName.Text = uInfo.uName;
            this.lblShowAge.Text = uInfo.age.ToString();
            this.lblShowPhoneNum.Text = uInfo.phoneNum.ToString();
            this.lblShowPersonIDNum.Text = uInfo.personIDNum;
            this.lblShowComment.Text = uInfo.comment;
            this.lblShowGender.Text = uInfo.gender;
            this.lblID.Text = uInfo.ID.ToString();
            //图片显示处理
            this.picShowMyPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            this.picShowMyPhoto.Image = ImageHelper.BytesToImage(uInfo.photo);
            //加载完成
            LoadController.State = "加载完成...";
            Thread.Sleep(500);
            //关闭加载界面
            LoadController.Close();
        }

        private void FrmDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Tag.ToString() == WinTag.frmSignQuery.ToString())
            {
                //报名查询窗体
                DialogHelper.ShowNextDlg(new Thread(delegate() { NinjectControllerFactory.Resolve<FrmSignQuery>().ShowDialog(); }));
            }
            else
            {
                //报名窗体（从而进行修改）
                var tmpFrmSign = NinjectControllerFactory.Resolve<FrmSign>();
                tmpFrmSign.FillID = Convert.ToInt32(lblID.Text);
                DialogHelper.ShowNextDlg(new Thread(delegate() { tmpFrmSign.ShowDialog(); }));
            }
        }
    }
}
