namespace QL_CuaHangVatTuNongNghiep
{
    partial class FormXacNhanXoaNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormXacNhanXoaNhanVien));
            btnKhong = new Button();
            btnCo = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnKhong
            // 
            btnKhong.Cursor = Cursors.Hand;
            btnKhong.Font = new Font("Segoe UI", 13F);
            btnKhong.ImeMode = ImeMode.NoControl;
            btnKhong.Location = new Point(357, 97);
            btnKhong.Name = "btnKhong";
            btnKhong.Size = new Size(92, 42);
            btnKhong.TabIndex = 9;
            btnKhong.Text = "Không";
            btnKhong.UseVisualStyleBackColor = true;
            btnKhong.Click += btnKhong_Click;
            // 
            // btnCo
            // 
            btnCo.Cursor = Cursors.Hand;
            btnCo.Font = new Font("Segoe UI", 13F);
            btnCo.ImeMode = ImeMode.NoControl;
            btnCo.Location = new Point(275, 97);
            btnCo.Name = "btnCo";
            btnCo.Size = new Size(76, 42);
            btnCo.TabIndex = 10;
            btnCo.Text = "Có";
            btnCo.UseVisualStyleBackColor = true;
            btnCo.Click += btnCo_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 13F);
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(83, 15);
            label1.Name = "label1";
            label1.Size = new Size(386, 68);
            label1.TabIndex = 8;
            label1.Text = "Bạn có chắc chắn muốn xóa nhân viên này không?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.ImeMode = ImeMode.NoControl;
            pictureBox1.Location = new Point(7, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FormXacNhanXoaNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(476, 155);
            Controls.Add(btnKhong);
            Controls.Add(btnCo);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormXacNhanXoaNhanVien";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thông báo";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnKhong;
        private Button btnCo;
        private Label label1;
        private PictureBox pictureBox1;
    }
}