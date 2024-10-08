using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS2
{
    public partial class Dmk : Form
    {
        public Dmk()
        {
            InitializeComponent();
        }

        private void btnthoatdmk_Click(object sender, EventArgs e)
        {
            MainForm frmMain = new MainForm();
            frmMain.Show();
            this.Hide();
        }

        private void btndmk_Click(object sender, EventArgs e)
        {   // kiẻm tra tên đăng nhập
            string sqlKey = "select * from TaiKhoan where TenDN ='" + txtTenDN.Text + "'";
            //kiểm tra mật khẩu cũ

            string sqlmkc = "select MatKhau from TaiKhoan where TenDN ='" + txtTenDN.Text + "'";
            // các ô k đc để trống
            if (txtTenDN.Text =="" || txtMkc.Text =="" || txtMkm.Text =="" || txtNlmk.Text =="") {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin vào các ô");
            }
            else if (!kn.Check_Key(sqlmkc, txtMkc.Text))
            {
                MessageBox.Show("Nhập sai mật khẩu cũ");
                txtMkc.Clear();
            } else if (txtMkm.Text != txtNlmk.Text)
            {
                MessageBox.Show("Sai nhập lại mật khẩu");
                txtNlmk.Clear();
            } else if (txtMkc.Text == txtNlmk.Text)
            {
                MessageBox.Show("Mật khẩu mới trùng với mật khẩu cũ");
                txtMkm.Clear();
                txtNlmk.Clear();
            }
            // cập nhật lại mật khẩu khi thỏa các điều kiện trên
            else if (kn.Check_Key(sqlKey, txtTenDN.Text))
            {
                string queryMk = "update TaiKhoan set MatKhau ='" + txtNlmk.Text
                    + "'where TenDN = '" + txtTenDN.Text + "'";
                kn.ThayDoiDL(queryMk);
                MessageBox.Show("Thay đổi thành công");

                // Hiên thị from đăng nhập
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();

            } else
            {
                MessageBox.Show("Tên đăng nhập không hợp lệ");
            }
        }
    }
}
