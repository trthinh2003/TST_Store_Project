namespace QL_CuaHangVatTuNongNghiep
{
    partial class FormPhieuNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhieuNhap));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label1 = new Label();
            groupBox1 = new GroupBox();
            cboTenLoaiHangHoa = new ComboBox();
            cboDVT = new ComboBox();
            btnDatLaiHangHoa = new Button();
            btnXoaHangHoa = new Button();
            btnSuaThongTinHangHoa = new Button();
            btnLuuHangHoa = new Button();
            btnThemHangHoa = new Button();
            txtMaHangHoa = new TextBox();
            txtTenHangHoa = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            gbAnhHangHoa = new GroupBox();
            ptbAnhHangHoa = new PictureBox();
            btnLoadAnh = new Button();
            cboNhaCungCap = new ComboBox();
            txtSoLuongNhap = new TextBox();
            txtSTTPhieuNhap = new TextBox();
            txtDonGiaNhap = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label4 = new Label();
            label7 = new Label();
            dgvHangHoa = new DataGridView();
            gbHangHoa = new GroupBox();
            gbPhieuNhap = new GroupBox();
            dgvPhieuNhap = new DataGridView();
            btnDatLaiPhieuNhap = new Button();
            btnXoaPhieuNhap = new Button();
            btnSuaPhieuNhap = new Button();
            btnLuuPhieuNhap = new Button();
            txtMaNV = new TextBox();
            btnThemPhieuNhap = new Button();
            txtMaHangHoa_PhieuNhap = new TextBox();
            label10 = new Label();
            label12 = new Label();
            groupBox1.SuspendLayout();
            gbAnhHangHoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAnhHangHoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).BeginInit();
            gbHangHoa.SuspendLayout();
            gbPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1575, 48);
            label1.TabIndex = 4;
            label1.Text = "THÔNG TIN PHIẾU NHẬP HÀNG";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(cboTenLoaiHangHoa);
            groupBox1.Controls.Add(cboDVT);
            groupBox1.Controls.Add(btnDatLaiHangHoa);
            groupBox1.Controls.Add(btnXoaHangHoa);
            groupBox1.Controls.Add(btnSuaThongTinHangHoa);
            groupBox1.Controls.Add(btnLuuHangHoa);
            groupBox1.Controls.Add(btnThemHangHoa);
            groupBox1.Controls.Add(txtMaHangHoa);
            groupBox1.Controls.Add(txtTenHangHoa);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(gbAnhHangHoa);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(30, 424);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(829, 351);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // cboTenLoaiHangHoa
            // 
            cboTenLoaiHangHoa.Font = new Font("Segoe UI", 10F);
            cboTenLoaiHangHoa.FormattingEnabled = true;
            cboTenLoaiHangHoa.Location = new Point(146, 49);
            cboTenLoaiHangHoa.Name = "cboTenLoaiHangHoa";
            cboTenLoaiHangHoa.Size = new Size(251, 31);
            cboTenLoaiHangHoa.TabIndex = 1;
            // 
            // cboDVT
            // 
            cboDVT.Font = new Font("Segoe UI", 10F);
            cboDVT.FormattingEnabled = true;
            cboDVT.Items.AddRange(new object[] { "Chai", "Gói", "Kg" });
            cboDVT.Location = new Point(146, 184);
            cboDVT.Name = "cboDVT";
            cboDVT.Size = new Size(106, 31);
            cboDVT.TabIndex = 4;
            // 
            // btnDatLaiHangHoa
            // 
            btnDatLaiHangHoa.BackColor = Color.Teal;
            btnDatLaiHangHoa.Cursor = Cursors.Hand;
            btnDatLaiHangHoa.Font = new Font("Segoe UI", 12F);
            btnDatLaiHangHoa.ForeColor = SystemColors.ButtonHighlight;
            btnDatLaiHangHoa.Image = (Image)resources.GetObject("btnDatLaiHangHoa.Image");
            btnDatLaiHangHoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnDatLaiHangHoa.Location = new Point(403, 274);
            btnDatLaiHangHoa.Name = "btnDatLaiHangHoa";
            btnDatLaiHangHoa.Size = new Size(118, 55);
            btnDatLaiHangHoa.TabIndex = 5;
            btnDatLaiHangHoa.Text = "Đặt lại";
            btnDatLaiHangHoa.TextAlign = ContentAlignment.MiddleRight;
            btnDatLaiHangHoa.UseVisualStyleBackColor = false;
            btnDatLaiHangHoa.Click += btnDatLaiHangHoa_Click;
            // 
            // btnXoaHangHoa
            // 
            btnXoaHangHoa.BackColor = Color.Teal;
            btnXoaHangHoa.Cursor = Cursors.Hand;
            btnXoaHangHoa.Font = new Font("Segoe UI", 12F);
            btnXoaHangHoa.ForeColor = SystemColors.ButtonHighlight;
            btnXoaHangHoa.Location = new Point(306, 274);
            btnXoaHangHoa.Name = "btnXoaHangHoa";
            btnXoaHangHoa.Size = new Size(91, 56);
            btnXoaHangHoa.TabIndex = 5;
            btnXoaHangHoa.Text = "Xóa";
            btnXoaHangHoa.UseVisualStyleBackColor = false;
            btnXoaHangHoa.Click += btnXoaHangHoa_Click;
            // 
            // btnSuaThongTinHangHoa
            // 
            btnSuaThongTinHangHoa.BackColor = Color.Teal;
            btnSuaThongTinHangHoa.Cursor = Cursors.Hand;
            btnSuaThongTinHangHoa.Font = new Font("Segoe UI", 12F);
            btnSuaThongTinHangHoa.ForeColor = SystemColors.ButtonHighlight;
            btnSuaThongTinHangHoa.Location = new Point(211, 274);
            btnSuaThongTinHangHoa.Name = "btnSuaThongTinHangHoa";
            btnSuaThongTinHangHoa.Size = new Size(89, 56);
            btnSuaThongTinHangHoa.TabIndex = 5;
            btnSuaThongTinHangHoa.Text = "Sửa";
            btnSuaThongTinHangHoa.UseVisualStyleBackColor = false;
            btnSuaThongTinHangHoa.Click += btnSuaThongTinHangHoa_Click;
            // 
            // btnLuuHangHoa
            // 
            btnLuuHangHoa.BackColor = Color.Teal;
            btnLuuHangHoa.Cursor = Cursors.Hand;
            btnLuuHangHoa.Font = new Font("Segoe UI", 12F);
            btnLuuHangHoa.ForeColor = SystemColors.ButtonHighlight;
            btnLuuHangHoa.Location = new Point(124, 274);
            btnLuuHangHoa.Name = "btnLuuHangHoa";
            btnLuuHangHoa.Size = new Size(81, 56);
            btnLuuHangHoa.TabIndex = 5;
            btnLuuHangHoa.Text = "Lưu";
            btnLuuHangHoa.UseVisualStyleBackColor = false;
            btnLuuHangHoa.Click += btnLuuHangHoa_Click;
            // 
            // btnThemHangHoa
            // 
            btnThemHangHoa.BackColor = Color.Teal;
            btnThemHangHoa.Cursor = Cursors.Hand;
            btnThemHangHoa.Font = new Font("Segoe UI", 12F);
            btnThemHangHoa.ForeColor = SystemColors.ButtonHighlight;
            btnThemHangHoa.Location = new Point(20, 275);
            btnThemHangHoa.Name = "btnThemHangHoa";
            btnThemHangHoa.Size = new Size(98, 55);
            btnThemHangHoa.TabIndex = 5;
            btnThemHangHoa.Text = "Thêm";
            btnThemHangHoa.UseVisualStyleBackColor = false;
            btnThemHangHoa.Click += btnThemHangHoa_Click;
            // 
            // txtMaHangHoa
            // 
            txtMaHangHoa.Font = new Font("Segoe UI", 10F);
            txtMaHangHoa.Location = new Point(146, 96);
            txtMaHangHoa.Name = "txtMaHangHoa";
            txtMaHangHoa.Size = new Size(114, 30);
            txtMaHangHoa.TabIndex = 2;
            // 
            // txtTenHangHoa
            // 
            txtTenHangHoa.Font = new Font("Segoe UI", 10F);
            txtTenHangHoa.Location = new Point(146, 139);
            txtTenHangHoa.Name = "txtTenHangHoa";
            txtTenHangHoa.Size = new Size(274, 30);
            txtTenHangHoa.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(20, 52);
            label6.Name = "label6";
            label6.Size = new Size(123, 23);
            label6.TabIndex = 0;
            label6.Text = "Loại hàng hóa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(20, 184);
            label5.Name = "label5";
            label5.Size = new Size(98, 23);
            label5.TabIndex = 0;
            label5.Text = "Đơn vị tính:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(20, 142);
            label3.Name = "label3";
            label3.Size = new Size(118, 23);
            label3.TabIndex = 0;
            label3.Text = "Tên hàng hóa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(20, 96);
            label2.Name = "label2";
            label2.Size = new Size(116, 23);
            label2.TabIndex = 0;
            label2.Text = "Mã hàng hóa:";
            // 
            // gbAnhHangHoa
            // 
            gbAnhHangHoa.Controls.Add(ptbAnhHangHoa);
            gbAnhHangHoa.Controls.Add(btnLoadAnh);
            gbAnhHangHoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbAnhHangHoa.Location = new Point(587, 0);
            gbAnhHangHoa.Name = "gbAnhHangHoa";
            gbAnhHangHoa.Size = new Size(219, 283);
            gbAnhHangHoa.TabIndex = 9;
            gbAnhHangHoa.TabStop = false;
            gbAnhHangHoa.Text = "Ảnh hàng hóa";
            // 
            // ptbAnhHangHoa
            // 
            ptbAnhHangHoa.BackColor = SystemColors.ButtonHighlight;
            ptbAnhHangHoa.BorderStyle = BorderStyle.Fixed3D;
            ptbAnhHangHoa.Location = new Point(30, 35);
            ptbAnhHangHoa.Name = "ptbAnhHangHoa";
            ptbAnhHangHoa.Size = new Size(164, 170);
            ptbAnhHangHoa.SizeMode = PictureBoxSizeMode.Zoom;
            ptbAnhHangHoa.TabIndex = 8;
            ptbAnhHangHoa.TabStop = false;
            // 
            // btnLoadAnh
            // 
            btnLoadAnh.BackColor = Color.Teal;
            btnLoadAnh.Cursor = Cursors.Hand;
            btnLoadAnh.Font = new Font("Segoe UI", 11F);
            btnLoadAnh.ForeColor = SystemColors.ButtonHighlight;
            btnLoadAnh.Location = new Point(30, 214);
            btnLoadAnh.Name = "btnLoadAnh";
            btnLoadAnh.Size = new Size(164, 47);
            btnLoadAnh.TabIndex = 5;
            btnLoadAnh.Text = "Thêm ảnh";
            btnLoadAnh.UseVisualStyleBackColor = false;
            btnLoadAnh.Click += btnLoadAnh_Click;
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.Font = new Font("Segoe UI", 10F);
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(137, 584);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(173, 31);
            cboNhaCungCap.TabIndex = 6;
            // 
            // txtSoLuongNhap
            // 
            txtSoLuongNhap.Font = new Font("Segoe UI", 10F);
            txtSoLuongNhap.Location = new Point(529, 585);
            txtSoLuongNhap.Name = "txtSoLuongNhap";
            txtSoLuongNhap.Size = new Size(139, 30);
            txtSoLuongNhap.TabIndex = 5;
            // 
            // txtSTTPhieuNhap
            // 
            txtSTTPhieuNhap.Font = new Font("Segoe UI", 10F);
            txtSTTPhieuNhap.Location = new Point(137, 474);
            txtSTTPhieuNhap.Name = "txtSTTPhieuNhap";
            txtSTTPhieuNhap.Size = new Size(91, 30);
            txtSTTPhieuNhap.TabIndex = 5;
            // 
            // txtDonGiaNhap
            // 
            txtDonGiaNhap.Font = new Font("Segoe UI", 10F);
            txtDonGiaNhap.Location = new Point(529, 532);
            txtDonGiaNhap.Name = "txtDonGiaNhap";
            txtDonGiaNhap.Size = new Size(139, 30);
            txtDonGiaNhap.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(397, 592);
            label8.Name = "label8";
            label8.Size = new Size(126, 23);
            label8.TabIndex = 0;
            label8.Text = "Số lượng nhập:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(8, 478);
            label9.Name = "label9";
            label9.Size = new Size(123, 23);
            label9.TabIndex = 0;
            label9.Text = "Phiếu nhập số:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(397, 535);
            label4.Name = "label4";
            label4.Size = new Size(118, 23);
            label4.TabIndex = 0;
            label4.Text = "Đơn giá nhập:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(8, 590);
            label7.Name = "label7";
            label7.Size = new Size(121, 23);
            label7.TabIndex = 0;
            label7.Text = "Nhà cung cấp:";
            // 
            // dgvHangHoa
            // 
            dgvHangHoa.AllowUserToAddRows = false;
            dgvHangHoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHangHoa.BackgroundColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHangHoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHangHoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHangHoa.EnableHeadersVisualStyles = false;
            dgvHangHoa.Location = new Point(8, 35);
            dgvHangHoa.Margin = new Padding(5);
            dgvHangHoa.Name = "dgvHangHoa";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Teal;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvHangHoa.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvHangHoa.RowHeadersVisible = false;
            dgvHangHoa.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvHangHoa.RowTemplate.Height = 32;
            dgvHangHoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHangHoa.Size = new Size(813, 307);
            dgvHangHoa.TabIndex = 5;
            dgvHangHoa.CellClick += dgvHangHoa_CellClick;
            // 
            // gbHangHoa
            // 
            gbHangHoa.Controls.Add(dgvHangHoa);
            gbHangHoa.Location = new Point(30, 51);
            gbHangHoa.Name = "gbHangHoa";
            gbHangHoa.Size = new Size(829, 357);
            gbHangHoa.TabIndex = 10;
            gbHangHoa.TabStop = false;
            gbHangHoa.Text = "Thông tin hàng hóa";
            // 
            // gbPhieuNhap
            // 
            gbPhieuNhap.Controls.Add(cboNhaCungCap);
            gbPhieuNhap.Controls.Add(dgvPhieuNhap);
            gbPhieuNhap.Controls.Add(btnDatLaiPhieuNhap);
            gbPhieuNhap.Controls.Add(label9);
            gbPhieuNhap.Controls.Add(btnXoaPhieuNhap);
            gbPhieuNhap.Controls.Add(txtSTTPhieuNhap);
            gbPhieuNhap.Controls.Add(btnSuaPhieuNhap);
            gbPhieuNhap.Controls.Add(label4);
            gbPhieuNhap.Controls.Add(btnLuuPhieuNhap);
            gbPhieuNhap.Controls.Add(txtMaNV);
            gbPhieuNhap.Controls.Add(btnThemPhieuNhap);
            gbPhieuNhap.Controls.Add(txtSoLuongNhap);
            gbPhieuNhap.Controls.Add(txtDonGiaNhap);
            gbPhieuNhap.Controls.Add(txtMaHangHoa_PhieuNhap);
            gbPhieuNhap.Controls.Add(label10);
            gbPhieuNhap.Controls.Add(label8);
            gbPhieuNhap.Controls.Add(label7);
            gbPhieuNhap.Controls.Add(label12);
            gbPhieuNhap.Location = new Point(880, 51);
            gbPhieuNhap.Name = "gbPhieuNhap";
            gbPhieuNhap.Size = new Size(683, 724);
            gbPhieuNhap.TabIndex = 11;
            gbPhieuNhap.TabStop = false;
            gbPhieuNhap.Text = "Thông tin phiếu nhập";
            // 
            // dgvPhieuNhap
            // 
            dgvPhieuNhap.AllowUserToAddRows = false;
            dgvPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhieuNhap.BackgroundColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Teal;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPhieuNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuNhap.EnableHeadersVisualStyles = false;
            dgvPhieuNhap.Location = new Point(8, 29);
            dgvPhieuNhap.Margin = new Padding(5);
            dgvPhieuNhap.Name = "dgvPhieuNhap";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Teal;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvPhieuNhap.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvPhieuNhap.RowHeadersVisible = false;
            dgvPhieuNhap.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            dgvPhieuNhap.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvPhieuNhap.RowTemplate.Height = 32;
            dgvPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhieuNhap.Size = new Size(653, 419);
            dgvPhieuNhap.TabIndex = 5;
            dgvPhieuNhap.CellClick += dgvPhieuNhap_CellClick;
            // 
            // btnDatLaiPhieuNhap
            // 
            btnDatLaiPhieuNhap.BackColor = Color.Teal;
            btnDatLaiPhieuNhap.Cursor = Cursors.Hand;
            btnDatLaiPhieuNhap.Font = new Font("Segoe UI", 12F);
            btnDatLaiPhieuNhap.ForeColor = SystemColors.ButtonHighlight;
            btnDatLaiPhieuNhap.Image = (Image)resources.GetObject("btnDatLaiPhieuNhap.Image");
            btnDatLaiPhieuNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btnDatLaiPhieuNhap.Location = new Point(483, 647);
            btnDatLaiPhieuNhap.Name = "btnDatLaiPhieuNhap";
            btnDatLaiPhieuNhap.Size = new Size(118, 55);
            btnDatLaiPhieuNhap.TabIndex = 5;
            btnDatLaiPhieuNhap.Text = "Đặt lại";
            btnDatLaiPhieuNhap.TextAlign = ContentAlignment.MiddleRight;
            btnDatLaiPhieuNhap.UseVisualStyleBackColor = false;
            btnDatLaiPhieuNhap.Click += btnDatLaiPhieuNhap_Click;
            // 
            // btnXoaPhieuNhap
            // 
            btnXoaPhieuNhap.BackColor = Color.Teal;
            btnXoaPhieuNhap.Cursor = Cursors.Hand;
            btnXoaPhieuNhap.Font = new Font("Segoe UI", 12F);
            btnXoaPhieuNhap.ForeColor = SystemColors.ButtonHighlight;
            btnXoaPhieuNhap.Location = new Point(386, 647);
            btnXoaPhieuNhap.Name = "btnXoaPhieuNhap";
            btnXoaPhieuNhap.Size = new Size(91, 56);
            btnXoaPhieuNhap.TabIndex = 5;
            btnXoaPhieuNhap.Text = "Xóa";
            btnXoaPhieuNhap.UseVisualStyleBackColor = false;
            // 
            // btnSuaPhieuNhap
            // 
            btnSuaPhieuNhap.BackColor = Color.Teal;
            btnSuaPhieuNhap.Cursor = Cursors.Hand;
            btnSuaPhieuNhap.Font = new Font("Segoe UI", 12F);
            btnSuaPhieuNhap.ForeColor = SystemColors.ButtonHighlight;
            btnSuaPhieuNhap.Location = new Point(291, 647);
            btnSuaPhieuNhap.Name = "btnSuaPhieuNhap";
            btnSuaPhieuNhap.Size = new Size(89, 56);
            btnSuaPhieuNhap.TabIndex = 5;
            btnSuaPhieuNhap.Text = "Sửa";
            btnSuaPhieuNhap.UseVisualStyleBackColor = false;
            // 
            // btnLuuPhieuNhap
            // 
            btnLuuPhieuNhap.BackColor = Color.Teal;
            btnLuuPhieuNhap.Cursor = Cursors.Hand;
            btnLuuPhieuNhap.Font = new Font("Segoe UI", 12F);
            btnLuuPhieuNhap.ForeColor = SystemColors.ButtonHighlight;
            btnLuuPhieuNhap.Location = new Point(204, 647);
            btnLuuPhieuNhap.Name = "btnLuuPhieuNhap";
            btnLuuPhieuNhap.Size = new Size(81, 56);
            btnLuuPhieuNhap.TabIndex = 5;
            btnLuuPhieuNhap.Text = "Lưu";
            btnLuuPhieuNhap.UseVisualStyleBackColor = false;
            btnLuuPhieuNhap.Click += btnLuuPhieuNhap_Click;
            // 
            // txtMaNV
            // 
            txtMaNV.Font = new Font("Segoe UI", 10F);
            txtMaNV.Location = new Point(137, 528);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(112, 30);
            txtMaNV.TabIndex = 5;
            // 
            // btnThemPhieuNhap
            // 
            btnThemPhieuNhap.BackColor = Color.Teal;
            btnThemPhieuNhap.Cursor = Cursors.Hand;
            btnThemPhieuNhap.Font = new Font("Segoe UI", 12F);
            btnThemPhieuNhap.ForeColor = SystemColors.ButtonHighlight;
            btnThemPhieuNhap.Location = new Point(100, 648);
            btnThemPhieuNhap.Name = "btnThemPhieuNhap";
            btnThemPhieuNhap.Size = new Size(98, 55);
            btnThemPhieuNhap.TabIndex = 5;
            btnThemPhieuNhap.Text = "Thêm";
            btnThemPhieuNhap.UseVisualStyleBackColor = false;
            btnThemPhieuNhap.Click += btnThemPhieuNhap_Click;
            // 
            // txtMaHangHoa_PhieuNhap
            // 
            txtMaHangHoa_PhieuNhap.Font = new Font("Segoe UI", 10F);
            txtMaHangHoa_PhieuNhap.Location = new Point(529, 474);
            txtMaHangHoa_PhieuNhap.Name = "txtMaHangHoa_PhieuNhap";
            txtMaHangHoa_PhieuNhap.Size = new Size(114, 30);
            txtMaHangHoa_PhieuNhap.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(8, 535);
            label10.Name = "label10";
            label10.Size = new Size(118, 23);
            label10.TabIndex = 0;
            label10.Text = "Mã nhân viên:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(397, 474);
            label12.Name = "label12";
            label12.Size = new Size(116, 23);
            label12.TabIndex = 0;
            label12.Text = "Mã hàng hóa:";
            // 
            // FormPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1575, 863);
            Controls.Add(gbPhieuNhap);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(gbHangHoa);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "FormPhieuNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormThemHangHoaTuPhieuNhap";
            Load += FormPhieuNhap_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbAnhHangHoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbAnhHangHoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).EndInit();
            gbHangHoa.ResumeLayout(false);
            gbPhieuNhap.ResumeLayout(false);
            gbPhieuNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuNhap).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private GroupBox groupBox1;
        private ComboBox cboNhaCungCap;
        private ComboBox cboTenLoaiHangHoa;
        private ComboBox cboDVT;
        private Button btnDatLaiHangHoa;
        private Button btnXoaHangHoa;
        private Button btnSuaThongTinHangHoa;
        private TextBox txtMaHangHoa;
        private TextBox txtTenHangHoa;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private GroupBox gbAnhHangHoa;
        private PictureBox ptbAnhHangHoa;
        private Button btnLoadAnh;
        private DataGridView dgvHangHoa;
        private TextBox txtSoLuongNhap;
        private TextBox txtDonGiaNhap;
        private Label label8;
        private Label label4;
        private Button btnLuuHangHoa;
        private Button btnThemHangHoa;
        private TextBox txtSTTPhieuNhap;
        private Label label9;
        private GroupBox gbHangHoa;
        private GroupBox gbPhieuNhap;
        private DataGridView dgvPhieuNhap;
        private TextBox txtMaNV;
        private Label label10;
        private TextBox txtMaHangHoa_PhieuNhap;
        private Label label12;
        private Button btnDatLaiPhieuNhap;
        private Button btnXoaPhieuNhap;
        private Button btnSuaPhieuNhap;
        private Button btnLuuPhieuNhap;
        private Button btnThemPhieuNhap;
    }
}