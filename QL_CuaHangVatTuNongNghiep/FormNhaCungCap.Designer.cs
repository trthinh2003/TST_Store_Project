namespace QL_CuaHangVatTuNongNghiep
{
    partial class FormNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhaCungCap));
            dgvNCC = new DataGridView();
            groupBox1 = new GroupBox();
            btnLuuThongTin = new Button();
            btnDatLai = new Button();
            btnXoaHangHoa = new Button();
            btnSuaThongTin = new Button();
            btnThemNhaCungCap = new Button();
            txtEmail = new TextBox();
            txtMaNhaCungCap = new TextBox();
            txtDiachi = new TextBox();
            txtSDT = new TextBox();
            txtTenNhaCungCap = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtKeyWord = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvNCC).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvNCC
            // 
            dgvNCC.AllowUserToAddRows = false;
            dgvNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNCC.BackgroundColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvNCC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvNCC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNCC.EnableHeadersVisualStyles = false;
            dgvNCC.Location = new Point(84, 106);
            dgvNCC.Margin = new Padding(5);
            dgvNCC.Name = "dgvNCC";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Teal;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvNCC.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvNCC.RowHeadersVisible = false;
            dgvNCC.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgvNCC.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvNCC.RowTemplate.Height = 32;
            dgvNCC.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNCC.Size = new Size(1463, 283);
            dgvNCC.TabIndex = 1;
            dgvNCC.CellClick += dgvNCC_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(btnLuuThongTin);
            groupBox1.Controls.Add(btnDatLai);
            groupBox1.Controls.Add(btnXoaHangHoa);
            groupBox1.Controls.Add(btnSuaThongTin);
            groupBox1.Controls.Add(btnThemNhaCungCap);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtMaNhaCungCap);
            groupBox1.Controls.Add(txtDiachi);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtTenNhaCungCap);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(84, 416);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1463, 385);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // btnLuuThongTin
            // 
            btnLuuThongTin.BackColor = Color.Teal;
            btnLuuThongTin.Font = new Font("Segoe UI", 14F);
            btnLuuThongTin.ForeColor = SystemColors.ButtonHighlight;
            btnLuuThongTin.Location = new Point(429, 284);
            btnLuuThongTin.Name = "btnLuuThongTin";
            btnLuuThongTin.Size = new Size(176, 67);
            btnLuuThongTin.TabIndex = 10;
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
            btnDatLai.Location = new Point(1137, 284);
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
            btnXoaHangHoa.Location = new Point(874, 284);
            btnXoaHangHoa.Name = "btnXoaHangHoa";
            btnXoaHangHoa.Size = new Size(229, 67);
            btnXoaHangHoa.TabIndex = 5;
            btnXoaHangHoa.Text = "Xóa nhà cung cấp";
            btnXoaHangHoa.UseVisualStyleBackColor = false;
            btnXoaHangHoa.Click += btnXoaHangHoa_Click;
            // 
            // btnSuaThongTin
            // 
            btnSuaThongTin.BackColor = Color.Teal;
            btnSuaThongTin.Cursor = Cursors.Hand;
            btnSuaThongTin.Font = new Font("Segoe UI", 14F);
            btnSuaThongTin.ForeColor = SystemColors.ButtonHighlight;
            btnSuaThongTin.Location = new Point(653, 284);
            btnSuaThongTin.Name = "btnSuaThongTin";
            btnSuaThongTin.Size = new Size(178, 67);
            btnSuaThongTin.TabIndex = 5;
            btnSuaThongTin.Text = "Sửa thông tin";
            btnSuaThongTin.UseVisualStyleBackColor = false;
            btnSuaThongTin.Click += btnSuaThongTin_Click;
            // 
            // btnThemNhaCungCap
            // 
            btnThemNhaCungCap.BackColor = Color.Teal;
            btnThemNhaCungCap.Cursor = Cursors.Hand;
            btnThemNhaCungCap.Font = new Font("Segoe UI", 14F);
            btnThemNhaCungCap.ForeColor = SystemColors.ButtonHighlight;
            btnThemNhaCungCap.Location = new Point(141, 284);
            btnThemNhaCungCap.Name = "btnThemNhaCungCap";
            btnThemNhaCungCap.Size = new Size(250, 67);
            btnThemNhaCungCap.TabIndex = 5;
            btnThemNhaCungCap.Text = "Thêm nhà cung cấp";
            btnThemNhaCungCap.UseVisualStyleBackColor = false;
            btnThemNhaCungCap.Click += btnThemNhaCungCap_Click;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 13F);
            txtEmail.Location = new Point(713, 70);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(496, 36);
            txtEmail.TabIndex = 5;
            // 
            // txtMaNhaCungCap
            // 
            txtMaNhaCungCap.Font = new Font("Segoe UI", 13F);
            txtMaNhaCungCap.Location = new Point(277, 70);
            txtMaNhaCungCap.Name = "txtMaNhaCungCap";
            txtMaNhaCungCap.Size = new Size(114, 36);
            txtMaNhaCungCap.TabIndex = 3;
            // 
            // txtDiachi
            // 
            txtDiachi.Font = new Font("Segoe UI", 13F);
            txtDiachi.Location = new Point(726, 132);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(483, 36);
            txtDiachi.TabIndex = 3;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI", 13F);
            txtSDT.Location = new Point(232, 204);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(373, 36);
            txtSDT.TabIndex = 3;
            // 
            // txtTenNhaCungCap
            // 
            txtTenNhaCungCap.Font = new Font("Segoe UI", 13F);
            txtTenNhaCungCap.Location = new Point(277, 135);
            txtTenNhaCungCap.Name = "txtTenNhaCungCap";
            txtTenNhaCungCap.Size = new Size(328, 36);
            txtTenNhaCungCap.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(638, 70);
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
            label6.Location = new Point(638, 135);
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
            label5.Location = new Point(81, 204);
            label5.Name = "label5";
            label5.Size = new Size(145, 30);
            label5.TabIndex = 0;
            label5.Text = "Số điện thoại:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(81, 135);
            label3.Name = "label3";
            label3.Size = new Size(186, 30);
            label3.TabIndex = 0;
            label3.Text = "Tên nhà cung cấp:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(81, 70);
            label2.Name = "label2";
            label2.Size = new Size(183, 30);
            label2.TabIndex = 0;
            label2.Text = "Mã nhà cung cấp:";
            label2.Click += label2_Click;
            // 
            // txtKeyWord
            // 
            txtKeyWord.Location = new Point(316, 37);
            txtKeyWord.Multiline = true;
            txtKeyWord.Name = "txtKeyWord";
            txtKeyWord.Size = new Size(544, 42);
            txtKeyWord.TabIndex = 5;
            txtKeyWord.KeyDown += txtKeyWord_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(84, 42);
            label1.Name = "label1";
            label1.Size = new Size(228, 28);
            label1.TabIndex = 6;
            label1.Text = "Tìm Kiếm Nhà Cung Cấp:";
            // 
            // FormNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1615, 916);
            Controls.Add(label1);
            Controls.Add(txtKeyWord);
            Controls.Add(groupBox1);
            Controls.Add(dgvNCC);
            Name = "FormNhaCungCap";
            Text = "FormNhaCungCap";
            Load += FormNhaCungCap_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNCC).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvNCC;
        private GroupBox groupBox1;
        private Button btnLuuThongTin;
        private Button btnDatLai;
        private Button btnXoaHangHoa;
        private Button btnSuaThongTin;
        private Button btnThemNhaCungCap;
        private TextBox txtEmail;
        private TextBox txtMaNhaCungCap;
        private TextBox txtTenNhaCungCap;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox txtSDT;
        private TextBox txtDiachi;
        private TextBox txtKeyWord;
        private Label label1;
    }
}