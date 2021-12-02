using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace hieuthuoc_QuocCuong
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPS_TextChanged(object sender, EventArgs e)
        {
            txtPS.UseSystemPasswordChar=true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-MCA4FUJ\MSSQLSERVER02;Initial Catalog=HIeuThuoc_QuocCuong;Integrated Security=True");
              conn.Open();
                string SqlSelect = "Select * from nhanvien where ten_dang_nhap = '" + txtUS.Text + "'and mat_khau = '" + txtPS.Text + "'";

                SqlCommand cmd = new SqlCommand(SqlSelect, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    this.Hide();
                    MessageBox.Show("Đăng nhập thành công! chuyển đến giao diện quản lí cửa hàng thuốc");
                    main n = new main();
                    n.Show();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                    txtUS.Text = "";
                    txtPS.Text = "";
                    txtUS.Focus();
                }
            
          
        }

        private void txtUS_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ckPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ckPass.Checked)
            {
                txtPS.UseSystemPasswordChar = false;
            }
            else
                txtPS.UseSystemPasswordChar = true;
        }
    }
}
