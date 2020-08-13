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
using TravelRegistrationSystem.Domain.Entities;
using Ninject;
using System.Threading;

namespace TravelRegistrationSystem.WinFormUI
{
    public delegate void SendUserInfoToFrmDetail(int id);           //定义一个委托，向Detail窗体发送数据

    public partial class FrmMain :Skin_VS
    {
        /*
        private IUserAdminRepository uAdminRepository;
        private IUserInfoRepository uInfoRepository;
        */
        public FrmMain()
        {
            InitializeComponent();
        }
        /*
        public FrmMain(IUserAdminRepository adminRepository,IUserInfoRepository userInfoRepository)
        {
            uAdminRepository = adminRepository;
            uInfoRepository = userInfoRepository;
            InitializeComponent();
        }
        */
        //管理员登录
        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            DialogHelper.ShowNextDlg(new Thread(delegate() { NinjectControllerFactory.Resolve<FrmLogin>().ShowDialog(); }));
            this.Close();
        }
        //用户报名
        private void btnUserSignUp_Click(object sender, EventArgs e)
        {
            DialogHelper.ShowNextDlg(new Thread(delegate() { NinjectControllerFactory.Resolve<FrmSign>().ShowDialog(); }));
            this.Close();
        }
        //报名信息查询
        private void btnSignQuery_Click(object sender, EventArgs e)
        {
            DialogHelper.ShowNextDlg(new Thread(delegate() { NinjectControllerFactory.Resolve<FrmSignQuery>().ShowDialog(); }));
            this.Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Text = ModalityConfig.getXmlTitle();
        }
    }
}
