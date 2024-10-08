using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// phần báo cáo
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace QLKS2
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLKSDataSet.BaoCao5' table. You can move, or remove it, as needed.
            //this.BaoCao5TableAdapter.Fill(this.QLKSDataSet.BaoCao5);

            this.rpHoaDon.RefreshReport();
            this.ShowComboboxMaDPHD();
        }
        public void ShowComboboxMaDPHD()
        {
            cobMaHD.DataSource = kn.LayBang("select * from HoaDon");
            cobMaHD.DisplayMember = "MaHD";
            cobMaHD.ValueMember = "MaHD";
            txtMaPHD.DataBindings.Clear();
            txtMaPHD.DataBindings.Add("Text", cobMaHD.DataSource, "MaP");
        }

        private void btnXemHD_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.QLKSConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "BaoCao5";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@MaHD", cobMaHD.Text));
            // Khai báo dataset để lấy dữ liệu
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            // thiết lập báo cáo
            rpHoaDon.ProcessingMode = ProcessingMode.Local;
            rpHoaDon.LocalReport.ReportPath = "rpHoaDon.rdlc";
            if (ds.Tables[0].Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "dsHoaDon";
                rds.Value = ds.Tables[0];
                // Gắn lên mẫu báo cáo
                rpHoaDon.LocalReport.DataSources.Clear();
                rpHoaDon.LocalReport.DataSources.Add(rds);
                rpHoaDon.RefreshReport();
            }
        }
        string tinhtrangT = "Trống";
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string queryUpdate = "update Phong set TinhTrang = N'" + tinhtrangT
                    + "'where MaP = '" + txtMaPHD.Text + "'";
            kn.ThayDoiDL(queryUpdate);
            MessageBox.Show("Cảm ơn bạn đã thanh toán");
            MainForm frmMain = new MainForm();
            frmMain.Show();
            this.Close();
        }

        private void btnHuyHD_Click(object sender, EventArgs e)
        {
            MainForm frmMain = new MainForm();
            frmMain.Show();
            this.Close();
        }
    }
}
