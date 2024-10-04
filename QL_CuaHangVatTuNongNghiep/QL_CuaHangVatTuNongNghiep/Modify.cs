using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CuaHangVatTuNongNghiep
{
    public class Modify
    {
        SqlDataAdapter adapter;
        SqlCommand command;
        public Modify() { }
        public DataTable DataTable(string query)
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
    }
}
