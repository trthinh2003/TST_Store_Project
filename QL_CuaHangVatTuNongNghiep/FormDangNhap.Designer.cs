namespace QL_CuaHangVatTuNongNghiep
{
    partial class FormDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            pictureBox1 = new PictureBox();
            splitter1 = new Splitter();
            label1 = new Label();
            txtMatKhau = new TextBox();
            label2 = new Label();
            txtTenDangNhap = new TextBox();
            btnDangNhap = new Button();
            btnThoat = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(136, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(235, 222);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 574);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label1.Location = new Point(26, 285);
            label1.Name = "label1";
            label1.Size = new Size(172, 26);
            label1.TabIndex = 3;
            label1.Text = "Tên đăng nhập:";
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(75, 419);
            txtMatKhau.Multiline = true;
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(423, 41);
            txtMatKhau.TabIndex = 2;
            txtMatKhau.TextChanged += txtMatKhau_TextChanged;
            txtMatKhau.KeyDown += txtMatKhau_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
            label2.Location = new Point(26, 381);
            label2.Name = "label2";
            label2.Size = new Size(120, 26);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu:";
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.Location = new Point(75, 320);
            txtTenDangNhap.Multiline = true;
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(423, 41);
            txtTenDangNhap.TabIndex = 1;
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = SystemColors.ButtonFace;
            btnDangNhap.Cursor = Cursors.Hand;
            btnDangNhap.Image = (Image)resources.GetObject("btnDangNhap.Image");
            btnDangNhap.ImageAlign = ContentAlignment.MiddleLeft;
            btnDangNhap.Location = new Point(61, 490);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(196, 63);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.TextAlign = ContentAlignment.MiddleRight;
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.ButtonFace;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.Image = (Image)resources.GetObject("btnThoat.Image");
            btnThoat.ImageAlign = ContentAlignment.MiddleLeft;
            btnThoat.Location = new Point(278, 490);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(154, 63);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.TextAlign = ContentAlignment.MiddleRight;
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = (Image)resources.GetObject("pictureBox2.InitialImage");
            pictureBox2.Location = new Point(26, 314);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = null;
            pictureBox3.Location = new Point(26, 419);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(521, 574);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnThoat);
            Controls.Add(btnDangNhap);
            Controls.Add(txtTenDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(splitter1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5);
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += FormDangNhap_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Splitter splitter1;
        private Label label1;
        private TextBox txtMatKhau;
        private Label label2;
        private TextBox txtTenDangNhap;
        private Button btnDangNhap;
        private Button btnThoat;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
