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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void ShowCombobox()
        {
            cobTkKH.DataSource = kn.LayBang("select * from KhachHang");
            cobTkKH.DisplayMember = "TenKH";
            cobTkKH.ValueMember = "MaKH";
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLKSDataSet.BaoCao4' table. You can move, or remove it, as needed.
           // this.BaoCao4TableAdapter.Fill(this.QLKSDataSet.BaoCao4);
            dGVKH.DataSource = kn.LayBang("select * from KhachHang");
            //this.dGVKH.Refresh();
            // cobTkKH.DataSource = kn.LayBang("select TenKH from KHACHHANG");
            // hiển thị dữ liệu vào combobox
            this.ShowCombobox();
            // tab dich vu
            dGVDV.DataSource = kn.LayBang("select * from DichVu");
            // combobox dich vu
            this.ShowComboboxDV();
            //------------------
            // tab Phòng
            dGVP.DataSource = kn.LayBang("select * from Phong");
            // combobox tìm kiếm Phòng
            this.ShowComboboxP();
            this.ShowComboboxMaNVP();
            //----------------------
            // tab Đặt Phòng
            dGVDP.DataSource = kn.LayBang("select MaDP, TenKH, TenP, TenNV, NgayDen, NgayDi, DatPhong.MaKH, DatPhong.MaNV from DatPhong, KhachHang, Phong, NhanVien where DatPhong.MaKH = KhachHang.MaKH and DatPhong.MaP = Phong.MaP and DatPhong.MaNV = NhanVien.MaNV");
            // combobox hiển thị mã khách hàng ở tab Đặt phòng
            this.ShowComboboxMaKHP();
            this.ShowComboboxMaPP();
            this.ShowComboboxTKDP();
            this.ShowComboboxMaNVDP();
            //this.rpvHoaDon.RefreshReport();
            //this.rpvHoaDon.RefreshReport();
            // hiển thị mã đặt phòng ở tab Hoa Don
            dGVHD.DataSource = kn.LayBang("select * from HoaDon");
            this.ShowComboboxMaDPHD();
            //this.rpvHoaDon.RefreshReport();
            //----------------------------------------------
            // tab Báo Cáo
            chartDT.Series["chartDT"].Points.AddXY("1", 50000000);
            chartDT.Series["chartDT"].Points.AddXY("2", 80000000);
            chartDT.Series["chartDT"].Points.AddXY("3", 70000000);
            chartDT.Series["chartDT"].Points.AddXY("4", 40000000);
            chartDT.Series["chartDT"].Points.AddXY("5", 100000000);
            chartDT.Series["chartDT"].Points.AddXY("6", 120000000);
            chartDT.Series["chartDT"].Points.AddXY("7", 150000000);
            chartDT.Series["chartDT"].Points.AddXY("8", 80000000);
            chartDT.Series["chartDT"].Points.AddXY("9", 25000000);
            chartDT.Series["chartDT"].Points.AddXY("10", 110000000);
            chartDT.Series["chartDT"].Points.AddXY("11", 90000000);
            chartDT.Series["chartDT"].Points.AddXY("12", 80000000);
            //---------------------------
            // tab số lượng đặt phòng
            chartSP.Series["chartSP"].Points.AddXY("1", 100);
            chartSP.Series["chartSP"].Points.AddXY("2", 80);
            chartSP.Series["chartSP"].Points.AddXY("3", 50);
            chartSP.Series["chartSP"].Points.AddXY("4", 150);
            chartSP.Series["chartSP"].Points.AddXY("5", 200);
            chartSP.Series["chartSP"].Points.AddXY("6", 180);
            chartSP.Series["chartSP"].Points.AddXY("7", 175);
            chartSP.Series["chartSP"].Points.AddXY("8", 90);
            chartSP.Series["chartSP"].Points.AddXY("9", 85);
            chartSP.Series["chartSP"].Points.AddXY("10", 180);
            chartSP.Series["chartSP"].Points.AddXY("11", 145);
            chartSP.Series["chartSP"].Points.AddXY("12", 130);


        }

        //đôi mật khẩu người dùng

        private void btnDmk_Click(object sender, EventArgs e)
        {
            Dmk frmDmk = new Dmk();
            frmDmk.Show();
            this.Hide();
        }

        // ---đăng xuất

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            this.Hide();
        }
        // Hiển thị form nhân viên
        private void btnNv_Click(object sender, EventArgs e)
        {
            NhanVien frmNV = new NhanVien();
            frmNV.Show();
        }

        // ---- trang chủ ////
        private void dGVKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // hiển thị dữ liệu lên textbox khi click vào datagridView

        private void dGVKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dGVKH.CurrentRow.Index;
            txtMaKH.Text = dGVKH.Rows[i].Cells[0].Value.ToString();
            txtTenKH.Text= dGVKH.Rows[i].Cells[1].Value.ToString();
            txtCmnd.Text = dGVKH.Rows[i].Cells[2].Value.ToString();
            cobQt.Text = dGVKH.Rows[i].Cells[3].Value.ToString();
            txtSdt.Text = dGVKH.Rows[i].Cells[4].Value.ToString();
            txtTuoi.Text = dGVKH.Rows[i].Cells[5].Value.ToString();
            if (dGVKH.Rows[i].Cells[6].Value.ToString() == "Nam")
            {
                rdoNam.Checked = true;
            }
            else  {
                rdoNu.Checked = true;
            }
            

        }

        private void btnTkKH_Click(object sender, EventArgs e)
        {
            String sql = "select * from KhachHang where TenKH like N'%" + this.cobTkKH.Text + "%'";
            dGVKH.DataSource = kn.LayBang(sql);
            Console.WriteLine("ten" + cobTkKH.Text);
            Console.WriteLine("Ma" + cobTkKH.ValueMember);
        }

        // giới tính
        string gt;

        private void btnThemKH_Click(object sender, EventArgs e)
        {
           
            if (rdoNam.Checked)
            {
                gt = "Nam";
            }
            else if (rdoNu.Checked)
            {
                gt = "Nữ";
            }

            // kiểm tra khóa
            string sqlkey = "select MaKH from KhachHang where MaKH = '" + txtMaKH.Text + "'";
            if (txtMaKH.Text != "" && !kn.Check_Key(sqlkey, txtMaKH.Text))
            {
                string query = "insert into KhachHang values ('"
                        + txtMaKH.Text.Trim() + "',N'"
                        + txtTenKH.Text.Trim() + "','"
                        + txtCmnd.Text.Trim() + "',N'"
                        + cobQt.Text.Trim() + "',N'"
                        + txtSdt.Text.Trim() + "','"
                        + txtTuoi.Text.Trim() + "',N'"
                        + gt.Trim() + "')";
                kn.ThayDoiDL(query);
                dGVKH.DataSource = kn.LayBang("select * from KhachHang");
                this.ShowCombobox();
            }
            else
            {
                MessageBox.Show("Khóa không hợp lệ");
            }
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            if (rdoNam.Checked)
            {
                gt = "Nam";
            }
            else if (rdoNu.Checked)
            {
                gt = "Nữ";
            }
            string sqlkey = "select MaKH from KhachHang where MaKH = '" + txtMaKH.Text + "'";
            if (txtMaKH.Text != "" && kn.Check_Key(sqlkey, txtMaKH.Text))
            {
                string query = "update KhachHang set TenKH=N'" + txtTenKH.Text
                    + "',Cmnd ='" + txtCmnd.Text
                    + "',Quoctich = N'" + cobQt.Text
                    + "',Sdt = N'" + txtSdt.Text
                    + "',Tuoi = '" + txtTuoi.Text
                    + "',GioiTinhKH = N'" + gt
                    + "'Where MaKH = '" + txtMaKH.Text + "'";
                kn.ThayDoiDL(query);
                dGVKH.DataSource = kn.LayBang("select * from KhachHang");
                this.ShowCombobox();
                this.ShowComboboxMaKHP();
            }
            else
            {
                MessageBox.Show("Khóa không hợp lệ");
            }
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa khách hàng không ?", "Xóa khách hàng",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
            {
                kn.ThayDoiDL("delete from KhachHang Where (MaKH = '" + txtMaKH.Text + "')");
                dGVKH.DataSource = kn.LayBang("select * from KhachHang");
                this.ShowCombobox();
            }
        }

        private void btnLammoiKH_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtCmnd.Text = "";
            txtSdt.Text = "";
            txtTuoi.Text = "";
            cobQt.Text = "";
            cobTkKH.Text = "";
            dGVKH.DataSource = kn.LayBang("select * from KhachHang");
        }

        //--------------------------------------------------------------------
        //-------- tab dịch vụ
        // show combobox tìm kiếm dịch vụ
        public void ShowComboboxDV()
        {
            cobTkDV.DataSource = kn.LayBang("select * from DichVu");
            cobTkDV.DisplayMember = "TenDV";
            cobTkDV.ValueMember = "MaDV";
        }

        private void btnTkDV_Click(object sender, EventArgs e)
        {
            String sql = "select * from DichVu where TenDV like N'%" + this.cobTkDV.Text + "%'";
            dGVDV.DataSource = kn.LayBang(sql);
           // this.txtMaDV.Text = kn.LayBang("select TenDV from DichVu where TenDV like N'%" + cobTkDV.Text + "%'");
        }
        private void dGVDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int i;
            i = dGVDV.CurrentRow.Index;
            txtMaDV.Text = dGVDV.Rows[i].Cells[0].Value.ToString();
            txtTenDV.Text = dGVDV.Rows[i].Cells[1].Value.ToString();
            txtDonGia.Text = dGVDV.Rows[i].Cells[2].Value.ToString();
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            string sqlkey = "select MaDV from DichVu where MaDV = '" + txtMaDV.Text + "'";
            if (txtMaDV.Text != "" && !kn.Check_Key(sqlkey, txtMaDV.Text))
            {
                string query = "insert into DichVu values ('"
                        + txtMaDV.Text.Trim() + "',N'"
                        + txtTenDV.Text.Trim() + "','"
                        + txtDonGia.Text.Trim() + "')";
                kn.ThayDoiDL(query);
                dGVDV.DataSource = kn.LayBang("select * from DichVu");
                this.ShowComboboxDV();
                
            }
            else
            {
                MessageBox.Show("Khóa không hợp lệ");
            }
        }

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            string sqlkey = "select MaDV from DichVu where MaDV = '" + txtMaDV.Text + "'";
            if (txtMaDV.Text != "" && kn.Check_Key(sqlkey, txtMaDV.Text))
            {

                string query = "update DichVu set TenDV=N'" + txtTenDV.Text
                    + "',DonGiaDV ='" + txtDonGia.Text
                    + "'Where MaDV = '" + txtMaDV.Text + "'";
                kn.ThayDoiDL(query);
                dGVDV.DataSource = kn.LayBang("select * from DichVu");
                this.ShowComboboxDV();
            }
            else
            {
                MessageBox.Show("Khóa không hợp lệ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa dịch vụ không ?", "Xóa dịch vụ",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
            {
                kn.ThayDoiDL("delete from DichVu Where (MaDV = '" + txtMaDV.Text + "')");
                dGVDV.DataSource = kn.LayBang("select * from DichVu");
                this.ShowComboboxDV();
            }
        }

        private void btnLamMoiDV_Click(object sender, EventArgs e)
        {
            txtMaDV.Clear();
            txtTenDV.Clear();
            txtDonGia.Clear();
            cobTkDV.Text = "";
            dGVDV.DataSource = kn.LayBang("select * from DichVu");
        }
        //--------------------------------------------------------------------------------
        // tab Phòng

        // hiển thị combobox tìm kiếm Phòng
        public void ShowComboboxP()
        {
            cobTkP.DataSource = kn.LayBang("select * from Phong");
            cobTkP.DisplayMember = "TenP";
            cobTkP.ValueMember = "MaP";
        }

        // hiển thị mã nhân viên
        public void ShowComboboxMaNVP()
        {
            cobMaNVP.DataSource = kn.LayBang("select * from NhanVien");
            cobMaNVP.DisplayMember = "MaNV";
            cobMaNVP.ValueMember = "MaNV";
            txtMaNVP.DataBindings.Clear();
            txtMaNVP.DataBindings.Add("Text", cobMaNVP.DataSource, "TenNV");
        }

        // Xử lý
        private void btnTkP_Click(object sender, EventArgs e)
        {
            String sql = "select * from Phong where TenP like N'%" + this.cobTkP.Text + "%'";
            dGVP.DataSource = kn.LayBang(sql);
        }
        private void cobMaNVP_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int id = Convert.ToInt32(cobMaNVP.SelectedValue);
           /* cobMaNVP.DataSource = kn.LayBang("select * from NhanVien where MaNV = " + id +");
            cobMaNVP.DisplayMember = "TenNV";
            cobMaNVP.ValueMember = "MaNV";
            txtMaNVP.DataBindings.Clear();
            txtMaNVP.DataBindings.Add("Text", cobMaNVP.DataSource, "MaNV");
           */
        }

        private void dGVP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dGVP.CurrentRow.Index;
            txtMaP.Text = dGVP.Rows[i].Cells[0].Value.ToString();
            txtTenP.Text = dGVP.Rows[i].Cells[1].Value.ToString();
            cobLoaiP.Text = dGVP.Rows[i].Cells[2].Value.ToString();
            cobKieuP.Text = dGVP.Rows[i].Cells[3].Value.ToString();
            cobTinhTrang.Text = dGVP.Rows[i].Cells[4].Value.ToString();
            txtGiaP.Text = dGVP.Rows[i].Cells[5].Value.ToString();
            cobMaNVP.Text = dGVP.Rows[i].Cells[6].Value.ToString();
            // hiển thị dữ liệu lên ô combobox
            //txtMaNVP.DataBindings.Clear();
            //txtMaNVP.DataBindings.Add("Text", dGVP.DataSource, "MaNV");
           // this.ShowComboboxMaNVP();
        }

        private void btnThemP_Click(object sender, EventArgs e)
        {
            if (dGVP.Rows[dGVP.CurrentRow.Index].Cells[1].Value.ToString() != txtTenP.Text)
            {
                string sqlkey = "select MaP from Phong where MaP = '" + txtMaP.Text + "'";
                if (txtMaP.Text != "" && !kn.Check_Key(sqlkey, txtMaP.Text))
                {
                    string query = "insert into Phong values ('"
                            + txtMaP.Text.Trim() + "',N'"
                            + txtTenP.Text.Trim() + "',N'"
                            + cobLoaiP.Text.Trim() + "',N'"
                            + cobKieuP.Text.Trim() + "',N'"
                            + cobTinhTrang.Text.Trim() + "','"
                            + txtGiaP.Text.Trim() + "','"
                            + cobMaNVP.Text.Trim() + "')";
                    kn.ThayDoiDL(query);
                    dGVP.DataSource = kn.LayBang("select * from Phong");
                    this.ShowComboboxP();
                }
                else
                {
                    MessageBox.Show("Khóa không hợp lệ");
                }
            } else
            {
                MessageBox.Show("Phòng này đã tồn tại");
            }
        }

        private void btnSuaP_Click(object sender, EventArgs e)
        {
            string sqlkey = "select MaP from Phong where MaP = '" + txtMaP.Text + "'";
            if (txtMaP.Text != "" && kn.Check_Key(sqlkey, txtMaP.Text))
            {
                string query = "update Phong set TenP=N'" + txtTenP.Text
                    + "',LoaiP =N'" + cobLoaiP.Text
                    + "',KieuP =N'" + cobKieuP.Text
                    + "',TinhTrang =N'" + cobTinhTrang.Text
                    + "',GiaPhong ='" + txtGiaP.Text
                    + "',MaNV = '" + cobMaNVP.Text
                    + "'Where MaP = '" + txtMaP.Text + "'";
                kn.ThayDoiDL(query);
                dGVP.DataSource = kn.LayBang("select * from Phong");
                this.ShowComboboxP();
                this.ShowComboboxMaPP();
            }
            else
            {
                MessageBox.Show("Khóa không hợp lệ");
            }
        }

        private void btnXoaP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa phòng không ?", "Xóa Phòng",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
            {
                kn.ThayDoiDL("delete from Phong Where (MaP = '" + txtMaP.Text + "')");
                dGVP.DataSource = kn.LayBang("select * from Phong");
                this.ShowComboboxP();
            }
            
        }

        private void btnLamMoiP_Click(object sender, EventArgs e)
        {
            txtMaP.Clear();
            txtTenP.Clear();
            cobKieuP.Text = "";
            cobLoaiP.Text = "";
            cobMaNVP.Text = "";
            cobTinhTrang.Text = "";
            txtGiaP.Clear();
            cobTkP.Text = "";
            txtMaNVP.Clear();
            dGVP.DataSource = kn.LayBang("select * from Phong");
        }
        //-------------------------------------------------------------------------------
        //----tab Đặt phòng
        // hiển thị Mã khách hàng trên tab Đặt phòng
        public void ShowComboboxMaKHP()
        {
            cobMaKHP.DataSource = kn.LayBang("select * from KhachHang");
            cobMaKHP.DisplayMember = "MaKH";
            cobMaKHP.ValueMember = "MaKH";
            txtTenKHP.DataBindings.Clear();
            txtTenKHP.DataBindings.Add("Text", cobMaKHP.DataSource, "TenKH");
        }
        // hiển thị tên khách hàng
        /*public void ShowComboboxTenKHP()
        {
            txtTenKHP.DataSource = kn.LayBang("select * from KhachHang");
            txtTenKHP.DisplayMember = "MaKH";
            txtTenKHP.ValueMember = "MaKH";
            txtTenKHP.DataBindings.Clear();
            txtTenKHP.DataBindings.Add("Text", cobMaKHP.DataSource, "TenKH");
        }*/

        // hiển thị Mã Phòng trên tab Đặt phòng
        public void ShowComboboxMaPP()
        {
            cobMaPP.DataSource = kn.LayBang("select * from Phong");
            cobMaPP.DisplayMember = "MaP";
            cobMaPP.ValueMember = "MaP";
            txtTenPP.DataBindings.Clear();
            txtTenPP.DataBindings.Add("Text", cobMaPP.DataSource, "TenP");
            // ô tình trạng Phòng
            txtTinhTrangP.DataBindings.Clear();
            txtTinhTrangP.DataBindings.Add("Text", cobMaPP.DataSource, "TinhTrang");
        }
        // hiển thị Tên phòng
        public void ShowComboboxTKDP()
        {
            cobTkDP.DataSource = kn.LayBang("select * from DatPhong");
            cobTkDP.DisplayMember = "MaDP";
            cobTkDP.ValueMember = "MaDP";
        }
        // hiển thị Mã Nhân viên
        public void ShowComboboxMaNVDP()
        {
            cobMaNVDP.DataSource = kn.LayBang("select * from NhanVien");
            cobMaNVDP.DisplayMember = "MaNV";
            cobMaNVDP.ValueMember = "MaNV";
            txtTenNVDP.DataBindings.Clear();
            txtTenNVDP.DataBindings.Add("Text", cobMaNVDP.DataSource, "TenNV");
        }
        private void btnTKDP_Click(object sender, EventArgs e)
        {
            String sql = "select MaDP, TenKH, TenP, TenNV, NgayDen, NgayDi, DatPhong.MaKH, DatPhong.MaNV from DatPhong, KhachHang, Phong, NhanVien where DatPhong.MaKH = KhachHang.MaKH and DatPhong.MaP = Phong.MaP and DatPhong.MaNV = NhanVien.MaNV and MaDP like N'%" + this.cobTkDP.Text + "%'";
            dGVDP.DataSource = kn.LayBang(sql);
        }

        private void dGVDP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dGVDP.CurrentRow.Index;
            txtMaDP.Text = dGVDP.Rows[i].Cells[0].Value.ToString();
            txtTenKHP.Text = dGVDP.Rows[i].Cells[1].Value.ToString();
            txtTenPP.Text = dGVDP.Rows[i].Cells[2].Value.ToString();
            txtTenNVDP.Text = dGVDP.Rows[i].Cells[3].Value.ToString();
            dTPNgayDen.Text = dGVDP.Rows[i].Cells[4].Value.ToString();
            dTPNgayDi.Text = dGVDP.Rows[i].Cells[5].Value.ToString();
            cobMaKHP.Text = dGVDP.Rows[i].Cells[6].Value.ToString();
            cobMaNVDP.Text = dGVDP.Rows[i].Cells[7].Value.ToString();


        }
        // tình trạng phòng
        string tinhtrangD = "Đầy";
        string tinhtrangT = "Trống";
        private void btnThemDP_Click(object sender, EventArgs e)
        {
            
            // chuyển ngày qua sô
            DateTime NgayDen = Convert.ToDateTime(dTPNgayDen.Text);
            DateTime NgayDi = Convert.ToDateTime(dTPNgayDi.Text);
            TimeSpan time = NgayDi.Subtract(NgayDen);
            int days = time.Days;
            Console.WriteLine(days);
            if (days < 0)
            {
                MessageBox.Show("Ngày không hợp lệ");
            } else if (txtTinhTrangP.Text == "Đầy" || txtTinhTrangP.Text == "Bảo trì")
            {
                MessageBox.Show("Phòng Đầy hoặc đang Bảo trì");
            } else /*if (txtTenPP.Text == dGVDP.Rows[dGVDP.CurrentRow.Index].Cells[2].Value.ToString())
            {
                MessageBox.Show("Phòng này đã có người đặt");
            } else*/
            {
                string sqlkey = "select MaDP from DatPhong where MaDP = '" + txtMaDP.Text + "'";
                if (txtMaDP.Text != "" && !kn.Check_Key(sqlkey, txtMaDP.Text))
                {
                    string query = "insert into DatPhong values ('"
                        + txtMaDP.Text.Trim() + "',N'"
                        + cobMaPP.Text.Trim() + "',N'"
                        + cobMaKHP.Text.Trim() + "','"
                        + cobMaNVDP.Text.Trim() + "','"
                        + dTPNgayDen.Value.ToString() + "',N'"
                        + dTPNgayDi.Value.ToString() + "')";
                    kn.ThayDoiDL(query);
                    dGVDP.DataSource = kn.LayBang("select MaDP, TenKH, TenP, TenNV, NgayDen, NgayDi from DatPhong, KhachHang, Phong, NhanVien where DatPhong.MaKH = KhachHang.MaKH and DatPhong.MaP = Phong.MaP and DatPhong.MaNV = NhanVien.MaNV");
                    this.ShowComboboxTKDP();
                    // cập nhật lại phòng đầy khi đặt phòng
                    string queryUpdate = "update Phong set TinhTrang = N'" + tinhtrangD
                    + "'where MaP = '" + cobMaPP.Text + "'";
                    kn.ThayDoiDL(queryUpdate);
                    dGVP.DataSource = kn.LayBang("select * from Phong");
                    // hiển thị combobox Mã phòng
                    this.ShowComboboxMaPP();
                }
                else
                {
                    MessageBox.Show("Khóa không hợp lệ");
                }
            }
        }

        private void btnSuaDP_Click(object sender, EventArgs e)
        {
            DateTime NgayDen = Convert.ToDateTime(dTPNgayDen.Text);
            DateTime NgayDi = Convert.ToDateTime(dTPNgayDi.Text);
            TimeSpan time = NgayDi.Subtract(NgayDen);
            int days = time.Days;
            Console.WriteLine(days);
            if (days < 0)
            {
                MessageBox.Show("Ngày không hợp lệ");
            }
            else /*if (txtTinhTrangP.Text == "Đầy" || txtTinhTrangP.Text == "Bảo trì")
            {
                MessageBox.Show("Phòng Đầy hoặc đang Bảo trì");
            } else*/
            {
                string sqlkey = "select MaDP from DatPhong where MaDP = '" + txtMaDP.Text + "'";
                if (txtMaDP.Text != "" && kn.Check_Key(sqlkey, txtMaDP.Text))
                {
                    string query = "update DatPhong set MaP=N'" + cobMaPP.Text
                    + "',MaKH =N'" + cobMaKHP.Text
                    + "',MaNV='" + cobMaNVDP.Text
                    + "',NgayDen ='" + dTPNgayDen.Value.ToString()
                    + "',NgayDi ='" + dTPNgayDi.Value.ToString()
                    + "'where MaDP = '" + txtMaDP.Text + "'";
                    kn.ThayDoiDL(query);
                    dGVDP.DataSource = kn.LayBang("select MaDP, TenKH, TenP, TenNV, NgayDen, NgayDi from DatPhong, KhachHang, Phong, NhanVien where DatPhong.MaKH = KhachHang.MaKH and DatPhong.MaP = Phong.MaP and DatPhong.MaNV = NhanVien.MaNV");
                    this.ShowComboboxTKDP();
                }
                else
                {
                    MessageBox.Show("Khóa không hợp lệ");
                }
            }
        }

        private void btnXoaDP_Click(object sender, EventArgs e)
        {
            /* if (MessageBox.Show("Bạn có muốn xóa đặt phòng không ?", "Xóa Đặt Phòng",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question).ToString() == "OK")
             {
                 kn.ThayDoiDL("delete from DatPhong Where (MaDP = '" + txtMaDP.Text + "')");
                 dGVDP.DataSource = kn.LayBang("select MaDP, TenKH, TenP, TenNV, NgayDen, NgayDi from DatPhong, KhachHang, Phong, NhanVien where DatPhong.MaKH = KhachHang.MaKH and DatPhong.MaP = Phong.MaP and DatPhong.MaNV = NhanVien.MaNV");
                 this.ShowComboboxTKDP();
                /* // cập nhật lại phòng trống khi xóa đặt phòng
                 string queryUpdate = "update Phong set TinhTrang = N'" + tinhtrangT
                 + "'where TenP = '" + txtTenPP.Text + "'";
                 kn.ThayDoiDL(queryUpdate);
                 dGVP.DataSource = kn.LayBang("select * from Phong");
                 // hiển thị combobox Mã phòng
                 this.ShowComboboxMaPP();
             } */
            MessageBox.Show("Vui lòng thanh toán ");
        }

        private void btnLamMoiDP_Click(object sender, EventArgs e)
        {
            txtMaDP.Clear();
            cobMaNVDP.Text = "";
            cobMaKHP.Text = "";
            cobMaNVDP.Text = "";
            txtTinhTrangP.Clear();
            txtTenPP.Clear();
            txtTenKHP.Clear();
            cobTkDP.Text = "";
            cobMaPP.Text = "";
            txtTenNVDP.Clear();
            dTPNgayDen.Text = "";
            dTPNgayDi.Text = "";
            dGVDP.DataSource = kn.LayBang("select MaDP, TenKH, TenP, TenNV, NgayDen, NgayDi from DatPhong, KhachHang, Phong, NhanVien where DatPhong.MaKH = KhachHang.MaKH and DatPhong.MaP = Phong.MaP and DatPhong.MaNV = NhanVien.MaNV");

        }
        //--- mở Form sử dụng dịch vụ
        private void btnDichVu_Click(object sender, EventArgs e)
        {
            DichVu frmDV = new DichVu();
            // truyền dữ liệu qua form Sử dụng Dịch vụ'
            frmDV.temp2 = cobMaKHP.Text;
            frmDV.temp1 = txtTenKHP.Text;
            frmDV.Show();
        }
        // tab hóa đơn
        public void ShowComboboxMaDPHD()
        {
            cobMaDPHD.DataSource = kn.LayBang("select * from DatPhong");
            cobMaDPHD.DisplayMember = "MaDP";
            cobMaDPHD.ValueMember = "MaDP";
            txtMaKHHD.DataBindings.Clear();
            txtMaKHHD.DataBindings.Add("Text", cobMaDPHD.DataSource, "MaKH");
            txtMaPHD.DataBindings.Clear();
            txtMaPHD.DataBindings.Add("Text", cobMaDPHD.DataSource, "MaP");
        }

        /*private void btnXemHD_Click(object sender, EventArgs e)
         {
             SqlConnection con = new SqlConnection();
             con.ConnectionString = Properties.Settings.Default.QLKSConnectionString;
             SqlCommand cmd = new SqlCommand();
             cmd.CommandText = "BaoCao4";
             cmd.CommandType = CommandType.StoredProcedure;
             cmd.Connection = con;
             cmd.Parameters.Add(new SqlParameter("@MaPhong", cobMaDPHD.Text));
             cmd.Parameters.Add(new SqlParameter("@MaKhachang", txtMaKHHD.Text));
             // khai báo data set để chứa dữ liệu
             DataSet ds = new DataSet();
             SqlDataAdapter dap = new SqlDataAdapter(cmd);
             dap.Fill(ds);
             // thiết lập báo cáo
             //rpvHoaDon.ProcessingMode = ProcessingMode.Local;
            // rpvHoaDon.LocalReport.ReportPath = "BaoCaoHD.rdlc";
             // gắn dữ liệu
             if (ds.Tables[0].Rows.Count > 0)
             {
                 ReportDataSource rds = new ReportDataSource();
                 rds.Name = "dsHoaDon";
                 rds.Value = ds.Tables[0];
                 // Gắn lên mẫu báo cáo
                /* rpvHoaDon.LocalReport.DataSources.Clear();
                 rpvHoaDon.LocalReport.DataSources.Add(rds);
                 rpvHoaDon.RefreshReport();
             }

         }*/



        private void dGVHD_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dGVHD.CurrentRow.Index;
            txtMaHD.Text = dGVHD.Rows[i].Cells[0].Value.ToString();
            txtMaPHD.Text = dGVHD.Rows[i].Cells[1].Value.ToString();
            cobMaDPHD.Text = dGVHD.Rows[i].Cells[2].Value.ToString();
            txtGiamGia.Text = dGVHD.Rows[i].Cells[3].Value.ToString();
            cobLoaiTT.Text = dGVHD.Rows[i].Cells[4].Value.ToString();
        }
        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            string sqlkey = "select MaHD from HoaDon where MaHD = '" + txtMaHD.Text + "'";
            if (txtMaHD.Text != "" && !kn.Check_Key(sqlkey, txtMaHD.Text))
            {
                string query = "insert into HoaDon values ('"
                        + txtMaHD.Text.Trim() + "',N'"
                        + txtMaPHD.Text.Trim() + "',N'"
                        + cobMaDPHD.Text.Trim() + "',N'"
                        + txtGiamGia.Text.Trim() + "',N'"
                        + cobLoaiTT.Text.Trim() + "')";
                kn.ThayDoiDL(query);
                dGVHD.DataSource = kn.LayBang("select * from HoaDon");
                //this.ShowCombobox();
            }
            else
            {
                MessageBox.Show("Khóa không hợp lệ");
            }
        }

        private void btnInHD_Click(object sender, EventArgs e)
        {
            frmHoaDon frmHD = new frmHoaDon();
            frmHD.Show();
            this.Hide();
        }

        private void btnSuaHD_Click(object sender, EventArgs e)
        {
            string sqlkey = "select MaHD from HoaDon where MaHD = '" + txtMaHD.Text + "'";
            if (txtMaHD.Text != "" && kn.Check_Key(sqlkey, txtMaHD.Text))
            {
                string query = "update HoaDon set MaP=N'" + txtMaPHD.Text
                    + "',MaDP =N'" + cobMaDPHD.Text
                    + "',GiamGia ='" + txtGiamGia.Text
                    + "',LoaiTT = N'" + cobLoaiTT.Text
                    + "'where MaHD = '" + txtMaHD.Text + "'";
                kn.ThayDoiDL(query);
                dGVHD.DataSource = kn.LayBang("select * from HoaDon");
                //this.ShowCombobox();
            }
            else
            {
                MessageBox.Show("Khóa không hợp lệ");
            }
        }

     

        private void btnLammoiHD_Click_1(object sender, EventArgs e)
        {
            txtGiamGia.Clear();
            txtMaHD.Clear();
            cobLoaiTT.Text = "";
            cobMaDPHD.Text = "";
            txtMaKHHD.Clear();
            txtMaPHD.Clear();
            dGVHD.DataSource = kn.LayBang("select * from HoaDon");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cobMaDPHD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cobMaPP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //----------------------------------
        // tab báo cáo

    }
}
