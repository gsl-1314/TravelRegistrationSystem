namespace TravelRegistrationSystem.WinFormUI
{
    partial class FrmManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManage));
            this.dgvPeople = new CCWin.SkinControl.SkinDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personIDNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationDeadLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblModality = new CCWin.SkinControl.SkinLabel();
            this.cboModality = new CCWin.SkinControl.SkinComboBox();
            this.lblName = new CCWin.SkinControl.SkinLabel();
            this.txtName = new CCWin.SkinControl.SkinTextBox();
            this.lblPhoneNum = new CCWin.SkinControl.SkinLabel();
            this.txtPhoneNum = new CCWin.SkinControl.SkinTextBox();
            this.btnQuery = new CCWin.SkinControl.SkinButton();
            this.btnModality = new CCWin.SkinControl.SkinButton();
            this.btnDelete = new CCWin.SkinControl.SkinButton();
            this.cboModalityContext = new CCWin.SkinControl.SkinComboBox();
            this.cboGenderContext = new CCWin.SkinControl.SkinComboBox();
            this.panelBottom = new CCWin.SkinControl.SkinPanel();
            this.lblTotal = new CCWin.SkinControl.SkinLabel();
            this.cboCurrentPage = new CCWin.SkinControl.SkinComboBox();
            this.lblT = new CCWin.SkinControl.SkinLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgvPeople.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPeople.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPeople.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPeople.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPeople.ColumnFont = null;
            this.dgvPeople.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.uName,
            this.modality,
            this.phoneNum,
            this.personIDNum,
            this.gender,
            this.age,
            this.registrationDeadLine,
            this.photo,
            this.comment});
            this.dgvPeople.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPeople.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPeople.EnableHeadersVisualStyles = false;
            this.dgvPeople.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvPeople.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvPeople.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvPeople.Location = new System.Drawing.Point(16, 88);
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPeople.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvPeople.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPeople.RowTemplate.Height = 23;
            this.dgvPeople.Size = new System.Drawing.Size(1112, 595);
            this.dgvPeople.TabIndex = 0;
            this.dgvPeople.TitleBack = null;
            this.dgvPeople.TitleBackColorBegin = System.Drawing.Color.White;
            this.dgvPeople.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.dgvPeople.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvPeople_CellBeginEdit);
            this.dgvPeople.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeople_CellEndEdit);
            this.dgvPeople.CurrentCellChanged += new System.EventHandler(this.dgvPeople_CurrentCellChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "编号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // uName
            // 
            this.uName.DataPropertyName = "uName";
            this.uName.HeaderText = "姓名";
            this.uName.Name = "uName";
            // 
            // modality
            // 
            this.modality.DataPropertyName = "modality";
            this.modality.HeaderText = "形式";
            this.modality.Name = "modality";
            this.modality.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // phoneNum
            // 
            this.phoneNum.DataPropertyName = "phoneNum";
            this.phoneNum.HeaderText = "手机号码";
            this.phoneNum.Name = "phoneNum";
            // 
            // personIDNum
            // 
            this.personIDNum.DataPropertyName = "personIDNum";
            this.personIDNum.HeaderText = "身份证号";
            this.personIDNum.Name = "personIDNum";
            this.personIDNum.Width = 150;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "性别";
            this.gender.Name = "gender";
            this.gender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // age
            // 
            this.age.DataPropertyName = "age";
            this.age.HeaderText = "年龄";
            this.age.Name = "age";
            // 
            // registrationDeadLine
            // 
            this.registrationDeadLine.DataPropertyName = "registrationDeadLine";
            this.registrationDeadLine.HeaderText = "报名日期";
            this.registrationDeadLine.Name = "registrationDeadLine";
            this.registrationDeadLine.Width = 150;
            // 
            // photo
            // 
            this.photo.DataPropertyName = "photo";
            this.photo.HeaderText = "照片";
            this.photo.Name = "photo";
            this.photo.ReadOnly = true;
            this.photo.Visible = false;
            // 
            // comment
            // 
            this.comment.DataPropertyName = "comment";
            this.comment.HeaderText = "备注";
            this.comment.Name = "comment";
            this.comment.ReadOnly = true;
            this.comment.Visible = false;
            // 
            // lblModality
            // 
            this.lblModality.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblModality.AutoSize = true;
            this.lblModality.BackColor = System.Drawing.Color.Transparent;
            this.lblModality.BorderColor = System.Drawing.Color.White;
            this.lblModality.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblModality.Location = new System.Drawing.Point(34, 45);
            this.lblModality.Name = "lblModality";
            this.lblModality.Size = new System.Drawing.Size(90, 32);
            this.lblModality.TabIndex = 1;
            this.lblModality.Text = "形式：";
            // 
            // cboModality
            // 
            this.cboModality.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboModality.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboModality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModality.FormattingEnabled = true;
            this.cboModality.Location = new System.Drawing.Point(119, 51);
            this.cboModality.Name = "cboModality";
            this.cboModality.Size = new System.Drawing.Size(147, 26);
            this.cboModality.TabIndex = 2;
            this.cboModality.WaterText = "";
            this.cboModality.SelectedIndexChanged += new System.EventHandler(this.cboModality_SelectedIndexChanged);
            this.cboModality.SelectionChangeCommitted += new System.EventHandler(this.cboModality_SelectionChangeCommitted);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.BorderColor = System.Drawing.Color.White;
            this.lblName.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(297, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 32);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "姓名：";
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
            this.txtName.Location = new System.Drawing.Point(375, 47);
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
            this.txtName.Size = new System.Drawing.Size(144, 30);
            // 
            // 
            // 
            this.txtName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtName.SkinTxt.Multiline = true;
            this.txtName.SkinTxt.Name = "BaseText";
            this.txtName.SkinTxt.Size = new System.Drawing.Size(134, 20);
            this.txtName.SkinTxt.TabIndex = 0;
            this.txtName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtName.SkinTxt.WaterText = "";
            this.txtName.TabIndex = 4;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtName.WaterText = "";
            this.txtName.WordWrap = true;
            // 
            // lblPhoneNum
            // 
            this.lblPhoneNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhoneNum.AutoSize = true;
            this.lblPhoneNum.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNum.BorderColor = System.Drawing.Color.White;
            this.lblPhoneNum.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPhoneNum.Location = new System.Drawing.Point(549, 45);
            this.lblPhoneNum.Name = "lblPhoneNum";
            this.lblPhoneNum.Size = new System.Drawing.Size(115, 32);
            this.lblPhoneNum.TabIndex = 5;
            this.lblPhoneNum.Text = "手机号：";
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
            this.txtPhoneNum.Location = new System.Drawing.Point(658, 47);
            this.txtPhoneNum.Margin = new System.Windows.Forms.Padding(0);
            this.txtPhoneNum.MaxLength = 32767;
            this.txtPhoneNum.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtPhoneNum.MouseBack = null;
            this.txtPhoneNum.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPhoneNum.Multiline = true;
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.NormlBack = null;
            this.txtPhoneNum.Padding = new System.Windows.Forms.Padding(5);
            this.txtPhoneNum.ReadOnly = false;
            this.txtPhoneNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhoneNum.Size = new System.Drawing.Size(144, 30);
            // 
            // 
            // 
            this.txtPhoneNum.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhoneNum.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhoneNum.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtPhoneNum.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtPhoneNum.SkinTxt.Multiline = true;
            this.txtPhoneNum.SkinTxt.Name = "BaseText";
            this.txtPhoneNum.SkinTxt.Size = new System.Drawing.Size(134, 20);
            this.txtPhoneNum.SkinTxt.TabIndex = 0;
            this.txtPhoneNum.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPhoneNum.SkinTxt.WaterText = "";
            this.txtPhoneNum.TabIndex = 6;
            this.txtPhoneNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPhoneNum.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPhoneNum.WaterText = "";
            this.txtPhoneNum.WordWrap = true;
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuery.BackColor = System.Drawing.Color.Transparent;
            this.btnQuery.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnQuery.DownBack = null;
            this.btnQuery.Location = new System.Drawing.Point(834, 39);
            this.btnQuery.MouseBack = null;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.NormlBack = null;
            this.btnQuery.Size = new System.Drawing.Size(89, 44);
            this.btnQuery.TabIndex = 7;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnModality
            // 
            this.btnModality.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModality.BackColor = System.Drawing.Color.Transparent;
            this.btnModality.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnModality.DownBack = null;
            this.btnModality.Location = new System.Drawing.Point(939, 39);
            this.btnModality.MouseBack = null;
            this.btnModality.Name = "btnModality";
            this.btnModality.NormlBack = null;
            this.btnModality.Size = new System.Drawing.Size(89, 44);
            this.btnModality.TabIndex = 8;
            this.btnModality.Text = "形式统计";
            this.btnModality.UseVisualStyleBackColor = false;
            this.btnModality.Click += new System.EventHandler(this.btnModality_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnDelete.DownBack = null;
            this.btnDelete.Location = new System.Drawing.Point(1044, 39);
            this.btnDelete.MouseBack = null;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NormlBack = null;
            this.btnDelete.Size = new System.Drawing.Size(89, 44);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cboModalityContext
            // 
            this.cboModalityContext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboModalityContext.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboModalityContext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModalityContext.FormattingEnabled = true;
            this.cboModalityContext.Location = new System.Drawing.Point(157, 132);
            this.cboModalityContext.Name = "cboModalityContext";
            this.cboModalityContext.Size = new System.Drawing.Size(100, 26);
            this.cboModalityContext.TabIndex = 10;
            this.cboModalityContext.WaterText = "";
            this.cboModalityContext.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboModalityContext_DrawItem);
            this.cboModalityContext.SelectedIndexChanged += new System.EventHandler(this.cboModalityContext_SelectedIndexChanged);
            this.cboModalityContext.SelectionChangeCommitted += new System.EventHandler(this.cboModalityContext_SelectionChangeCommitted);
            // 
            // cboGenderContext
            // 
            this.cboGenderContext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboGenderContext.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGenderContext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGenderContext.FormattingEnabled = true;
            this.cboGenderContext.Location = new System.Drawing.Point(508, 132);
            this.cboGenderContext.Name = "cboGenderContext";
            this.cboGenderContext.Size = new System.Drawing.Size(100, 26);
            this.cboGenderContext.TabIndex = 11;
            this.cboGenderContext.WaterText = "";
            this.cboGenderContext.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cboGenderContext_DrawItem);
            this.cboGenderContext.SelectedIndexChanged += new System.EventHandler(this.cboGenderContext_SelectedIndexChanged);
            this.cboGenderContext.SelectionChangeCommitted += new System.EventHandler(this.cboGenderContext_SelectionChangeCommitted);
            // 
            // panelBottom
            // 
            this.panelBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBottom.BackColor = System.Drawing.Color.Transparent;
            this.panelBottom.Controls.Add(this.lblT);
            this.panelBottom.Controls.Add(this.lblTotal);
            this.panelBottom.Controls.Add(this.cboCurrentPage);
            this.panelBottom.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.panelBottom.DownBack = null;
            this.panelBottom.Location = new System.Drawing.Point(681, 690);
            this.panelBottom.MouseBack = null;
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.NormlBack = null;
            this.panelBottom.Size = new System.Drawing.Size(446, 34);
            this.panelBottom.TabIndex = 12;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.BorderColor = System.Drawing.Color.White;
            this.lblTotal.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTotal.Location = new System.Drawing.Point(221, 7);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 20);
            this.lblTotal.TabIndex = 17;
            // 
            // cboCurrentPage
            // 
            this.cboCurrentPage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboCurrentPage.FormattingEnabled = true;
            this.cboCurrentPage.Location = new System.Drawing.Point(112, 4);
            this.cboCurrentPage.Name = "cboCurrentPage";
            this.cboCurrentPage.Size = new System.Drawing.Size(100, 26);
            this.cboCurrentPage.TabIndex = 16;
            this.cboCurrentPage.WaterText = "";
            this.cboCurrentPage.SelectionChangeCommitted += new System.EventHandler(this.cboCurrentPage_SelectionChangeCommitted_1);
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.BackColor = System.Drawing.Color.Transparent;
            this.lblT.BorderColor = System.Drawing.Color.White;
            this.lblT.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblT.Location = new System.Drawing.Point(22, 6);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(84, 20);
            this.lblT.TabIndex = 20;
            this.lblT.Text = "当前处于第";
            // 
            // FrmManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 735);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.cboGenderContext);
            this.Controls.Add(this.cboModalityContext);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModality);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtPhoneNum);
            this.Controls.Add(this.lblPhoneNum);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cboModality);
            this.Controls.Add(this.lblModality);
            this.Controls.Add(this.dgvPeople);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmManage";
            this.Text = "报名信息管理";
            this.TitleCenter = false;
            this.TitleColor = System.Drawing.Color.LavenderBlush;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmManage_FormClosed);
            this.Load += new System.EventHandler(this.FrmManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinDataGridView dgvPeople;
        private CCWin.SkinControl.SkinLabel lblModality;
        private CCWin.SkinControl.SkinComboBox cboModality;
        private CCWin.SkinControl.SkinLabel lblName;
        private CCWin.SkinControl.SkinTextBox txtName;
        private CCWin.SkinControl.SkinLabel lblPhoneNum;
        private CCWin.SkinControl.SkinTextBox txtPhoneNum;
        private CCWin.SkinControl.SkinButton btnQuery;
        private CCWin.SkinControl.SkinButton btnModality;
        private CCWin.SkinControl.SkinButton btnDelete;
        private CCWin.SkinControl.SkinComboBox cboModalityContext;
        private CCWin.SkinControl.SkinComboBox cboGenderContext;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn uName;
        private System.Windows.Forms.DataGridViewTextBoxColumn modality;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn personIDNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationDeadLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
        private CCWin.SkinControl.SkinPanel panelBottom;
        private CCWin.SkinControl.SkinLabel lblT;
        private CCWin.SkinControl.SkinLabel lblTotal;
        private CCWin.SkinControl.SkinComboBox cboCurrentPage;
    }
}