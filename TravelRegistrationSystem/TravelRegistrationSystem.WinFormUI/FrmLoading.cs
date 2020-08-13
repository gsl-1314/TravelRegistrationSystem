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

namespace TravelRegistrationSystem.WinFormUI
{
    /// <summary>
    /// 加载界面
    /// </summary>
    public partial class FrmLoading :Skin_Metro,ILoad
    {
        public FrmLoading()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        public void SetState(string state)
        {
            this.lblState.Text = state;
        }

        private void FrmLoading_Load(object sender, EventArgs e)
        {
            this.rollingBar.StartRolling();
        }

        private void FrmLoading_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
