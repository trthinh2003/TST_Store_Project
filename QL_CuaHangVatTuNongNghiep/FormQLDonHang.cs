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
    public partial class FormQLDonHang : Form
    {
        public FormQLDonHang()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void FormQLDonHang_Load(object sender, EventArgs e)
        {
            ThietLapPlaceHoderChoTBTimKiem();
            HienThiDGDonHang();
            tinhTongTienDonHang();
        }

        private void HienThiDGDonHang()
        {
            dgvDonHang.DataSource = modify.DataTable("SELECT hd.MaHoaDon, nv.MaNV, nv.TenNV, hd.NgayLap, h.MaHang, h.TenHang, kh.MaKH, ct.SoLuong, ct.DonGia " +
                                                     "FROM HoaDon hd, KhachHang kh, NhanVien nv, CT_HD ct, HangHoa h " +
                                                     "WHERE nv.MaNV = hd.MaNV " +
                                                     "AND kh.MaKH = hd.MaKH " +
                                                     "AND ct.MaHoaDon = hd.MaHoaDon " +
                                                     "AND ct.MaHang = h.MaHang");
            dgvDonHang.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            DieuChinhCacCotDG(dgvDonHang);
        }

        private void DieuChinhCacCotDG(DataGridView dgvDonHang)
        {
            dgvDonHang.Columns["MaHoaDon"].HeaderText = "Mã đơn";
            dgvDonHang.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dgvDonHang.Columns["TenNV"].HeaderText = "Họ tên nhân viên";
            dgvDonHang.Columns["NgayLap"].HeaderText = "Ngày lập";
            dgvDonHang.Columns["MaHang"].HeaderText = "Mã hàng hóa";
            dgvDonHang.Columns["TenHang"].Visible = false;
            dgvDonHang.Columns["MaKH"].HeaderText = "Mã khách hàng";
            dgvDonHang.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvDonHang.Columns["DonGia"].HeaderText = "Đơn giá";
        }

        private void tinhTongTienDonHang()
        {
            lblTongTienDonHang.Text = modify.LayTongTien("SELECT SUM(ct.SoLuong * ct.DonGia) " +
                                                         "FROM HoaDon hd, KhachHang kh, NhanVien nv, CT_HD ct, HangHoa h " +
                                                         "WHERE nv.MaNV = hd.MaNV " +
                                                         "AND kh.MaKH = hd.MaKH " +
                                                         "AND ct.MaHoaDon = hd.MaHoaDon " +
                                                         "AND ct.MaHang = h.MaHang").ToString("#,##0");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTimKiemDonHang.Text) || 
                txtTimKiemDonHang.Text == "Tìm kiếm Đơn hàng theo Mã đơn hoặc Mã nhân viên lập...")
            {
                HienThiDGDonHang();
            }
            else
            {
                string tukhoa = txtTimKiemDonHang.Text;
                string sql_timkiem = "SELECT hd.MaHoaDon, nv.MaNV, nv.TenNV, hd.NgayLap, h.MaHang, h.TenHang, kh.MaKH, ct.SoLuong, ct.DonGia " +
                                     "FROM HoaDon hd, KhachHang kh, NhanVien nv, CT_HD ct, HangHoa h " +
                                     "WHERE nv.MaNV = hd.MaNV " +
                                     "AND kh.MaKH = hd.MaKH " +
                                     "AND ct.MaHoaDon = hd.MaHoaDon " +
                                     "AND ct.MaHang = h.MaHang " +
                                     "AND(hd.MaHoaDon = " + tukhoa + " OR nv.MaNV = " + tukhoa + ")";
                dgvDonHang.DataSource = modify.DataTable(sql_timkiem);
                DieuChinhCacCotDG(dgvDonHang);
                txtTimKiemDonHang.Text = "";
            }
        }

        private void txtTimKiemDonHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
            }
        }

        private void ThietLapPlaceHoderChoTBTimKiem()
        {
            txtTimKiemDonHang.Text = "Tìm kiếm Đơn hàng theo Mã đơn hoặc Mã nhân viên lập...";
            txtTimKiemDonHang.ForeColor = Color.Gray;
        }

        private void txtTimKiemDonHang_Enter(object sender, EventArgs e)
        {
            if (txtTimKiemDonHang.Text == "Tìm kiếm Đơn hàng theo Mã đơn hoặc Mã nhân viên lập...")
            {
                txtTimKiemDonHang.Text = "";
                txtTimKiemDonHang.ForeColor = Color.Black;
            }
        }

        private void txtTimKiemDonHang_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiemDonHang.Text))
            {
                txtTimKiemDonHang.Text = "Tìm kiếm Đơn hàng theo Mã đơn hoặc Mã nhân viên lập...";
                txtTimKiemDonHang.ForeColor = Color.Gray;
            }
        }
    }
}
