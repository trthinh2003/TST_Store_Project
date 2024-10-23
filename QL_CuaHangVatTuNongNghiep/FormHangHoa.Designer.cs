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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHangHoa));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ptbAnhHangHoa = new System.Windows.Forms.PictureBox();
            this.btnLoadAnh = new System.Windows.Forms.Button();
            this.cboTenLoaiHangHoa = new System.Windows.Forms.ComboBox();
            this.cboDVT = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenHangHoa = new System.Windows.Forms.TextBox();
            this.txtMaHangHoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDatLai = new System.Windows.Forms.Button();
            this.btnXoaHangHoa = new System.Windows.Forms.Button();
            this.btnSuaThongTin = new System.Windows.Forms.Button();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiaNiemYet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboNhaCungCap = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.cboNhaCungCap);
            this.groupBox2.Controls.Add(this.cboTenLoaiHangHoa);
            this.groupBox2.Controls.Add(this.cboDVT);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtGiaNiemYet);
            this.groupBox2.Controls.Add(this.txtTenHangHoa);
            this.groupBox2.Controls.Add(this.txtMaHangHoa);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnDatLai);
            this.groupBox2.Controls.Add(this.btnXoaHangHoa);
            this.groupBox2.Controls.Add(this.btnSuaThongTin);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(37, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1217, 286);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hàng hóa";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ptbAnhHangHoa);
            this.groupBox4.Controls.Add(this.btnLoadAnh);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(968, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(202, 286);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Ảnh hàng hóa";
            // 
            // ptbAnhHangHoa
            // 
            this.ptbAnhHangHoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ptbAnhHangHoa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbAnhHangHoa.Location = new System.Drawing.Point(17, 29);
            this.ptbAnhHangHoa.Name = "ptbAnhHangHoa";
            this.ptbAnhHangHoa.Size = new System.Drawing.Size(166, 195);
            this.ptbAnhHangHoa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbAnhHangHoa.TabIndex = 0;
            this.ptbAnhHangHoa.TabStop = false;
            // 
            // btnLoadAnh
            // 
            this.btnLoadAnh.BackColor = System.Drawing.Color.Teal;
            this.btnLoadAnh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadAnh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLoadAnh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLoadAnh.Location = new System.Drawing.Point(17, 230);
            this.btnLoadAnh.Name = "btnLoadAnh";
            this.btnLoadAnh.Size = new System.Drawing.Size(166, 36);
            this.btnLoadAnh.TabIndex = 11;
            this.btnLoadAnh.Text = "Thêm ảnh";
            this.btnLoadAnh.UseVisualStyleBackColor = false;
            this.btnLoadAnh.Click += new System.EventHandler(this.btnLoadAnh_Click);
            // 
            // cboTenLoaiHangHoa
            // 
            this.cboTenLoaiHangHoa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboTenLoaiHangHoa.FormattingEnabled = true;
            this.cboTenLoaiHangHoa.Location = new System.Drawing.Point(624, 104);
            this.cboTenLoaiHangHoa.Name = "cboTenLoaiHangHoa";
            this.cboTenLoaiHangHoa.Size = new System.Drawing.Size(214, 36);
            this.cboTenLoaiHangHoa.TabIndex = 21;
            // 
            // cboDVT
            // 
            this.cboDVT.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboDVT.FormattingEnabled = true;
            this.cboDVT.Items.AddRange(new object[] {
            "Chai",
            "Gói",
            "Kg"});
            this.cboDVT.Location = new System.Drawing.Point(240, 159);
            this.cboDVT.Name = "cboDVT";
            this.cboDVT.Size = new System.Drawing.Size(121, 36);
            this.cboDVT.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(118, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 28);
            this.label3.TabIndex = 16;
            this.label3.Text = "Mã hàng hóa:";
            // 
            // txtTenHangHoa
            // 
            this.txtTenHangHoa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTenHangHoa.Location = new System.Drawing.Point(240, 104);
            this.txtTenHangHoa.Name = "txtTenHangHoa";
            this.txtTenHangHoa.Size = new System.Drawing.Size(240, 34);
            this.txtTenHangHoa.TabIndex = 20;
            // 
            // txtMaHangHoa
            // 
            this.txtMaHangHoa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMaHangHoa.Location = new System.Drawing.Point(240, 49);
            this.txtMaHangHoa.Name = "txtMaHangHoa";
            this.txtMaHangHoa.Size = new System.Drawing.Size(73, 34);
            this.txtMaHangHoa.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(118, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "Đơn vị tính:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(118, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 28);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tên hàng hóa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(503, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "Loại hàng hóa:";
            // 
            // btnDatLai
            // 
            this.btnDatLai.BackColor = System.Drawing.Color.Teal;
            this.btnDatLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatLai.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnDatLai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDatLai.Image = ((System.Drawing.Image)(resources.GetObject("btnDatLai.Image")));
            this.btnDatLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatLai.Location = new System.Drawing.Point(640, 216);
            this.btnDatLai.Name = "btnDatLai";
            this.btnDatLai.Size = new System.Drawing.Size(112, 50);
            this.btnDatLai.TabIndex = 15;
            this.btnDatLai.Text = "Đặt lại";
            this.btnDatLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDatLai.UseVisualStyleBackColor = false;
            this.btnDatLai.Click += new System.EventHandler(this.btnDatLai_Click);
            // 
            // btnXoaHangHoa
            // 
            this.btnXoaHangHoa.BackColor = System.Drawing.Color.Teal;
            this.btnXoaHangHoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaHangHoa.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnXoaHangHoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoaHangHoa.Location = new System.Drawing.Point(433, 216);
            this.btnXoaHangHoa.Name = "btnXoaHangHoa";
            this.btnXoaHangHoa.Size = new System.Drawing.Size(178, 50);
            this.btnXoaHangHoa.TabIndex = 14;
            this.btnXoaHangHoa.Text = "Xóa hàng hóa";
            this.btnXoaHangHoa.UseVisualStyleBackColor = false;
            this.btnXoaHangHoa.Click += new System.EventHandler(this.btnXoaHangHoa_Click);
            // 
            // btnSuaThongTin
            // 
            this.btnSuaThongTin.BackColor = System.Drawing.Color.Teal;
            this.btnSuaThongTin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaThongTin.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnSuaThongTin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSuaThongTin.Location = new System.Drawing.Point(240, 216);
            this.btnSuaThongTin.Name = "btnSuaThongTin";
            this.btnSuaThongTin.Size = new System.Drawing.Size(166, 50);
            this.btnSuaThongTin.TabIndex = 13;
            this.btnSuaThongTin.Text = "Sửa hàng hóa";
            this.btnSuaThongTin.UseVisualStyleBackColor = false;
            this.btnSuaThongTin.Click += new System.EventHandler(this.btnSuaThongTin_Click);
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.AllowUserToAddRows = false;
            this.dgvHangHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHangHoa.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHangHoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.EnableHeadersVisualStyles = false;
            this.dgvHangHoa.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvHangHoa.Location = new System.Drawing.Point(37, 45);
            this.dgvHangHoa.Name = "dgvHangHoa";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHangHoa.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvHangHoa.RowHeadersVisible = false;
            this.dgvHangHoa.RowHeadersWidth = 51;
            this.dgvHangHoa.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dgvHangHoa.RowTemplate.Height = 24;
            this.dgvHangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHangHoa.Size = new System.Drawing.Size(1217, 222);
            this.dgvHangHoa.TabIndex = 7;
            this.dgvHangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellClick);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(113, 9);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(374, 27);
            this.txtTimKiem.TabIndex = 9;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tìm kiếm:";
            // 
            // txtGiaNiemYet
            // 
            this.txtGiaNiemYet.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtGiaNiemYet.Location = new System.Drawing.Point(625, 52);
            this.txtGiaNiemYet.Name = "txtGiaNiemYet";
            this.txtGiaNiemYet.Size = new System.Drawing.Size(151, 34);
            this.txtGiaNiemYet.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(503, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "Giá niêm yết:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(503, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 28);
            this.label6.TabIndex = 18;
            this.label6.Text = "Nhà cung cấp:";
            // 
            // cboNhaCungCap
            // 
            this.cboNhaCungCap.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboNhaCungCap.FormattingEnabled = true;
            this.cboNhaCungCap.Location = new System.Drawing.Point(624, 162);
            this.cboNhaCungCap.Name = "cboNhaCungCap";
            this.cboNhaCungCap.Size = new System.Drawing.Size(214, 36);
            this.cboNhaCungCap.TabIndex = 21;
            // 
            // FormHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1288, 631);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvHangHoa);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormHangHoa";
            this.Text = "FormHangHoa";
            this.Load += new System.EventHandler(this.FormHangHoa_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnhHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox ptbAnhHangHoa;
        private System.Windows.Forms.Button btnLoadAnh;
        private System.Windows.Forms.ComboBox cboTenLoaiHangHoa;
        private System.Windows.Forms.ComboBox cboDVT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenHangHoa;
        private System.Windows.Forms.TextBox txtMaHangHoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDatLai;
        private System.Windows.Forms.Button btnXoaHangHoa;
        private System.Windows.Forms.Button btnSuaThongTin;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.ComboBox cboNhaCungCap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGiaNiemYet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
    }
}