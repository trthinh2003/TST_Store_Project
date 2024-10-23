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
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();
        }

        Ham h = new Ham();
        public SqlConnection conn = null;
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            ThietLapPlaceHoderChoTBTimKiem();
            h.KetNoi(ref conn);
            HienThiDGKH();
            DoiTenCotDG(dgvKhachHang);
        }

        private void ThietLapPlaceHoderChoTBTimKiem()
        {
            txtTimKiem.Text = "Tìm kiếm Khách hàng theo Tên khách hàng...";
            txtTimKiem.ForeColor = Color.Gray;
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm Khách hàng theo Tên khách hàng...")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                txtTimKiem.Text = "Tìm kiếm Khách hàng theo Tên khách hàng...";
                txtTimKiem.ForeColor = Color.Gray;
            }
        }

        private void HienThiDGKH()
        {
            h.HienThiDg(conn, "SELECT MaKH, TenKH, SDTKH, EmailKH, DiaChiKH FROM KhachHang", dgvKhachHang);
            dgvKhachHang.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13, FontStyle.Bold);
        }

        private void DoiTenCotDG(DataGridView dgvKhachHang)
        {
            dgvKhachHang.Columns["MaKH"].HeaderText = "Mã Khách Hàng";
            dgvKhachHang.Columns["TenKH"].HeaderText = "Tên Khách Hàng";
            dgvKhachHang.Columns["SDTKH"].HeaderText = "Số Điện Thoại";
            dgvKhachHang.Columns["EmailKH"].HeaderText = "Email";
            dgvKhachHang.Columns["DiaChiKH"].HeaderText = "Địa Chỉ";
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1) return;
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                txtMaKhachHang.Enabled = true;
                txtMaKhachHang.Text = row.Cells[0].Value.ToString();
                txtTenKhachHang.Text = row.Cells[1].Value.ToString();
                txtSoDienThoai.Text = row.Cells[2].Value.ToString();
                txtEmailKhachHang.Text = row.Cells[3].Value.ToString();
                txtDiaChiKhachHang.Text = row.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                string makh_max = "SELECT IDENT_CURRENT('KhachHang') + 1";
                SqlCommand command = new SqlCommand(makh_max, conn);
                command.Connection = conn;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int makh_moi = int.Parse(reader[0].ToString());
                    txtMaKhachHang.Text = makh_moi.ToString();
                }
                txtMaKhachHang.Enabled = false;
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT INTO KhachHang(TenKH, SDTKH, EmailKH, DiaChiKh) " +
                                      "VALUES(@tenkh, @sdtkh, @emailkh, @daichikh)"; ;
                command.Parameters.AddWithValue("@tenkh", txtTenKhachHang.Text);
                command.Parameters.AddWithValue("@sdtkh", txtSoDienThoai.Text);
                command.Parameters.AddWithValue("@emailkh", txtEmailKhachHang.Text);
                command.Parameters.AddWithValue("@daichikh", txtDiaChiKhachHang.Text);
                command.Connection = conn;
                int ret = command.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Thêm khách hàng thành công");
                    FormKhachHang_Load(sender, e);
                    btnDatLai_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE KhachHang SET TenKH = @tenkh, SDTKH = @sdtkh, EmailKH = @emailkh, " +
                                      "DiaChiKH = @diachikh WHERE MaKH = @makh";
                command.Parameters.AddWithValue("@makh", txtMaKhachHang.Text);
                command.Parameters.AddWithValue("@tenkh", txtTenKhachHang.Text);
                command.Parameters.AddWithValue("@sdtkh", txtSoDienThoai.Text);
                command.Parameters.AddWithValue("@emailkh", txtEmailKhachHang.Text);
                command.Parameters.AddWithValue("@diachikh", txtDiaChiKhachHang.Text);
                command.Connection = conn;
                int ret = command.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Sửa khách hàng thành công");
                    FormKhachHang_Load(sender, e);
                    btnDatLai_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa khách hàng thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                FormXacNhanXoaKhachHang formXacNhanXoa = new FormXacNhanXoaKhachHang();
                if (formXacNhanXoa.ShowDialog() == DialogResult.OK)
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "DELETE FROM KhachHang WHERE MaKH = @makh";
                    command.Parameters.AddWithValue("@makh", txtMaKhachHang.Text);
                    command.Connection = conn;
                    int ret = command.ExecuteNonQuery();
                    if (ret > 0)
                    {
                        MessageBox.Show("Xóa khách hàng thành công");
                        FormKhachHang_Load(sender, e);
                        btnDatLai_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xóa khách hàng thất bại");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txtMaKhachHang.Text = "";
            txtTenKhachHang.Text = "";
            txtSoDienThoai.Text = "";
            txtEmailKhachHang.Text = "";
            txtDiaChiKhachHang.Text = "";
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(txtTimKiem.Text))
                {
                    FormKhachHang_Load(sender, e);
                }
                else
                {
                    string tukhoa = txtTimKiem.Text;
                    string sql_timkiem = "SELECT MaKH, TenKH, SDTKH, EmailKH, DiaChiKH FROM KhachHang WHERE TenKH LIKE N'%" + tukhoa + "%'";
                    h.HienThiDg(conn, sql_timkiem, dgvKhachHang);
                }
            }
        }
    }
}
