namespace QL_CuaHangVatTuNongNghiep
{
    partial class FormKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhachHang));
            dgvKhachHang = new DataGridView();
            txtTimKiem = new TextBox();
            label1 = new Label();
            label7 = new Label();
            btnXoaKhachHang = new Button();
            btnSuaThongTin = new Button();
            btnThemKhachHang = new Button();
            txtSoDienThoai = new TextBox();
            txtDiaChiKhachHang = new TextBox();
            groupBox1 = new GroupBox();
            btnLuuThongTin = new Button();
            btnDatLai = new Button();
            txtEmailKhachHang = new TextBox();
            txtMaKhachHang = new TextBox();
            txtTenKhachHang = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.AllowUserToAddRows = false;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.BackgroundColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.EnableHeadersVisualStyles = false;
            dgvKhachHang.Location = new Point(72, 83);
            dgvKhachHang.Margin = new Padding(5);
            dgvKhachHang.Name = "dgvKhachHang";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Teal;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvKhachHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvKhachHang.RowHeadersVisible = false;
            dgvKhachHang.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvKhachHang.RowTemplate.Height = 32;
            dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKhachHang.Size = new Size(1463, 283);
            dgvKhachHang.TabIndex = 12;
            dgvKhachHang.CellClick += dgvKhachHang_CellClick;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BackColor = SystemColors.HighlightText;
            txtTimKiem.Location = new Point(196, 21);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(464, 39);
            txtTimKiem.TabIndex = 13;
            txtTimKiem.KeyDown += txtTimKiem_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(72, 28);
            label1.Name = "label1";
            label1.Size = new Size(118, 32);
            label1.TabIndex = 14;
            label1.Text = "Tìm kiếm:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(220, 208);
            label7.Name = "label7";
            label7.Size = new Size(145, 30);
            label7.TabIndex = 11;
            label7.Text = "Số điện thoại:";
            // 
            // btnXoaKhachHang
            // 
            btnXoaKhachHang.BackColor = Color.Teal;
            btnXoaKhachHang.Cursor = Cursors.Hand;
            btnXoaKhachHang.Font = new Font("Segoe UI", 14F);
            btnXoaKhachHang.ForeColor = SystemColors.ButtonHighlight;
            btnXoaKhachHang.Location = new Point(846, 281);
            btnXoaKhachHang.Name = "btnXoaKhachHang";
            btnXoaKhachHang.Size = new Size(211, 67);
            btnXoaKhachHang.TabIndex = 9;
            btnXoaKhachHang.Text = "Xóa Khách Hàng";
            btnXoaKhachHang.UseVisualStyleBackColor = false;
            btnXoaKhachHang.Click += btnXoaKhachHang_Click;
            // 
            // btnSuaThongTin
            // 
            btnSuaThongTin.BackColor = Color.Teal;
            btnSuaThongTin.Cursor = Cursors.Hand;
            btnSuaThongTin.Font = new Font("Segoe UI", 14F);
            btnSuaThongTin.ForeColor = SystemColors.ButtonHighlight;
            btnSuaThongTin.Location = new Point(646, 281);
            btnSuaThongTin.Name = "btnSuaThongTin";
            btnSuaThongTin.Size = new Size(178, 67);
            btnSuaThongTin.TabIndex = 8;
            btnSuaThongTin.Text = "Sửa thông tin";
            btnSuaThongTin.UseVisualStyleBackColor = false;
            btnSuaThongTin.Click += btnSuaThongTin_Click;
            // 
            // btnThemKhachHang
            // 
            btnThemKhachHang.BackColor = Color.Teal;
            btnThemKhachHang.Cursor = Cursors.Hand;
            btnThemKhachHang.Font = new Font("Segoe UI", 14F);
            btnThemKhachHang.ForeColor = SystemColors.ButtonHighlight;
            btnThemKhachHang.Location = new Point(194, 281);
            btnThemKhachHang.Name = "btnThemKhachHang";
            btnThemKhachHang.Size = new Size(220, 67);
            btnThemKhachHang.TabIndex = 6;
            btnThemKhachHang.Text = "Thêm Khách Hàng";
            btnThemKhachHang.UseVisualStyleBackColor = false;
            btnThemKhachHang.Click += btnThemKhachHang_Click;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Segoe UI", 13F);
            txtSoDienThoai.Location = new Point(386, 212);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(328, 36);
            txtSoDienThoai.TabIndex = 3;
            // 
            // txtDiaChiKhachHang
            // 
            txtDiaChiKhachHang.Font = new Font("Segoe UI", 13F);
            txtDiaChiKhachHang.Location = new Point(866, 143);
            txtDiaChiKhachHang.Name = "txtDiaChiKhachHang";
            txtDiaChiKhachHang.Size = new Size(328, 36);
            txtDiaChiKhachHang.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnLuuThongTin);
            groupBox1.Controls.Add(btnDatLai);
            groupBox1.Controls.Add(btnXoaKhachHang);
            groupBox1.Controls.Add(btnSuaThongTin);
            groupBox1.Controls.Add(btnThemKhachHang);
            groupBox1.Controls.Add(txtSoDienThoai);
            groupBox1.Controls.Add(txtDiaChiKhachHang);
            groupBox1.Controls.Add(txtEmailKhachHang);
            groupBox1.Controls.Add(txtMaKhachHang);
            groupBox1.Controls.Add(txtTenKhachHang);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(72, 388);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1463, 381);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // btnLuuThongTin
            // 
            btnLuuThongTin.BackColor = Color.Teal;
            btnLuuThongTin.Font = new Font("Segoe UI", 14F);
            btnLuuThongTin.ForeColor = SystemColors.ButtonHighlight;
            btnLuuThongTin.Location = new Point(440, 281);
            btnLuuThongTin.Name = "btnLuuThongTin";
            btnLuuThongTin.Size = new Size(176, 67);
            btnLuuThongTin.TabIndex = 7;
            btnLuuThongTin.Text = "Lưu thông tin";
            btnLuuThongTin.UseVisualStyleBackColor = false;
            btnLuuThongTin.Click += btnLuuThongTin_Click;
            // 
            // btnDatLai
            // 
            btnDatLai.BackColor = Color.Teal;
            btnDatLai.Cursor = Cursors.Hand;
            btnDatLai.Font = new Font("Segoe UI", 14F);
            btnDatLai.ForeColor = SystemColors.ButtonHighlight;
            btnDatLai.Image = (Image)resources.GetObject("btnDatLai.Image");
            btnDatLai.ImageAlign = ContentAlignment.MiddleLeft;
            btnDatLai.Location = new Point(1076, 281);
            btnDatLai.Name = "btnDatLai";
            btnDatLai.Size = new Size(144, 67);
            btnDatLai.TabIndex = 10;
            btnDatLai.Text = "Đặt lại";
            btnDatLai.TextAlign = ContentAlignment.MiddleRight;
            btnDatLai.UseVisualStyleBackColor = false;
            btnDatLai.Click += btnDatLai_Click;
            // 
            // txtEmailKhachHang
            // 
            txtEmailKhachHang.Font = new Font("Segoe UI", 13F);
            txtEmailKhachHang.Location = new Point(866, 84);
            txtEmailKhachHang.Name = "txtEmailKhachHang";
            txtEmailKhachHang.Size = new Size(328, 36);
            txtEmailKhachHang.TabIndex = 4;
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.Font = new Font("Segoe UI", 13F);
            txtMaKhachHang.Location = new Point(386, 84);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.Size = new Size(328, 36);
            txtMaKhachHang.TabIndex = 1;
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Font = new Font("Segoe UI", 13F);
            txtTenKhachHang.Location = new Point(386, 146);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(328, 36);
            txtTenKhachHang.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(777, 84);
            label4.Name = "label4";
            label4.Size = new Size(69, 30);
            label4.TabIndex = 0;
            label4.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(777, 149);
            label6.Name = "label6";
            label6.Size = new Size(82, 30);
            label6.TabIndex = 0;
            label6.Text = "Địa chỉ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(220, 149);
            label3.Name = "label3";
            label3.Size = new Size(168, 30);
            label3.TabIndex = 0;
            label3.Text = "Tên khách hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(220, 84);
            label2.Name = "label2";
            label2.Size = new Size(165, 30);
            label2.TabIndex = 0;
            label2.Text = "Mã khách hàng:";
            // 
            // FormKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1615, 916);
            Controls.Add(dgvKhachHang);
            Controls.Add(txtTimKiem);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "FormKhachHang";
            Text = "FormKhachHang";
            Load += FormKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKhachHang;
        private TextBox txtTimKiem;
        private Label label1;
        private Label label7;
        private Button btnXoaKhachHang;
        private Button btnSuaThongTin;
        private Button btnThemKhachHang;
        private TextBox txtSoDienThoai;
        private TextBox txtDiaChiKhachHang;
        private GroupBox groupBox1;
        private Button btnLuuThongTin;
        private Button btnDatLai;
        private TextBox txtEmailKhachHang;
        private TextBox txtMaKhachHang;
        private TextBox txtTenKhachHang;
        private Label label4;
        private Label label6;
        private Label label3;
        private Label label2;
    }
}