using ketnoi;
using System;
using System.Collections;
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
    public partial class FormNhaCungCap : Form
    {
        public FormNhaCungCap()
        {
            InitializeComponent();
        }

        Ham func = new Ham();
        SqlConnection conn = null;
        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
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

        private void DoiTenCotDGNhaCungCap(DataGridView dg)
        {
            dgvNCC.Columns["MaNhaCungCap"].HeaderText = "Mã Nhà Cung Cấp";
            dgvNCC.Columns["TenNhaCungCap"].HeaderText = "Tên Nhà Cung Cấp";
            dgvNCC.Columns["SoDienThoaiNhaCungCap"].HeaderText = "Số Điện Thoại";
            dgvNCC.Columns["EmailNhaCungCap"].HeaderText = "Email";
            dgvNCC.Columns["DiaChiNhaCungCap"].HeaderText = "Địa Chỉ";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void LayMaNhaCungCapMax(string query, TextBox tb)
        {
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                tb.Text = reader.GetInt32(0).ToString();
            }
            reader.Close();
            tb.Enabled = false;
        }




        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
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
            LayMaNhaCungCapMax("SELECT MAX(MaNhaCungCap) + 1 FROM NhaCungCap;", txtMaNhaCungCap);

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

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            txtMaNhaCungCap.Text = "";
            txtTenNhaCungCap.Text = "";
            txtDiachi.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
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

        private void btnXoaHangHoa_Click(object sender, EventArgs e)
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
