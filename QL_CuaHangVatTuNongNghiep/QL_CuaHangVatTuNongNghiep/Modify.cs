using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CuaHangVatTuNongNghiep
{
    public class Modify
    {
        SqlDataAdapter adapter;
        SqlCommand command;
        public Modify() { }
        public DataTable DataTable(string query) //Sử dụng để hiển thị dữ liệu lên DataGridView
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dt);
                conn.Close();
            }
            return dt;
        }

        public void CommandXacNhanTaiKhoan(TaiKhoan taiKhoan, string query, ref bool tonTaiTaiKhoan)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@tentaikhoan", taiKhoan.TenTaiKhoan);
                command.Parameters.AddWithValue("@matkhau", taiKhoan.MatKhau);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    taiKhoan.MaTaiKhoan = int.Parse(reader.GetInt32(0).ToString());
                    taiKhoan.MaNV = int.Parse(reader.GetInt32(3).ToString());
                    tonTaiTaiKhoan = true;
                }
                else
                {
                    tonTaiTaiKhoan = false;
                }
                conn.Close();
            }
        }

        public void CommandLayTenNV(ref string tenNV, ref string chucVu, string query)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    tenNV = reader.GetString(0);
                    chucVu = reader.GetString(1);
                }
                conn.Close();
            }
        }

        public void HienThiCombobox(string query, ComboBox cb, string hthi, string gtri)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                cb.DataSource = dt;
                cb.ValueMember = gtri;
                cb.DisplayMember = hthi;
                conn.Close();
            }
        }

        public void LayMaLoaiTuTenLoai(string query, ref int maLoai)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) maLoai = reader.GetInt32(0);
                else maLoai = -1;
                reader.Close();
                conn.Close();
            }
        }

        public void CommandHangHoa(HangHoa hangHoa, string query)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                command = new SqlCommand(query, conn);
                //@tenhang, @gianiemyet, @hinhanh, @maloai, @dvt
                command.Parameters.AddWithValue("@mahang", hangHoa.MaHangHoa);
                command.Parameters.AddWithValue("@tenhang", hangHoa.TenHang);
                command.Parameters.AddWithValue("@gianiemyet", hangHoa.GiaNiemYet);
                command.Parameters.Add("@hinhanh", SqlDbType.VarBinary);
                command.Parameters["@hinhanh"].Value = hangHoa.HinhAnh;
                command.Parameters.AddWithValue("@maloai", hangHoa.MaLoai);
                command.Parameters.AddWithValue("@dvt", hangHoa.Dvt);
                command.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
