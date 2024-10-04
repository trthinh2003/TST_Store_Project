using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System;

namespace QL_CuaHangVatTuNongNghiep
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        TaiKhoan taiKhoan;
        public int tempDN;
        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Length == 0)
                MessageBox.Show("Tên tài khoản không được để trống!");
            else if (txtMatKhau.Text.Length == 0)
                MessageBox.Show("Mật khẩu không được để trống!");
            else
            {
                string query = "SELECT * FROM TaiKhoan WHERE TenTaiKhoan = @tentaikhoan AND MatKhau = @matkhau";
                try
                {
                    bool existAccount = false;
                    layDuLieu();
                    modify.CommandXacNhanTaiKhoan(taiKhoan, query, ref existAccount);
                    if (existAccount == true)
                    {
                        MessageBox.Show("Đăng nhập thành công!");
                        this.Hide();
                        FormTrangChu frmTrangChu = new FormTrangChu(taiKhoan.MaNV);
                        frmTrangChu.ShowDialog();
                    }
                    else MessageBox.Show("Tài khoản không tồn tại!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void layDuLieu()
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            taiKhoan = new TaiKhoan(tenDangNhap, matKhau);
        }

        private void resetTenDangNhapVaMatKhau()
        {
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }
    }
}
