using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hieuthuoc_QuocCuong
{
    [Serializable]
    class thuoc
    {
        public string ma_thuoc { get; set; }
        public string ma_nhom { get; set; }
        public string ten_thuoc { get; set; }
        public string cong_dung { get; set; }
        public string thanh_phan { get; set; }
        public string don_vi_tinh { get; set; }
        public string xuat_xu { get; set; }
        public int gia_ban { get; set; }
        public int so_luong { get; set; }
        public thuoc()
        {

        }
        public thuoc(string mt, string mn, string tt, string cd, string tp, string dvt, string xx, int gb, int sl)
        {
            this.ma_thuoc = mt;
            this.ma_nhom = mn;
            this.ten_thuoc = tt;
            this.cong_dung = cd;
            this.thanh_phan = tp;
            this.don_vi_tinh = dvt;
            this.xuat_xu = xx;
            this.gia_ban = gb;
            this.so_luong = sl;
        }
    }
}
