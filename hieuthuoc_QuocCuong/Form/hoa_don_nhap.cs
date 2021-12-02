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
    public partial class hoa_don_nhap : Form
    {
        public hoa_don_nhap()
        {
            InitializeComponent();
        }
        databtl1 d = new databtl1();
        private void hoa_don_nhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hIeuThuoc_QuocCuongDataSet5.hoadonnhap' table. You can move, or remove it, as needed.
            this.hoadonnhapTableAdapter2.Fill(this.hIeuThuoc_QuocCuongDataSet5.hoadonnhap);
            // TODO: This line of code loads data into the 'hIeuThuoc_QuocCuongDataSet4.chitiethoadonnhap' table. You can move, or remove it, as needed.
            this.chitiethoadonnhapTableAdapter4.Fill(this.hIeuThuoc_QuocCuongDataSet4.chitiethoadonnhap);
            //// TODO: This line of code loads data into the 'hieu_thuocDataSet11.hoadonnhap' table. You can move, or remove it, as needed.
            //this.hoadonnhapTableAdapter1.Fill(this.hieu_thuocDataSet11.hoadonnhap);
            //// TODO: This line of code loads data into the 'hieu_thuocDataSet10.chitiethoadonnhap' table. You can move, or remove it, as needed.
            //this.chitiethoadonnhapTableAdapter3.Fill(this.hieu_thuocDataSet10.chitiethoadonnhap);
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }
        private void hien()
        {
            DataChiTietNhap.DataSource = d.CThoadon_nhapt();

        }
        private void hien2()
        {
            dataHDnhap.DataSource = d.hoadonnhap();

        }
        private void btnTHEM_Click(object sender, EventArgs e)
        {
            HD_nhap hdn = new HD_nhap();
            hdn.so_chung_tu_nhap = txtChungTuNhap.Text;
            hdn.ma_thuoc = txtMaThu.Text;
            hdn.don_gia_von = int.Parse(txtDongiaV.Text);
            hdn.so_luong_nhap = int.Parse(txtSoluongN.Text);
            d.themCT_hdn(hdn);
            hien();
            hien2();
            xoatext();
        }

        private void btnXOa_Click(object sender, EventArgs e)
        {

            string so_chung_tu_nhap = txtChungTuNhap.Text;
            d.xoa_CTN(so_chung_tu_nhap);
            MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo);
            hien();
            xoatext();
        }

        private void btnTH_Click(object sender, EventArgs e)
        {
            HD_nhap_2 hn = new HD_nhap_2();
            hn.so_chung_tu_nhap = txt_soctNHAP.Text;
            hn.ma_NV = txt_maNV.Text;
            hn.ngay_gio_nhap = Convert.ToDateTime(datetimeNn.Text);
            hn.ten_nha_cung_cap = txt_nhacc.Text;
            hn.tong_tien_nhap = 0;
            d.them_hoadonnhap(hn);
            hien2();
            xoatext();
        }

        private void btnX_Click(object sender, EventArgs e)
        {

            string so_chung_tu_nhap = txt_soctNHAP.Text;
            MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo);
            d.xoahoadonnhap(so_chung_tu_nhap);
            hien2();
            xoatext();
        }

        private void btnXuatfile_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel._Workbook wr = app.Workbooks.Add(Type.Missing);

            Microsoft.Office.Interop.Excel._Worksheet ws = null;
            ws = wr.Sheets["sheet1"];
            ws = wr.ActiveSheet;
            app.Visible = true;
            ws.Cells[1, 3] = "Hoa don nhap ";

            ws.Cells[2, 2] = "Số chứng từ nhap ";
            ws.Cells[2, 3] = "Ma nv ";
            ws.Cells[2, 4] = "Ngày nhập ";
            ws.Cells[2, 5] = "Tên nhà cung cấp ";
            ws.Cells[2, 6] = "Tổng tiền nhập";
            for (int i = 0; i < dataHDnhap.RowCount - 1; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    ws.Cells[i + 3, j + 2] = dataHDnhap.Rows[i].Cells[j].Value;
                }
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel._Workbook wr = app.Workbooks.Add(Type.Missing);

            Microsoft.Office.Interop.Excel._Worksheet ws = null;
            ws = wr.Sheets["sheet1"];
            ws = wr.ActiveSheet;
            app.Visible = true;
            ws.Cells[1, 3] = "Chi tiết hoa don nhap ";

            ws.Cells[2, 2] = "Số chứng từ nhap ";
            ws.Cells[2, 3] = "Mã thuốc ";
            ws.Cells[2, 4] = "Đơn giá vốn ";
            ws.Cells[2, 5] = "Số lượng nhập ";
            
            for (int i = 0; i <DataChiTietNhap.RowCount - 1; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    ws.Cells[i + 3, j + 2] = DataChiTietNhap.Rows[i].Cells[j].Value;
                }
            }
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

        private void thuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            thongtin_thuoc_capnhat t = new thongtin_thuoc_capnhat();
            t.Show();
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
            hoa_don_nhap hd = new hoa_don_nhap();
            hd.Show();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            main m = new main();
            m.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFIxx_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void xoatext()
        {
            txtChungTuNhap.Clear();
            txtDongiaV.Clear();
            txtMaThu.Clear();
            txtSoluongN.Clear();
            txt_maNV.Clear();
            txt_nhacc.Clear();
            txt_soctNHAP.Clear();
        }
    }
}
