namespace QL_CuaHangVatTuNongNghiep
{
    partial class FormInDonHang
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
            this.reportDonHang = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportDonHang
            // 
            this.reportDonHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportDonHang.Location = new System.Drawing.Point(0, 0);
            this.reportDonHang.Name = "reportDonHang";
            this.reportDonHang.ServerReport.BearerToken = null;
            this.reportDonHang.Size = new System.Drawing.Size(1225, 570);
            this.reportDonHang.TabIndex = 0;
            // 
            // FormInDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 570);
            this.Controls.Add(this.reportDonHang);
            this.Name = "FormInDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In đơn hàng";
            this.Load += new System.EventHandler(this.FormInDonHang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportDonHang;
    }
}