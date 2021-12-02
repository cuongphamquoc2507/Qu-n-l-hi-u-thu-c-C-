using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hieuthuoc_QuocCuong
{
    class HD_nhap_2
    {
        public string  so_chung_tu_nhap{ get; set; }
        public string ma_NV { get; set; }
        public DateTime ngay_gio_nhap { get; set; }
        public string ten_nha_cung_cap { get; set; }
        public int tong_tien_nhap { get; set; }
        public HD_nhap_2()
        {

        }
        public HD_nhap_2(string c)
        {
            this.so_chung_tu_nhap = c;
        }
    }
}
