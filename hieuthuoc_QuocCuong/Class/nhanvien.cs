using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hieuthuoc_QuocCuong
{
    [Serializable]
    class nhanvien
    {
        public string ma_NV { get; set; }
        public string ho_ten { get; set; }
        public string chuc_vu { get; set; }
        public string gioi_tinh { get; set; }
        public int tuoi { get; set; }
        public string dia_chi { get; set; }
        public string email { get; set; }
        public string so_dt { get; set; }
        
        public string ten_dang_nhap { get; set; }
        public string mat_khau { get; set; }
        public nhanvien()
        {

        }
        public nhanvien(string mnv, string ht, string cv, string gt, int tuoi, string dc, string m, string dt, string pq, string un, string p)
        {
            this.ma_NV = mnv;
            this.ho_ten = ht;
            this.chuc_vu = cv;
            this.gioi_tinh = gt;
            this.tuoi = tuoi;
            this.dia_chi = dc;
            this.email = m;
            this.so_dt = dt;
            
            this.ten_dang_nhap = un;
            this.mat_khau = p;
        }
    }
}
