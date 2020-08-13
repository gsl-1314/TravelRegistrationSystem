namespace TravelRegistrationSystem.WinFormUI
{
    partial class FrmSignQuery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSignQuery));
            this.lblTitle = new CCWin.SkinControl.SkinLabel();
            this.lblUserInfoPwd = new CCWin.SkinControl.SkinLabel();
            this.lblUserInfoName = new CCWin.SkinControl.SkinLabel();
            this.txtUserInfoID = new CCWin.SkinControl.SkinTextBox();
            this.txtUserInfoName = new CCWin.SkinControl.SkinTextBox();
            this.btnExit = new CCWin.SkinControl.SkinButton();
            this.btnQuery = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.BorderColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("华文新魏", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(494, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(251, 39);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "报名信息查询";
            // 
            // lblUserInfoPwd
            // 
            this.lblUserInfoPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserInfoPwd.AutoSize = true;
            this.lblUserInfoPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblUserInfoPwd.BorderColor = System.Drawing.Color.White;
            this.lblUserInfoPwd.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserInfoPwd.Location = new System.Drawing.Point(234, 250);
            this.lblUserInfoPwd.Name = "lblUserInfoPwd";
            this.lblUserInfoPwd.Size = new System.Drawing.Size(117, 31);
            this.lblUserInfoPwd.TabIndex = 5;
            this.lblUserInfoPwd.Text = "身份证号:";
            // 
            // lblUserInfoName
            // 
            this.lblUserInfoName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserInfoName.AutoSize = true;
            this.lblUserInfoName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserInfoName.BorderColor = System.Drawing.Color.White;
            this.lblUserInfoName.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserInfoName.Location = new System.Drawing.Point(282, 149);
            this.lblUserInfoName.Name = "lblUserInfoName";
            this.lblUserInfoName.Size = new System.Drawing.Size(69, 31);
            this.lblUserInfoName.TabIndex = 6;
            this.lblUserInfoName.Text = "姓名:";
            // 
            // txtUserInfoID
            // 
            this.txtUserInfoID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserInfoID.BackColor = System.Drawing.Color.Transparent;
            this.txtUserInfoID.DownBack = null;
            this.txtUserInfoID.Icon = null;
            this.txtUserInfoID.IconIsButton = false;
            this.txtUserInfoID.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtUserInfoID.IsPasswordChat = '◉';
            this.txtUserInfoID.IsSystemPasswordChar = false;
            this.txtUserInfoID.Lines = new string[0];
            this.txtUserInfoID.Location = new System.Drawing.Point(420, 244);
            this.txtUserInfoID.Margin = new System.Windows.Forms.Padding(0);
            this.txtUserInfoID.MaxLength = 25;
            this.txtUserInfoID.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtUserInfoID.MouseBack = null;
            this.txtUserInfoID.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtUserInfoID.Multiline = true;
            this.txtUserInfoID.Name = "txtUserInfoID";
            this.txtUserInfoID.NormlBack = null;
            this.txtUserInfoID.Padding = new System.Windows.Forms.Padding(5);
            this.txtUserInfoID.ReadOnly = false;
            this.txtUserInfoID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserInfoID.Size = new System.Drawing.Size(448, 39);
            // 
            // 
            // 
            this.txtUserInfoID.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserInfoID.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserInfoID.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtUserInfoID.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtUserInfoID.SkinTxt.MaxLength = 25;
            this.txtUserInfoID.SkinTxt.Multiline = true;
            this.txtUserInfoID.SkinTxt.Name = "BaseText";
            this.txtUserInfoID.SkinTxt.PasswordChar = '◉';
            this.txtUserInfoID.SkinTxt.Size = new System.Drawing.Size(438, 29);
            this.txtUserInfoID.SkinTxt.TabIndex = 0;
            this.txtUserInfoID.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtUserInfoID.SkinTxt.WaterText = "请输入您的身份证号";
            this.txtUserInfoID.TabIndex = 10;
            this.txtUserInfoID.TabStop = true;
            this.txtUserInfoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserInfoID.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtUserInfoID.WaterText = "请输入您的身份证号";
            this.txtUserInfoID.WordWrap = true;
            // 
            // txtUserInfoName
            // 
            this.txtUserInfoName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserInfoName.BackColor = System.Drawing.Color.Transparent;
            this.txtUserInfoName.DownBack = null;
            this.txtUserInfoName.Icon = null;
            this.txtUserInfoName.IconIsButton = false;
            this.txtUserInfoName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtUserInfoName.IsPasswordChat = '\0';
            this.txtUserInfoName.IsSystemPasswordChar = false;
            this.txtUserInfoName.Lines = new string[0];
            this.txtUserInfoName.Location = new System.Drawing.Point(419, 143);
            this.txtUserInfoName.Margin = new System.Windows.Forms.Padding(0);
            this.txtUserInfoName.MaxLength = 20;
            this.txtUserInfoName.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtUserInfoName.MouseBack = null;
            this.txtUserInfoName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtUserInfoName.Multiline = true;
            this.txtUserInfoName.Name = "txtUserInfoName";
            this.txtUserInfoName.NormlBack = null;
            this.txtUserInfoName.Padding = new System.Windows.Forms.Padding(5);
            this.txtUserInfoName.ReadOnly = false;
            this.txtUserInfoName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserInfoName.Size = new System.Drawing.Size(451, 37);
            // 
            // 
            // 
            this.txtUserInfoName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserInfoName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserInfoName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtUserInfoName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtUserInfoName.SkinTxt.MaxLength = 20;
            this.txtUserInfoName.SkinTxt.Multiline = true;
            this.txtUserInfoName.SkinTxt.Name = "BaseText";
            this.txtUserInfoName.SkinTxt.Size = new System.Drawing.Size(441, 27);
            this.txtUserInfoName.SkinTxt.TabIndex = 0;
            this.txtUserInfoName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtUserInfoName.SkinTxt.WaterText = "请输入您的姓名";
            this.txtUserInfoName.TabIndex = 9;
            this.txtUserInfoName.TabStop = true;
            this.txtUserInfoName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserInfoName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtUserInfoName.WaterText = "请输入您的姓名";
            this.txtUserInfoName.WordWrap = true;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnExit.DownBack = null;
            this.btnExit.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(679, 336);
            this.btnExit.MouseBack = null;
            this.btnExit.Name = "btnExit";
            this.btnExit.NormlBack = null;
            this.btnExit.Size = new System.Drawing.Size(264, 67);
            this.btnExit.TabIndex = 7;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnQuery.BackColor = System.Drawing.Color.Transparent;
            this.btnQuery.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnQuery.DownBack = null;
            this.btnQuery.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Location = new System.Drawing.Point(201, 336);
            this.btnQuery.MouseBack = null;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.NormlBack = null;
            this.btnQuery.Size = new System.Drawing.Size(264, 67);
            this.btnQuery.TabIndex = 8;
            this.btnQuery.TabStop = false;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // FrmSignQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 451);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUserInfoPwd);
            this.Controls.Add(this.lblUserInfoName);
            this.Controls.Add(this.txtUserInfoID);
            this.Controls.Add(this.txtUserInfoName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnQuery);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSignQuery";
            this.Text = "报名信息查询";
            this.TitleCenter = false;
            this.TitleColor = System.Drawing.Color.White;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSignQuery_FormClosed);
            this.Load += new System.EventHandler(this.FrmSignQuery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel lblTitle;
        private CCWin.SkinControl.SkinLabel lblUserInfoPwd;
        private CCWin.SkinControl.SkinLabel lblUserInfoName;
        private CCWin.SkinControl.SkinTextBox txtUserInfoID;
        private CCWin.SkinControl.SkinTextBox txtUserInfoName;
        private CCWin.SkinControl.SkinButton btnExit;
        private CCWin.SkinControl.SkinButton btnQuery;
    }
}