using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CuaHangVatTuNongNghiep
{
    public class HangHoa
    {
        private int maHangHoa;
        private string tenHang;
        private float giaNiemYet;
        private string dvt;
        private byte[] hinhAnh;
        private int maLoai;

        public HangHoa() { }

        public HangHoa(int maHangHoa, string tenHang)
        {
            this.maHangHoa = maHangHoa;
            this.tenHang = tenHang;
        }

        public HangHoa(int maHangHoa, string tenHang, float giaNiemYet, string dvt, byte[] hinhAnh, int maLoai)
        {
            this.MaHangHoa = maHangHoa;
            this.TenHang = tenHang;
            this.GiaNiemYet = giaNiemYet;
            this.Dvt = dvt;
            this.HinhAnh = hinhAnh;
            this.MaLoai = maLoai;
        }

        public int MaHangHoa { get => maHangHoa; set => maHangHoa = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public float GiaNiemYet { get => giaNiemYet; set => giaNiemYet = value; }
        public string Dvt { get => dvt; set => dvt = value; }
        public byte[] HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public int MaLoai { get => maLoai; set => maLoai = value; }
    }
}
