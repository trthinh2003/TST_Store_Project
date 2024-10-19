namespace QL_CuaHangVatTuNongNghiep
{
    partial class FormHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHangHoa));
            dgvHangHoa = new DataGridView();
            label1 = new Label();
            txtTimKiem = new TextBox();
            groupBox1 = new GroupBox();
            cboNhaCungCap = new ComboBox();
            cboTenLoaiHangHoa = new ComboBox();
            cboDVT = new ComboBox();
            btnDatLai = new Button();
            btnXoaHangHoa = new Button();
            btnSuaThongTin = new Button();
            txtGiaNiemYet = new TextBox();
            txtMaHangHoa = new TextBox();
            txtTenHangHoa = new TextBox();
            label4 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            ptbAnhHangHoa = new PictureBox();
            btnLoadAnh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAnhHangHoa).BeginInit();
            SuspendLayout();
            // 
            // dgvHangHoa
            // 
            dgvHangHoa.AllowUserToAddRows = false;
            dgvHangHoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHangHoa.BackgroundColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHangHoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHangHoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHangHoa.EnableHeadersVisualStyles = false;
            dgvHangHoa.Location = new Point(86, 72);
            dgvHangHoa.Margin = new Padding(5);
            dgvHangHoa.Name = "dgvHangHoa";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Teal;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvHangHoa.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvHangHoa.RowHeadersVisible = false;
            dgvHangHoa.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvHangHoa.RowTemplate.Height = 32;
            dgvHangHoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHangHoa.Size = new Size(1463, 283);
            dgvHangHoa.TabIndex = 0;
            dgvHangHoa.CellClick += dgvHangHoa_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 17);
            label1.Name = "label1";
            label1.Size = new Size(118, 32);
            label1.TabIndex = 1;
            label1.Text = "Tìm kiếm:";
            // 
            // txtTimKiem
            // 
            txtTimKiem.BackColor = SystemColors.HighlightText;
            txtTimKiem.Location = new Point(210, 14);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(464, 39);
            txtTimKiem.TabIndex = 1;
            txtTimKiem.KeyDown += txtTimKiem_KeyDown;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(cboNhaCungCap);
            groupBox1.Controls.Add(cboTenLoaiHangHoa);
            groupBox1.Controls.Add(cboDVT);
            groupBox1.Controls.Add(btnDatLai);
            groupBox1.Controls.Add(btnXoaHangHoa);
            groupBox1.Controls.Add(btnSuaThongTin);
            groupBox1.Controls.Add(txtGiaNiemYet);
            groupBox1.Controls.Add(txtMaHangHoa);
            groupBox1.Controls.Add(txtTenHangHoa);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(86, 377);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1463, 385);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hàng hóa";
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.Font = new Font("Segoe UI", 13F);
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(797, 196);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(251, 38);
            cboNhaCungCap.TabIndex = 6;
            // 
            // cboTenLoaiHangHoa
            // 
            cboTenLoaiHangHoa.Font = new Font("Segoe UI", 13F);
            cboTenLoaiHangHoa.FormattingEnabled = true;
            cboTenLoaiHangHoa.Location = new Point(797, 130);
            cboTenLoaiHangHoa.Name = "cboTenLoaiHangHoa";
            cboTenLoaiHangHoa.Size = new Size(251, 38);
            cboTenLoaiHangHoa.TabIndex = 6;
            // 
            // cboDVT
            // 
            cboDVT.Font = new Font("Segoe UI", 13F);
            cboDVT.FormattingEnabled = true;
            cboDVT.Items.AddRange(new object[] { "Chai", "Gói", "Kg" });
            cboDVT.Location = new Point(247, 201);
            cboDVT.Name = "cboDVT";
            cboDVT.Size = new Size(106, 38);
            cboDVT.TabIndex = 4;
            // 
            // btnDatLai
            // 
            btnDatLai.BackColor = Color.Teal;
            btnDatLai.Cursor = Cursors.Hand;
            btnDatLai.Font = new Font("Segoe UI", 14F);
            btnDatLai.ForeColor = SystemColors.ButtonHighlight;
            btnDatLai.Image = (Image)resources.GetObject("btnDatLai.Image");
            btnDatLai.ImageAlign = ContentAlignment.MiddleLeft;
            btnDatLai.Location = new Point(734, 288);
            btnDatLai.Name = "btnDatLai";
            btnDatLai.Size = new Size(144, 67);
            btnDatLai.TabIndex = 5;
            btnDatLai.Text = "Đặt lại";
            btnDatLai.TextAlign = ContentAlignment.MiddleRight;
            btnDatLai.UseVisualStyleBackColor = false;
            btnDatLai.Click += btnDatLai_Click;
            // 
            // btnXoaHangHoa
            // 
            btnXoaHangHoa.BackColor = Color.Teal;
            btnXoaHangHoa.Cursor = Cursors.Hand;
            btnXoaHangHoa.Font = new Font("Segoe UI", 14F);
            btnXoaHangHoa.ForeColor = SystemColors.ButtonHighlight;
            btnXoaHangHoa.Location = new Point(487, 288);
            btnXoaHangHoa.Name = "btnXoaHangHoa";
            btnXoaHangHoa.Size = new Size(183, 67);
            btnXoaHangHoa.TabIndex = 5;
            btnXoaHangHoa.Text = "Xóa hàng hóa";
            btnXoaHangHoa.UseVisualStyleBackColor = false;
            btnXoaHangHoa.Click += btnXoaHangHoa_Click;
            // 
            // btnSuaThongTin
            // 
            btnSuaThongTin.BackColor = Color.Teal;
            btnSuaThongTin.Cursor = Cursors.Hand;
            btnSuaThongTin.Font = new Font("Segoe UI", 14F);
            btnSuaThongTin.ForeColor = SystemColors.ButtonHighlight;
            btnSuaThongTin.Location = new Point(247, 288);
            btnSuaThongTin.Name = "btnSuaThongTin";
            btnSuaThongTin.Size = new Size(178, 67);
            btnSuaThongTin.TabIndex = 5;
            btnSuaThongTin.Text = "Sửa thông tin";
            btnSuaThongTin.UseVisualStyleBackColor = false;
            btnSuaThongTin.Click += btnSuaThongTin_Click;
            // 
            // txtGiaNiemYet
            // 
            txtGiaNiemYet.Font = new Font("Segoe UI", 13F);
            txtGiaNiemYet.Location = new Point(797, 64);
            txtGiaNiemYet.Name = "txtGiaNiemYet";
            txtGiaNiemYet.Size = new Size(166, 36);
            txtGiaNiemYet.TabIndex = 5;
            // 
            // txtMaHangHoa
            // 
            txtMaHangHoa.Font = new Font("Segoe UI", 13F);
            txtMaHangHoa.Location = new Point(247, 70);
            txtMaHangHoa.Name = "txtMaHangHoa";
            txtMaHangHoa.Size = new Size(114, 36);
            txtMaHangHoa.TabIndex = 3;
            // 
            // txtTenHangHoa
            // 
            txtTenHangHoa.Font = new Font("Segoe UI", 13F);
            txtTenHangHoa.Location = new Point(247, 132);
            txtTenHangHoa.Name = "txtTenHangHoa";
            txtTenHangHoa.Size = new Size(328, 36);
            txtTenHangHoa.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(638, 70);
            label4.Name = "label4";
            label4.Size = new Size(139, 30);
            label4.TabIndex = 0;
            label4.Text = "Giá niêm yết:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(638, 201);
            label7.Name = "label7";
            label7.Size = new Size(150, 30);
            label7.TabIndex = 0;
            label7.Text = "Nhà cung cấp:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(638, 135);
            label6.Name = "label6";
            label6.Size = new Size(153, 30);
            label6.TabIndex = 0;
            label6.Text = "Loại hàng hóa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(81, 204);
            label5.Name = "label5";
            label5.Size = new Size(122, 30);
            label5.TabIndex = 0;
            label5.Text = "Đơn vị tính:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(81, 135);
            label3.Name = "label3";
            label3.Size = new Size(148, 30);
            label3.TabIndex = 0;
            label3.Text = "Tên hàng hóa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(81, 70);
            label2.Name = "label2";
            label2.Size = new Size(145, 30);
            label2.TabIndex = 0;
            label2.Text = "Mã hàng hóa:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ptbAnhHangHoa);
            groupBox2.Controls.Add(btnLoadAnh);
            groupBox2.Location = new Point(1101, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(362, 385);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ảnh hàng hóa";
            // 
            // ptbAnhHangHoa
            // 
            ptbAnhHangHoa.BackColor = SystemColors.ButtonHighlight;
            ptbAnhHangHoa.BorderStyle = BorderStyle.Fixed3D;
            ptbAnhHangHoa.Location = new Point(68, 41);
            ptbAnhHangHoa.Name = "ptbAnhHangHoa";
            ptbAnhHangHoa.Size = new Size(233, 241);
            ptbAnhHangHoa.SizeMode = PictureBoxSizeMode.Zoom;
            ptbAnhHangHoa.TabIndex = 8;
            ptbAnhHangHoa.TabStop = false;
            // 
            // btnLoadAnh
            // 
            btnLoadAnh.BackColor = Color.Teal;
            btnLoadAnh.Cursor = Cursors.Hand;
            btnLoadAnh.Font = new Font("Segoe UI", 12F);
            btnLoadAnh.ForeColor = SystemColors.ButtonHighlight;
            btnLoadAnh.Location = new Point(68, 299);
            btnLoadAnh.Name = "btnLoadAnh";
            btnLoadAnh.Size = new Size(233, 47);
            btnLoadAnh.TabIndex = 5;
            btnLoadAnh.Text = "Thêm ảnh";
            btnLoadAnh.UseVisualStyleBackColor = false;
            btnLoadAnh.Click += btnLoadAnh_Click;
            // 
            // FormHangHoa
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1615, 916);
            Controls.Add(groupBox1);
            Controls.Add(txtTimKiem);
            Controls.Add(label1);
            Controls.Add(dgvHangHoa);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "FormHangHoa";
            Text = "FormHangHoa";
            Load += FormHangHoa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbAnhHangHoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHangHoa;
        private Label label1;
        private TextBox txtTimKiem;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txtTenHangHoa;
        private Label label3;
        private Button btnXoaHangHoa;
        private Button btnSuaThongTin;
        private TextBox txtGiaNiemYet;
        private Label label4;
        private PictureBox ptbAnhHangHoa;
        private ComboBox cboDVT;
        private Label label5;
        private ComboBox cboTenLoaiHangHoa;
        private Label label6;
        private Button btnLoadAnh;
        private Button btnDatLai;
        private TextBox txtMaHangHoa;
        private GroupBox groupBox2;
        private ComboBox cboNhaCungCap;
        private Label label7;
    }
}