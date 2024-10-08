using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CuaHangVatTuNongNghiep
{
    public class NhanVien
    {
        private int maNV;
        private string tenNV;
        private string gioiTinh;
        private string emailNV;
        private string diaChiNV;
        private string sdtNV;
        private string chucVu;
        private string tenDangNhap;
        private string matKhau;

        public NhanVien(string tenDangNhap, string matKhau)
        {
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
        }

        public NhanVien(int maNV, string tenNV, string gioiTinh, string emailNV, string diaChiNV, string sdtNV, string chucVu, string tenDangNhap, string matKhau)
        {
            this.MaNV = maNV;
            this.TenNV = tenNV;
            this.GioiTinh = gioiTinh;
            this.EmailNV = emailNV;
            this.DiaChiNV = diaChiNV;
            this.SdtNV = sdtNV;
            this.ChucVu = chucVu;
            this.TenDangNhap = tenDangNhap;
            this.MatKhau = matKhau;
        }

        public int MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string EmailNV { get => emailNV; set => emailNV = value; }
        public string DiaChiNV { get => diaChiNV; set => diaChiNV = value; }
        public string SdtNV { get => sdtNV; set => sdtNV = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
    }
}
