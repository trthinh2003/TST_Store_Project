using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CuaHangVatTuNongNghiep
{
    public class KhachHang
    {
        private int maKH;
        private string tenKH;
        private string sdt;
        private string email;
        private string diaChi;

        public KhachHang()
        {
            this.maKH = 0;
            this.tenKH = "";
            this.sdt = "";
            this.email = "";
            this.diaChi = "";
        }

        public int MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
    }
}
