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
    public partial class FormNhanVien : Form
    {
        int tempID;
        string chucvu;
        string tennhanvien;
        public FormNhanVien(int UserId)
        {
            InitializeComponent();
            tempID = UserId;
        }
        Modify modify = new Modify();
        Ham h = new Ham();
        public SqlConnection conn = null;

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            ThietLapPlaceHoderChoTBTimKiem();
            layTTNV();
            kiemTraUser();
            h.KetNoi(ref conn);
            h.HienThiDg(conn, "SELECT MaNV, TenNV, GioiTinh, EmailNV, DiaChiNV, SDTNV, ChucVu, TenDangNhap, MatKhau FROM NhanVien", dgvNhanVien);
            DoiTenCotDG(dgvNhanVien);
        }

        private void ThietLapPlaceHoderChoTBTimKiem()
        {
            txtTimKiem.Text = "Tìm kiếm Nhân viên theo Tên nhân viên...";
            txtTimKiem.ForeColor = Color.Gray;
        }

        private void txtTimKiem_Enter(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == "Tìm kiếm Nhân viên theo Tên nhân viên...")
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }

        private void txtTimKiem_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                txtTimKiem.Text = "Tìm kiếm Nhân viên theo Tên nhân viên...";
                txtTimKiem.ForeColor = Color.Gray;
            }
        }

        private void DoiTenCotDG(DataGridView dgvNhanVien)
        {
            dgvNhanVien.Columns["MaNV"].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns["TenNV"].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvNhanVien.Columns["EmailNV"].HeaderText = "Email";
            dgvNhanVien.Columns["DiaChiNV"].HeaderText = "Địa chỉ";
            dgvNhanVien.Columns["SDTNV"].HeaderText = "Số điện thoại";
            dgvNhanVien.Columns["ChucVu"].HeaderText = "Chức vụ";
            dgvNhanVien.Columns["TenDangNhap"].HeaderText = "Tên đăng nhập";
            dgvNhanVien.Columns["MatKhau"].HeaderText = "Mật khẩu";
            dgvNhanVien.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13, FontStyle.Bold);
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1) return;
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                txtMaNhanVien.Enabled = true;
                txtMaNhanVien.Text = row.Cells[0].Value.ToString();
                txtTenNhanVien.Text = row.Cells[1].Value.ToString();
                cmbGIoiTinh.Text = row.Cells[2].Value.ToString();
                txtEmailNhanVien.Text = row.Cells[3].Value.ToString();
                txtDiaChiNhanVien.Text = row.Cells[4].Value.ToString();
                txtSoDienThoai.Text = row.Cells[5].Value.ToString();
                cmbChucVu.Text = row.Cells[6].Value.ToString();
                txtTenDangNhap.Text = row.Cells[7].Value.ToString();
                txtMatKhau.Text = row.Cells[8].Value.ToString();
                txtMatKhau.PasswordChar = '*';

                // Nếu đúng nhân viên đó đăng nhập dựa vào UserId
                if (txtMaNhanVien.Text == tempID.ToString() && kiemTraCVNV(chucvu))
                {
                    txtMaNhanVien.Enabled = false;
                    txtTenNhanVien.Enabled = true;
                    cmbGIoiTinh.Enabled = true;
                    txtEmailNhanVien.Enabled = true;
                    txtDiaChiNhanVien.Enabled = true;
                    txtSoDienThoai.Enabled = true;
                    txtTenDangNhap.Enabled = true;
                    txtMatKhau.Enabled = true;
                    btnSuaThongTin.Visible = true;
                    btnHienThiMatKhau.Visible = true;
                }
                else if (kiemTraCVQL(chucvu)) kiemTraUser();
                // Không đúng nhân viên đã đăng nhập thì không được chỉnh sửa các nhân viên còn lại
                else
                {
                    txtMaNhanVien.Enabled = false;
                    txtTenNhanVien.Enabled = false;
                    cmbGIoiTinh.Enabled = false;
                    txtEmailNhanVien.Enabled = false;
                    txtDiaChiNhanVien.Enabled = false;
                    txtSoDienThoai.Enabled = false;
                    txtTenDangNhap.Enabled = false;
                    txtMatKhau.Enabled = false;
                    btnSuaThongTin.Visible = false;
                    btnHienThiMatKhau.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void layTTNV()
        {
            modify.CommandLayTenNV(ref tennhanvien, ref chucvu, $"SELECT TenNV, ChucVu FROM NhanVien WHERE MaNV = {tempID}");
        }

        private bool kiemTraCVQL(string chucvu) => chucvu == "Quản lý";
        private bool kiemTraCVNV(string chucvu) => chucvu == "Nhân viên";

        private void kiemTraUser()
        {
            // Nhân viên khi đăng nhập vào
            if (!kiemTraCVQL(chucvu))
            {
                txtMaNhanVien.Enabled = false;
                txtTenNhanVien.Enabled = false;
                cmbGIoiTinh.Enabled = false;
                txtEmailNhanVien.Enabled = false;
                txtDiaChiNhanVien.Enabled = false;
                txtSoDienThoai.Enabled = false;
                cmbChucVu.Enabled = false;
                txtTenDangNhap.Enabled = false;
                txtMatKhau.Enabled = false;
                btnThemNhanVien.Visible = false;
                btnLuuThongTin.Visible = false;
                btnSuaThongTin.Visible = false;
                btnXoaNhanVien.Visible = false;
                btnDatLai.Visible = false;
                btnHienThiMatKhau.Visible = false;
            }
            // Admin khi đăng nhập vào
            else
            {
                txtMaNhanVien.Enabled = true;
                txtTenNhanVien.Enabled = true;
                cmbGIoiTinh.Enabled = true;
                txtEmailNhanVien.Enabled = true;
                txtDiaChiNhanVien.Enabled = true;
                txtSoDienThoai.Enabled = true;
                cmbChucVu.Enabled = true;
                txtTenDangNhap.Enabled = true;
                txtMatKhau.Enabled = true;
                btnThemNhanVien.Visible = true;
                btnLuuThongTin.Visible = true;
                btnSuaThongTin.Visible = true;
                btnXoaNhanVien.Visible = true;
                btnDatLai.Visible = true;
                btnHienThiMatKhau.Visible = false;
            }
        }

        private void dgvNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvNhanVien.Columns[e.ColumnIndex].Name == "MatKhau")
            {
                e.Value = new string('*', e.Value.ToString().Length);
            }
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                string manv_max = "SELECT IDENT_CURRENT('NhanVien') + 1";
                SqlCommand command = new SqlCommand(manv_max, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    int manv_moi = int.Parse(reader[0].ToString());
                    txtMaNhanVien.Text = manv_moi.ToString();
                }
                txtMaNhanVien.Enabled = false;
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
                command.CommandText = "INSERT INTO NhanVien(TenNV, GioiTinh, EmailNV, DiaChiNV, SDTNV, ChucVu, TenDangNhap, MatKhau) " +
                                      "VALUES(@tennv, @gioitinh, @emailnv, @diachinv, @sdtnv, @chucvu, @tendangnhap, @matkhau)";
                command.Parameters.AddWithValue("@tennv", txtTenNhanVien.Text);
                command.Parameters.AddWithValue("@gioitinh", cmbGIoiTinh.Text);
                command.Parameters.AddWithValue("@emailnv", txtEmailNhanVien.Text);
                command.Parameters.AddWithValue("@diachinv", txtDiaChiNhanVien.Text);
                command.Parameters.AddWithValue("@sdtnv", txtSoDienThoai.Text);
                command.Parameters.AddWithValue("@chucvu", cmbChucVu.Text);
                command.Parameters.AddWithValue("@tendangnhap", txtTenDangNhap.Text);
                command.Parameters.AddWithValue("@matkhau", txtMatKhau.Text);
                command.Connection = conn;
                int ret = command.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Thêm nhân viên mới thành công");
                    FormNhanVien_Load(sender, e);
                    btnDatLai_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên mới thất bại");
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
                command.CommandText = "UPDATE NhanVien SET TenNV = @tennv, GioiTinh = @gioitinh, EmailNV = @emailnv, " +
                                      "DiaChiNV = @diachinv, SDTNV = @sdtnv, ChucVu = @chucvu, TenDangNhap = @tendangnhap, " +
                                      "MatKhau = @matkhau WHERE MaNV = @manv";
                command.Parameters.AddWithValue("@manv", txtMaNhanVien.Text);
                command.Parameters.AddWithValue("@tennv", txtTenNhanVien.Text);
                command.Parameters.AddWithValue("@gioitinh", cmbGIoiTinh.Text);
                command.Parameters.AddWithValue("@emailnv", txtEmailNhanVien.Text);
                command.Parameters.AddWithValue("@diachinv", txtDiaChiNhanVien.Text);
                command.Parameters.AddWithValue("@sdtnv", txtSoDienThoai.Text);
                command.Parameters.AddWithValue("@chucvu", cmbChucVu.Text);
                command.Parameters.AddWithValue("@tendangnhap", txtTenDangNhap.Text);
                command.Parameters.AddWithValue("@matkhau", txtMatKhau.Text);
                command.Connection = conn;
                int ret = command.ExecuteNonQuery();
                if (ret > 0)
                {
                    MessageBox.Show("Sửa thông tin nhân viên thành công");
                    FormNhanVien_Load(sender, e);
                    btnDatLai_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Sửa thông tin nhân viên thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                FormXacNhanXoaNhanVien frmXacNhan = new FormXacNhanXoaNhanVien();
                if (frmXacNhan.ShowDialog() == DialogResult.OK)
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.Text;
                    command.CommandText = "DELETE FROM NhanVien WHERE MaNV = @manv";
                    command.Parameters.AddWithValue("@manv", txtMaNhanVien.Text);
                    command.Connection = conn;
                    int ret = command.ExecuteNonQuery();
                    if (ret > 0)
                    {
                        MessageBox.Show("Xóa nhân viên thành công");
                        FormNhanVien_Load(sender, e);
                        btnDatLai_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại");
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
            txtMaNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            cmbGIoiTinh.Text = "";
            txtEmailNhanVien.Text = "";
            txtDiaChiNhanVien.Text = "";
            txtSoDienThoai.Text = "";
            cmbChucVu.Text = "";
            txtTenDangNhap.Text = "";
            txtMatKhau.Text = "";
        }

        private void btnHienThiMatKhau_Click(object sender, EventArgs e)
        {
            string strTmp = txtMatKhau.Text;
            txtMatKhau.Text = strTmp.ToLower();
            txtMatKhau.PasswordChar = '\0';
        }

        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (String.IsNullOrEmpty(txtTimKiem.Text))
                {
                    FormNhanVien_Load(sender, e);
                }
                else
                {
                    string tukhoa = txtTimKiem.Text;
                    string sql_timkiem = "SELECT MaNV, TenNV, GioiTinh, EmailNV, DiaChiNV, SDTNV, ChucVu, TenDangNhap, MatKhau " +
                                         "FROM NhanVien WHERE TenNV LIKE N'%" + tukhoa + "%'";
                    dgvNhanVien.DataSource = modify.DataTable(sql_timkiem);
                    DoiTenCotDG(dgvNhanVien);
                }
            }
        }

        private void btnHienThiMatKhau_Leave(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '*';
        }


    }
}
