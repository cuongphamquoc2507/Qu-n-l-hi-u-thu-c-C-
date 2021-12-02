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
    public partial class capnhat_thongtinnhanvienn : Form
    {
        databtl1 data = new databtl1();
        public capnhat_thongtinnhanvienn()
        {
            InitializeComponent();
        }

        private void capnhat_thongtinnhanvienn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hIeuThuoc_QuocCuongDataSet3.nhanvien' table. You can move, or remove it, as needed.
            this.nhanvienTableAdapter1.Fill(this.hIeuThuoc_QuocCuongDataSet3.nhanvien);
            


        }
        private void hienthi()
        {
            dataGridView1.DataSource = data.nhanvien();
        }
        public void xoatxt()
        {
            txtMa.Clear();
            txtHoten.Clear();
            txtChuc.Clear();
            txtdiachi.Clear();
            txtMail.Clear();
            txtPhone.Clear();
            txtTuoi.Clear();

        }
        private void btnADd_Click(object sender, EventArgs e)
        {
            nhanvien s = new nhanvien();
            s.ma_NV = txtMa.Text;
            s.ho_ten = txtHoten.Text;
            s.chuc_vu = txtChuc.Text;
            s.gioi_tinh = cbGioitinh.Text;
            s.tuoi = Convert.ToInt32(txtTuoi.Text);
            s.dia_chi = txtdiachi.Text;
            s.email = txtMail.Text;
            s.so_dt = txtPhone.Text;
            s.ten_dang_nhap = "cuong";
            s.mat_khau = "12345";

            data.themnhanvien(s);
            
            xoatxt();
            hienthi();
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string ma_NV = txtMa.Text;
                MessageBox.Show("Bạn có muốn xóa","Thông báo",MessageBoxButtons.YesNo);
                data.xoa(ma_NV);
                xoatxt();
                hienthi();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi xoá" + ex.Message, "Thông báo");

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d;
            d = e.RowIndex;
            txtMa.Enabled = true;

            txtMa.Text = dataGridView1.Rows[d].Cells[0].Value.ToString();
            txtHoten.Text = dataGridView1.Rows[d].Cells[1].Value.ToString();
            txtChuc.Text = dataGridView1.Rows[d].Cells[2].Value.ToString();
            cbGioitinh.Text = dataGridView1.Rows[d].Cells[3].Value.ToString();
            txtTuoi.Text = dataGridView1.Rows[d].Cells[4].Value.ToString();
            txtdiachi.Text = dataGridView1.Rows[d].Cells[5].Value.ToString();
            txtMail.Text = dataGridView1.Rows[d].Cells[6].Value.ToString();
            txtPhone.Text = dataGridView1.Rows[d].Cells[7].Value.ToString();

        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {

            main m = new main();
            m.Show();
        }

        private void thuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            thongtin_thuoc_capnhat t = new thongtin_thuoc_capnhat();
            t.Show();
        }

        private void tìmKiếmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            timthuoc_xuathoadon tk = new timthuoc_xuathoadon();
            tk.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

            capnhat_thongtinnhanvienn c = new capnhat_thongtinnhanvienn();
            c.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            nhanvien s = new nhanvien();
            s.ma_NV = txtMa.Text;
            s.ho_ten = txtHoten.Text;
            s.chuc_vu = txtChuc.Text;
            s.gioi_tinh = cbGioitinh.Text;
            s.tuoi = Convert.ToInt32(txtTuoi.Text);
            s.dia_chi = txtdiachi.Text;
            s.email = txtMail.Text;
            s.so_dt = txtPhone.Text;
            s.ten_dang_nhap = "cuong";
            s.mat_khau = "12345";
            data.suanhanvien(s);
            hienthi();
            xoatxt();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            
            Dangnhap d = new Dangnhap();
            d.Show();
        }

        private void lậpHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

            hoadon h = new hoadon();
            h.Show(); 
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            txtChuc.Clear();
            txtdiachi.Clear();
            txtHoten.Clear();
            txtMa.Clear();
            txtMail.Clear();
            txtPhone.Clear();
            txtTuoi.Clear();
        }

        private void btnXuats_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel._Workbook wr = app.Workbooks.Add(Type.Missing);

            Microsoft.Office.Interop.Excel._Worksheet ws = null;
            ws = wr.Sheets["sheet1"];
            ws = wr.ActiveSheet;
            app.Visible = true;
            ws.Cells[1, 3] = "Danh sách nhân viên ";

            ws.Cells[2, 2] = "Mã nhân viên ";
            ws.Cells[2, 3] = "Họ tên nhân viên ";
            ws.Cells[2, 4] = "Chức vụ ";
            ws.Cells[2, 5] = "Giới tính ";
            ws.Cells[2, 6] = "Tuổi ";
            ws.Cells[2, 7] = "Địa chỉ";
            ws.Cells[2, 8] = "email ";
            ws.Cells[2, 9] = "số điện thoại ";
            ws.Cells[2, 10] = "Username ";
            ws.Cells[2, 11] = "Password ";

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    ws.Cells[i + 3, j + 2] = dataGridView1.Rows[i].Cells[j].Value;
                }
            }
        }
    }
}
