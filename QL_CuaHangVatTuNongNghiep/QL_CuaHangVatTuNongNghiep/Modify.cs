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


        //Xử lý bên FormDangNhap
        public void CommandXacNhanTaiKhoan(NhanVien nhanVien, string query, ref bool tonTaiTaiKhoan)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@tendangnhap", nhanVien.TenDangNhap);
                command.Parameters.AddWithValue("@matkhau", nhanVien.MatKhau);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    nhanVien.MaNV = int.Parse(reader[0].ToString());
                    nhanVien.TenNV = reader[1].ToString();
                    nhanVien.GioiTinh = reader[2].ToString();
                    nhanVien.EmailNV = reader[3].ToString();
                    nhanVien.DiaChiNV = reader[4].ToString();
                    nhanVien.SdtNV = reader[5].ToString();
                    nhanVien.ChucVu = reader[6].ToString();
                    tonTaiTaiKhoan = true;
                }
                else
                {
                    tonTaiTaiKhoan = false;
                }
                conn.Close();
            }
        }

        //Xử lý bên FormTrangChu
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


        //Xử lý bên FormHangHoa
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

        public void LayMaHangHoaMaxNapVaoTextBox(string query, TextBox tb)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                command = new SqlCommand (query, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    tb.Text = reader.GetInt32(0).ToString();
                }
                reader.Close();
                tb.Enabled = false;
                conn.Close();
            }
        }
    }
}
