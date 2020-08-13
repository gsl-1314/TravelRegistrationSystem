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
using TravelRegistrationSystem.WinFormUI.Infrastructure;
using System.Threading;


namespace TravelRegistrationSystem.WinFormUI
{
    public partial class FrmSignQuery : Skin_Metro
    {
        private IUserInfoRepository uInfoRepository;

        public string QueryName { get { return this.txtUserInfoName.Text.ToString().Trim().Replace(" ", ""); } }

        public string QueryPersonIDNum { get { return this.txtUserInfoID.Text.ToString().Trim().Replace(" ", ""); } }

        public event SendUserInfoToFrmDetail sendUser_Event;                //实例化SendUserInfoToFrmDetail委托类型的事件

        public FrmSignQuery(IUserInfoRepository userInfoRepository)
        {
            uInfoRepository = userInfoRepository;
            InitializeComponent();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            var uInfo = uInfoRepository.UserInfoes.SingleOrDefault(p => p.personIDNum == QueryPersonIDNum);
            if (uInfo == null)
            {
                MessageBox.Show("您输入的身份证号在数据库中不存在！");
                return;
            }
            else
            {
                if (uInfo.uName != QueryName)
                {
                    MessageBox.Show("您输入姓名不对！");
                    return;
                }
                else
                {
                    this.Tag = WinTag.frmDetail;
                    this.Close();
                }
            }
        }

        private void FrmSignQuery_Load(object sender, EventArgs e)
        {
            this.Tag = WinTag.frmMain;
        }

        private void FrmSignQuery_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.Tag.ToString() == WinTag.frmDetail.ToString())
            {
                //报名详情窗口
                var uInfo = uInfoRepository.UserInfoes.FirstOrDefault(p => p.personIDNum == QueryPersonIDNum);
                var frmDetail = NinjectControllerFactory.Resolve<FrmDetail>();
                //使用委托把该记录的ID传送到详情窗口
                sendUser_Event += new SendUserInfoToFrmDetail(frmDetail.ToShowGetUserInfo);
                sendUser_Event.Invoke(uInfo.ID);

                //LoadController——加载窗口控制类，在这里调用Show方法
                //然后在将要显示的窗口 load事件里，设置它的setter——State及加载成功后隐藏该窗口
                LoadController.Show(typeof(FrmLoading));

                DialogHelper.ShowNextDlg(new Thread(delegate()
                {
                    frmDetail.ShowDialog();
                }));
            }
            else
            {
                //主窗口
                DialogHelper.ShowNextDlg(new Thread(delegate()
                {
                    NinjectControllerFactory.Resolve<FrmMain>().ShowDialog();
                }));
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
