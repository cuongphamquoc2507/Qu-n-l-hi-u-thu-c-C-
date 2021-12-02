using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hieuthuoc_QuocCuong
{
    [Serializable]
    class hoadonxuat1
    {
        public string so_chung_tu_xuat { get; set; }
        public string ma_thuoc { get; set; }
        public int don_gia_ban { get; set; }
        public int so_luong_xuat { get; set; }
        public hoadonxuat1()
        {

        }
        public hoadonxuat1(string sctx, string ma_t, int dgb, int slx)
        {
            this.so_chung_tu_xuat = sctx;
            this.ma_thuoc = ma_t;
            this.don_gia_ban = dgb;
            this.so_luong_xuat = slx;
        }
    }
}
