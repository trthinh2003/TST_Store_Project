﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CuaHangVatTuNongNghiep
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        Modify modify = new Modify();
        NhanVien nhanVien;
        public int tempDN;

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void layDuLieu()
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            nhanVien = new NhanVien(tenDangNhap, matKhau);
            //modify.LayThongTinNhanVien("SELECT MaNV, TenNV, GioiTinh, EmailNV, DiaChiNV, SDTNV, ChucVu " +
            //                           "FROM NhanVien " +
            //                           "WHERE TenDangNhap = @tendangnhap AND MatKhau = @matkhau;", nhanVien);

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Length == 0)
                MessageBox.Show("Tên tài khoản không được để trống!");
            else if (txtMatKhau.Text.Length == 0)
                MessageBox.Show("Mật khẩu không được để trống!");
            else
            {
                string query = "SELECT MaNV, TenNV, GioiTinh, EmailNV, DiaChiNV, SDTNV, ChucVu " +
                    "FROM NhanVien WHERE TenDangNhap = @tendangnhap AND MatKhau = @matkhau";
                try
                {
                    bool existAccount = false;
                    layDuLieu();
                    modify.CommandXacNhanTaiKhoan(nhanVien, query, ref existAccount);
                    if (existAccount == true)
                    {
                        MessageBox.Show("Đăng nhập thành công!");
                        this.Hide();
                        FormTrangChu frmTrangChu = new FormTrangChu(nhanVien.MaNV);
                        frmTrangChu.FormClosed += (s, args) => this.Close();
                        frmTrangChu.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không tồn tại!");
                        txtMatKhau.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }
    }
}
