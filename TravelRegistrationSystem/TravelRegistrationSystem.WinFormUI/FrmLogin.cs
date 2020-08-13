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
using System.Threading;
using TravelRegistrationSystem.Domain.Abstract;
using TravelRegistrationSystem.Domain.Entities;
using TravelRegistrationSystem.WinFormUI.Infrastructure;

namespace TravelRegistrationSystem.WinFormUI
{
    public partial class FrmLogin : Skin_Metro
    {
        private IUserAdminRepository uAdminRepository;

        public string Username { get { return txtAdminName.Text.ToString().Trim().Replace(" ", ""); } }

        public string Password { get { return txtAdminPwd.Text.ToString().Trim().Replace(" ", ""); } }

    
        public FrmLogin(IUserAdminRepository adminRepository)
        {
            uAdminRepository = adminRepository;
            InitializeComponent();
        }
        //管理员登录
        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (Username == "" || Password == "")
            {
                MessageBox.Show("用户和密码不能为空");
                txtAdminName.Focus();
                return;
            }
            //登录判定
            //uAdminRepository成员变量在这里应用
            UserAdmin admin = uAdminRepository.UserAdmins.SingleOrDefault(p => p.uName == Username);
            if (admin == null)
            {
                MessageBox.Show("你输入的用户不存在");
                return;
            }
            else
            {
                if (admin.uPwd != Password)
                {
                    MessageBox.Show("你输入的密码是错误的");
                    return;
                }
                else
                {
                    this.Tag = WinTag.frmManage;
                    this.Close();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(this.Tag.ToString()==WinTag.frmMain.ToString())
            { //主窗口
                DialogHelper.ShowNextDlg(new Thread(delegate() { 
                    NinjectControllerFactory.Resolve<FrmMain>().ShowDialog(); 
                }));
            }
            else
            { //管理员窗口
                LoadController.Show(typeof(FrmLoading));
                DialogHelper.ShowNextDlg(new Thread(delegate() {
                    NinjectControllerFactory.Resolve<FrmManage>().ShowDialog(); 
                }));
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.Tag = WinTag.frmMain;
        }
    }
}
