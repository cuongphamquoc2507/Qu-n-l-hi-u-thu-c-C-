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
    public partial class thongtin_thuoc_capnhat : Form
    {
        public thongtin_thuoc_capnhat()
        {
            InitializeComponent();
        }
        databtl1 d = new databtl1();
        private void thongtin_thuoc_capnhat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hIeuThuoc_QuocCuongDataSet6.thuoc' table. You can move, or remove it, as needed.
            this.thuocTableAdapter1.Fill(this.hIeuThuoc_QuocCuongDataSet6.thuoc);
            // TODO: This line of code loads data into the 'hieu_thuocDataSet1.thuoc' table. You can move, or remove it, as needed.
            this.thuocTableAdapter.Fill(this.hieu_thuocDataSet1.thuoc);

        }
        private void hien()
        {
            datathuoc.DataSource = d.thuoc();
        }
        private void btnADD_Click(object sender, EventArgs e)
        {
            thuoc t = new thuoc();
            t.ma_nhom = txtMAn.Text;
            t.ma_thuoc = txtMAt.Text;
            t.ten_thuoc = txtTent.Text;
            t.cong_dung = txtCd.Text;
            t.thanh_phan = txtTp.Text;
            t.don_vi_tinh = txtDvt.Text;
            t.gia_ban = int.Parse(txtGb.Text);
            t.so_luong = int.Parse(txtSl.Text);
            t.xuat_xu = txtXx.Text;
            d.themthuoc(t);
            
            hien();

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void datathuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int d;
            d = e.RowIndex;
            txtMAt.Enabled = true;
            
            txtMAt.Text = datathuoc.Rows[d].Cells[0].Value.ToString();
            txtMAn.Text = datathuoc.Rows[d].Cells[1].Value.ToString();
            txtTent.Text = datathuoc.Rows[d].Cells[2].Value.ToString();
            txtCd.Text = datathuoc.Rows[d].Cells[3].Value.ToString();
            txtTp.Text = datathuoc.Rows[d].Cells[4].Value.ToString();
            txtDvt.Text = datathuoc.Rows[d].Cells[5].Value.ToString();
            txtXx.Text = datathuoc.Rows[d].Cells[6].Value.ToString();
            txtGb.Text = datathuoc.Rows[d].Cells[7].Value.ToString();
            txtSl.Text = datathuoc.Rows[d].Cells[8].Value.ToString();
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            try
            {
                string ma_thuoc = txtMAt.Text;
                MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo);
                d.xoathuoc(ma_thuoc);
                
                hien();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
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
            this.Close();
            hoadon h = new hoadon();
            h.Show();
        }

        private void btnFix_Click(object sender, EventArgs e)
        {

            thuoc t = new thuoc();
            t.ma_nhom = txtMAn.Text;
            t.ma_thuoc = txtMAt.Text;
            t.ten_thuoc = txtTent.Text;
            t.cong_dung = txtCd.Text;
            t.thanh_phan = txtTp.Text;
            t.don_vi_tinh = txtDvt.Text;
            t.gia_ban = int.Parse(txtGb.Text);
            t.so_luong = int.Parse(txtSl.Text);
            t.xuat_xu = txtXx.Text;
            d.suathuoc(t);

            hien();

        }

        private void btnEX_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel._Workbook wr = app.Workbooks.Add(Type.Missing);

            Microsoft.Office.Interop.Excel._Worksheet ws = null;
            ws = wr.Sheets["sheet1"];
            ws = wr.ActiveSheet;
            app.Visible = true;
            ws.Cells[1, 3] = "Danh sách thuốc ";

            ws.Cells[2, 2] = "Mã nhóm ";
            ws.Cells[2, 3] = "Mã thuốc ";
            ws.Cells[2, 4] = "Tên thuốc ";
            ws.Cells[2, 5] = "Công dụng";
            ws.Cells[2, 6] = "Thành phần";
            ws.Cells[2, 7] = "Đơn vị tính";
            ws.Cells[2,8] = "Xuất xứ";
            ws.Cells[2,9] = "Giá bán";
            ws.Cells[2, 10] = "Số lượng";
            for (int i = 0; i < datathuoc.RowCount - 1; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    ws.Cells[i + 3, j + 2] = datathuoc.Rows[i].Cells[j].Value;
                }
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void nhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hoa_don_nhap h = new hoa_don_nhap();
            h.Show();
        }

        private void xuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            hoadon h= new hoadon();
            h.Show();
        }
    }
}
