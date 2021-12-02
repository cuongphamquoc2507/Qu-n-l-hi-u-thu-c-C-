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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            capnhat_thongtinnhanvienn nv = new capnhat_thongtinnhanvienn();
            nv.Show();
        }

        private void thuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            thongtin_thuoc_capnhat tt = new thongtin_thuoc_capnhat();
            tt.Show();
        }

        private void hóaĐơnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            hoadon h = new hoadon();
            h.Show();
        }

        private void chứcNăngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timthuoc_xuathoadon tl = new timthuoc_xuathoadon();
            tl.Show();
            MessageBox.Show("Welcome to form TÌM KIẾM");
        }

        private void thuốcToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void hóaĐơnXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            hoadon h = new hoadon();
            h.Show();
            MessageBox.Show("Welcome to form HÓA ĐƠN XUẤT");
            
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hoa_don_nhap h = new hoa_don_nhap();
            h.Show();
            MessageBox.Show("Welcome to form HÓA ĐƠN NHẬP");
        }

        private void hóaĐơnNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            hoa_don_nhap h = new hoa_don_nhap();
            h.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
