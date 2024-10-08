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
    public partial class DichVu : Form
    {
        public DichVu()
        {
            InitializeComponent();
        }

        private void DichVu_Load(object sender, EventArgs e)
        {
            //string ten = txtMaKHDV.Text;
            dGVSDDV.DataSource = kn.LayBang("select TenDV, SoLuong from DichVu, SDDichVu where DichVu.MaDV = SDDichVu.MaDV and MaKH like '"+temp2+"'");
            // hiển thị combobox
            this.ShowComboboxTenDV();
            txtTenKHDV.Text = temp1;
            txtMaKHDV.Text = temp2;
        }
        // hiển thị tên khách hàng từ formMain
        public string temp1;
        public string temp2;
        // hiển thị tên dịch vụ vào combobox
        public void ShowComboboxTenDV()
        {
            cobTenDVDV.DataSource = kn.LayBang("select * from DichVu");
            cobTenDVDV.DisplayMember = "TenDV";
            cobTenDVDV.ValueMember = "MaDV";
            txtMaDVDV.DataBindings.Clear();
            txtMaDVDV.DataBindings.Add("Text", cobTenDVDV.DataSource, "MaDV");
            txtDonGiaSD.DataBindings.Clear();
            txtDonGiaSD.DataBindings.Add("Text", cobTenDVDV.DataSource, "DonGiaDV");
        }
        private void dGVSĐV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dGVSDDV.CurrentRow.Index;
            cobTenDVDV.Text = dGVSDDV.Rows[i].Cells[0].Value.ToString();
            txtSoLuong.Text = dGVSDDV.Rows[i].Cells[1].Value.ToString();
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            int sl = Convert.ToInt32(txtSoLuong.Text);
           /* if (txtSoLuong.Text =="")
            {
               // MessageBox.Show("Chưa nhập số lượng");
                //int sl1 = Convert.ToInt32(txtSoLuong.Text);
            } else*/ if (sl <= 0 )
            {
                MessageBox.Show("Số lượng phải lớn hơn 0");
            }
            else if (dGVSDDV.RowCount >= 0 && dGVSDDV.Rows[dGVSDDV.CurrentRow.Index].Cells[0].Value.ToString() != cobTenDVDV.Text)
            {
                // Console.WriteLine(dGVSDDV.RowCount);
                string query = "insert into SDDichVu values ('"
                    + txtMaKHDV.Text.Trim() + "',N'"
                    + txtMaDVDV.Text.Trim() + "',N'"
                    + txtSoLuong.Text.Trim() + "')";
                kn.ThayDoiDL(query);
                dGVSDDV.DataSource = kn.LayBang("select TenDV, SoLuong from DichVu, SDDichVu where DichVu.MaDV = SDDichVu.MaDV and MaKH like '" + temp2 + "'");
            }
            else
            {
                MessageBox.Show("Dịch vụ này đã có");
            }
        }

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            int sl = Convert.ToInt32(txtSoLuong.Text);
            if (sl <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0");
            }
            else if (dGVSDDV.Rows[dGVSDDV.CurrentRow.Index].Cells[0].Value.ToString() == cobTenDVDV.Text)
            {
                string query = "update SDDichVu set SoLuong ='" + txtSoLuong.Text
                    //+ "',MaDV = '" + txtMaDVDV.Text 
                    + "'where MaDV = '" + txtMaDVDV.Text +"'";
                kn.ThayDoiDL(query);
                dGVSDDV.DataSource = kn.LayBang("select TenDV, SoLuong from DichVu, SDDichVu where DichVu.MaDV = SDDichVu.MaDV and MaKH like '" + temp2 + "'");
            }
            else
            {
                MessageBox.Show("Dịch vụ này không có trong danh sách");
            }
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa Dịch vụ không ?", "Xóa Sử Dụng Dịch Vụ",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
            {
                kn.ThayDoiDL("delete from SDDichVu Where (MaDV = '" + txtMaDVDV.Text + "')");
                dGVSDDV.DataSource = kn.LayBang("select TenDV, SoLuong from DichVu, SDDichVu where DichVu.MaDV = SDDichVu.MaDV and MaKH like '" + temp2 + "'");
               
            }
        }

        private void btnLammoiDV_Click(object sender, EventArgs e)
        {
            cobTenDVDV.Text = "";
            txtSoLuong.Clear();
            dGVSDDV.DataSource = kn.LayBang("select TenDV, SoLuong from DichVu, SDDichVu where DichVu.MaDV = SDDichVu.MaDV and MaKH like '" + temp2 + "'");

        }

        private void btnHuyDV_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cảm ơn bạn sử dụng dịch vụ", "Dịch vụ",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information).ToString() == "OK")
            {
                this.Close();
            }
        }

        
    }
}
