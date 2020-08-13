namespace TravelRegistrationSystem.WinFormUI
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btnAdminLogin = new CCWin.SkinControl.SkinButton();
            this.btnUserSignUp = new CCWin.SkinControl.SkinButton();
            this.btnSignQuery = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdminLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnAdminLogin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAdminLogin.DownBack = null;
            this.btnAdminLogin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdminLogin.Location = new System.Drawing.Point(313, 111);
            this.btnAdminLogin.MouseBack = null;
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.NormlBack = null;
            this.btnAdminLogin.Size = new System.Drawing.Size(282, 53);
            this.btnAdminLogin.TabIndex = 0;
            this.btnAdminLogin.Text = "管理员登录";
            this.btnAdminLogin.UseVisualStyleBackColor = false;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // btnUserSignUp
            // 
            this.btnUserSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUserSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnUserSignUp.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnUserSignUp.DownBack = null;
            this.btnUserSignUp.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUserSignUp.Location = new System.Drawing.Point(313, 243);
            this.btnUserSignUp.MouseBack = null;
            this.btnUserSignUp.Name = "btnUserSignUp";
            this.btnUserSignUp.NormlBack = null;
            this.btnUserSignUp.Size = new System.Drawing.Size(282, 53);
            this.btnUserSignUp.TabIndex = 1;
            this.btnUserSignUp.Text = "用户报名";
            this.btnUserSignUp.UseVisualStyleBackColor = false;
            this.btnUserSignUp.Click += new System.EventHandler(this.btnUserSignUp_Click);
            // 
            // btnSignQuery
            // 
            this.btnSignQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignQuery.BackColor = System.Drawing.Color.Transparent;
            this.btnSignQuery.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSignQuery.DownBack = null;
            this.btnSignQuery.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSignQuery.Location = new System.Drawing.Point(313, 383);
            this.btnSignQuery.MouseBack = null;
            this.btnSignQuery.Name = "btnSignQuery";
            this.btnSignQuery.NormlBack = null;
            this.btnSignQuery.Size = new System.Drawing.Size(282, 53);
            this.btnSignQuery.TabIndex = 2;
            this.btnSignQuery.Text = "报名信息查询";
            this.btnSignQuery.UseVisualStyleBackColor = false;
            this.btnSignQuery.Click += new System.EventHandler(this.btnSignQuery_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(920, 528);
            this.Controls.Add(this.btnSignQuery);
            this.Controls.Add(this.btnUserSignUp);
            this.Controls.Add(this.btnAdminLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Tag = "1";
            this.Text = "某某旅游景点报名系统";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinButton btnAdminLogin;
        private CCWin.SkinControl.SkinButton btnUserSignUp;
        private CCWin.SkinControl.SkinButton btnSignQuery;

    }
}

