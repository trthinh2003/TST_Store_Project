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
    public partial class FormNhaCungCap : Form
    {
        public FormNhaCungCap()
        {
            InitializeComponent();
        }
        Ham func = new Ham();
        Modify modify = new Modify();
        SqlConnection conn = null;
        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            ThietLapPlaceHoderChoTBTimKiem();
            try
            {
                func.KetNoi(ref conn);
                func.HienThiDg(conn, "SELECT * FROM NhaCungCap", dgvNCC);
                DoiTenCotDGNhaCungCap(dgvNCC);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ThietLapPlaceHoderChoTBTimKiem()
        {
            txtKeyWord.Text = "Tìm kiếm Nhà cung cấp theo Tên nhà cung cấp...";
            txtKeyWord.ForeColor = Color.Gray;
        }


        private void txtKeyWord_Enter(object sender, EventArgs e)
        {
            if (txtKeyWord.Text == "Tìm kiếm Nhà cung cấp theo Tên nhà cung cấp...")
            {
                txtKeyWord.Text = "";
                txtKeyWord.ForeColor = Color.Black;
            }
        }

        private void txtKeyWord_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKeyWord.Text))
            {
                txtKeyWord.Text = "Tìm kiếm Nhà cung cấp theo Tên nhà cung cấp...";
                txtKeyWord.ForeColor = Color.Gray;
            }
        }

        private void DoiTenCotDGNhaCungCap(DataGridView dg)
        {
            dgvNCC.Columns["MaNhaCungCap"].HeaderText = "Mã nhà cung cấp";
            dgvNCC.Columns["TenNhaCungCap"].HeaderText = "Tên nhà cung cấp";
            dgvNCC.Columns["SoDienThoaiNhaCungCap"].HeaderText = "Số điện thoại";
            dgvNCC.Columns["EmailNhaCungCap"].HeaderText = "Email";
            dgvNCC.Columns["DiaChiNhaCungCap"].HeaderText = "Địa chỉ";
            dgvNCC.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13, FontStyle.Bold);

        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == -1) return;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvNCC.Rows[e.RowIndex];
            txtMaNhaCungCap.Text = row.Cells[0].Value.ToString();
            //manhacungcap = (int)row.Cells[0].Value;
            txtTenNhaCungCap.Text = row.Cells[1].Value.ToString();
            txtDiachi.Text = row.Cells[2].Value.ToString();
            txtSDT.Text = row.Cells[3].Value.ToString();
            txtEmail.Text = row.Cells[4].Value.ToString();
        }

        private void btnThemNhaCungCap_Click(object sender, EventArgs e)
        {
            btnDatLai_Click(sender, e);
            modify.LayMaMaxNapVaoTextBox("SELECT IDENT_CURRENT('NhaCungCap') + 1", txtMaNhaCungCap);
        }

        private void btnLuuThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO NhaCungCap VALUES (@tenncc, @diachincc, @sdtncc, @emailncc)";
                cmd.Parameters.Add("@tenncc", SqlDbType.NVarChar).Value = txtTenNhaCungCap.Text;
                cmd.Parameters.Add("@diachincc", SqlDbType.NVarChar).Value = txtDiachi.Text;
                cmd.Parameters.Add("@sdtncc", SqlDbType.NVarChar).Value = txtSDT.Text;
                cmd.Parameters.Add("@emailncc", SqlDbType.NVarChar).Value = txtEmail.Text;
                cmd.Connection = conn;
                int ret = cmd.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Thêm Thành Công <3");
                    conn.Close();
                    FormNhaCungCap_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm Thất Bại !!!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhập Liệu Chưa Đầy Đủ !!!");
            }
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE NhaCungCap SET TenNhaCungCap = @tenncc, " +
                                  "DiaChiNhaCungCap = @diachincc, SoDienThoaiNhaCungCap = @sdtncc " +
                                  "WHERE MaNhaCungCap = @mancc";

                cmd.Parameters.Add("@mancc", SqlDbType.Int).Value = txtMaNhaCungCap.Text;
                cmd.Parameters.Add("@tenncc", SqlDbType.NVarChar).Value = txtTenNhaCungCap.Text;
                cmd.Parameters.Add("@diachincc", SqlDbType.NVarChar).Value = txtDiachi.Text;
                cmd.Parameters.Add("@sdtncc", SqlDbType.NVarChar).Value = txtSDT.Text;
                cmd.Parameters.Add("@emailncc", SqlDbType.NVarChar).Value = txtEmail.Text;


                //cmd.Parameters.Add("@mancc", SqlDbType.Int).Value = manhacungcap; // lay gia tri ma tu bien manhacungcap trong datagridview

                cmd.Connection = conn;
                int ret = cmd.ExecuteNonQuery();

                if (ret > 0)
                {
                    MessageBox.Show("Sửa Thành Công <3");
                    conn.Close();
                    FormNhaCungCap_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa Thất Bại !!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhập Liệu Chưa Đầy Đủ !!!");
            }
        }

        private void btnXoaNhaCungCap_Click(object sender, EventArgs e)
        {
            try
            {
                FormXacNhanXoaNhaCungCap frmxacnhan = new FormXacNhanXoaNhaCungCap();
                if (frmxacnhan.ShowDialog() == DialogResult.OK)
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "DELETE FROM NhaCungCap WHERE MaNhaCungCap = @mancc";

                    cmd.Parameters.Add("@mancc", SqlDbType.Int).Value = txtMaNhaCungCap.Text;


                    cmd.Connection = conn;
                    int ret = cmd.ExecuteNonQuery();

                    if (ret > 0)
                    {

                        conn.Close();
                        FormNhaCungCap_Load(sender, e);
                        MessageBox.Show("Xóa Thành Công <3");
                    }
                    else
                    {
                        MessageBox.Show("Xóa Thất Bại !!!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nhập Liệu Chưa Đầy Đủ !!!");
            }
        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txtMaNhaCungCap.Text = "";
            txtTenNhaCungCap.Text = "";
            txtDiachi.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
        }

        private void txtKeyWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string keyword = txtKeyWord.Text;
                string sql = "SELECT * FROM NhaCungCap WHERE TenNhaCungCap LIKE N'%" + keyword + "%'";
                func.HienThiDg(conn, sql, dgvNCC);
            }
        }
    }
}
