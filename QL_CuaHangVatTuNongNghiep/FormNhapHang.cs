using ketnoi;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace QL_CuaHangVatTuNongNghiep
{
    public partial class FormNhapHang : Form
    {

        Ham func = new Ham();
        SqlConnection conn = null;
        int tempDN;
        public FormNhapHang(int userID)
        {
            InitializeComponent();
            tempDN = userID;
        }

        private void FormNhapHang_Load(object sender, EventArgs e)
        {
            func.KetNoi(ref conn);
            func.HienThiDg(conn, "SELECT p.STTPhieuNhap, p.NgayLapPhieu, nv.MaNV, h.MaHang, lh.MaLoai, h.TenHang, h.DVT, ct.SoLuongNhap, ct.DonGiaNhap, ncc.MaNhaCungCap " +
                                 "FROM NhanVien nv, PhieuNhapHang p, ChiTietPhieuNhap ct, HangHoa h, LoaiHang lh, NhaCungCap ncc " +
                                 "WHERE p.STTPhieuNhap = ct.STTPhieuNhap " +
                                 "AND h.MaHang = ct.MaHang " +
                                 "AND h.MaLoai = lh.MaLoai " +
                                 "AND p.MaNhaCungCap = ncc.MaNhaCungCap " +
                                 "AND nv.MaNV = p.MaNV", dgPhieuNhapHang);
            DoiTenCotDGNhaCungCap(dgPhieuNhapHang);
        }
        private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DoiTenCotDGNhaCungCap(DataGridView dg)
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
    }
}
