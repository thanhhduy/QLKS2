namespace QLKS2
{
    partial class frmHoaDon
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BaoCao5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLKSDataSet = new QLKS2.QLKSDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXemHD = new System.Windows.Forms.Button();
            this.cobMaHD = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rpHoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BaoCao5TableAdapter = new QLKS2.QLKSDataSetTableAdapters.BaoCao5TableAdapter();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnHuyHD = new System.Windows.Forms.Button();
            this.txtMaPHD = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCao5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLKSDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BaoCao5BindingSource
            // 
            this.BaoCao5BindingSource.DataMember = "BaoCao5";
            this.BaoCao5BindingSource.DataSource = this.QLKSDataSet;
            // 
            // QLKSDataSet
            // 
            this.QLKSDataSet.DataSetName = "QLKSDataSet";
            this.QLKSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaPHD);
            this.groupBox1.Controls.Add(this.btnXemHD);
            this.groupBox1.Controls.Add(this.cobMaHD);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(25, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập mã hóa đơn";
            // 
            // btnXemHD
            // 
            this.btnXemHD.BackColor = System.Drawing.Color.YellowGreen;
            this.btnXemHD.Location = new System.Drawing.Point(296, 38);
            this.btnXemHD.Name = "btnXemHD";
            this.btnXemHD.Size = new System.Drawing.Size(123, 27);
            this.btnXemHD.TabIndex = 2;
            this.btnXemHD.Text = "Xem hóa đơn";
            this.btnXemHD.UseVisualStyleBackColor = false;
            this.btnXemHD.Click += new System.EventHandler(this.btnXemHD_Click);
            // 
            // cobMaHD
            // 
            this.cobMaHD.FormattingEnabled = true;
            this.cobMaHD.Location = new System.Drawing.Point(156, 38);
            this.cobMaHD.Name = "cobMaHD";
            this.cobMaHD.Size = new System.Drawing.Size(121, 26);
            this.cobMaHD.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // rpHoaDon
            // 
            reportDataSource1.Name = "dsHoaDon";
            reportDataSource1.Value = this.BaoCao5BindingSource;
            this.rpHoaDon.LocalReport.DataSources.Add(reportDataSource1);
            this.rpHoaDon.LocalReport.ReportEmbeddedResource = "QLKS2.rpHoaDon.rdlc";
            this.rpHoaDon.Location = new System.Drawing.Point(12, 119);
            this.rpHoaDon.Name = "rpHoaDon";
            this.rpHoaDon.ServerReport.BearerToken = null;
            this.rpHoaDon.Size = new System.Drawing.Size(512, 432);
            this.rpHoaDon.TabIndex = 1;
            // 
            // BaoCao5TableAdapter
            // 
            this.BaoCao5TableAdapter.ClearBeforeFill = true;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.YellowGreen;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(321, 557);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(139, 41);
            this.btnThanhToan.TabIndex = 3;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnHuyHD
            // 
            this.btnHuyHD.BackColor = System.Drawing.Color.Red;
            this.btnHuyHD.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyHD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHuyHD.Location = new System.Drawing.Point(64, 557);
            this.btnHuyHD.Name = "btnHuyHD";
            this.btnHuyHD.Size = new System.Drawing.Size(139, 41);
            this.btnHuyHD.TabIndex = 3;
            this.btnHuyHD.Text = "Hủy";
            this.btnHuyHD.UseVisualStyleBackColor = false;
            this.btnHuyHD.Click += new System.EventHandler(this.btnHuyHD_Click);
            // 
            // txtMaPHD
            // 
            this.txtMaPHD.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtMaPHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaPHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPHD.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtMaPHD.Location = new System.Drawing.Point(280, 42);
            this.txtMaPHD.Name = "txtMaPHD";
            this.txtMaPHD.Size = new System.Drawing.Size(10, 13);
            this.txtMaPHD.TabIndex = 4;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(536, 610);
            this.Controls.Add(this.btnHuyHD);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.rpHoaDon);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BaoCao5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLKSDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXemHD;
        private System.Windows.Forms.ComboBox cobMaHD;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer rpHoaDon;
        private System.Windows.Forms.BindingSource BaoCao5BindingSource;
        private QLKSDataSet QLKSDataSet;
        private QLKSDataSetTableAdapters.BaoCao5TableAdapter BaoCao5TableAdapter;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnHuyHD;
        private System.Windows.Forms.TextBox txtMaPHD;
    }
}