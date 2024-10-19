using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Collections;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Text.RegularExpressions;

namespace QL_CuaHangVatTuNongNghiep
{
    public partial class FormHangHoa : Form
    {
        public FormHangHoa()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        HangHoa hangHoa;
        NhaCungCap nhaCungCap;
        int maNCC;
        int maHang;
        private void FormHangHoa_Load(object sender, EventArgs e)
        {
            string query = "SELECT c.MaNhaCungCap, h.MaHang, h.TenHang, h.DVT, h.GiaNiemYet, h.HinhAnh, l.MaLoai, l.TenLoai, ncc.TenNhaCungCap " +
                           "FROM HangHoa h, LoaiHang l, CungCap c, NhaCungCap ncc " +
                           "WHERE h.MaLoai = l.MaLoai " +
                           "AND h.MaHang = c.MaHang " +
                           "AND c.MaNhaCungCap = ncc.MaNhaCungCap " +
                           "ORDER BY c.MaNhaCungCap";
            dgvHangHoa.DataSource = modify.DataTable(query);
            DieuChinhCacCotDG(dgvHangHoa);
            modify.HienThiCombobox("SELECT MaLoai, TenLoai FROM LoaiHang", cboTenLoaiHangHoa, "TenLoai", "MaLoai");
            modify.HienThiCombobox("SELECT MaNhaCungCap, TenNhaCungCap FROM NhaCungCap", cboNhaCungCap, "TenNhaCungCap", "MaNhaCungCap");
        }

        private void DieuChinhCacCotDG(DataGridView dgvHangHoa)
        {
            dgvHangHoa.Columns["MaNhaCungCap"].HeaderText = "Mã nhà cung cấp";
            dgvHangHoa.Columns["MaHang"].HeaderText = "Mã hàng hóa";
            dgvHangHoa.Columns["TenHang"].HeaderText = "Tên hàng hóa";
            dgvHangHoa.Columns["DVT"].HeaderText = "Đơn vị tính";
            dgvHangHoa.Columns["GiaNiemYet"].HeaderText = "Giá niêm yết";
            dgvHangHoa.Columns["HinhAnh"].Visible = false;
            dgvHangHoa.Columns["MaLoai"].HeaderText = "Mã loại";
            dgvHangHoa.Columns["TenLoai"].HeaderText = "Tên loại";
            dgvHangHoa.Columns["TenNhaCungCap"].Visible = false;
            txtMaHangHoa.Enabled = true;
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

        private void layDuLieu()
        {
            int maHangHoa;
            if (txtMaHangHoa.Text.Length == 0) maHangHoa = 0;
            else maHangHoa = int.Parse(txtMaHangHoa.Text);
            string tenHang = txtTenHangHoa.Text;
            float giaNiemYet = float.Parse(txtGiaNiemYet.Text);
            string dvt = cboDVT.Text;
            byte[] anh = chuyenAnhSangMangByte(ptbAnhHangHoa);
            string tenLoai = cboTenLoaiHangHoa.Text;
            int maLoai = 0;
            string tenNhaCungCap = cboNhaCungCap.Text;
            int maNhaCungCap = 0;
            modify.LayMaLoaiTuTenLoai("SELECT MaLoai FROM LoaiHang WHERE TenLoai LIKE N'" + tenLoai + "'", ref maLoai);
            modify.LayMaLoaiTuTenLoai("SELECT MaNhaCungCap FROM NhaCungCap WHERE TenNhaCungCap LIKE N'" + tenNhaCungCap + "'", ref maNhaCungCap);
            hangHoa = new HangHoa(maHangHoa, tenHang, giaNiemYet, dvt, anh, maLoai);
            nhaCungCap = new NhaCungCap(maNhaCungCap, tenNhaCungCap);
        }

        private byte[] chuyenAnhSangMangByte(PictureBox ptbAnhHangHoa)
        {
            MemoryStream memoryStream = new MemoryStream();
            ptbAnhHangHoa.Image.Save(memoryStream, ptbAnhHangHoa.Image.RawFormat);
            return memoryStream.ToArray();
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1) return;
                DataGridViewRow row = dgvHangHoa.Rows[e.RowIndex];
                txtMaHangHoa.Enabled = true;
                txtMaHangHoa.Text = row.Cells[1].Value.ToString();
                txtTenHangHoa.Text = row.Cells[2].Value.ToString();
                cboDVT.Text = row.Cells[3].Value.ToString();
                txtGiaNiemYet.Text = row.Cells[4].Value.ToString();
                if (row.Cells[5].Value.ToString() != "")
                {
                    MemoryStream memoryStream = new MemoryStream((byte[])row.Cells[5].Value);
                    ptbAnhHangHoa.Image = Image.FromStream(memoryStream);
                }
                else
                {
                    ptbAnhHangHoa.Image = null;
                }
                cboTenLoaiHangHoa.Text = row.Cells[7].Value.ToString();
                cboNhaCungCap.Text = row.Cells[8].Value.ToString();
                layMaHangVaMaNCC(int.Parse(row.Cells[1].Value.ToString()), int.Parse(row.Cells[0].Value.ToString()));
                //MessageBox.Show(maHang + " - " + maNCC);

            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }

        }

        private void layMaHangVaMaNCC(int _maHang, int _maNCC)
        {
            maHang = _maHang;
            maNCC = _maNCC;
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txtMaHangHoa.Text = "";
            txtTenHangHoa.Text = "";
            cboDVT.Text = "";
            txtGiaNiemYet.Text = "";
            cboTenLoaiHangHoa.Text = "";
            cboNhaCungCap.Text = "";
            ptbAnhHangHoa.Image = null;
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            string query1 = "UPDATE HangHoa SET TenHang = @tenhang, GiaNiemYet = @gianiemyet," +
                "HinhAnh=@hinhanh, DVT = @dvt, MaLoai = @maloai WHERE MaHang = @mahang";
            string query2 = "DELETE FROM CungCap WHERE MaHang = @mahang AND MaNhaCungCap = @manhacungcap";
            string query3 = "INSERT INTO CungCap(MaHang, MaNhaCungCap) VALUES (@mahang, @manhacungcap)";
            try
            {
                layDuLieu();
                modify.CommandHangHoa(hangHoa, query1);
                modify.CommandNhaCungCap(maHang, maNCC, query2);
                modify.CommandNhaCungCap(hangHoa, nhaCungCap, query3);
                MessageBox.Show("Sửa thông tin hàng hóa thành công!");
                FormHangHoa_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoaHangHoa_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM CungCap WHERE MaHang = @mahang AND MaNhaCungCap = @manhacungcap";
            try
            {
                layDuLieu();
                FormXacNhanXoaHangHoa frmXacNhanXoa = new FormXacNhanXoaHangHoa();
                if (frmXacNhanXoa.ShowDialog() == DialogResult.OK)
                {
                    modify.CommandNhaCungCap(maHang, maNCC, query);
                    MessageBox.Show("Xóa hàng hóa thành công!");
                    FormHangHoa_Load(sender, e);
                    btnDatLai_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string tuKhoa = txtTimKiem.Text.Trim();
                string sqlSearch = "SELECT h.MaHang, h.TenHang, h.DVT, h.GiaNiemYet, h.HinhAnh, l.MaLoai, l.TenLoai " +
                    "FROM HangHoa h, LoaiHang l " +
                    "WHERE h.MaLoai = l.MaLoai " +
                    "AND TenHang LIKE N'%" + tuKhoa + "%'";
                dgvHangHoa.DataSource = modify.DataTable(sqlSearch);
            }
        }


    }
}
