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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QL_CuaHangVatTuNongNghiep
{
    public partial class FormDonHang : Form
    {
        int tempDN;
        public FormDonHang(int userID)
        {
            InitializeComponent();
            tempDN = userID;

        }
        Modify modify = new Modify();
        KhachHang kh = new KhachHang();
        HangHoa h;

        private void FormDonHang_Load(object sender, EventArgs e)
        {
            modify.HienThiCombobox("SELECT MaLoai, TenLoai FROM LoaiHang", cboTenLoaiHangHoa);
            modify.HienThiCombobox("SELECT MaHang, TenHang FROM HangHoa", cboHangHoa);
            lbltxtSoLuongCon.Text = "";
            lblSoLuongHangHoaCon.Text = "";
            lblCanhBaoSoLuong.Text = "";
            ThietLapPlaceHoderChoTBTimKiem();
            txtMaNV.Text = tempDN + "";
            txtMaNV.Enabled = false;
            HienThiDGDonHang();
            DieuChinhCacCotDG(dgvDonHang);
            tinhTongTienDonHang();
        }

        private void HienThiDGDonHang()
        {
            dgvDonHang.DataSource = modify.DataTable("SELECT hd.MaHoaDon, nv.MaNV, hd.NgayLap, h.MaHang, kh.MaKH, ct.SoLuong, ct.DonGia " +
                                                     "FROM HoaDon hd, KhachHang kh, NhanVien nv, CT_HD ct, HangHoa h " +
                                                     "WHERE nv.MaNV = hd.MaNV " +
                                                     "AND kh.MaKH = hd.MaKH " +
                                                     "AND ct.MaHoaDon = hd.MaHoaDon " +
                                                     "AND ct.MaHang = h.MaHang;");
        }

        private void DieuChinhCacCotDG(DataGridView dgvDonHang)
        {
            dgvDonHang.Columns["MaHoaDon"].HeaderText = "Mã đơn";
            dgvDonHang.Columns["MaNV"].HeaderText = "Nhân viên lập";
            dgvDonHang.Columns["NgayLap"].HeaderText = "Ngày lập";
            dgvDonHang.Columns["MaHang"].HeaderText = "Mã hàng hóa";
            dgvDonHang.Columns["MaKH"].HeaderText = "Mã khách hàng";
            dgvDonHang.Columns["SoLuong"].HeaderText = "Số lượng";
            dgvDonHang.Columns["DonGia"].HeaderText = "Đơn giá";

        }

        private void ThietLapPlaceHoderChoTBTimKiem()
        {
            txtTimKiemDonHang.Text = "Tìm kiếm đon hàng theo Mã đơn hoặc Mã NV lập...";
            txtTimKiemDonHang.ForeColor = Color.Gray;
        }

        private void txtTimKiemDonHang_Enter(object sender, EventArgs e)
        {
            if (txtTimKiemDonHang.Text == "Tìm kiếm đon hàng theo Mã đơn hoặc Mã NV lập...")
            {
                txtTimKiemDonHang.Text = "";
                txtTimKiemDonHang.ForeColor = Color.Black;
            }
        }

        private void txtTimKiemDonHang_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiemDonHang.Text))
            {
                txtTimKiemDonHang.Text = "Tìm kiếm đon hàng theo Mã đơn hoặc Mã NV lập...";
                txtTimKiemDonHang.ForeColor = Color.Gray;
            }
        }

        private bool ktraInputKhachHang()
        {
            if (String.IsNullOrEmpty(txtMaKH.Text) || String.IsNullOrEmpty(txtTenKH.Text) ||
                String.IsNullOrEmpty(txtSDTKH.Text) || String.IsNullOrEmpty(txtEmailKH.Text) ||
                String.IsNullOrEmpty(txtDiachiKH.Text)) return false;
            else return true;
        }

        private bool ktraInputHangHoa()
        {
            if (String.IsNullOrEmpty(cboTenLoaiHangHoa.Text) || String.IsNullOrEmpty(cboHangHoa.Text) ||
                String.IsNullOrEmpty(txtSoLuongNhap.Text) || ptbAnhHangHoa.Image == null) return false;
            else return true;
        }

        private bool ktraInputDonHang()
        {
            if (String.IsNullOrEmpty(txtMaDonHang.Text) || String.IsNullOrEmpty(txtMaHangHoa.Text) ||
                String.IsNullOrEmpty(txtDonGia.Text)) return false;
            else return true;
        }


        private void txtSDTKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string query = "SELECT MaKH, TenKH, SDTKH, EmailKH, DiaChiKH FROM KhachHang WHERE SDTKH = " + txtSDTKH.Text;
                modify.CommandLayTTKH(query, kh);
                txtMaKH.Text = kh.MaKH + "";
                txtTenKH.Text = kh.TenKH;
                txtSDTKH.Text = kh.Sdt;
                txtEmailKH.Text = kh.Email;
                txtDiachiKH.Text = kh.DiaChi;
            }
        }

        private void txtMaKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string query = "SELECT MaKH, TenKH, SDTKH, EmailKH, DiaChiKH FROM KhachHang WHERE MaKH = " + txtMaKH.Text;
                modify.CommandLayTTKH(query, kh);
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
            cboHangHoa.Text = "";
            ptbAnhHangHoa.Image = null;
            modify.HienThiCombobox("SELECT h.MaHang, h.TenHang FROM HangHoa h, LoaiHang l " +
                "WHERE h.MaLoai = l.MaLoai AND l.maloai = " + maLoai, cboHangHoa);
        }

        private void cboHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHangHoa.SelectedIndex == -1) return;
            string thongtinHangHoa = cboHangHoa.SelectedItem as string;
            string[] hangHoa = thongtinHangHoa.Split(" - ");
            int maHang = int.Parse(hangHoa[0]);
            string tenHang = hangHoa[1];
            txtMaHangHoa.Text = maHang.ToString();
            h = new HangHoa(maHang, tenHang);
            int maLoai = 0;
            string tenLoai = "";
            int soLuongNhap = 0;
            int soLuongBan = 0;
            modify.CommandLayTTHangHoaTuMaHang("SELECT DVT, GiaNiemYet, HinhAnh FROM HangHoa WHERE MaHang = " + maHang, h);
            modify.LayLoaiHangTuMaHang("SELECT l.MaLoai, l.TenLoai FROM LoaiHang l, HangHoa h " +
                                       "WHERE l.MaLoai = h.MaLoai AND h.MaHang = " + maHang, ref maLoai, ref tenLoai);
            modify.LaySoLuong("SELECT SUM(SoLuongNhap) FROM ChiTietPhieuNhap WHERE MaHang = " + maHang, ref soLuongNhap);
            modify.LaySoLuong("SELECT SUM(SoLuong) FROM CT_HD WHERE MaHang = " + maHang, ref soLuongBan);
            cboTenLoaiHangHoa.Text = maLoai + " - " + tenLoai;
            cboHangHoa.Text = maHang + " - " + tenHang;
            lbltxtSoLuongCon.Text = "Số lượng còn: ";
            int soLuongCon = soLuongNhap - soLuongBan;
            lblSoLuongHangHoaCon.Text = soLuongCon.ToString();
            lblDVT.Text = h.Dvt;
            lblGiaNiemYet.Text = h.GiaNiemYet + " VND";
            txtDonGia.Text = lblGiaNiemYet.Text.Split(" ")[0];
            MemoryStream memoryStream = new MemoryStream(h.HinhAnh);
            ptbAnhHangHoa.Image = Image.FromStream(memoryStream);
        }

        private void txtSoLuongNhap_TextChanged(object sender, EventArgs e)
        {
            int soLuongCon;
            int soLuongNhap;
            int.TryParse(lblSoLuongHangHoaCon.Text, out soLuongCon);
            int.TryParse(txtSoLuongNhap.Text, out soLuongNhap);
            if (soLuongNhap > soLuongCon && !String.IsNullOrEmpty(cboHangHoa.Text))
                lblCanhBaoSoLuong.Text = "Số lượng hàng hóa bạn vừa nhập đã vượt quá số lượng hàng hóa còn lại có trong kho.";
            else lblCanhBaoSoLuong.Text = "";
        }

        private void btnDatLaiKH_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtSDTKH.Text = "";
            txtEmailKH.Text = "";
            txtDiachiKH.Text = ""; ;
        }

        private void btnDatLaiHangHoa_Click(object sender, EventArgs e)
        {
            cboTenLoaiHangHoa.Text = "";
            cboHangHoa.Text = "";
            lblDVT.Text = "...";
            lblGiaNiemYet.Text = "0 VND";
            txtSoLuongNhap.Text = "";
            ptbAnhHangHoa.Image = null;
            cboTenLoaiHangHoa.Items.Clear();
            cboHangHoa.Items.Clear();
            modify.HienThiCombobox("SELECT MaLoai, TenLoai FROM LoaiHang", cboTenLoaiHangHoa);
            modify.HienThiCombobox("SELECT MaHang, TenHang FROM HangHoa", cboHangHoa);
            lbltxtSoLuongCon.Text = "";
            lblSoLuongHangHoaCon.Text = "";
            lblCanhBaoSoLuong.Text = "";
        }

        private void txtSoLuongNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThemDonHang_Click(object sender, EventArgs e)
        {
            btnDatLaiKH_Click(sender, e);
            btnDatLaiHangHoa_Click(sender, e);
            btnDatLaiDonHang_Click(sender, e);
            modify.LayMaMaxNapVaoTextBox("SELECT DISTINCT IDENT_CURRENT('HoaDon') + 1;", txtMaDonHang);
        }

        private void btnLuuDonHang_Click(object sender, EventArgs e)
        {
            if (ktraInputKhachHang() == false || ktraInputHangHoa() == false || ktraInputDonHang() == false)
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đơn hàng!");
            else
            {
                if (lblCanhBaoSoLuong.Text != "") MessageBox.Show("Kiểm tra lại số lượng nhập...");
                else
                {
                    string query1 = "INSERT INTO HoaDon(NgayLap, MaNV, MaKH) " +
                        "VALUES (@ngaylap, @manv, @makh)";
                    string query2 = "INSERT INTO CT_HD(MaHoaDon, MaHang, SoLuong, DonGia) " +
                        "VALUES (@mahoadon, @mahang, @soluong, @dongia)";
                    try
                    {
                        modify.CommandThemDonHang(query1, int.Parse(txtMaNV.Text), int.Parse(txtMaKH.Text));
                        modify.CommandThemDonHang(query2, int.Parse(txtMaDonHang.Text), int.Parse(txtMaHangHoa.Text),
                            int.Parse(txtSoLuongNhap.Text), int.Parse(txtDonGia.Text));
                        MessageBox.Show("Thêm đơn hàng mới thành công!");
                        HienThiDGDonHang();
                        tinhTongTienDonHang();
                        btnDatLaiKH_Click(sender, e);
                        btnDatLaiHangHoa_Click(sender, e);
                        btnDatLaiDonHang_Click(sender, e);

                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); return; }
                }
            }
        }

        private void btnInThongTin_Click(object sender, EventArgs e)
        {

        }

        private void btnDatLaiDonHang_Click(object sender, EventArgs e)
        {
            txtMaDonHang.Text = "";
            txtMaHangHoa.Text = "";
            txtDonGia.Text = "";
            txtMaDonHang.Enabled = true;
        }

        private void tinhTongTienDonHang()
        {
            lblTongTienDonHang.Text = modify.LayTongTienDonHang("SELECT SUM(ct.SoLuong * ct.DonGia) " +
                                                                "FROM HoaDon hd, KhachHang kh, NhanVien nv, CT_HD ct, HangHoa h " +
                                                                "WHERE nv.MaNV = hd.MaNV " +
                                                                "AND kh.MaKH = hd.MaKH " +
                                                                "AND ct.MaHoaDon = hd.MaHoaDon " +
                                                                "AND ct.MaHang = h.MaHang;").ToString("# ##0");
        }

        private void txtTimKiemDonHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiemDonHang_Click(sender, e);
            }
        }

        private void btnTimKiemDonHang_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTimKiemDonHang.Text))
            {
                HienThiDGDonHang();
            }
            else
            {
                string tukhoa = txtTimKiemDonHang.Text;
                string sql_timkiem = "SELECT hd.MaHoaDon, nv.MaNV, hd.NgayLap, h.MaHang, kh.MaKH, ct.SoLuong, ct.DonGia " +
                                     "FROM HoaDon hd " +
                                     "JOIN NhanVien nv ON nv.MaNV = hd.MaNV " +
                                     "JOIN KhachHang kh ON kh.MaKH = hd.MaKH " +
                                     "JOIN CT_HD ct ON ct.MaHoaDon = hd.MaHoaDon " +
                                     "JOIN HangHoa h ON ct.MaHang = h.MaHang " +
                                     "WHERE hd.MaHoaDon = " + tukhoa + " OR nv.MaNV = " + tukhoa;
                dgvDonHang.DataSource = modify.DataTable(sql_timkiem);
                DieuChinhCacCotDG(dgvDonHang);
                txtTimKiemDonHang.Text = "";
            }
        }
    }
}
