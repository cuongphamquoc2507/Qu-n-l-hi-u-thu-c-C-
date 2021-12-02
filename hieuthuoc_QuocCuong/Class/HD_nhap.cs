using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hieuthuoc_QuocCuong
{
    class HD_nhap
    {
        public string so_chung_tu_nhap{ get; set; }
        public string ma_thuoc { get; set; }
        public int don_gia_von { get; set; }
        public  int so_luong_nhap { get; set; }
        public HD_nhap()
        {

        }
        public HD_nhap(string cn)
        {
            this.so_chung_tu_nhap = cn;
        }
    }
}
