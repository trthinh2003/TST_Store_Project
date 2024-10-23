using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace QL_CuaHangVatTuNongNghiep
{
    public partial class FormInDonHang : Form
    {
        int tempDN;
        string tongTien;
        public FormInDonHang(int userID, string totalOrder)
        {
            InitializeComponent();
            tempDN = userID;
            tongTien = totalOrder;
        }
        Modify modify = new Modify();
        private void FormInDonHang_Load(object sender, EventArgs e)
        {
            DataSet ds = modify.DataSet("SELECT hd.MaHoaDon as MaDonHang, hd.NgayLap, h.MaHang, h.TenHang, kh.TenKH, ct.SoLuong, ct.DonGia " +
                                        "FROM HoaDon hd, KhachHang kh, NhanVien nv, CT_HD ct, HangHoa h " +
                                        "WHERE nv.MaNV = hd.MaNV " +
                                        "AND kh.MaKH = hd.MaKH " +
                                        "AND ct.MaHoaDon = hd.MaHoaDon " +
                                        "AND ct.MaHang = h.MaHang " +
                                        "AND nv.MaNV = " + tempDN, "ThongTinDonHang");
            this.reportDonHang.LocalReport.ReportEmbeddedResource = "QL_CuaHangVatTuNongNghiep.ReportDonHang.rdlc";

            string tenNV = "";
            modify.CommandLayTenNV(ref tenNV, "SELECT TenNV FROM NhanVien WHERE MaNV = " + tempDN);
            ReportParameter hoTenNV = new ReportParameter("HoTenNhanVien", tenNV);
            this.reportDonHang.LocalReport.SetParameters(hoTenNV);

            ReportParameter tinhTongTien = new ReportParameter("TongTien", tongTien + " VND");
            this.reportDonHang.LocalReport.SetParameters(tinhTongTien);

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "ThongTinDonHang";
            rds.Value = ds.Tables[0];
            this.reportDonHang.LocalReport.DataSources.Add(rds);

            this.reportDonHang.RefreshReport();
        }
    }
}
