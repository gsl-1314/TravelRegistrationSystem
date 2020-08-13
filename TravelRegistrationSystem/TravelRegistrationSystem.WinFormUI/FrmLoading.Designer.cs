namespace TravelRegistrationSystem.WinFormUI
{
    partial class FrmLoading
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
            CCWin.SkinControl.SkinRollingBarThemeBase skinRollingBarThemeBase1 = new CCWin.SkinControl.SkinRollingBarThemeBase();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoading));
            this.rollingBar = new CCWin.SkinControl.SkinRollingBar();
            this.lblState = new CCWin.SkinControl.SkinLabel();
            this.SuspendLayout();
            // 
            // rollingBar
            // 
            this.rollingBar.Location = new System.Drawing.Point(99, 95);
            this.rollingBar.Name = "rollingBar";
            this.rollingBar.Radius2 = 24;
            this.rollingBar.Size = new System.Drawing.Size(88, 32);
            this.rollingBar.TabIndex = 0;
            this.rollingBar.TabStop = false;
            skinRollingBarThemeBase1.BackColor = System.Drawing.Color.Transparent;
            skinRollingBarThemeBase1.BaseColor = System.Drawing.Color.Red;
            skinRollingBarThemeBase1.DiamondColor = System.Drawing.Color.White;
            skinRollingBarThemeBase1.PenWidth = 2F;
            skinRollingBarThemeBase1.Radius1 = 10;
            skinRollingBarThemeBase1.Radius2 = 24;
            skinRollingBarThemeBase1.SpokeNum = 12;
            this.rollingBar.XTheme = skinRollingBarThemeBase1;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.Transparent;
            this.lblState.BorderColor = System.Drawing.Color.White;
            this.lblState.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblState.Location = new System.Drawing.Point(102, 153);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(0, 20);
            this.lblState.TabIndex = 1;
            // 
            // FrmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.ControlBox = false;
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.rollingBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLoading";
            this.Text = "正在加载";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLoading_FormClosing);
            this.Load += new System.EventHandler(this.FrmLoading_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinRollingBar rollingBar;
        private CCWin.SkinControl.SkinLabel lblState;
    }
}