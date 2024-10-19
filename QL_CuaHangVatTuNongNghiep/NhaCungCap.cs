using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CuaHangVatTuNongNghiep
{
    public class NhaCungCap
    {
        private int maNhaCungCap;
        private string tenNhaCungCap;

        public NhaCungCap(int maNhaCungCap, string tenNhaCungCap)
        {
            this.MaNhaCungCap = maNhaCungCap;
            this.TenNhaCungCap = tenNhaCungCap;
        }

        public int MaNhaCungCap { get => maNhaCungCap; set => maNhaCungCap = value; }
        public string TenNhaCungCap { get => tenNhaCungCap; set => tenNhaCungCap = value; }
    }
}
