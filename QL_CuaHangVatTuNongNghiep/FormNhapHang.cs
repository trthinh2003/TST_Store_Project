using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CuaHangVatTuNongNghiep
{
    public partial class FormNhapHang : Form
    {
        Ham func = new Ham();
        Modify modify = new Modify();
        SqlConnection conn = null;
        int tempDN;
        public FormNhapHang(int userID)
        {
            InitializeComponent();
            tempDN = userID;
        }

        private void FormNhapHang_Load(object sender, EventArgs e)
        {
            ThietLapPlaceHoderChoTBTimKiem();
            HienThiDGDonHang();
            TinhTongTienNhapHang();
        }

        private void HienThiDGDonHang()
        {
            func.KetNoi(ref conn);
            func.HienThiDg(conn, "SELECT p.STTPhieuNhap, p.NgayLapPhieu, nv.MaNV, h.MaHang, lh.MaLoai, h.TenHang, h.DVT, ct.SoLuongNhap, ct.DonGiaNhap, ncc.MaNhaCungCap " +
                                 "FROM NhanVien nv, PhieuNhapHang p, ChiTietPhieuNhap ct, HangHoa h, LoaiHang lh, NhaCungCap ncc " +
                                 "WHERE p.STTPhieuNhap = ct.STTPhieuNhap " +
                                 "AND h.MaHang = ct.MaHang " +
                                 "AND h.MaLoai = lh.MaLoai " +
                                 "AND p.MaNhaCungCap = ncc.MaNhaCungCap " +
                                 "AND nv.MaNV = p.MaNV", dgPhieuNhapHang);
            DoiTenCotDGPhieuNhap(dgPhieuNhapHang);
            conn.Close();
        }

        private void ThietLapPlaceHoderChoTBTimKiem()
        {
            txtTimKiem.Text = "Tìm kiếm Phiếu nhập hàng theo STT phiếu hoặc Mã NV lập ...";
            txtTimKiem.ForeColor = Color.Gray;
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm Phiếu nhập hàng theo STT phiếu hoặc Mã NV lập ...")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                txtTimKiem.Text = "Tìm kiếm Phiếu nhập hàng theo STT phiếu hoặc Mã NV lập ...";
                txtTimKiem.ForeColor = Color.Gray;
            }
        }

        private void TinhTongTienNhapHang()
        {
            lblTongTienNhapHang.Text = modify.LayTongTien("SELECT SUM(SoLuongNhap * DonGiaNhap) FROM ChiTietPhieuNhap").ToString("#,##0");
        }

        private void DoiTenCotDGPhieuNhap(DataGridView dg)
        {
            dgPhieuNhapHang.Columns["STTPhieuNhap"].HeaderText = "STT Phiếu";
            dgPhieuNhapHang.Columns["NgayLapPhieu"].HeaderText = "Ngày lập phiếu";
            dgPhieuNhapHang.Columns["MaNV"].HeaderText = "Nhân viên lập";
            dgPhieuNhapHang.Columns["MaHang"].HeaderText = "Mã hàng hóa";
            dgPhieuNhapHang.Columns["MaLoai"].HeaderText = "Loại hàng hóa";
            dgPhieuNhapHang.Columns["TenHang"].HeaderText = "Tên hàng hóa";
            dgPhieuNhapHang.Columns["SoLuongNhap"].HeaderText = "Số lượng nhập";
            dgPhieuNhapHang.Columns["DonGiaNhap"].HeaderText = "Đơn giá nhập";
            dgPhieuNhapHang.Columns["MaNhaCungCap"].HeaderText = "Mã nhà cung cấp";
            dgPhieuNhapHang.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            FormPhieuNhap frmPhieuNhap = new FormPhieuNhap(tempDN);
            frmPhieuNhap.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FormNhapHang_Load(sender, e);
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTimKiem.Text) ||
              txtTimKiem.Text == "Tìm kiếm Phiếu nhập hàng theo STT phiếu hoặc Mã NV lập ...")
            {
                HienThiDGDonHang();
            }
            else
            {
                string tukhoa = txtTimKiem.Text;
                string sql_timkiem = "SELECT p.STTPhieuNhap, p.NgayLapPhieu, nv.MaNV, h.MaHang, lh.MaLoai, h.TenHang, h.DVT, ct.SoLuongNhap, ct.DonGiaNhap, ncc.MaNhaCungCap " +
                                     "FROM NhanVien nv, PhieuNhapHang p, ChiTietPhieuNhap ct, HangHoa h, LoaiHang lh, NhaCungCap ncc " +
                                     "WHERE p.STTPhieuNhap = ct.STTPhieuNhap " +
                                     "AND h.MaHang = ct.MaHang " +
                                     "AND h.MaLoai = lh.MaLoai " +
                                     "AND p.MaNhaCungCap = ncc.MaNhaCungCap " +
                                     "AND nv.MaNV = p.MaNV " +
                                     "AND (p.STTPhieuNhap = " + tukhoa + " OR nv.MaNV = " + tukhoa + ")";
                dgPhieuNhapHang.DataSource = modify.DataTable(sql_timkiem);
                DoiTenCotDGPhieuNhap(dgPhieuNhapHang);
                txtTimKiem.Text = "";
            }
        }

        private void dgPhieuNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
