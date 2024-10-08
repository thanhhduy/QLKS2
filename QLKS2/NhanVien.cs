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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        public void showcomboboxNV()
        {
            cobTkNV.DataSource = kn.LayBang("select * from NhanVien");
            cobTkNV.DisplayMember = "TenNV";
            cobTkNV.ValueMember = "MaNV";
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            dGVNV.DataSource = kn.LayBang("select * from NhanVien");
            // hiển thị nhân viên vào combobox
            this.showcomboboxNV();
        }

        // tìm nhân viên

        private void btnTkNV_Click(object sender, EventArgs e)
        {
            String sql = "select * from NhanVien where TenNV like N'%" + this.cobTkNV.Text + "%'";
            dGVNV.DataSource = kn.LayBang(sql);
        }

        // hiển thị nhân viên vào datagridView

        private void dGVNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dGVNV.CurrentRow.Index;
            txtMaNv.Text = dGVNV.Rows[i].Cells[0].Value.ToString();
            txtTenNV.Text = dGVNV.Rows[i].Cells[1].Value.ToString();
            cobChucVu.Text = dGVNV.Rows[i].Cells[2].Value.ToString();
            dtPNgaySinhNV.Text = dGVNV.Rows[i].Cells[3].Value.ToString();
            
            dtPNgayvaolam.Text = dGVNV.Rows[i].Cells[5].Value.ToString();
            if (dGVNV.Rows[i].Cells[4].Value.ToString() == "Nam")
            {
                rdoNamNv.Checked = true;
            }
            else
            {
                rdoNuNv.Checked = true;
            }
        }

        // giới tính
        string gtnv;
        
        // thêm nhân viên
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (rdoNamNv.Checked)
            {
                gtnv = "Nam";
            }
            else if (rdoNuNv.Checked)
            {
                gtnv = "Nữ";
            }

            string sqlkey = "select MaNV from NhanVien where MaNv = '" + txtMaNv.Text + "'";
            if (txtMaNv.Text != "" && !kn.Check_Key(sqlkey, txtMaNv.Text))
            {
                string query = "insert into NhanVien values ('"
                    + txtMaNv.Text.Trim() + "',N'"
                    + txtTenNV.Text.Trim() + "',N'"
                    + cobChucVu.Text.Trim() + "',N'"
                    + dtPNgaySinhNV.Value.ToString() + "',N'"
                    + gtnv.Trim() + "',N'"
                    + dtPNgayvaolam.Value.ToString() + "')";
                kn.ThayDoiDL(query);
                dGVNV.DataSource = kn.LayBang("select * from NhanVien");
                this.showcomboboxNV();
                
            }
            else
            {
                MessageBox.Show("Khóa không hợp lệ");
            }
        }
        // sửa nhân viên
        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (rdoNamNv.Checked)
            {
                gtnv = "Nam";
            }
            else if (rdoNuNv.Checked)
            {
                gtnv = "Nữ";
            }
            string sqlkey = "select MaNV from NhanVien where MaNv = '" + txtMaNv.Text + "'";
            if (txtMaNv.Text != "" && kn.Check_Key(sqlkey, txtMaNv.Text))
            {
                string query = "update NhanVien set TenNV=N'" + txtTenNV.Text
                    + "',ChucVu =N'" + cobChucVu.Text
                    + "',NgaySinh ='" + dtPNgaySinhNV.Value.ToString()
                    + "',GioiTinhNV =N'" + gtnv
                    + "',NgayVaoLam ='" + dtPNgayvaolam.Value.ToString()
                    + "'where MaNV = '" + txtMaNv.Text + "'";
                kn.ThayDoiDL(query);
                dGVNV.DataSource = kn.LayBang("select * from NhanVien");
                this.showcomboboxNV();
            }
            else
            {
                MessageBox.Show("Khóa không hợp lệ");
            }
        }
        // xoa nhân viên
        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nhân viên không ?", "Xóa nhân viên",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
            {
                kn.ThayDoiDL("delete from NhanVien Where (MaNV = '" + txtMaNv.Text + "')");
                dGVNV.DataSource = kn.LayBang("select * from NhanVien");
                this.showcomboboxNV();
            }
        }
        // làm mới
        private void btnLammoiNV_Click(object sender, EventArgs e)
        {
            txtMaNv.Clear();
            txtTenNV.Clear();
            cobChucVu.Text = "";
            dtPNgaySinhNV.Value.ToString();
            dGVNV.DataSource = kn.LayBang("select * from NhanVien");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dtPNgaySinhNV_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtPNgayvaolam1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
