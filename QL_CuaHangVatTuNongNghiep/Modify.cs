using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
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

        public void HienThiCombobox(string query, ComboBox cb)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cb.Items.Add(reader.GetInt32(0) + " - " + reader.GetString(1));
                }
                reader.Close();
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
        public void LayMaNhaCungCapTuTenNhaCungCap(string query, ref int maNhaCungCap)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) maNhaCungCap = reader.GetInt32(0);
                else maNhaCungCap = -1;
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

        public void CommandXoaHangHoa(HangHoa hangHoa, string query)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                command.Connection = conn;
                command.Parameters.AddWithValue("@mahang", hangHoa.MaHangHoa);
                command.ExecuteNonQuery();
                conn.Close();
            }
        }

        //Xử lý bên FormNhaCungCap
        public void CommandNhaCungCap(HangHoa h, NhaCungCap ncc, string query)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                command = new SqlCommand(query, conn);
                //@mahang, @manhacungcap
                command.Parameters.AddWithValue("@mahang", h.MaHangHoa);
                command.Parameters.AddWithValue("@manhacungcap", ncc.MaNhaCungCap);
                command.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void CommandNhaCungCap(int maHang, int maNCC, string query)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                command = new SqlCommand(query, conn);
                //@mahang, @manhacungcap
                command.Parameters.AddWithValue("@mahang", maHang);
                command.Parameters.AddWithValue("@manhacungcap", maNCC);
                command.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void LayMaMaxNapVaoTextBox(string query, TextBox tb)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (!reader.IsDBNull(0)) tb.Text = reader[0].ToString();
                    else tb.Text = "0";
                }
                reader.Close();
                tb.Enabled = false;
                conn.Close();
            }
        }

        public void CommandThemPhieuNhap(string query, NhaCungCap nhaCungCap, int nhanvienID)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                //@NgayLapPhieu, @MaNhaCungCap, @MaNV
                command = new SqlCommand(query, conn);
                command.Parameters.Add("@NgayLapPhieu", SqlDbType.DateTime).Value = DateTime.Now.ToString();
                command.Parameters.AddWithValue("@MaNhaCungCap", nhaCungCap.MaNhaCungCap);
                command.Parameters.AddWithValue("@MaNV", nhanvienID);
                command.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void CommandThemChiTietPhieuNhap(string query, int sttPhieu, HangHoa hangHoa, int soLuongNhap, float donGiaNhap)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                command = new SqlCommand(query, conn);
                //@STTPhieuNhap, @MaHang, @SoLuongNhap, @DonGiaNhap
                command.Parameters.AddWithValue("@STTPhieuNhap", sttPhieu);
                command.Parameters.AddWithValue("@MaHang", hangHoa.MaHangHoa);
                command.Parameters.AddWithValue("@SoLuongNhap", soLuongNhap);
                command.Parameters.AddWithValue("@DonGiaNhap", donGiaNhap);
                command.ExecuteNonQuery();
                conn.Close();
            }
        }

        //Xử lý bên FormDonHang
        public void CommandLayTTKH(string query, KhachHang kh)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    kh.MaKH = int.Parse(reader[0].ToString());
                    kh.TenKH = reader[1].ToString();
                    kh.Sdt = reader[2].ToString();
                    kh.Email = reader[3].ToString();
                    kh.DiaChi = reader[4].ToString();
                }
                reader.Close();
                conn.Close();
            }
        }

        public void CommandLayTTHangHoaTuMaHang(string query, HangHoa h)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    h.Dvt = reader[0].ToString();
                    h.GiaNiemYet = float.Parse(reader[1].ToString());
                    h.HinhAnh = (byte[])reader[2];
                }
                reader.Close();
                conn.Close();
            }
        }

        public void LayLoaiHangTuMaHang(string query, ref int maLoai, ref string tenLoai)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    maLoai = reader.GetInt32(0);
                    tenLoai = reader.GetString(1);
                }
                reader.Close();
                conn.Close();
            }
        }

        public void LaySoLuong(string query, ref int soLuong)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (!reader.IsDBNull(0)) soLuong = reader.GetInt32(0);
                    else soLuong = -1;
                }
                reader.Close();
                conn.Close();
            }
        }
        public void CommandThemDonHang(string query, int maNV, int maKH)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                //@ngaylap, @manv, @makh
                command = new SqlCommand(query, conn);
                command.Parameters.Add("@ngaylap", SqlDbType.DateTime).Value = DateTime.Now.ToString();
                command.Parameters.AddWithValue("@manv", maNV);
                command.Parameters.AddWithValue("@makh", maKH);
                command.ExecuteNonQuery();
                conn.Close();
            }
        }
        public void CommandThemDonHang(string query, int maHD, int maHang, int soLuong, float donGia)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                //@mahoadon, @mahang, @soluong, @dongia)
                command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@mahoadon", maHD);
                command.Parameters.AddWithValue("@mahang", maHang);
                command.Parameters.AddWithValue("@soluong", soLuong);
                command.Parameters.AddWithValue("@dongia", donGia);
                command.ExecuteNonQuery();
                conn.Close();
            }
        }

        public double LayTongTienDonHang(string query)
        {
            double tongTien = 0.0;
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    tongTien = reader.GetDouble(0);
                }
                reader.Close();
                conn.Close();
            }
            return tongTien;
        }
    }
}
