namespace QL_CuaHangVatTuNongNghiep
{
    partial class FormNhapHang
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgPhieuNhapHang = new DataGridView();
            btnNhapHang = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgPhieuNhapHang).BeginInit();
            SuspendLayout();
            // 
            // dgPhieuNhapHang
            // 
            dgPhieuNhapHang.AllowUserToAddRows = false;
            dgPhieuNhapHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgPhieuNhapHang.BackgroundColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgPhieuNhapHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgPhieuNhapHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPhieuNhapHang.EnableHeadersVisualStyles = false;
            dgPhieuNhapHang.Location = new Point(38, 83);
            dgPhieuNhapHang.Margin = new Padding(5);
            dgPhieuNhapHang.Name = "dgPhieuNhapHang";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Teal;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgPhieuNhapHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgPhieuNhapHang.RowHeadersVisible = false;
            dgPhieuNhapHang.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 10F);
            dgPhieuNhapHang.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgPhieuNhapHang.RowTemplate.Height = 32;
            dgPhieuNhapHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPhieuNhapHang.Size = new Size(1541, 584);
            dgPhieuNhapHang.TabIndex = 2;
            dgPhieuNhapHang.CellContentClick += dgvNCC_CellContentClick;
            // 
            // btnNhapHang
            // 
            btnNhapHang.BackColor = Color.Teal;
            btnNhapHang.Cursor = Cursors.Hand;
            btnNhapHang.Font = new Font("Segoe UI", 14F);
            btnNhapHang.ForeColor = SystemColors.ButtonHighlight;
            btnNhapHang.Location = new Point(592, 693);
            btnNhapHang.Name = "btnNhapHang";
            btnNhapHang.Size = new Size(178, 67);
            btnNhapHang.TabIndex = 8;
            btnNhapHang.Text = "Nhập hàng";
            btnNhapHang.UseVisualStyleBackColor = false;
            btnNhapHang.Click += btnNhapHang_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Teal;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Font = new Font("Segoe UI", 14F);
            btnRefresh.ForeColor = SystemColors.ButtonHighlight;
            btnRefresh.Location = new Point(808, 693);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(157, 67);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // FormNhapHang
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1615, 916);
            Controls.Add(btnRefresh);
            Controls.Add(btnNhapHang);
            Controls.Add(dgPhieuNhapHang);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "FormNhapHang";
            Text = "FormNhapHang";
            Load += FormNhapHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgPhieuNhapHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgPhieuNhapHang;
        private Button btnNhapHang;
        private Button btnRefresh;
    }
}