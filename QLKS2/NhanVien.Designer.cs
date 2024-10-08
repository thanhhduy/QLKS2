namespace QLKS2
{
    partial class NhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtPNgayvaolam = new System.Windows.Forms.DateTimePicker();
            this.dtPNgaySinhNV = new System.Windows.Forms.DateTimePicker();
            this.rdoNuNv = new System.Windows.Forms.RadioButton();
            this.rdoNamNv = new System.Windows.Forms.RadioButton();
            this.cobChucVu = new System.Windows.Forms.ComboBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dGVNV = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinhNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayVaoLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnTkNV = new System.Windows.Forms.Button();
            this.cobTkNV = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.btnLammoiNV = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNV)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtPNgayvaolam);
            this.groupBox1.Controls.Add(this.dtPNgaySinhNV);
            this.groupBox1.Controls.Add(this.rdoNuNv);
            this.groupBox1.Controls.Add(this.rdoNamNv);
            this.groupBox1.Controls.Add(this.cobChucVu);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.txtMaNv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(30, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 182);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtPNgayvaolam
            // 
            this.dtPNgayvaolam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPNgayvaolam.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPNgayvaolam.Location = new System.Drawing.Point(429, 71);
            this.dtPNgayvaolam.Name = "dtPNgayvaolam";
            this.dtPNgayvaolam.Size = new System.Drawing.Size(200, 34);
            this.dtPNgayvaolam.TabIndex = 3;
            this.dtPNgayvaolam.Value = new System.DateTime(2023, 5, 10, 0, 0, 0, 0);
            this.dtPNgayvaolam.ValueChanged += new System.EventHandler(this.dtPNgayvaolam1_ValueChanged);
            // 
            // dtPNgaySinhNV
            // 
            this.dtPNgaySinhNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPNgaySinhNV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPNgaySinhNV.Location = new System.Drawing.Point(429, 24);
            this.dtPNgaySinhNV.Name = "dtPNgaySinhNV";
            this.dtPNgaySinhNV.Size = new System.Drawing.Size(200, 34);
            this.dtPNgaySinhNV.TabIndex = 3;
            this.dtPNgaySinhNV.Value = new System.DateTime(2023, 5, 10, 0, 0, 0, 0);
            this.dtPNgaySinhNV.ValueChanged += new System.EventHandler(this.dtPNgaySinhNV_ValueChanged);
            // 
            // rdoNuNv
            // 
            this.rdoNuNv.AutoSize = true;
            this.rdoNuNv.Location = new System.Drawing.Point(527, 114);
            this.rdoNuNv.Name = "rdoNuNv";
            this.rdoNuNv.Size = new System.Drawing.Size(53, 25);
            this.rdoNuNv.TabIndex = 4;
            this.rdoNuNv.TabStop = true;
            this.rdoNuNv.Text = "Nữ";
            this.rdoNuNv.UseVisualStyleBackColor = true;
            // 
            // rdoNamNv
            // 
            this.rdoNamNv.AutoSize = true;
            this.rdoNamNv.Location = new System.Drawing.Point(418, 112);
            this.rdoNamNv.Name = "rdoNamNv";
            this.rdoNamNv.Size = new System.Drawing.Size(70, 25);
            this.rdoNamNv.TabIndex = 4;
            this.rdoNamNv.TabStop = true;
            this.rdoNamNv.Text = "Nam";
            this.rdoNamNv.UseVisualStyleBackColor = true;
            // 
            // cobChucVu
            // 
            this.cobChucVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobChucVu.FormattingEnabled = true;
            this.cobChucVu.Items.AddRange(new object[] {
            "Trưởng phòng",
            "Quản lý",
            "Nhân viên"});
            this.cobChucVu.Location = new System.Drawing.Point(127, 110);
            this.cobChucVu.Name = "cobChucVu";
            this.cobChucVu.Size = new System.Drawing.Size(153, 31);
            this.cobChucVu.TabIndex = 2;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(127, 71);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(153, 26);
            this.txtTenNV.TabIndex = 1;
            // 
            // txtMaNv
            // 
            this.txtMaNv.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNv.Location = new System.Drawing.Point(127, 28);
            this.txtMaNv.Name = "txtMaNv";
            this.txtMaNv.Size = new System.Drawing.Size(153, 26);
            this.txtMaNv.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.SandyBrown;
            this.label3.Location = new System.Drawing.Point(26, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chức vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SandyBrown;
            this.label2.Location = new System.Drawing.Point(25, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhân viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.SandyBrown;
            this.label6.Location = new System.Drawing.Point(308, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.SandyBrown;
            this.label5.Location = new System.Drawing.Point(308, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày vào làm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.SandyBrown;
            this.label4.Location = new System.Drawing.Point(308, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.SandyBrown;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SandyBrown;
            this.label7.Location = new System.Drawing.Point(55, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Danh sách nhân viên";
            // 
            // dGVNV
            // 
            this.dGVNV.BackgroundColor = System.Drawing.Color.DarkRed;
            this.dGVNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.ChucVu,
            this.NgaySinh,
            this.GioiTinhNV,
            this.NgayVaoLam});
            this.dGVNV.GridColor = System.Drawing.Color.DarkRed;
            this.dGVNV.Location = new System.Drawing.Point(30, 268);
            this.dGVNV.Name = "dGVNV";
            this.dGVNV.RowHeadersWidth = 51;
            this.dGVNV.Size = new System.Drawing.Size(648, 204);
            this.dGVNV.TabIndex = 1;
            this.dGVNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVNV_CellClick);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 80;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên nhân viên";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            this.TenNV.Width = 150;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "Chức vụ";
            this.ChucVu.MinimumWidth = 6;
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.Width = 125;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.Width = 120;
            // 
            // GioiTinhNV
            // 
            this.GioiTinhNV.DataPropertyName = "GioiTinhNV";
            this.GioiTinhNV.HeaderText = "Giới tính";
            this.GioiTinhNV.MinimumWidth = 6;
            this.GioiTinhNV.Name = "GioiTinhNV";
            this.GioiTinhNV.Width = 50;
            // 
            // NgayVaoLam
            // 
            this.NgayVaoLam.DataPropertyName = "NgayVaoLam";
            this.NgayVaoLam.HeaderText = "Ngày vào làm";
            this.NgayVaoLam.MinimumWidth = 6;
            this.NgayVaoLam.Name = "NgayVaoLam";
            this.NgayVaoLam.Width = 120;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.btnTkNV);
            this.groupBox2.Controls.Add(this.cobTkNV);
            this.groupBox2.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox2.Location = new System.Drawing.Point(703, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 182);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm nhân viên";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(162, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnTkNV
            // 
            this.btnTkNV.BackColor = System.Drawing.SystemColors.Control;
            this.btnTkNV.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnTkNV.Location = new System.Drawing.Point(16, 94);
            this.btnTkNV.Name = "btnTkNV";
            this.btnTkNV.Size = new System.Drawing.Size(178, 40);
            this.btnTkNV.TabIndex = 3;
            this.btnTkNV.Text = "Tìm kiếm ";
            this.btnTkNV.UseVisualStyleBackColor = false;
            this.btnTkNV.Click += new System.EventHandler(this.btnTkNV_Click);
            // 
            // cobTkNV
            // 
            this.cobTkNV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobTkNV.FormattingEnabled = true;
            this.cobTkNV.Location = new System.Drawing.Point(16, 32);
            this.cobTkNV.Name = "cobTkNV";
            this.cobTkNV.Size = new System.Drawing.Size(178, 30);
            this.cobTkNV.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox9);
            this.groupBox3.Controls.Add(this.btnLammoiNV);
            this.groupBox3.Controls.Add(this.textBox8);
            this.groupBox3.Controls.Add(this.btnXoaNV);
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.Controls.Add(this.btnSuaNV);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.btnThemNV);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Location = new System.Drawing.Point(703, 248);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 224);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xử lý";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Control;
            this.textBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox9.HideSelection = false;
            this.textBox9.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox9.Location = new System.Drawing.Point(109, 187);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(72, 21);
            this.textBox9.TabIndex = 7;
            this.textBox9.Text = "Làm mới";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLammoiNV
            // 
            this.btnLammoiNV.BackColor = System.Drawing.SystemColors.Control;
            this.btnLammoiNV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLammoiNV.BackgroundImage")));
            this.btnLammoiNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLammoiNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLammoiNV.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLammoiNV.Location = new System.Drawing.Point(108, 125);
            this.btnLammoiNV.Name = "btnLammoiNV";
            this.btnLammoiNV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLammoiNV.Size = new System.Drawing.Size(75, 70);
            this.btnLammoiNV.TabIndex = 6;
            this.btnLammoiNV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLammoiNV.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnLammoiNV.UseCompatibleTextRendering = true;
            this.btnLammoiNV.UseVisualStyleBackColor = false;
            this.btnLammoiNV.Click += new System.EventHandler(this.btnLammoiNV_Click);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Control;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox8.HideSelection = false;
            this.textBox8.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox8.Location = new System.Drawing.Point(17, 187);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(72, 21);
            this.textBox8.TabIndex = 5;
            this.textBox8.Text = "Xóa";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoaNV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaNV.BackgroundImage")));
            this.btnXoaNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoaNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaNV.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoaNV.Location = new System.Drawing.Point(16, 125);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnXoaNV.Size = new System.Drawing.Size(75, 70);
            this.btnXoaNV.TabIndex = 4;
            this.btnXoaNV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoaNV.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnXoaNV.UseCompatibleTextRendering = true;
            this.btnXoaNV.UseVisualStyleBackColor = false;
            this.btnXoaNV.Click += new System.EventHandler(this.btnXoaNV_Click);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox7.HideSelection = false;
            this.textBox7.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox7.Location = new System.Drawing.Point(108, 87);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(72, 21);
            this.textBox7.TabIndex = 3;
            this.textBox7.Text = "Sửa";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.BackColor = System.Drawing.SystemColors.Control;
            this.btnSuaNV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuaNV.BackgroundImage")));
            this.btnSuaNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuaNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaNV.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSuaNV.Location = new System.Drawing.Point(107, 25);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSuaNV.Size = new System.Drawing.Size(75, 70);
            this.btnSuaNV.TabIndex = 2;
            this.btnSuaNV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSuaNV.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSuaNV.UseCompatibleTextRendering = true;
            this.btnSuaNV.UseVisualStyleBackColor = false;
            this.btnSuaNV.Click += new System.EventHandler(this.btnSuaNV_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox4.HideSelection = false;
            this.textBox4.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox4.Location = new System.Drawing.Point(16, 87);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(72, 21);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = "Thêm";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.SystemColors.Control;
            this.btnThemNV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemNV.BackgroundImage")));
            this.btnThemNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThemNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemNV.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThemNV.Location = new System.Drawing.Point(15, 25);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnThemNV.Size = new System.Drawing.Size(75, 70);
            this.btnThemNV.TabIndex = 0;
            this.btnThemNV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThemNV.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnThemNV.UseCompatibleTextRendering = true;
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(942, 503);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dGVNV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVNV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoNuNv;
        private System.Windows.Forms.RadioButton rdoNamNv;
        private System.Windows.Forms.ComboBox cobChucVu;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dGVNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinhNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayVaoLam;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cobTkNV;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnTkNV;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button btnLammoiNV;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtPNgayvaolam;
        private System.Windows.Forms.DateTimePicker dtPNgaySinhNV;
    }
}