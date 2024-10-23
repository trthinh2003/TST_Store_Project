using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CuaHangVatTuNongNghiep
{
    public partial class FormPhieuNhap : Form
    {
        Modify modify = new Modify();
        Ham func = new Ham();
        SqlConnection conn = null;
        HangHoa hangHoa;
        NhaCungCap nhaCungCap;
        int tempDN;
        public FormPhieuNhap(int userID)
        {
            InitializeComponent();
            tempDN = userID;
        }

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            func.KetNoi(ref conn);
            HienThiDGHangHoa();
            HienThiDGPhieuNhap();
            modify.HienThiCombobox("SELECT MaLoai, TenLoai FROM LoaiHang", cboTenLoaiHangHoa);
            modify.HienThiCombobox("SELECT MaNhaCungCap, TenNhaCungCap FROM NhaCungCap", cboNhaCungCap);
            modifyDGHangHoa(dgvHangHoa);
            modifyDGPhieuNhap(dgvPhieuNhap);
            txtMaNV.Text = tempDN.ToString();
            txtMaNV.Enabled = false;
        }

        private void HienThiDGHangHoa()
        {
            dgvHangHoa.DataSource = modify.DataTable("SELECT lh.MaLoai, lh.TenLoai, h.MaHang, h.TenHang, h.DVT, h.HinhAnh " +
                                         "FROM LoaiHang lh, HangHoa h " +
                                         "WHERE lh.MaLoai = h.MaLoai");
        }

        private void HienThiDGPhieuNhap()
        {
            func.HienThiDg(conn, "SELECT DISTINCT p.STTPhieuNhap,nv.MaNV, ncc.MaNhaCungCap, h.MaHang, ct.SoLuongNhap, ct.DonGiaNhap " +
                     "FROM PhieuNhapHang p, NhanVien nv, HangHoa h, ChiTietPhieuNhap ct, NhaCungCap ncc, CungCap cc " +
                     "WHERE p.STTPhieuNhap = ct.STTPhieuNhap " +
                     "AND p.MaNV = nv.MaNV " +
                     "AND h.MaHang = ct.MaHang " +
                     "AND ncc.MaNhaCungCap = cc.MaNhaCungCap " +
                     "AND p.MaNhaCungCap = ncc.MaNhaCungCap " +
                     "AND nv.MaNV = " + tempDN, dgvPhieuNhap);
        }

        private void modifyDGHangHoa(DataGridView dgvHangHoa)
        {
            dgvHangHoa.Columns["MaLoai"].HeaderText = "Mã loại";
            dgvHangHoa.Columns["TenLoai"].HeaderText = "Tên loại";
            dgvHangHoa.Columns["MaHang"].HeaderText = "Mã hàng hóa";
            dgvHangHoa.Columns["TenHang"].HeaderText = "Tên hàng hóa";
            dgvHangHoa.Columns["DVT"].HeaderText = "DVT";
            dgvHangHoa.Columns["HinhAnh"].Visible = false;
        }
        private void modifyDGPhieuNhap(DataGridView dgvPhieuNhap)
        {
            dgvPhieuNhap.Columns["STTPhieuNhap"].HeaderText = "STT";
            dgvPhieuNhap.Columns["MaNV"].HeaderText = "Nhân viên lập";
            dgvPhieuNhap.Columns["MaNhaCungCap"].HeaderText = "Nhà cung cấp";
            dgvPhieuNhap.Columns["MaHang"].HeaderText = "Mã hàng hóa";
            dgvPhieuNhap.Columns["SoLuongNhap"].HeaderText = "Số lượng nhập";
            dgvPhieuNhap.Columns["DonGiaNhap"].HeaderText = "Đơn giá nhập";
        }

        private void layDuLieuHangHoa()
        {
            string[] thongtinLoaiHang = cboTenLoaiHangHoa.Text.Split(new string[] { " - " }, StringSplitOptions.None);
            int maLoai = int.Parse(thongtinLoaiHang[0]);
            string tenLoai = thongtinLoaiHang[1];
            int maHangHoa = int.Parse(txtMaHangHoa.Text);
            string tenHang = txtTenHangHoa.Text;
            string dvt = cboDVT.Text;
            byte[] anh = chuyenAnhSangMangByte(ptbAnhHangHoa);
            hangHoa = new HangHoa(maHangHoa, tenHang, 0.0f, dvt, anh, maLoai);
        }

        private void layDuLieuNhaCungCap()
        {
            string[] thongtinNhaCungCap = cboNhaCungCap.Text.Split(new string[] { " - " }, StringSplitOptions.None);
            int maNhaCungCap = int.Parse(thongtinNhaCungCap[0]);
            string tenNhaCungCap = thongtinNhaCungCap[1];
            nhaCungCap = new NhaCungCap(maNhaCungCap, tenNhaCungCap);
        }

        private byte[] chuyenAnhSangMangByte(PictureBox ptbAnhHangHoa)
        {
            MemoryStream memoryStream = new MemoryStream();
            if (ptbAnhHangHoa.Image != null)
                ptbAnhHangHoa.Image.Save(memoryStream, ptbAnhHangHoa.Image.RawFormat);
            return memoryStream.ToArray();
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dgvHangHoa.Rows[e.RowIndex];
            cboTenLoaiHangHoa.Text = row.Cells[0].Value.ToString() + " - " + row.Cells[1].Value.ToString();
            txtMaHangHoa.Text = row.Cells[2].Value.ToString();
            txtMaHangHoa.Enabled = true;
            txtTenHangHoa.Text = row.Cells[3].Value.ToString();
            cboDVT.Text = row.Cells[4].Value.ToString();
            if (row.Cells[5].Value.ToString() != "")
            {
                MemoryStream memoryStream = new MemoryStream((byte[])row.Cells[5].Value);
                ptbAnhHangHoa.Image = Image.FromStream(memoryStream);
            }
            else
            {
                ptbAnhHangHoa.Image = null;
            }
            txtMaHangHoa_PhieuNhap.Text = row.Cells[2].Value.ToString();
        }

        private bool ktraInputHangHoa()
        {
            if (String.IsNullOrEmpty(txtMaHangHoa.Text) || String.IsNullOrEmpty(txtTenHangHoa.Text) ||
                String.IsNullOrEmpty(cboDVT.Text) || String.IsNullOrEmpty(cboTenLoaiHangHoa.Text) || ptbAnhHangHoa.Image == null) return false;
            else return true;
        }
        private bool ktraInputPhieuNhap()
        {
            if (String.IsNullOrEmpty(txtSTTPhieuNhap.Text) || String.IsNullOrEmpty(txtMaNV.Text) ||
                String.IsNullOrEmpty(cboNhaCungCap.Text) || String.IsNullOrEmpty(txtMaHangHoa_PhieuNhap.Text) ||
                String.IsNullOrEmpty(txtDonGiaNhap.Text) || String.IsNullOrEmpty(txtSoLuongNhap.Text)) return false;
            else return true;
        }

        private void btnLoadAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "Image Files(*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png)|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ptbAnhHangHoa.ImageLocation = openFileDialog.FileName;
            }
        }

        private void btnThemHangHoa_Click(object sender, EventArgs e)
        {
            btnDatLaiHangHoa_Click(sender, e);
            modify.LayMaMaxNapVaoTextBox("SELECT DISTINCT IDENT_CURRENT('HangHoa') + 1 FROM HangHoa;", txtMaHangHoa);
        }

        private void btnLuuHangHoa_Click(object sender, EventArgs e)
        {
            if (ktraInputHangHoa() == false) MessageBox.Show("Bạn cần nhập đầy đủ thông tin hàng hóa!");
            else
            {
                string query = "INSERT INTO HangHoa(TenHang, DVT, GiaNiemYet, HinhAnh, MaLoai) " +
                    "VALUES (@tenhang, @dvt, @gianiemyet, @hinhanh, @maloai)";
                try
                {
                    layDuLieuHangHoa();
                    modify.CommandHangHoa(hangHoa, query);
                    MessageBox.Show("Thêm hàng hóa mới thành công!");
                    HienThiDGHangHoa();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnSuaThongTinHangHoa_Click(object sender, EventArgs e)
        {
            if (ktraInputHangHoa() == false) MessageBox.Show("Bạn cần nhập đầy đủ thông tin hàng hóa!");
            else
            {
                string query = "UPDATE HangHoa SET TenHang = @tenhang , DVT = @dvt, " +
                    "GiaNiemYet = @gianiemyet, HinhAnh = @hinhanh, MaLoai = @maloai " +
                    "WHERE MaHang = @mahang";
                try
                {
                    layDuLieuHangHoa();
                    modify.CommandHangHoa(hangHoa, query);
                    MessageBox.Show("Sửa thông tin hàng hóa thành công!");
                    HienThiDGHangHoa();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnXoaHangHoa_Click(object sender, EventArgs e)
        {
            if (ktraInputHangHoa() == false) MessageBox.Show("Bạn cần nhập đầy đủ thông tin hàng hóa!");
            else
            {
                string query = "DELETE FROM HangHoa WHERE MaHang = @mahang";
                try
                {
                    FormXacNhanXoaHangHoa frmXacNhanXoaHangHoa = new FormXacNhanXoaHangHoa();
                    if (frmXacNhanXoaHangHoa.ShowDialog() == DialogResult.OK)
                    {
                        layDuLieuHangHoa();
                        modify.CommandXoaHangHoa(hangHoa, query);
                        MessageBox.Show("Xóa hàng hóa thành công!");
                        HienThiDGHangHoa();
                        btnDatLaiHangHoa_Click(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnDatLaiHangHoa_Click(object sender, EventArgs e)
        {
            cboTenLoaiHangHoa.Text = "";
            txtMaHangHoa.Text = "";
            txtMaHangHoa.Enabled = true;
            txtTenHangHoa.Text = "";
            cboDVT.Text = "";
            ptbAnhHangHoa.Image = null;
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow row = dgvPhieuNhap.Rows[e.RowIndex];
            txtSTTPhieuNhap.Text = row.Cells[0].Value.ToString();
            txtMaNV.Text = row.Cells[1].Value.ToString();
            cboNhaCungCap.Text = row.Cells[2].Value.ToString();
            txtMaHangHoa_PhieuNhap.Text = row.Cells[3].Value.ToString();
            txtSoLuongNhap.Text = row.Cells[4].Value.ToString();
            txtDonGiaNhap.Text = row.Cells[5].Value.ToString();
        }

        private void btnDatLaiPhieuNhap_Click(object sender, EventArgs e)
        {
            txtSTTPhieuNhap.Text = "";
            cboNhaCungCap.Text = "";
            txtMaHangHoa_PhieuNhap.Text = "";
            txtDonGiaNhap.Text = "";
            txtSoLuongNhap.Text = "";
        }

        private void btnThemPhieuNhap_Click(object sender, EventArgs e)
        {
            btnDatLaiPhieuNhap_Click(sender, e);
            modify.LayMaMaxNapVaoTextBox("SELECT IDENT_CURRENT('PhieuNhapHang')+1 FROM PhieuNhapHang", txtSTTPhieuNhap);
        }

        private void btnLuuPhieuNhap_Click(object sender, EventArgs e)
        {
            if (ktraInputPhieuNhap() == false) MessageBox.Show("Bạn cần nhập đầy đủ thông tin phiếu nhập!");
            else
            {
                string query1 = "INSERT INTO PhieuNhapHang(NgayLapPhieu, MaNhaCungCap, MaNV) " +
                    "VALUES (@NgayLapPhieu, @MaNhaCungCap, @MaNV)";
                string query2 = "INSERT INTO ChiTietPhieuNhap(STTPhieuNhap, MaHang, SoLuongNhap, DonGiaNhap) " +
                    "VALUES (@STTPhieuNhap, @MaHang, @SoLuongNhap, @DonGiaNhap)";
                string query3 = "INSERT INTO CungCap(MaHang, MaNhaCungCap) " +
                    "VALUES (@mahang, @manhacungcap)";
                try
                {
                    layDuLieuHangHoa();
                    layDuLieuNhaCungCap();
                    modify.CommandThemPhieuNhap(query1, nhaCungCap, tempDN);
                    modify.CommandThemChiTietPhieuNhap(query2, int.Parse(txtSTTPhieuNhap.Text), hangHoa, int.Parse(txtSoLuongNhap.Text), float.Parse(txtDonGiaNhap.Text));
                    try
                    {
                        modify.CommandNhaCungCap(hangHoa, nhaCungCap, query3);
                    }
                    catch (SqlException ex) { }
                    MessageBox.Show("Thêm phiếu nhập mới thành công!");
                    HienThiDGPhieuNhap();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
    }
}
