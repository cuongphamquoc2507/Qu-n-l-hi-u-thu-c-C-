using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace hieuthuoc_QuocCuong
{
    class databtl1
    {
        SqlConnection con;
        public databtl1()
        {
            string strconnect = @"Data Source=DESKTOP-MCA4FUJ\MSSQLSERVER02;Initial Catalog=HIeuThuoc_QuocCuong;Integrated Security=True";
            con = new SqlConnection(strconnect);
        }
        //bảng nhân viên
        public DataTable nhanvien()
        {
            DataTable table = new DataTable();
            string sql = "select * from nhanvien";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;

        }

        public void themnhanvien(nhanvien s)
        {

            con.Open();
            string sql = "insert into nhanvien values(@ma_NV,@ho_ten,@chuc_vu,@gioi_tinh,@tuoi,@dia_chi,@email,@so_dt, @ten_dang_nhap,@mat_khau)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("ma_NV", s.ma_NV);
            cmd.Parameters.AddWithValue("ho_ten", s.ho_ten);
            cmd.Parameters.AddWithValue("chuc_vu", s.chuc_vu);
            cmd.Parameters.AddWithValue("gioi_tinh", s.gioi_tinh);
            cmd.Parameters.AddWithValue("tuoi", s.tuoi);
            cmd.Parameters.AddWithValue("dia_chi", s.dia_chi);
            cmd.Parameters.AddWithValue("email", s.email);
            cmd.Parameters.AddWithValue("so_dt", s.so_dt);
            cmd.Parameters.AddWithValue("ten_dang_nhap", s.ten_dang_nhap);
            cmd.Parameters.AddWithValue("mat_khau", s.mat_khau);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void xoa(string ma_NV)
        {
            con.Open();
            string sql = "delete from nhanvien where ma_NV = @ma_NV";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("ma_NV", ma_NV);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void suanhanvien(nhanvien s)
        {

            con.Open();
            string sql = "update nhanvien set  ho_ten=@ho_ten, chuc_vu=@chuc_vu, gioi_tinh=@gioi_tinh, tuoi=@tuoi, dia_chi=@dia_chi, email = @email, so_dt=@so_dt, ten_dang_nhap=@ten_dang_nhap, mat_khau=@mat_khau where ma_NV=@ma_NV";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("ma_NV", s.ma_NV);
            cmd.Parameters.AddWithValue("ho_ten", s.ho_ten);
            cmd.Parameters.AddWithValue("chuc_vu", s.chuc_vu);
            cmd.Parameters.AddWithValue("gioi_tinh", s.gioi_tinh);
            cmd.Parameters.AddWithValue("tuoi", s.tuoi);
            cmd.Parameters.AddWithValue("dia_chi", s.dia_chi);
            cmd.Parameters.AddWithValue("email", s.email);
            cmd.Parameters.AddWithValue("so_dt", s.so_dt);
            cmd.Parameters.AddWithValue("ten_dang_nhap", s.ten_dang_nhap);
            cmd.Parameters.AddWithValue("mat_khau", s.mat_khau);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        ///thuốc
        public DataTable thuoc()
        {
            DataTable t = new DataTable();
            string sq = "select * from thuoc";
            SqlDataAdapter ad = new SqlDataAdapter(sq, con);
            ad.Fill(t);
            con.Close();
            return t;

        }
        public void themthuoc(thuoc t)
        {
            con.Open();
            string sql = "insert into thuoc values(@ma_thuoc,@ma_nhom,@ten_thuoc,@cong_dung,@thanh_phan,@don_vi_tinh,@xuat_xu,@gia_ban,@so_luong)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("ma_thuoc", t.ma_thuoc);
            cmd.Parameters.AddWithValue("ma_nhom", t.ma_nhom);
            cmd.Parameters.AddWithValue("ten_thuoc", t.ten_thuoc);
            cmd.Parameters.AddWithValue("cong_dung", t.cong_dung);
            cmd.Parameters.AddWithValue("thanh_phan", t.thanh_phan);
            cmd.Parameters.AddWithValue("don_vi_tinh", t.don_vi_tinh);
            cmd.Parameters.AddWithValue("xuat_xu", t.xuat_xu);
            cmd.Parameters.AddWithValue("gia_ban", t.gia_ban);
            cmd.Parameters.AddWithValue("so_luong", t.so_luong);

            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void suathuoc(thuoc s)
        {

            con.Open();
            string sql = "update thuoc set ma_thuoc=@ma_thuoc, ma_nhom=@ma_nhom, ten_thuoc = @ten_thuoc, cong_dung=@cong_dung,thanh_phan=@thanh_phan, don_vi_tinh = @don_vi_tinh, xuat_xu = @xuat_xu, gia_ban = @gia_ban, so_luong = @so_luong where ma_thuoc=@ma_thuoc";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("ma_thuoc", s.ma_thuoc);
            cmd.Parameters.AddWithValue("ma_nhom", s.ma_nhom);
            cmd.Parameters.AddWithValue("ten_thuoc", s.ten_thuoc);
            cmd.Parameters.AddWithValue("cong_dung", s.cong_dung);
            cmd.Parameters.AddWithValue("thanh_phan", s.thanh_phan);
            cmd.Parameters.AddWithValue("don_vi_tinh", s.don_vi_tinh);
            cmd.Parameters.AddWithValue("xuat_xu", s.xuat_xu);
            cmd.Parameters.AddWithValue("gia_ban", s.gia_ban);
            cmd.Parameters.AddWithValue("so_luong", s.so_luong);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void xoathuoc(string ma_thuoc)
        {
            con.Open();
            string sql = "delete from thuoc where ma_thuoc = @ma_thuoc";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("ma_thuoc", ma_thuoc);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable tim_thuoc_theo_ten(string ten_thuoc)
        {
            con.Open();
            DataTable t = new DataTable();
            string sql = "select *from thuoc where ten_thuoc like N'%" + ten_thuoc + "%'";
            SqlDataAdapter a = new SqlDataAdapter(sql, con);
            a.Fill(t);
            con.Close();
            return t;

        }
        public DataTable tim_thuoc_theo_ma(string ma_thuoc)
        {
            con.Open();
            DataTable t = new DataTable();
            string sql = "select *from thuoc where ma_thuoc like N'%" +ma_thuoc + "%'";
            SqlDataAdapter a = new SqlDataAdapter(sql, con);
            a.Fill(t);
            con.Close();
            return t;

        }
        public DataTable tim_thuoc_theo_cd(string cong_dung)
        {
            con.Open();
            DataTable t = new DataTable();
            string sql = "select *from thuoc where cong_dung like N'%" + cong_dung + "%'";
            SqlDataAdapter a = new SqlDataAdapter(sql, con);
            a.Fill(t);
            con.Close();
            return t;

        }
        public DataTable timnv_ten(string ho_ten)
        {
            con.Open();
            DataTable t = new DataTable();
            string sql = "select *from nhanvien where ho_ten like N'%" + ho_ten + "%'";
            SqlDataAdapter a = new SqlDataAdapter(sql, con);
            a.Fill(t);
            con.Close();
            return t;

        }
        public DataTable timnv_tuoi(int tuoi)
        {
            con.Open();
            DataTable t = new DataTable();
            string sql = "select *from nhanvien where tuoi like N'%" + tuoi + "%'";
            SqlDataAdapter a = new SqlDataAdapter(sql, con);
            a.Fill(t);
            con.Close();
            return t;

        }
        public DataTable timnv_Gt(string gioi_tinh)
        {
            con.Open();
            DataTable t = new DataTable();
            string sql = "select *from nhanvien where gioi_tinh like N'%" + gioi_tinh + "%'";
            SqlDataAdapter a = new SqlDataAdapter(sql, con);
            a.Fill(t);
            con.Close();
            return t;

        }
        //làm việc với bảng chi tiết hóa đơn
        public DataTable CThoadon_xuat()
        {
            DataTable table = new DataTable();
            string sql = "select * from chitiethoadonxuat";
           
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;

        }
        public void themCT_hdx(hoadonxuat1 h)
        {
            con.Open();
            string sql = "insert into chitiethoadonxuat values(@so_chung_tu_xuat,@ma_thuoc,@don_gia_ban,@so_luong_xuat)";
           
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("so_chung_tu_xuat", h.so_chung_tu_xuat);
            cmd.Parameters.AddWithValue("ma_thuoc", h.ma_thuoc);
            cmd.Parameters.AddWithValue("don_gia_ban", h.don_gia_ban);
            cmd.Parameters.AddWithValue("so_luong_xuat", h.so_luong_xuat);
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            string s = "update hoadonxuat SET tong_tien_ban = (Select SUM(don_gia_ban * so_luong_xuat) FROM chitiethoadonxuat where so_chung_tu_xuat = hoadonxuat.so_chung_tu_xuat)";
            SqlCommand cm = new SqlCommand(s, con);
            cm.ExecuteNonQuery();
            con.Close();

        }
        public void xoa_CTX(string so_chung_tu_xuat)
        {
            con.Open();
            string sql = "delete from chitiethoadonxuat where so_chung_tu_xuat = @so_chung_tu_xuat";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("so_chung_tu_xuat", so_chung_tu_xuat);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //lam viec với bên lập hóa đơn
        public DataTable hoadonxuat()
        {
            DataTable table = new DataTable();
            string sql = "select * from hoadonxuat";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }
        public void themhoadonxuat(hoadonxuat2 s)
        {

            con.Open();

            string sql = "insert into hoadonxuat values(@so_chung_tu_xuat,@ma_NV,@ngay_gio_xuat,@tong_tien_ban)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("so_chung_tu_xuat", s.so_chung_tu_xuat);
            cmd.Parameters.AddWithValue("ma_NV", s.ma_NV);
            cmd.Parameters.AddWithValue("ngay_gio_xuat", s.ngay_gio_xuat);
            cmd.Parameters.AddWithValue("tong_tien_ban", s.tong_tien_ban);
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            //nhập xong tự tính tổng
            string sql1 = "update hoadonxuat set tong_tien_ban = (select SUM(don_gia_ban * so_luong_xuat) from chitiethoadonxuat where so_chung_tu_xuat = hoadonxuat.so_chung_tu_xuat)";
            SqlCommand cm1 = new SqlCommand(sql1, con);
            cm1.ExecuteNonQuery();
            con.Close();

        }
        public void xoahoadonxuat(string so_chung_tu_xuat)
        {
            con.Open();
            string sql = "delete from hoadonxuat where so_chung_tu_xuat = @so_chung_tu_xuat";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("so_chung_tu_xuat", so_chung_tu_xuat);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //làm bảng chi tiết hóa dơn nhập
        public DataTable CThoadon_nhapt()
        {
            DataTable table = new DataTable();
            string sql = "select * from chitiethoadonnhap";

            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;

        }
        public void themCT_hdn(HD_nhap h)
        {
            con.Open();
            string sql = "insert into chitiethoadonnhap values(@so_chung_tu_nhap,@ma_thuoc,@don_gia_von,@so_luong_nhap)";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("so_chung_tu_nhap", h.so_chung_tu_nhap);
            cmd.Parameters.AddWithValue("ma_thuoc", h.ma_thuoc);
            cmd.Parameters.AddWithValue("don_gia_von", h.don_gia_von);
            cmd.Parameters.AddWithValue("so_luong_nhap", h.so_luong_nhap);
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            string s = "update hoadonnhap SET tong_tien_nhap = (Select SUM(don_gia_von * so_luong_nhap) FROM chitiethoadonnhap where so_chung_tu_nhap = hoadonnhap.so_chung_tu_nhap)";
            SqlCommand cm = new SqlCommand(s, con);
            cm.ExecuteNonQuery();
            con.Close();

        }
        public void sua_cthdn(HD_nhap h)
        {
          
        }
        public void xoa_CTN(string so_chung_tu_nhap)
        {
            con.Open();
            string sql = "delete from chitiethoadonnhap where so_chung_tu_nhap = @so_chung_tu_nhap";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("so_chung_tu_nhap", so_chung_tu_nhap);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable hoadonnhap()
        {
            DataTable table = new DataTable();
            string sql = "select * from hoadonnhap";
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(table);
            con.Close();
            return table;
        }
        public void them_hoadonnhap(HD_nhap_2 s)
        {

            con.Open();

            string sql = "insert into hoadonnhap values(@so_chung_tu_nhap,@ma_NV,@ngay_gio_nhap,@ten_nha_cung_cap,@tong_tien_nhap)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("so_chung_tu_nhap", s.so_chung_tu_nhap);
            cmd.Parameters.AddWithValue("ma_NV", s.ma_NV);
            cmd.Parameters.AddWithValue("ngay_gio_nhap", s.ngay_gio_nhap);
            cmd.Parameters.AddWithValue("ten_nha_cung_cap", s.ten_nha_cung_cap);
            cmd.Parameters.AddWithValue("tong_tien_nhap", s.tong_tien_nhap);
            cmd.ExecuteNonQuery();
            con.Close();
            
            

        }
        public void sua_hdn(HD_nhap_2 s)
        {

            con.Open();
            string sql = "update hoadonnhap set sochungtunhap=@so_chung_tu_nhap, ma_nhan_vien = @manhanvien, ngaygionhap =@ngay_gio_nhap, ten_nha_cung_cap = @ten_nha_cung_cap, tong_tien_nhap =(select SUM(don_gia_von * soluongnhap) from chitiethoadonnhap where sochungtunhap = hoadonnhap.sochungtunhap) where sochungtunhap=@sochungtunhap";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("sochungtunhap", s.so_chung_tu_nhap);
            cmd.Parameters.AddWithValue("ma_NV", s.ma_NV);
            cmd.Parameters.AddWithValue("ngay_gio_nhap", s.ngay_gio_nhap);
            cmd.Parameters.AddWithValue("ten_nha_cung_cap", s.ten_nha_cung_cap);
            cmd.Parameters.AddWithValue("tong_tien_nhap", s.tong_tien_nhap);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void xoahoadonnhap(string so_chung_tu_nhap)
        {
            con.Open();
            string sql = "delete from hoadonnhap where so_chung_tu_nhap = @so_chung_tu_nhap";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("so_chung_tu_nhap", so_chung_tu_nhap);
            cmd.ExecuteNonQuery();
            con.Close();
        }




    }
}
