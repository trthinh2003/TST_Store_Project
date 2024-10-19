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
            btnQLNhapHang.ForeColor = Color.White;
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
            moFormCon(new FormNhanVien(tempDN));
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

        private void btnQLNhapHang_Click(object sender, EventArgs e)
        {
            moFormCon(new FormNhapHang(tempDN));
            resetMauCacButton();
            btnQLNhapHang.ForeColor = Color.OliveDrab;
            lblFormName.Text = "Thông tin nhập hàng";
        }
    }
}
