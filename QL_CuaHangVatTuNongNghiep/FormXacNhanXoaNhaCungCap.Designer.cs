namespace QL_CuaHangVatTuNongNghiep
{
    partial class FormXacNhanXoaNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormXacNhanXoaNhaCungCap));
            this.btnKhong = new System.Windows.Forms.Button();
            this.btnCo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKhong
            // 
            this.btnKhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhong.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnKhong.Location = new System.Drawing.Point(357, 97);
            this.btnKhong.Name = "btnKhong";
            this.btnKhong.Size = new System.Drawing.Size(92, 42);
            this.btnKhong.TabIndex = 7;
            this.btnKhong.Text = "Không";
            this.btnKhong.UseVisualStyleBackColor = true;
            this.btnKhong.Click += new System.EventHandler(this.btnKhong_Click);
            // 
            // btnCo
            // 
            this.btnCo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCo.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnCo.Location = new System.Drawing.Point(275, 97);
            this.btnCo.Name = "btnCo";
            this.btnCo.Size = new System.Drawing.Size(76, 42);
            this.btnCo.TabIndex = 6;
            this.btnCo.Text = "Có";
            this.btnCo.UseVisualStyleBackColor = true;
            this.btnCo.Click += new System.EventHandler(this.btnCo_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label1.Location = new System.Drawing.Point(83, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 68);
            this.label1.TabIndex = 5;
            this.label1.Text = "Bạn có chắc chắn muốn xóa nhà cung cấp này không?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // FormXacNhanXoaNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(476, 155);
            this.Controls.Add(this.btnKhong);
            this.Controls.Add(this.btnCo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormXacNhanXoaNhaCungCap";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông báo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKhong;
        private System.Windows.Forms.Button btnCo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}