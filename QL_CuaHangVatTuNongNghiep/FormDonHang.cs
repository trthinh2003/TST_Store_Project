using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace QL_CuaHangVatTuNongNghiep
{
    public partial class FormDonHang : Form
    {
        public FormDonHang()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        KhachHang kh = new KhachHang();
        HangHoa h;

        private void FormDonHang_Load(object sender, EventArgs e)
        {
            modify.HienThiCombobox("SELECT MaLoai, TenLoai FROM LoaiHang", cboTenLoaiHangHoa);
            modify.HienThiCombobox("SELECT MaHang, TenHang FROM HangHoa", cboHangHoa);
        }

        private void btnThemPhieuNhap_Click(object sender, EventArgs e)
        {

        }

        private void txtSDTKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string query = "SELECT MaKH, TenKH, SDTKH, EmailKH, DiaChiKH FROM KhachHang WHERE SDTKH = " + txtSDTKH.Text;
                modify.CommandLayTTKHTuSDT(query, kh);
                txtMaKH.Text = kh.MaKH + "";
                txtTenKH.Text = kh.TenKH;
                txtSDTKH.Text = kh.Sdt;
                txtEmailKH.Text = kh.Email;
                txtDiachiKH.Text = kh.DiaChi;
            }
        }

        private void cboTenLoaiHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTenLoaiHangHoa.SelectedIndex == -1) return;
            string thongtinloaiHang = cboTenLoaiHangHoa.SelectedItem as string;
            string[] loaiHang = thongtinloaiHang.Split(" - ");
            int maLoai = int.Parse(loaiHang[0]);
            cboHangHoa.Items.Clear();
            modify.HienThiCombobox("SELECT h.MaHang, h.TenHang FROM HangHoa h, LoaiHang l WHERE h.MaLoai = l.MaLoai AND l.maloai = " + maLoai, cboHangHoa);
        }

        private void cboHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHangHoa.SelectedIndex == -1) return;
            string thongtinHangHoa = cboHangHoa.SelectedItem as string;
            string[] hangHoa = thongtinHangHoa.Split(" - ");
            int maHang = int.Parse(hangHoa[0]);
            string tenHang = hangHoa[1];
            h = new HangHoa(maHang, tenHang);
            modify.CommandLayTTHangHoaTuMaHang("SELECT DVT, GiaNiemYet, HinhAnh FROM HangHoa WHERE MaHang = " + maHang, h);
            lblDVT.Text = h.Dvt;
            lblGiaNiemYet.Text = h.GiaNiemYet.ToString();
            MemoryStream memoryStream = new MemoryStream(h.HinhAnh);
            ptbAnhHangHoa.Image = Image.FromStream(memoryStream);

        }
    }
}
