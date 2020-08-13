namespace TravelRegistrationSystem.WinFormUI
{
    partial class FrmModality
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModality));
            this.chartSubject = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTitle = new CCWin.SkinControl.SkinLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chartSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSubject
            // 
            this.chartSubject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartSubject.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSubject.Legends.Add(legend1);
            this.chartSubject.Location = new System.Drawing.Point(104, 105);
            this.chartSubject.Margin = new System.Windows.Forms.Padding(4);
            this.chartSubject.Name = "chartSubject";
            this.chartSubject.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartSubject.Series.Add(series1);
            this.chartSubject.Size = new System.Drawing.Size(951, 290);
            this.chartSubject.TabIndex = 0;
            this.chartSubject.Text = "chart1";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.BorderColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTitle.Location = new System.Drawing.Point(454, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(181, 40);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "形式统计";
            // 
            // FrmModality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 451);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.chartSubject);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmModality";
            this.Text = "形式统计";
            this.TitleCenter = false;
            this.TitleColor = System.Drawing.Color.White;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmModality_FormClosed);
            this.Load += new System.EventHandler(this.FrmModality_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartSubject)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSubject;
        private CCWin.SkinControl.SkinLabel lblTitle;
    }
}