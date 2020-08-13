namespace TravelRegistrationSystem.WinFormUI
{
    partial class FrmSign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSign));
            this.lblTitle = new CCWin.SkinControl.SkinLabel();
            this.lblModality = new CCWin.SkinControl.SkinLabel();
            this.cboModality = new CCWin.SkinControl.SkinComboBox();
            this.lblName = new CCWin.SkinControl.SkinLabel();
            this.lblPhoneNum = new CCWin.SkinControl.SkinLabel();
            this.lblPersonIDNum = new CCWin.SkinControl.SkinLabel();
            this.lblGender = new CCWin.SkinControl.SkinLabel();
            this.lblAge = new CCWin.SkinControl.SkinLabel();
            this.lblPhoto = new CCWin.SkinControl.SkinLabel();
            this.lblComment = new CCWin.SkinControl.SkinLabel();
            this.cboAge = new CCWin.SkinControl.SkinComboBox();
            this.rdoMale = new CCWin.SkinControl.SkinRadioButton();
            this.rdoFemale = new CCWin.SkinControl.SkinRadioButton();
            this.picMyPhoto = new CCWin.SkinControl.SkinPictureBox();
            this.btnSelectPhoto = new CCWin.SkinControl.SkinButton();
            this.txtName = new CCWin.SkinControl.SkinTextBox();
            this.txtPhoneNum = new CCWin.SkinControl.SkinTextBox();
            this.txtPersonIDNum = new CCWin.SkinControl.SkinTextBox();
            this.txtComment = new CCWin.SkinControl.SkinTextBox();
            this.btnSave = new CCWin.SkinControl.SkinButton();
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.lblID = new CCWin.SkinControl.SkinLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picMyPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.BorderColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(357, 51);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(279, 53);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "报名信息填写";
            // 
            // lblModality
            // 
            this.lblModality.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModality.AutoSize = true;
            this.lblModality.BackColor = System.Drawing.Color.Transparent;
            this.lblModality.BorderColor = System.Drawing.Color.White;
            this.lblModality.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblModality.Location = new System.Drawing.Point(280, 118);
            this.lblModality.Name = "lblModality";
            this.lblModality.Size = new System.Drawing.Size(99, 32);
            this.lblModality.TabIndex = 0;
            this.lblModality.Text = "形式：";
            // 
            // cboModality
            // 
            this.cboModality.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboModality.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboModality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModality.FormattingEnabled = true;
            this.cboModality.Location = new System.Drawing.Point(388, 122);
            this.cboModality.Name = "cboModality";
            this.cboModality.Size = new System.Drawing.Size(324, 26);
            this.cboModality.TabIndex = 1;
            this.cboModality.WaterText = "";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.BorderColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(280, 174);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(99, 32);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓名：";
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNum.BorderColor = System.Drawing.Color.White;
            this.lblPhoneNum.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPhoneNum.Location = new System.Drawing.Point(251, 230);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(127, 32);
            this.lblPhoneNum.TabIndex = 0;
            this.lblPhoneNum.Text = "手机号：";
            // 
            // lblPersonIDNum
            // 
            this.lblPersonIDNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPersonIDNum.AutoSize = true;
            this.lblPersonIDNum.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonIDNum.BorderColor = System.Drawing.Color.White;
            this.lblPersonIDNum.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPersonIDNum.Location = new System.Drawing.Point(224, 286);
            this.lblPersonIDNum.Name = "lblPersonIDNum";
            this.lblPersonIDNum.Size = new System.Drawing.Size(155, 32);
            this.lblPersonIDNum.TabIndex = 0;
            this.lblPersonIDNum.Text = "身份证号：";
            // 
            // lblGender
            // 
            this.lblGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.BorderColor = System.Drawing.Color.White;
            this.lblGender.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGender.Location = new System.Drawing.Point(280, 342);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(99, 32);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "性别：";
            // 
            // lblAge
            // 
            this.lblAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.BorderColor = System.Drawing.Color.White;
            this.lblAge.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAge.Location = new System.Drawing.Point(280, 398);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(99, 32);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "年龄：";
            // 
            // lblPhoto
            // 
            this.lblPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoto.BorderColor = System.Drawing.Color.White;
            this.lblPhoto.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPhoto.Location = new System.Drawing.Point(280, 454);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(99, 32);
            this.lblPhoto.TabIndex = 0;
            this.lblPhoto.Text = "照片：";
            // 
            // lblComment
            // 
            this.lblComment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblComment.AutoSize = true;
            this.lblComment.BackColor = System.Drawing.Color.Transparent;
            this.lblComment.BorderColor = System.Drawing.Color.White;
            this.lblComment.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblComment.Location = new System.Drawing.Point(280, 510);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(99, 32);
            this.lblComment.TabIndex = 0;
            this.lblComment.Text = "备注：";
            // 
            // cboAge
            // 
            this.cboAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboAge.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAge.FormattingEnabled = true;
            this.cboAge.Location = new System.Drawing.Point(388, 406);
            this.cboAge.Name = "cboAge";
            this.cboAge.Size = new System.Drawing.Size(324, 26);
            this.cboAge.TabIndex = 7;
            this.cboAge.WaterText = "";
            // 
            // rdoMale
            // 
            this.rdoMale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoMale.AutoSize = true;
            this.rdoMale.BackColor = System.Drawing.Color.Transparent;
            this.rdoMale.Checked = true;
            this.rdoMale.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.rdoMale.DownBack = null;
            this.rdoMale.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoMale.Location = new System.Drawing.Point(388, 342);
            this.rdoMale.MouseBack = null;
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.NormlBack = null;
            this.rdoMale.SelectedDownBack = null;
            this.rdoMale.SelectedMouseBack = null;
            this.rdoMale.SelectedNormlBack = null;
            this.rdoMale.Size = new System.Drawing.Size(45, 24);
            this.rdoMale.TabIndex = 5;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "男";
            this.rdoMale.UseVisualStyleBackColor = false;
            // 
            // rdoFemale
            // 
            this.rdoFemale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.BackColor = System.Drawing.Color.Transparent;
            this.rdoFemale.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.rdoFemale.DownBack = null;
            this.rdoFemale.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoFemale.Location = new System.Drawing.Point(552, 342);
            this.rdoFemale.MouseBack = null;
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.NormlBack = null;
            this.rdoFemale.SelectedDownBack = null;
            this.rdoFemale.SelectedMouseBack = null;
            this.rdoFemale.SelectedNormlBack = null;
            this.rdoFemale.Size = new System.Drawing.Size(45, 24);
            this.rdoFemale.TabIndex = 6;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "女";
            this.rdoFemale.UseVisualStyleBackColor = false;
            // 
            // picMyPhoto
            // 
            this.picMyPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picMyPhoto.BackColor = System.Drawing.Color.Transparent;
            this.picMyPhoto.Location = new System.Drawing.Point(388, 449);
            this.picMyPhoto.Name = "picMyPhoto";
            this.picMyPhoto.Size = new System.Drawing.Size(143, 50);
            this.picMyPhoto.TabIndex = 17;
            this.picMyPhoto.TabStop = false;
            // 
            // btnSelectPhoto
            // 
            this.btnSelectPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelectPhoto.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectPhoto.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSelectPhoto.DownBack = null;
            this.btnSelectPhoto.Location = new System.Drawing.Point(568, 453);
            this.btnSelectPhoto.MouseBack = null;
            this.btnSelectPhoto.Name = "btnSelectPhoto";
            this.btnSelectPhoto.NormlBack = null;
            this.btnSelectPhoto.Size = new System.Drawing.Size(141, 45);
            this.btnSelectPhoto.TabIndex = 8;
            this.btnSelectPhoto.Text = "选择头像";
            this.btnSelectPhoto.UseVisualStyleBackColor = false;
            this.btnSelectPhoto.Click += new System.EventHandler(this.btnSelectPhoto_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.DownBack = null;
            this.txtName.Icon = null;
            this.txtName.IconIsButton = false;
            this.txtName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtName.IsPasswordChat = '\0';
            this.txtName.IsSystemPasswordChar = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(387, 173);
            this.txtName.Margin = new System.Windows.Forms.Padding(0);
            this.txtName.MaxLength = 32767;
            this.txtName.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtName.MouseBack = null;
            this.txtName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.NormlBack = null;
            this.txtName.Padding = new System.Windows.Forms.Padding(5);
            this.txtName.ReadOnly = false;
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.Size = new System.Drawing.Size(325, 33);
            // 
            // 
            // 
            this.txtName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtName.SkinTxt.Multiline = true;
            this.txtName.SkinTxt.Name = "BaseText";
            this.txtName.SkinTxt.Size = new System.Drawing.Size(315, 23);
            this.txtName.SkinTxt.TabIndex = 0;
            this.txtName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtName.SkinTxt.WaterText = "请输入您的姓名";
            this.txtName.TabIndex = 2;
            this.txtName.TabStop = true;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtName.WaterText = "请输入您的姓名";
            this.txtName.WordWrap = true;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhoneNum.BackColor = System.Drawing.Color.Transparent;
            this.txtPhoneNum.DownBack = null;
            this.txtPhoneNum.Icon = null;
            this.txtPhoneNum.IconIsButton = false;
            this.txtPhoneNum.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPhoneNum.IsPasswordChat = '\0';
            this.txtPhoneNum.IsSystemPasswordChar = false;
            this.txtPhoneNum.Lines = new string[0];
            this.txtPhoneNum.Location = new System.Drawing.Point(387, 230);
            this.txtPhoneNum.Margin = new System.Windows.Forms.Padding(0);
            this.txtPhoneNum.MaxLength = 25;
            this.txtPhoneNum.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtPhoneNum.MouseBack = null;
            this.txtPhoneNum.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPhoneNum.Multiline = true;
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.NormlBack = null;
            this.txtPhoneNum.Padding = new System.Windows.Forms.Padding(5);
            this.txtPhoneNum.ReadOnly = false;
            this.txtPhoneNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhoneNum.Size = new System.Drawing.Size(325, 33);
            // 
            // 
            // 
            this.txtPhoneNum.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNum.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhoneNum.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtPhoneNum.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtPhoneNum.SkinTxt.MaxLength = 25;
            this.txtPhoneNum.SkinTxt.Multiline = true;
            this.txtPhoneNum.SkinTxt.Name = "BaseText";
            this.txtPhoneNum.SkinTxt.Size = new System.Drawing.Size(315, 23);
            this.txtPhoneNum.SkinTxt.TabIndex = 0;
            this.txtPhoneNum.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPhoneNum.SkinTxt.WaterText = "请输入您的手机号";
            this.txtPhoneNum.TabIndex = 3;
            this.txtPhoneNum.TabStop = true;
            this.txtPhoneNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPhoneNum.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPhoneNum.WaterText = "请输入您的手机号";
            this.txtPhoneNum.WordWrap = true;
            // 
            // txtPersonIDNum
            // 
            this.txtPersonIDNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPersonIDNum.BackColor = System.Drawing.Color.Transparent;
            this.txtPersonIDNum.DownBack = null;
            this.txtPersonIDNum.Icon = null;
            this.txtPersonIDNum.IconIsButton = false;
            this.txtPersonIDNum.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPersonIDNum.IsPasswordChat = '\0';
            this.txtPersonIDNum.IsSystemPasswordChar = false;
            this.txtPersonIDNum.Lines = new string[0];
            this.txtPersonIDNum.Location = new System.Drawing.Point(387, 286);
            this.txtPersonIDNum.Margin = new System.Windows.Forms.Padding(0);
            this.txtPersonIDNum.MaxLength = 25;
            this.txtPersonIDNum.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtPersonIDNum.MouseBack = null;
            this.txtPersonIDNum.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPersonIDNum.Multiline = true;
            this.txtPersonIDNum.Name = "txtPersonIDNum";
            this.txtPersonIDNum.NormlBack = null;
            this.txtPersonIDNum.Padding = new System.Windows.Forms.Padding(5);
            this.txtPersonIDNum.ReadOnly = false;
            this.txtPersonIDNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPersonIDNum.Size = new System.Drawing.Size(325, 33);
            // 
            // 
            // 
            this.txtPersonIDNum.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPersonIDNum.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPersonIDNum.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtPersonIDNum.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtPersonIDNum.SkinTxt.MaxLength = 25;
            this.txtPersonIDNum.SkinTxt.Multiline = true;
            this.txtPersonIDNum.SkinTxt.Name = "BaseText";
            this.txtPersonIDNum.SkinTxt.Size = new System.Drawing.Size(315, 23);
            this.txtPersonIDNum.SkinTxt.TabIndex = 0;
            this.txtPersonIDNum.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPersonIDNum.SkinTxt.WaterText = "请输入您的身份证号";
            this.txtPersonIDNum.TabIndex = 4;
            this.txtPersonIDNum.TabStop = true;
            this.txtPersonIDNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPersonIDNum.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPersonIDNum.WaterText = "请输入您的身份证号";
            this.txtPersonIDNum.WordWrap = true;
            // 
            // txtComment
            // 
            this.txtComment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtComment.BackColor = System.Drawing.Color.Transparent;
            this.txtComment.DownBack = null;
            this.txtComment.Icon = null;
            this.txtComment.IconIsButton = false;
            this.txtComment.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtComment.IsPasswordChat = '\0';
            this.txtComment.IsSystemPasswordChar = false;
            this.txtComment.Lines = new string[0];
            this.txtComment.Location = new System.Drawing.Point(388, 528);
            this.txtComment.Margin = new System.Windows.Forms.Padding(0);
            this.txtComment.MaxLength = 50;
            this.txtComment.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtComment.MouseBack = null;
            this.txtComment.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.NormlBack = null;
            this.txtComment.Padding = new System.Windows.Forms.Padding(5);
            this.txtComment.ReadOnly = false;
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtComment.Size = new System.Drawing.Size(325, 103);
            // 
            // 
            // 
            this.txtComment.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComment.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComment.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtComment.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtComment.SkinTxt.MaxLength = 50;
            this.txtComment.SkinTxt.Multiline = true;
            this.txtComment.SkinTxt.Name = "BaseText";
            this.txtComment.SkinTxt.Size = new System.Drawing.Size(315, 93);
            this.txtComment.SkinTxt.TabIndex = 0;
            this.txtComment.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtComment.SkinTxt.WaterText = "填写您想要说的其他话(50字以内)";
            this.txtComment.TabIndex = 9;
            this.txtComment.TabStop = true;
            this.txtComment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtComment.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtComment.WaterText = "填写您想要说的其他话(50字以内)";
            this.txtComment.WordWrap = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSave.DownBack = null;
            this.btnSave.Location = new System.Drawing.Point(387, 655);
            this.btnSave.MouseBack = null;
            this.btnSave.Name = "btnSave";
            this.btnSave.NormlBack = null;
            this.btnSave.Size = new System.Drawing.Size(98, 45);
            this.btnSave.TabIndex = 10;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCancel.DownBack = null;
            this.btnCancel.Location = new System.Drawing.Point(615, 655);
            this.btnCancel.MouseBack = null;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = null;
            this.btnCancel.Size = new System.Drawing.Size(98, 45);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.BorderColor = System.Drawing.Color.White;
            this.lblID.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblID.Location = new System.Drawing.Point(680, 54);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 20);
            this.lblID.TabIndex = 25;
            this.lblID.Text = "0";
            this.lblID.Visible = false;
            // 
            // FrmSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 728);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtPersonIDNum);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSelectPhoto);
            this.Controls.Add(this.picMyPhoto);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.cboAge);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblPhoto);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblPersonIDNum);
            this.Controls.Add(this.lblPhoneNum);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cboModality);
            this.Controls.Add(this.lblModality);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSign";
            this.Text = "报名信息填写";
            this.TitleCenter = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSign_FormClosed);
            this.Load += new System.EventHandler(this.FrmSign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMyPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel lblTitle;
        private CCWin.SkinControl.SkinLabel lblModality;
        private CCWin.SkinControl.SkinComboBox cboModality;
        private CCWin.SkinControl.SkinLabel lblName;
        private CCWin.SkinControl.SkinLabel lblPhoneNum;
        private CCWin.SkinControl.SkinLabel lblPersonIDNum;
        private CCWin.SkinControl.SkinLabel lblGender;
        private CCWin.SkinControl.SkinLabel lblAge;
        private CCWin.SkinControl.SkinLabel lblPhoto;
        private CCWin.SkinControl.SkinLabel lblComment;
        private CCWin.SkinControl.SkinComboBox cboAge;
        private CCWin.SkinControl.SkinRadioButton rdoMale;
        private CCWin.SkinControl.SkinRadioButton rdoFemale;
        private CCWin.SkinControl.SkinPictureBox picMyPhoto;
        private CCWin.SkinControl.SkinButton btnSelectPhoto;
        private CCWin.SkinControl.SkinTextBox txtName;
        private CCWin.SkinControl.SkinTextBox txtPhoneNum;
        private CCWin.SkinControl.SkinTextBox txtPersonIDNum;
        private CCWin.SkinControl.SkinTextBox txtComment;
        private CCWin.SkinControl.SkinButton btnSave;
        private CCWin.SkinControl.SkinButton btnCancel;
        private CCWin.SkinControl.SkinLabel lblID;
    }
}