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
            try
            {
                layTTNV();
                lblWelcome.Text = "Xin chào, " + tenNhanVien;
                lblChucVu.Text = "Chức vụ: " + chucVu;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            lblCountNhanVien.Text = modify.DemSoLuong("SELECT COUNT(*) FROM NhanVien").ToString();
            lblCountOrder.Text = modify.DemSoLuong("SELECT COUNT(*) FROM HoaDon").ToString();
            lblCountKhachHang.Text = modify.DemSoLuong("SELECT COUNT(*) FROM KhachHang").ToString();
        }

        private void layTTNV()
        {
            string query = "SELECT TenNV, ChucVu FROM NhanVien WHERE MaNV = " + tempDN;
            modify.CommandLayTenNV(ref tenNhanVien, ref chucVu, query);
        }

        private void ptbLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangNhap frmDangNhap = new FormDangNhap();
            frmDangNhap.Show();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangNhap frmDangNhap = new FormDangNhap();
            frmDangNhap.Show();
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
            btnQLNhapHang.ForeColor = Color.White;
            btnQLDonHang.ForeColor = Color.White;
        }

        private void ptbLogoStore_Click(object sender, EventArgs e)
        {
            if (formHienTai != null) formHienTai.Close();
            resetMauCacButton();
            btnTrangChu.ForeColor = Color.OliveDrab;
            lblFormName.Text = "QUẢN LÝ CỬA HÀNG VẬT TƯ NÔNG NGHIỆP";
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            if (formHienTai != null) formHienTai.Close();
            resetMauCacButton();
            btnTrangChu.ForeColor = Color.OliveDrab;
            lblFormName.Text = "QUẢN LÝ CỬA HÀNG VẬT TƯ NÔNG NGHIỆP";
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            moFormCon(new FormHangHoa());
            resetMauCacButton();
            btnHangHoa.ForeColor = Color.OliveDrab;
            lblFormName.Text = "THÔNG TIN HÀNG HÓA";
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            moFormCon(new FormNhaCungCap());
            resetMauCacButton();
            btnNhaCungCap.ForeColor = Color.OliveDrab;
            lblFormName.Text = "THÔNG TIN NHÀ CUNG CẤP";
        }

        private void btnTaoDonHang_Click(object sender, EventArgs e)
        {
            moFormCon(new FormDonHang(tempDN));
            resetMauCacButton();
            btnTaoDonHang.ForeColor = Color.OliveDrab;
            lblFormName.Text = "TẠO ĐƠN HÀNG";
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            moFormCon(new FormNhanVien(tempDN));
            resetMauCacButton();
            btnNhanVien.ForeColor = Color.OliveDrab;
            lblFormName.Text = "THÔNG TIN NHÂN VIÊN";
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            moFormCon(new FormKhachHang());
            resetMauCacButton();
            btnKhachHang.ForeColor = Color.OliveDrab;
            lblFormName.Text = "THÔNG TIN KHÁCH HÀNG";
        }

        private void btnQLNhapHang_Click(object sender, EventArgs e)
        {
            moFormCon(new FormNhapHang(tempDN));
            resetMauCacButton();
            btnQLNhapHang.ForeColor = Color.OliveDrab;
            lblFormName.Text = "QUẢN LÝ NHẬP HÀNG";
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            moFormCon(new FormQLDonHang());
            resetMauCacButton();
            btnQLDonHang.ForeColor = Color.OliveDrab;
            lblFormName.Text = "QUẢN LÝ ĐƠN HÀNG";
        }
    }
}
