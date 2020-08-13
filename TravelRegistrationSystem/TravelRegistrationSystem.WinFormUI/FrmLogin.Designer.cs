namespace TravelRegistrationSystem.WinFormUI
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btnLogin = new CCWin.SkinControl.SkinButton();
            this.btnExit = new CCWin.SkinControl.SkinButton();
            this.txtAdminName = new CCWin.SkinControl.SkinTextBox();
            this.txtAdminPwd = new CCWin.SkinControl.SkinTextBox();
            this.lblAdminName = new CCWin.SkinControl.SkinLabel();
            this.lblAdminPwd = new CCWin.SkinControl.SkinLabel();
            this.lblTitle = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnLogin.DownBack = null;
            this.btnLogin.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.Location = new System.Drawing.Point(189, 351);
            this.btnLogin.MouseBack = null;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NormlBack = null;
            this.btnLogin.Size = new System.Drawing.Size(264, 67);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnExit.DownBack = null;
            this.btnExit.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(667, 351);
            this.btnExit.MouseBack = null;
            this.btnExit.Name = "btnExit";
            this.btnExit.NormlBack = null;
            this.btnExit.Size = new System.Drawing.Size(264, 67);
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtAdminName
            // 
            this.txtAdminName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdminName.BackColor = System.Drawing.Color.Transparent;
            this.txtAdminName.DownBack = null;
            this.txtAdminName.Icon = null;
            this.txtAdminName.IconIsButton = false;
            this.txtAdminName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtAdminName.IsPasswordChat = '\0';
            this.txtAdminName.IsSystemPasswordChar = false;
            this.txtAdminName.Lines = new string[0];
            this.txtAdminName.Location = new System.Drawing.Point(407, 158);
            this.txtAdminName.Margin = new System.Windows.Forms.Padding(0);
            this.txtAdminName.MaxLength = 25;
            this.txtAdminName.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtAdminName.MouseBack = null;
            this.txtAdminName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtAdminName.Multiline = true;
            this.txtAdminName.Name = "txtAdminName";
            this.txtAdminName.NormlBack = null;
            this.txtAdminName.Padding = new System.Windows.Forms.Padding(5);
            this.txtAdminName.ReadOnly = false;
            this.txtAdminName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdminName.Size = new System.Drawing.Size(451, 37);
            // 
            // 
            // 
            this.txtAdminName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdminName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAdminName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtAdminName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtAdminName.SkinTxt.MaxLength = 25;
            this.txtAdminName.SkinTxt.Multiline = true;
            this.txtAdminName.SkinTxt.Name = "BaseText";
            this.txtAdminName.SkinTxt.Size = new System.Drawing.Size(441, 27);
            this.txtAdminName.SkinTxt.TabIndex = 0;
            this.txtAdminName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtAdminName.SkinTxt.WaterText = "请输入管理员名称";
            this.txtAdminName.TabIndex = 2;
            this.txtAdminName.TabStop = true;
            this.txtAdminName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAdminName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtAdminName.WaterText = "请输入管理员名称";
            this.txtAdminName.WordWrap = true;
            // 
            // txtAdminPwd
            // 
            this.txtAdminPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAdminPwd.BackColor = System.Drawing.Color.Transparent;
            this.txtAdminPwd.DownBack = null;
            this.txtAdminPwd.Icon = null;
            this.txtAdminPwd.IconIsButton = false;
            this.txtAdminPwd.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtAdminPwd.IsPasswordChat = '◉';
            this.txtAdminPwd.IsSystemPasswordChar = false;
            this.txtAdminPwd.Lines = new string[0];
            this.txtAdminPwd.Location = new System.Drawing.Point(408, 259);
            this.txtAdminPwd.Margin = new System.Windows.Forms.Padding(0);
            this.txtAdminPwd.MaxLength = 25;
            this.txtAdminPwd.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtAdminPwd.MouseBack = null;
            this.txtAdminPwd.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtAdminPwd.Multiline = true;
            this.txtAdminPwd.Name = "txtAdminPwd";
            this.txtAdminPwd.NormlBack = null;
            this.txtAdminPwd.Padding = new System.Windows.Forms.Padding(5);
            this.txtAdminPwd.ReadOnly = false;
            this.txtAdminPwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdminPwd.Size = new System.Drawing.Size(448, 39);
            // 
            // 
            // 
            this.txtAdminPwd.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdminPwd.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAdminPwd.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtAdminPwd.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtAdminPwd.SkinTxt.MaxLength = 25;
            this.txtAdminPwd.SkinTxt.Multiline = true;
            this.txtAdminPwd.SkinTxt.Name = "BaseText";
            this.txtAdminPwd.SkinTxt.PasswordChar = '◉';
            this.txtAdminPwd.SkinTxt.Size = new System.Drawing.Size(438, 29);
            this.txtAdminPwd.SkinTxt.TabIndex = 0;
            this.txtAdminPwd.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtAdminPwd.SkinTxt.WaterText = "请输入管理员密码";
            this.txtAdminPwd.TabIndex = 3;
            this.txtAdminPwd.TabStop = true;
            this.txtAdminPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAdminPwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtAdminPwd.WaterText = "请输入管理员密码";
            this.txtAdminPwd.WordWrap = true;
            // 
            // lblAdminName
            // 
            this.lblAdminName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminName.BorderColor = System.Drawing.Color.White;
            this.lblAdminName.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAdminName.Location = new System.Drawing.Point(246, 162);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(93, 31);
            this.lblAdminName.TabIndex = 0;
            this.lblAdminName.Text = "用户名:";
            // 
            // lblAdminPwd
            // 
            this.lblAdminPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdminPwd.AutoSize = true;
            this.lblAdminPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminPwd.BorderColor = System.Drawing.Color.White;
            this.lblAdminPwd.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAdminPwd.Location = new System.Drawing.Point(250, 265);
            this.lblAdminPwd.Name = "lblAdminPwd";
            this.lblAdminPwd.Size = new System.Drawing.Size(69, 31);
            this.lblAdminPwd.TabIndex = 0;
            this.lblAdminPwd.Text = "密码:";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.BorderColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("华文新魏", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(482, 62);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(212, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "管理员登录";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 451);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAdminPwd);
            this.Controls.Add(this.lblAdminName);
            this.Controls.Add(this.txtAdminPwd);
            this.Controls.Add(this.txtAdminName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.Text = "登录";
            this.TitleCenter = false;
            this.TitleColor = System.Drawing.Color.LavenderBlush;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogin_FormClosed);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton btnLogin;
        private CCWin.SkinControl.SkinButton btnExit;
        private CCWin.SkinControl.SkinTextBox txtAdminName;
        private CCWin.SkinControl.SkinTextBox txtAdminPwd;
        private CCWin.SkinControl.SkinLabel lblAdminName;
        private CCWin.SkinControl.SkinLabel lblAdminPwd;
        private CCWin.SkinControl.SkinLabel lblTitle;
    }
}