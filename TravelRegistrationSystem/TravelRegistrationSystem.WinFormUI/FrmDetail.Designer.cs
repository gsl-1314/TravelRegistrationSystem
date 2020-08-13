namespace TravelRegistrationSystem.WinFormUI
{
    partial class FrmDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetail));
            this.lblTitle = new CCWin.SkinControl.SkinLabel();
            this.lblComment = new CCWin.SkinControl.SkinLabel();
            this.lblPhoto = new CCWin.SkinControl.SkinLabel();
            this.lblAge = new CCWin.SkinControl.SkinLabel();
            this.lblGender = new CCWin.SkinControl.SkinLabel();
            this.lblPersonIDNum = new CCWin.SkinControl.SkinLabel();
            this.lblPhoneNum = new CCWin.SkinControl.SkinLabel();
            this.lblName = new CCWin.SkinControl.SkinLabel();
            this.lblModality = new CCWin.SkinControl.SkinLabel();
            this.picShowMyPhoto = new CCWin.SkinControl.SkinPictureBox();
            this.lblShowModality = new CCWin.SkinControl.SkinLabel();
            this.lblShowName = new CCWin.SkinControl.SkinLabel();
            this.lblShowPhoneNum = new CCWin.SkinControl.SkinLabel();
            this.lblShowPersonIDNum = new CCWin.SkinControl.SkinLabel();
            this.lblShowGender = new CCWin.SkinControl.SkinLabel();
            this.lblShowAge = new CCWin.SkinControl.SkinLabel();
            this.lblShowComment = new CCWin.SkinControl.SkinLabel();
            this.btnAlter = new CCWin.SkinControl.SkinButton();
            this.lblID = new CCWin.SkinControl.SkinLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picShowMyPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.BorderColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("华文中宋", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(415, 68);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(184, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "报名信息";
            // 
            // lblComment
            // 
            this.lblComment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblComment.AutoSize = true;
            this.lblComment.BackColor = System.Drawing.Color.Transparent;
            this.lblComment.BorderColor = System.Drawing.Color.White;
            this.lblComment.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblComment.Location = new System.Drawing.Point(299, 533);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(99, 32);
            this.lblComment.TabIndex = 18;
            this.lblComment.Text = "备注：";
            // 
            // lblPhoto
            // 
            this.lblPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhoto.AutoSize = true;
            this.lblPhoto.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoto.BorderColor = System.Drawing.Color.White;
            this.lblPhoto.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPhoto.Location = new System.Drawing.Point(299, 127);
            this.lblPhoto.Name = "lblPhoto";
            this.lblPhoto.Size = new System.Drawing.Size(99, 32);
            this.lblPhoto.TabIndex = 17;
            this.lblPhoto.Text = "照片：";
            // 
            // lblAge
            // 
            this.lblAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.BorderColor = System.Drawing.Color.White;
            this.lblAge.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAge.Location = new System.Drawing.Point(299, 475);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(99, 32);
            this.lblAge.TabIndex = 16;
            this.lblAge.Text = "年龄：";
            // 
            // lblGender
            // 
            this.lblGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.BorderColor = System.Drawing.Color.White;
            this.lblGender.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGender.Location = new System.Drawing.Point(299, 417);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(99, 32);
            this.lblGender.TabIndex = 15;
            this.lblGender.Text = "性别：";
            // 
            // lblPersonIDNum
            // 
            this.lblPersonIDNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPersonIDNum.AutoSize = true;
            this.lblPersonIDNum.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonIDNum.BorderColor = System.Drawing.Color.White;
            this.lblPersonIDNum.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPersonIDNum.Location = new System.Drawing.Point(243, 359);
            this.lblPersonIDNum.Name = "lblPersonIDNum";
            this.lblPersonIDNum.Size = new System.Drawing.Size(155, 32);
            this.lblPersonIDNum.TabIndex = 14;
            this.lblPersonIDNum.Text = "身份证号：";
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNum.BorderColor = System.Drawing.Color.White;
            this.lblPhoneNum.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPhoneNum.Location = new System.Drawing.Point(271, 301);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(127, 32);
            this.lblPhoneNum.TabIndex = 13;
            this.lblPhoneNum.Text = "手机号：";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.BorderColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(299, 243);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(99, 32);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "姓名：";
            // 
            // lblModality
            // 
            this.lblModality.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModality.AutoSize = true;
            this.lblModality.BackColor = System.Drawing.Color.Transparent;
            this.lblModality.BorderColor = System.Drawing.Color.White;
            this.lblModality.Font = new System.Drawing.Font("华文中宋", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblModality.Location = new System.Drawing.Point(299, 185);
            this.lblModality.Name = "lblModality";
            this.lblModality.Size = new System.Drawing.Size(99, 32);
            this.lblModality.TabIndex = 11;
            this.lblModality.Text = "形式：";
            // 
            // picShowMyPhoto
            // 
            this.picShowMyPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picShowMyPhoto.BackColor = System.Drawing.Color.Transparent;
            this.picShowMyPhoto.Location = new System.Drawing.Point(419, 120);
            this.picShowMyPhoto.Name = "picShowMyPhoto";
            this.picShowMyPhoto.Size = new System.Drawing.Size(176, 59);
            this.picShowMyPhoto.TabIndex = 19;
            this.picShowMyPhoto.TabStop = false;
            // 
            // lblShowModality
            // 
            this.lblShowModality.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblShowModality.AutoSize = true;
            this.lblShowModality.BackColor = System.Drawing.Color.Transparent;
            this.lblShowModality.BorderColor = System.Drawing.Color.White;
            this.lblShowModality.Font = new System.Drawing.Font("楷体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblShowModality.Location = new System.Drawing.Point(443, 192);
            this.lblShowModality.Name = "lblShowModality";
            this.lblShowModality.Size = new System.Drawing.Size(124, 28);
            this.lblShowModality.TabIndex = 20;
            this.lblShowModality.Text = "自助旅游";
            // 
            // lblShowName
            // 
            this.lblShowName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblShowName.AutoSize = true;
            this.lblShowName.BackColor = System.Drawing.Color.Transparent;
            this.lblShowName.BorderColor = System.Drawing.Color.White;
            this.lblShowName.Font = new System.Drawing.Font("楷体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblShowName.Location = new System.Drawing.Point(443, 247);
            this.lblShowName.Name = "lblShowName";
            this.lblShowName.Size = new System.Drawing.Size(68, 28);
            this.lblShowName.TabIndex = 21;
            this.lblShowName.Text = "郭鹏";
            // 
            // lblShowPhoneNum
            // 
            this.lblShowPhoneNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblShowPhoneNum.AutoSize = true;
            this.lblShowPhoneNum.BackColor = System.Drawing.Color.Transparent;
            this.lblShowPhoneNum.BorderColor = System.Drawing.Color.White;
            this.lblShowPhoneNum.Font = new System.Drawing.Font("楷体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblShowPhoneNum.Location = new System.Drawing.Point(443, 305);
            this.lblShowPhoneNum.Name = "lblShowPhoneNum";
            this.lblShowPhoneNum.Size = new System.Drawing.Size(166, 28);
            this.lblShowPhoneNum.TabIndex = 22;
            this.lblShowPhoneNum.Text = "152XXXXXXXX";
            // 
            // lblShowPersonIDNum
            // 
            this.lblShowPersonIDNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblShowPersonIDNum.AutoSize = true;
            this.lblShowPersonIDNum.BackColor = System.Drawing.Color.Transparent;
            this.lblShowPersonIDNum.BorderColor = System.Drawing.Color.White;
            this.lblShowPersonIDNum.Font = new System.Drawing.Font("楷体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblShowPersonIDNum.Location = new System.Drawing.Point(443, 359);
            this.lblShowPersonIDNum.Name = "lblShowPersonIDNum";
            this.lblShowPersonIDNum.Size = new System.Drawing.Size(194, 28);
            this.lblShowPersonIDNum.TabIndex = 23;
            this.lblShowPersonIDNum.Text = "XXXXXXXXXXXXX";
            // 
            // lblShowGender
            // 
            this.lblShowGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblShowGender.AutoSize = true;
            this.lblShowGender.BackColor = System.Drawing.Color.Transparent;
            this.lblShowGender.BorderColor = System.Drawing.Color.White;
            this.lblShowGender.Font = new System.Drawing.Font("楷体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblShowGender.Location = new System.Drawing.Point(443, 421);
            this.lblShowGender.Name = "lblShowGender";
            this.lblShowGender.Size = new System.Drawing.Size(40, 28);
            this.lblShowGender.TabIndex = 24;
            this.lblShowGender.Text = "男";
            // 
            // lblShowAge
            // 
            this.lblShowAge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblShowAge.AutoSize = true;
            this.lblShowAge.BackColor = System.Drawing.Color.Transparent;
            this.lblShowAge.BorderColor = System.Drawing.Color.White;
            this.lblShowAge.Font = new System.Drawing.Font("楷体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblShowAge.Location = new System.Drawing.Point(443, 479);
            this.lblShowAge.Name = "lblShowAge";
            this.lblShowAge.Size = new System.Drawing.Size(40, 28);
            this.lblShowAge.TabIndex = 25;
            this.lblShowAge.Text = "30";
            // 
            // lblShowComment
            // 
            this.lblShowComment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblShowComment.BackColor = System.Drawing.Color.Transparent;
            this.lblShowComment.BorderColor = System.Drawing.Color.White;
            this.lblShowComment.Font = new System.Drawing.Font("楷体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblShowComment.Location = new System.Drawing.Point(443, 537);
            this.lblShowComment.Name = "lblShowComment";
            this.lblShowComment.Size = new System.Drawing.Size(569, 95);
            this.lblShowComment.TabIndex = 26;
            this.lblShowComment.Text = "曾梦想仗剑走天涯";
            // 
            // btnAlter
            // 
            this.btnAlter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAlter.BackColor = System.Drawing.Color.Transparent;
            this.btnAlter.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAlter.DownBack = null;
            this.btnAlter.Location = new System.Drawing.Point(633, 648);
            this.btnAlter.MouseBack = null;
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.NormlBack = null;
            this.btnAlter.Size = new System.Drawing.Size(164, 44);
            this.btnAlter.TabIndex = 27;
            this.btnAlter.Text = "修改";
            this.btnAlter.UseVisualStyleBackColor = false;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.BorderColor = System.Drawing.Color.White;
            this.lblID.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblID.Location = new System.Drawing.Point(673, 88);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 20);
            this.lblID.TabIndex = 28;
            this.lblID.Text = "0";
            this.lblID.Visible = false;
            // 
            // FrmDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 713);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnAlter);
            this.Controls.Add(this.lblShowComment);
            this.Controls.Add(this.lblShowAge);
            this.Controls.Add(this.lblShowGender);
            this.Controls.Add(this.lblShowPersonIDNum);
            this.Controls.Add(this.lblShowPhoneNum);
            this.Controls.Add(this.lblShowName);
            this.Controls.Add(this.lblShowModality);
            this.Controls.Add(this.picShowMyPhoto);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblPhoto);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblPersonIDNum);
            this.Controls.Add(this.lblPhoneNum);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblModality);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDetail";
            this.Text = "报名信息";
            this.TitleCenter = false;
            this.TitleColor = System.Drawing.Color.White;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmDetail_FormClosed);
            this.Load += new System.EventHandler(this.FrmDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picShowMyPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel lblTitle;
        private CCWin.SkinControl.SkinLabel lblComment;
        private CCWin.SkinControl.SkinLabel lblPhoto;
        private CCWin.SkinControl.SkinLabel lblAge;
        private CCWin.SkinControl.SkinLabel lblGender;
        private CCWin.SkinControl.SkinLabel lblPersonIDNum;
        private CCWin.SkinControl.SkinLabel lblPhoneNum;
        private CCWin.SkinControl.SkinLabel lblName;
        private CCWin.SkinControl.SkinLabel lblModality;
        private CCWin.SkinControl.SkinPictureBox picShowMyPhoto;
        private CCWin.SkinControl.SkinLabel lblShowModality;
        private CCWin.SkinControl.SkinLabel lblShowName;
        private CCWin.SkinControl.SkinLabel lblShowPhoneNum;
        private CCWin.SkinControl.SkinLabel lblShowPersonIDNum;
        private CCWin.SkinControl.SkinLabel lblShowGender;
        private CCWin.SkinControl.SkinLabel lblShowAge;
        private CCWin.SkinControl.SkinLabel lblShowComment;
        private CCWin.SkinControl.SkinButton btnAlter;
        private CCWin.SkinControl.SkinLabel lblID;
    }
}