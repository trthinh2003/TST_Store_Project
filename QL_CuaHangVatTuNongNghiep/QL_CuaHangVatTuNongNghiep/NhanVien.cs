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
        private string emailNV;
        private string diaChiNV;
        private string sdtNV;
        private bool gioiTinh;
        private string chucVu;

        public NhanVien() { }
        public NhanVien(int maNV, string tenNV, string emailNV, string diaChiNV, string sdtNV, bool gioiTinh, string chucVu)
        {
            this.MaNV = maNV;
            this.TenNV = tenNV;
            this.EmailNV = emailNV;
            this.DiaChiNV = diaChiNV;
            this.SdtNV = sdtNV;
            this.GioiTinh = gioiTinh;
            this.ChucVu = chucVu;
        }

        public int MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string EmailNV { get => emailNV; set => emailNV = value; }
        public string DiaChiNV { get => diaChiNV; set => diaChiNV = value; }
        public string SdtNV { get => sdtNV; set => sdtNV = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
    }
}
