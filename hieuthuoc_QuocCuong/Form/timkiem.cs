using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hieuthuoc_QuocCuong
{
    public partial class timthuoc_xuathoadon : Form
    {
        databtl1 d = new databtl1();
        public timthuoc_xuathoadon()
        {
            InitializeComponent();
        }

        private void timthuoc_xuathoadon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hIeuThuoc_QuocCuongDataSet8.nhanvien' table. You can move, or remove it, as needed.
            this.nhanvienTableAdapter1.Fill(this.hIeuThuoc_QuocCuongDataSet8.nhanvien);
            // TODO: This line of code loads data into the 'hIeuThuoc_QuocCuongDataSet7.thuoc' table. You can move, or remove it, as needed.
            this.thuocTableAdapter1.Fill(this.hIeuThuoc_QuocCuongDataSet7.thuoc);
            // TODO: This line of code loads data into the 'hieu_thuocDataSet3.nhanvien' table. You can move, or remove it, as needed.
            this.nhanvienTableAdapter.Fill(this.hieu_thuocDataSet3.nhanvien);
            // TODO: This line of code loads data into the 'hieu_thuocDataSet2.thuoc' table. You can move, or remove it, as needed.
            this.thuocTableAdapter.Fill(this.hieu_thuocDataSet2.thuoc);


        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            

            if (cbTim.Text == "Theo tên")
            {
                String ten_thuoc = txtNhapthongtin.Text;
                DataTable t = d.tim_thuoc_theo_ten(ten_thuoc);
                dataTimKiem.DataSource = t;
            }
            if (cbTim.Text == "Theo công dụng")
            {
                string cong_dung = txtNhapthongtin.Text;             
                DataTable ta = d.tim_thuoc_theo_cd(cong_dung);
                dataTimKiem.DataSource = ta;
            }
        }

        private void btnHienthilai_Click(object sender, EventArgs e)
        {
            dataTimKiem.DataSource = d.thuoc();
        }

        private void btnTimK_Click(object sender, EventArgs e)
        {
            if (cbPhuongthuc.Text == "Tên")
            {
                String ho_ten = txtThongT.Text;
                DataTable tt = d.timnv_ten(ho_ten);
                dataNv.DataSource = tt;
            }
            if (cbPhuongthuc.Text == "Tuổi")
            {
                int tuoi = int.Parse(txtThongT.Text);
                DataTable tb = d.timnv_tuoi(tuoi);
                dataNv.DataSource = tb;
            }
            if (cbPhuongthuc.Text == "Giới tính")
            {
                string gioi_tinh = txtThongT.Text;
                DataTable gt = d.timnv_Gt(gioi_tinh);
                dataNv.DataSource = gt;
            }
        }

        private void thuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongtin_thuoc_capnhat t = new thongtin_thuoc_capnhat();
            t.Show();

        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timthuoc_xuathoadon tk = new timthuoc_xuathoadon();
            tk.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capnhat_thongtinnhanvienn c = new capnhat_thongtinnhanvienn();
            c.Show();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dataNv.DataSource = d.nhanvien();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void lậpHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hoa_don_nhap n = new hoa_don_nhap();
            n.Show();
        }

        private void xuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hoadon h = new hoadon();
            h.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
         
            Dangnhap d = new Dangnhap();
            d.Show();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main m = new main();
            m.Show();
        }
    }
}
