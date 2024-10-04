using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CuaHangVatTuNongNghiep
{
    public partial class FormTrangChu : Form
    {
        Modify modify = new Modify();
        private Form formHienTai;
        string tenNhanVien;
        string chucVu;
        int tempDN;
        public FormTrangChu(int userID)
        {
            InitializeComponent();
            tempDN = userID;
        }
        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            layTTNV();
            lblWelcome.Text = "Xin chào, " + tenNhanVien;
            lblChucVu.Text = "Chức vụ: " + chucVu;
            if (chucVu != "Quản lý")
            {
                btnTaiKhoan.Visible = false;
                ptbBtnQLTaiKhoan.Visible = false;
            }
        }
        private void layTTNV()
        {
            string query = "SELECT TenNV, ChucVu FROM NhanVien WHERE MaNV = " + tempDN;
            modify.CommandLayTenNV(ref tenNhanVien, ref chucVu, query);
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangNhap frmDangNhap = new FormDangNhap();
            frmDangNhap.ShowDialog();
        }

        private void ptbLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangNhap frmDangNhap = new FormDangNhap();
            frmDangNhap.ShowDialog();
        }


        private void moFormCon(Form formCon)
        {
            if (formHienTai != null) formHienTai.Close();
            formHienTai = formCon;
            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;
            pnBody.Controls.Add(formCon);
            pnBody.Tag = formCon;
            formCon.BringToFront();
            formCon.Show();
        }

        private void resetMauCacButton()
        {
            btnTrangChu.ForeColor = Color.White;
            btnHangHoa.ForeColor = Color.White;
            btnNhaCungCap.ForeColor = Color.White;
            btnTaoDonHang.ForeColor = Color.White;
            btnNhanVien.ForeColor = Color.White;
            btnKhachHang.ForeColor = Color.White;
            btnTaiKhoan.ForeColor = Color.White;
        }

        private void ptbLogoStore_Click(object sender, EventArgs e)
        {
            if (formHienTai != null) formHienTai.Close();
            resetMauCacButton();
            btnTrangChu.ForeColor = Color.OliveDrab;
            lblFormName.Text = "Quản lý Cửa hàng vật tư nông nghiệp";
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            if (formHienTai != null) formHienTai.Close();
            resetMauCacButton();
            btnTrangChu.ForeColor = Color.OliveDrab;
            lblFormName.Text = "Quản lý Cửa hàng vật tư nông nghiệp";
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            moFormCon(new FormHangHoa());
            resetMauCacButton();
            btnHangHoa.ForeColor = Color.OliveDrab;
            lblFormName.Text = "Thông tin hàng hóa";
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            moFormCon(new FormNhaCungCap());
            resetMauCacButton();
            btnNhaCungCap.ForeColor = Color.OliveDrab;
            lblFormName.Text = "Thông tin nhà cung cấp";
        }

        private void btnTaoDonHang_Click(object sender, EventArgs e)
        {
            moFormCon(new FormDonHang());
            resetMauCacButton();
            btnTaoDonHang.ForeColor = Color.OliveDrab;
            lblFormName.Text = "Thông tin đơn hàng";
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            moFormCon(new FormNhanVien());
            resetMauCacButton();
            btnNhanVien.ForeColor = Color.OliveDrab;
            lblFormName.Text = "Thông tin nhân viên";
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            moFormCon(new FormKhachHang());
            resetMauCacButton();
            btnKhachHang.ForeColor = Color.OliveDrab;
            lblFormName.Text = "Thông tin khách hàng";
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            moFormCon(new FormQLTaiKhoan());
            resetMauCacButton();
            btnTaiKhoan.ForeColor = Color.OliveDrab;
            lblFormName.Text = "Thông tin tài khoản";
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
