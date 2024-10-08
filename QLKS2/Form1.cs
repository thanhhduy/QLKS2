using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btndn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-4IK6CM8;Initial Catalog=QLKS;Integrated Security=True");
            string tk = txtdangnhap.Text;
            string mk = txtmk.Text;
            string sql = "select * from TaiKhoan where TenDN = '" +tk+ "' and MatKhau = '" +mk+ "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dta = cmd.ExecuteReader();
            
            if (dta.Read() == true)
            {
                // MessageBox.Show("Đăng nhập thành công");
                // mở Form mới
                MainForm frMain = new MainForm();
                frMain.Show();
                this.Hide();
               // this.Close();

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng Tên Đăng Nhập và Mật khẩu");
                txtdangnhap.Clear();
                txtmk.Clear();
            }
            con.Close();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //txtdangnhap.DataSource = kn.LayBang("select TenDN from TaiKhoan");

        }
    }
}
