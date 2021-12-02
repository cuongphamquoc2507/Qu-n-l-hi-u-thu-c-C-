using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hieuthuoc_QuocCuong
{
    class hoadonxuat2
    {
        public string so_chung_tu_xuat { get; set; }
        public string ma_NV { get; set; }
        public DateTime ngay_gio_xuat { get; set; }
        public int tong_tien_ban { get; set; }
        public hoadonxuat2()
        {

        }
        public hoadonxuat2(string sx)
        {
            this.so_chung_tu_xuat = sx;

        }

    }
}
