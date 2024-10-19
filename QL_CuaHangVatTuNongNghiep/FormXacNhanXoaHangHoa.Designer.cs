namespace QL_CuaHangVatTuNongNghiep
{
    partial class FormXacNhanXoaHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormXacNhanXoaHangHoa));
            label1 = new Label();
            btnCo = new Button();
            btnKhong = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // btnCo
            // 
            btnCo.Cursor = Cursors.Hand;
            resources.ApplyResources(btnCo, "btnCo");
            btnCo.Name = "btnCo";
            btnCo.UseVisualStyleBackColor = true;
            btnCo.Click += btnCo_Click;
            // 
            // btnKhong
            // 
            btnKhong.Cursor = Cursors.Hand;
            resources.ApplyResources(btnKhong, "btnKhong");
            btnKhong.Name = "btnKhong";
            btnKhong.UseVisualStyleBackColor = true;
            btnKhong.Click += btnKhong_Click;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // FormXacNhanXoaHangHoa
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(btnKhong);
            Controls.Add(btnCo);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormXacNhanXoaHangHoa";
            Load += FormXacNhanXoaHangHoa_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button btnCo;
        private Button btnKhong;
        private PictureBox pictureBox1;
    }
}