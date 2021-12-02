using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace hieuthuoc_QuocCuong
{
    public partial class hoadon : Form
    {
        databtl1 d = new databtl1();
        public hoadon()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hoadon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hIeuThuoc_QuocCuongDataSet10.thuoc' table. You can move, or remove it, as needed.
            this.thuocTableAdapter.Fill(this.hIeuThuoc_QuocCuongDataSet10.thuoc);
            // TODO: This line of code loads data into the 'hIeuThuoc_QuocCuongDataSet2.hoadonxuat' table. You can move, or remove it, as needed.
            this.hoadonxuatTableAdapter1.Fill(this.hIeuThuoc_QuocCuongDataSet2.hoadonxuat);
            // TODO: This line of code loads data into the 'hIeuThuoc_QuocCuongDataSet1.chitiethoadonxuat' table. You can move, or remove it, as needed.
            this.chitiethoadonxuatTableAdapter2.Fill(this.hIeuThuoc_QuocCuongDataSet1.chitiethoadonxuat);
            // TODO: This line of code loads data into the 'hIeuThuoc_QuocCuongDataSet.chitiethoadonxuat' table. You can move, or remove it, as needed.
            this.chitiethoadonxuatTableAdapter1.Fill(this.hIeuThuoc_QuocCuongDataSet.chitiethoadonxuat);
            // TODO: This line of code loads data into the 'hieu_thuocDataSet5.chitiethoadonxuat' table. You can move, or remove it, as needed.
           

        }
        private void hien()
        {
            DataChiTiet.DataSource = d.CThoadon_xuat();
            
        }
       
        private void hien_benlaphd()
        {
            dataLap.DataSource = d.hoadonxuat();
        }
        public void xoatxt()
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ///khoi tao Ex
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel._Workbook wr = app.Workbooks.Add(Type.Missing);

            Microsoft.Office.Interop.Excel._Worksheet ws = null;
            ws = wr.Sheets["sheet1"];
            ws = wr.ActiveSheet;
            app.Visible = true;
            ws.Cells[1, 3] = "Hoa don xuat ";

            ws.Cells[2, 2] = "Số chứng từ xuất ";
            ws.Cells[2, 3] = "Ma nv ";
            ws.Cells[2, 4] = "Ngày ";
            ws.Cells[2, 5] = "Tổng tiền ";
            for (int i = 0; i < dataLap.RowCount - 1; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    ws.Cells[i + 3, j + 2] = dataLap.Rows[i].Cells[j].Value;
                }
            }
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            hoadonxuat1 hdx = new hoadonxuat1();
            hdx.so_chung_tu_xuat = txtChungTuXuat.Text;
            hdx.ma_thuoc = txtMaThuoc.Text;
            hdx.don_gia_ban = int.Parse(txtDongia.Text);
            hdx.so_luong_xuat = int.Parse(txtSoluong.Text);
            d.themCT_hdx(hdx);
            hien();
            hien_benlaphd();
            xoatext();
        }

        private void btnFix_Click(object sender, EventArgs e)
        {

        }

        private void btnXOa_Click(object sender, EventArgs e)
        {
            string so_chung_tu_xuat = txtChungTuXuat.Text;
            MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo);
            d.xoa_CTX(so_chung_tu_xuat);
            hien();
            xoatext();
        }

        private void btnTH_Click(object sender, EventArgs e)
        {
            hoadonxuat2 hdx2 = new hoadonxuat2();
            hdx2.so_chung_tu_xuat =sochungtuX_txt.Text;
            hdx2.ma_NV = manv_txt.Text;
            hdx2.ngay_gio_xuat = Convert.ToDateTime(datetime.Text);
            hdx2.tong_tien_ban = 0;
            d.themhoadonxuat(hdx2);
            hien();
            hien_benlaphd();
            xoatext();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            string so_chung_tu_xuat = sochungtuX_txt.Text;
            MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo);
            d.xoahoadonxuat(so_chung_tu_xuat);
            hien_benlaphd();
            xoatext();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void lậpHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void xuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            hoadon h = new hoadon();
            h.Show();
        }

        private void nhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            hoa_don_nhap h = new hoa_don_nhap();
            h.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
          
            Dangnhap d = new Dangnhap();
            d.Show();
        }
        public void xoatext()
        {
            txtChungTuXuat.Clear();
            txtDongia.Clear();
            txtMaThuoc.Clear();
            txtSoluong.Clear();
            manv_txt.Clear();
            sochungtuX_txt.Clear();
            
        }

        private void btnXu_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel._Workbook wr = app.Workbooks.Add(Type.Missing);

            Microsoft.Office.Interop.Excel._Worksheet ws = null;
            ws = wr.Sheets["sheet1"];
            ws = wr.ActiveSheet;
            app.Visible = true;
            ws.Cells[1, 3] = "Chi tiết hóa đơn xuất ";

            ws.Cells[2, 2] = "Số chứng từ xuất ";
            ws.Cells[2, 3] = "Mã thuốc ";
            ws.Cells[2, 4] = "Đơn giá bán ";
            ws.Cells[2, 5] = "Số lượng bán ";
            for (int i = 0; i < DataChiTiet.RowCount - 1; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    ws.Cells[i + 3, j + 2] = DataChiTiet.Rows[i].Cells[j].Value;
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            String ten_thuoc = txtNhap.Text;
            DataTable tt = d.tim_thuoc_theo_ten(ten_thuoc);
            Thong_tin_thuoc.DataSource = tt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
