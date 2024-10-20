namespace QL_CuaHangVatTuNongNghiep
{
    partial class FormNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            dgvNhanVien = new DataGridView();
            btnHienThiMatKhau = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            btnLuuThongTin = new Button();
            cmbChucVu = new ComboBox();
            cmbGIoiTinh = new ComboBox();
            btnDatLai = new Button();
            btnXoaNhanVien = new Button();
            btnSuaThongTin = new Button();
            btnThemNhanVien = new Button();
            txtSoDienThoai = new TextBox();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            txtDiaChiNhanVien = new TextBox();
            txtEmailNhanVien = new TextBox();
            txtMaNhanVien = new TextBox();
            txtTenNhanVien = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtTimKiem = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AllowUserToAddRows = false;
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.BackgroundColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.EnableHeadersVisualStyles = false;
            dgvNhanVien.Location = new Point(80, 72);
            dgvNhanVien.Margin = new Padding(5);
            dgvNhanVien.Name = "dgvNhanVien";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Teal;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvNhanVien.RowHeadersVisible = false;
            dgvNhanVien.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvNhanVien.RowTemplate.Height = 32;
            dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNhanVien.Size = new Size(1463, 283);
            dgvNhanVien.TabIndex = 8;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            dgvNhanVien.CellFormatting += dgvNhanVien_CellFormatting;
            // 
            // btnHienThiMatKhau
            // 
            btnHienThiMatKhau.BackColor = SystemColors.ControlLight;
            btnHienThiMatKhau.Cursor = Cursors.Hand;
            btnHienThiMatKhau.Image = (Image)resources.GetObject("btnHienThiMatKhau.Image");
            btnHienThiMatKhau.Location = new Point(1246, 211);
            btnHienThiMatKhau.Name = "btnHienThiMatKhau";
            btnHienThiMatKhau.Size = new Size(44, 36);
            btnHienThiMatKhau.TabIndex = 15;
            btnHienThiMatKhau.UseVisualStyleBackColor = false;
            btnHienThiMatKhau.Click += btnHienThiMatKhau_Click;
            btnHienThiMatKhau.Leave += btnHienThiMatKhau_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13F);
            label10.Location = new Point(752, 218);
            label10.Name = "label10";
            label10.Size = new Size(108, 30);
            label10.TabIndex = 14;
            label10.Text = "Mật khẩu:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13F);
            label9.Location = new Point(751, 161);
            label9.Name = "label9";
            label9.Size = new Size(161, 30);
            label9.TabIndex = 13;
            label9.Text = "Tên đăng nhập:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13F);
            label8.Location = new Point(194, 272);
            label8.Name = "label8";
            label8.Size = new Size(96, 30);
            label8.TabIndex = 12;
            label8.Text = "Chức vụ:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(194, 211);
            label7.Name = "label7";
            label7.Size = new Size(145, 30);
            label7.TabIndex = 11;
            label7.Text = "Số điện thoại:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(btnHienThiMatKhau);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnLuuThongTin);
            groupBox1.Controls.Add(cmbChucVu);
            groupBox1.Controls.Add(cmbGIoiTinh);
            groupBox1.Controls.Add(btnDatLai);
            groupBox1.Controls.Add(btnXoaNhanVien);
            groupBox1.Controls.Add(btnSuaThongTin);
            groupBox1.Controls.Add(btnThemNhanVien);
            groupBox1.Controls.Add(txtSoDienThoai);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtTenDangNhap);
            groupBox1.Controls.Add(txtDiaChiNhanVien);
            groupBox1.Controls.Add(txtEmailNhanVien);
            groupBox1.Controls.Add(txtMaNhanVien);
            groupBox1.Controls.Add(txtTenNhanVien);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(80, 363);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1463, 436);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhân viên";
            // 
            // btnLuuThongTin
            // 
            btnLuuThongTin.BackColor = Color.Teal;
            btnLuuThongTin.Font = new Font("Segoe UI", 14F);
            btnLuuThongTin.ForeColor = SystemColors.ButtonHighlight;
            btnLuuThongTin.Location = new Point(458, 338);
            btnLuuThongTin.Name = "btnLuuThongTin";
            btnLuuThongTin.Size = new Size(176, 67);
            btnLuuThongTin.TabIndex = 11;
            btnLuuThongTin.Text = "Lưu thông tin";
            btnLuuThongTin.UseVisualStyleBackColor = false;
            btnLuuThongTin.Click += btnLuuThongTin_Click;
            // 
            // cmbChucVu
            // 
            cmbChucVu.Font = new Font("Segoe UI", 13F);
            cmbChucVu.FormattingEnabled = true;
            cmbChucVu.Items.AddRange(new object[] { "Quản lý", "Nhân viên" });
            cmbChucVu.Location = new Point(360, 272);
            cmbChucVu.Name = "cmbChucVu";
            cmbChucVu.Size = new Size(328, 38);
            cmbChucVu.TabIndex = 5;
            // 
            // cmbGIoiTinh
            // 
            cmbGIoiTinh.Font = new Font("Segoe UI", 13F);
            cmbGIoiTinh.FormattingEnabled = true;
            cmbGIoiTinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cmbGIoiTinh.Location = new Point(360, 153);
            cmbGIoiTinh.Name = "cmbGIoiTinh";
            cmbGIoiTinh.Size = new Size(328, 38);
            cmbGIoiTinh.TabIndex = 3;
            // 
            // btnDatLai
            // 
            btnDatLai.BackColor = Color.Teal;
            btnDatLai.Cursor = Cursors.Hand;
            btnDatLai.Font = new Font("Segoe UI", 14F);
            btnDatLai.ForeColor = SystemColors.ButtonHighlight;
            btnDatLai.Image = (Image)resources.GetObject("btnDatLai.Image");
            btnDatLai.ImageAlign = ContentAlignment.MiddleLeft;
            btnDatLai.Location = new Point(1081, 338);
            btnDatLai.Name = "btnDatLai";
            btnDatLai.Size = new Size(144, 67);
            btnDatLai.TabIndex = 14;
            btnDatLai.Text = "Đặt lại";
            btnDatLai.TextAlign = ContentAlignment.MiddleRight;
            btnDatLai.UseVisualStyleBackColor = false;
            btnDatLai.Click += btnDatLai_Click;
            // 
            // btnXoaNhanVien
            // 
            btnXoaNhanVien.BackColor = Color.Teal;
            btnXoaNhanVien.Cursor = Cursors.Hand;
            btnXoaNhanVien.Font = new Font("Segoe UI", 14F);
            btnXoaNhanVien.ForeColor = SystemColors.ButtonHighlight;
            btnXoaNhanVien.Location = new Point(864, 338);
            btnXoaNhanVien.Name = "btnXoaNhanVien";
            btnXoaNhanVien.Size = new Size(183, 67);
            btnXoaNhanVien.TabIndex = 13;
            btnXoaNhanVien.Text = "Xóa Nhân Viên";
            btnXoaNhanVien.UseVisualStyleBackColor = false;
            btnXoaNhanVien.Click += btnXoaNhanVien_Click;
            // 
            // btnSuaThongTin
            // 
            btnSuaThongTin.BackColor = Color.Teal;
            btnSuaThongTin.Cursor = Cursors.Hand;
            btnSuaThongTin.Font = new Font("Segoe UI", 14F);
            btnSuaThongTin.ForeColor = SystemColors.ButtonHighlight;
            btnSuaThongTin.Location = new Point(664, 338);
            btnSuaThongTin.Name = "btnSuaThongTin";
            btnSuaThongTin.Size = new Size(178, 67);
            btnSuaThongTin.TabIndex = 12;
            btnSuaThongTin.Text = "Sửa thông tin";
            btnSuaThongTin.UseVisualStyleBackColor = false;
            btnSuaThongTin.Click += btnSuaThongTin_Click;
            // 
            // btnThemNhanVien
            // 
            btnThemNhanVien.BackColor = Color.Teal;
            btnThemNhanVien.Cursor = Cursors.Hand;
            btnThemNhanVien.Font = new Font("Segoe UI", 14F);
            btnThemNhanVien.ForeColor = SystemColors.ButtonHighlight;
            btnThemNhanVien.Location = new Point(220, 338);
            btnThemNhanVien.Name = "btnThemNhanVien";
            btnThemNhanVien.Size = new Size(206, 67);
            btnThemNhanVien.TabIndex = 10;
            btnThemNhanVien.Text = "Thêm Nhân Viên";
            btnThemNhanVien.UseVisualStyleBackColor = false;
            btnThemNhanVien.Click += btnThemNhanVien_Click;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Font = new Font("Segoe UI", 13F);
            txtSoDienThoai.Location = new Point(360, 215);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(328, 36);
            txtSoDienThoai.TabIndex = 4;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Font = new Font("Segoe UI", 13F);
            txtMatKhau.Location = new Point(912, 211);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(328, 36);
            txtMatKhau.TabIndex = 9;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Font = new Font("Segoe UI", 13F);
            txtTenDangNhap.Location = new Point(912, 150);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(328, 36);
            txtTenDangNhap.TabIndex = 8;
            // 
            // txtDiaChiNhanVien
            // 
            txtDiaChiNhanVien.Font = new Font("Segoe UI", 13F);
            txtDiaChiNhanVien.Location = new Point(912, 95);
            txtDiaChiNhanVien.Name = "txtDiaChiNhanVien";
            txtDiaChiNhanVien.Size = new Size(328, 36);
            txtDiaChiNhanVien.TabIndex = 7;
            // 
            // txtEmailNhanVien
            // 
            txtEmailNhanVien.Font = new Font("Segoe UI", 13F);
            txtEmailNhanVien.Location = new Point(912, 44);
            txtEmailNhanVien.Name = "txtEmailNhanVien";
            txtEmailNhanVien.Size = new Size(328, 36);
            txtEmailNhanVien.TabIndex = 6;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Font = new Font("Segoe UI", 13F);
            txtMaNhanVien.Location = new Point(360, 44);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(328, 36);
            txtMaNhanVien.TabIndex = 1;
            // 
            // txtTenNhanVien
            // 
            txtTenNhanVien.Font = new Font("Segoe UI", 13F);
            txtTenNhanVien.Location = new Point(360, 98);
            txtTenNhanVien.Name = "txtTenNhanVien";
            txtTenNhanVien.Size = new Size(328, 36);
            txtTenNhanVien.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(751, 44);
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
            label6.Location = new Point(751, 101);
            label6.Name = "label6";
            label6.Size = new Size(82, 30);
            label6.TabIndex = 0;
            label6.Text = "Địa chỉ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(194, 156);
            label5.Name = "label5";
            label5.Size = new Size(98, 30);
            label5.TabIndex = 0;
            label5.Text = "Giới tính:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(194, 101);
            label3.Name = "label3";
            label3.Size = new Size(151, 30);
            label3.TabIndex = 0;
            label3.Text = "Tên nhân viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(194, 44);
            label2.Name = "label2";
            label2.Size = new Size(148, 30);
            label2.TabIndex = 0;
            label2.Text = "Mã nhân viên:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.BackColor = SystemColors.HighlightText;
            txtTimKiem.Location = new Point(204, 25);
            txtTimKiem.Multiline = true;
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(464, 39);
            txtTimKiem.TabIndex = 9;
            txtTimKiem.KeyDown += txtTimKiem_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(80, 32);
            label1.Name = "label1";
            label1.Size = new Size(118, 32);
            label1.TabIndex = 10;
            label1.Text = "Tìm kiếm:";
            // 
            // FormNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1615, 916);
            Controls.Add(dgvNhanVien);
            Controls.Add(groupBox1);
            Controls.Add(txtTimKiem);
            Controls.Add(label1);
            Name = "FormNhanVien";
            Text = "FormNhanVien";
            Load += FormNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvNhanVien;
        private Button btnHienThiMatKhau;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private GroupBox groupBox1;
        private Button btnLuuThongTin;
        private ComboBox cmbChucVu;
        private ComboBox cmbGIoiTinh;
        private Button btnDatLai;
        private Button btnXoaNhanVien;
        private Button btnSuaThongTin;
        private Button btnThemNhanVien;
        private TextBox txtSoDienThoai;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private TextBox txtDiaChiNhanVien;
        private TextBox txtEmailNhanVien;
        private TextBox txtMaNhanVien;
        private TextBox txtTenNhanVien;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox txtTimKiem;
        private Label label1;
    }
}