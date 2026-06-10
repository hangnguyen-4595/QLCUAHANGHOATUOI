namespace QLCUAHANGHOATUOI.GUI
{
    partial class frmSanphamNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanphamNV));
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlXinchao = new Guna.UI2.WinForms.Guna2Panel();
            this.dtpNgaythang = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblTenvaitro = new System.Windows.Forms.Label();
            this.lblVaitro = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblXinchao = new System.Windows.Forms.Label();
            this.pnlAnhchao = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSanpham = new Guna.UI2.WinForms.Guna2Button();
            this.pnlLanghoa = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThongke = new Guna.UI2.WinForms.Guna2Button();
            this.btnHoadon = new Guna.UI2.WinForms.Guna2Button();
            this.btnKhachhang = new Guna.UI2.WinForms.Guna2Button();
            this.pnlLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.btnQuaylai = new Guna.UI2.WinForms.Guna2Button();
            this.pnlMain.SuspendLayout();
            this.pnlXinchao.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlMain.BorderColor = System.Drawing.Color.Black;
            this.pnlMain.BorderRadius = 3;
            this.pnlMain.Controls.Add(this.pnlXinchao);
            this.pnlMain.Controls.Add(this.pnlMenu);
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1510, 819);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlXinchao
            // 
            this.pnlXinchao.BackColor = System.Drawing.Color.Transparent;
            this.pnlXinchao.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlXinchao.BorderThickness = 3;
            this.pnlXinchao.Controls.Add(this.dtpNgaythang);
            this.pnlXinchao.Controls.Add(this.lblTenvaitro);
            this.pnlXinchao.Controls.Add(this.lblVaitro);
            this.pnlXinchao.Controls.Add(this.lblTen);
            this.pnlXinchao.Controls.Add(this.lblXinchao);
            this.pnlXinchao.Controls.Add(this.pnlAnhchao);
            this.pnlXinchao.CustomBorderColor = System.Drawing.Color.Black;
            this.pnlXinchao.FillColor = System.Drawing.Color.Transparent;
            this.pnlXinchao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlXinchao.Location = new System.Drawing.Point(301, 3);
            this.pnlXinchao.Name = "pnlXinchao";
            this.pnlXinchao.Size = new System.Drawing.Size(1206, 112);
            this.pnlXinchao.TabIndex = 1;
            // 
            // dtpNgaythang
            // 
            this.dtpNgaythang.Checked = true;
            this.dtpNgaythang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtpNgaythang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgaythang.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgaythang.Location = new System.Drawing.Point(844, 31);
            this.dtpNgaythang.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaythang.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaythang.Name = "dtpNgaythang";
            this.dtpNgaythang.Size = new System.Drawing.Size(242, 36);
            this.dtpNgaythang.TabIndex = 5;
            this.dtpNgaythang.Value = new System.DateTime(2026, 6, 4, 21, 43, 43, 114);
            // 
            // lblTenvaitro
            // 
            this.lblTenvaitro.AutoSize = true;
            this.lblTenvaitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenvaitro.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTenvaitro.Location = new System.Drawing.Point(334, 58);
            this.lblTenvaitro.Name = "lblTenvaitro";
            this.lblTenvaitro.Size = new System.Drawing.Size(100, 22);
            this.lblTenvaitro.TabIndex = 4;
            this.lblTenvaitro.Text = "Nhân viên";
            // 
            // lblVaitro
            // 
            this.lblVaitro.AutoSize = true;
            this.lblVaitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaitro.Location = new System.Drawing.Point(193, 58);
            this.lblVaitro.Name = "lblVaitro";
            this.lblVaitro.Size = new System.Drawing.Size(81, 22);
            this.lblVaitro.TabIndex = 3;
            this.lblVaitro.Text = "Vai trò: ";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTen.Location = new System.Drawing.Point(334, 16);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(169, 22);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Nguyễn Thị Linh !\r\n";
            // 
            // lblXinchao
            // 
            this.lblXinchao.AutoSize = true;
            this.lblXinchao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXinchao.Location = new System.Drawing.Point(193, 16);
            this.lblXinchao.Name = "lblXinchao";
            this.lblXinchao.Size = new System.Drawing.Size(100, 22);
            this.lblXinchao.TabIndex = 1;
            this.lblXinchao.Text = "Xin chào: ";
            // 
            // pnlAnhchao
            // 
            this.pnlAnhchao.BackgroundImage = global::QLCUAHANGHOATUOI.Properties.Resources.ảnh;
            this.pnlAnhchao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlAnhchao.Location = new System.Drawing.Point(3, 3);
            this.pnlAnhchao.Name = "pnlAnhchao";
            this.pnlAnhchao.Size = new System.Drawing.Size(112, 106);
            this.pnlAnhchao.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlMenu.BorderThickness = 5;
            this.pnlMenu.Controls.Add(this.btnQuaylai);
            this.pnlMenu.Controls.Add(this.btnSanpham);
            this.pnlMenu.Controls.Add(this.pnlLanghoa);
            this.pnlMenu.Controls.Add(this.btnThongke);
            this.pnlMenu.Controls.Add(this.btnHoadon);
            this.pnlMenu.Controls.Add(this.btnKhachhang);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.CustomBorderColor = System.Drawing.Color.Black;
            this.pnlMenu.Location = new System.Drawing.Point(0, 3);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(295, 797);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnSanpham
            // 
            this.btnSanpham.BorderColor = System.Drawing.Color.White;
            this.btnSanpham.BorderRadius = 15;
            this.btnSanpham.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnSanpham.BorderThickness = 3;
            this.btnSanpham.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSanpham.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSanpham.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSanpham.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSanpham.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanpham.ForeColor = System.Drawing.Color.Black;
            this.btnSanpham.Image = ((System.Drawing.Image)(resources.GetObject("btnSanpham.Image")));
            this.btnSanpham.Location = new System.Drawing.Point(36, 228);
            this.btnSanpham.Name = "btnSanpham";
            this.btnSanpham.Size = new System.Drawing.Size(218, 45);
            this.btnSanpham.TabIndex = 11;
            this.btnSanpham.Text = "Sản phẩm";
            // 
            // pnlLanghoa
            // 
            this.pnlLanghoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLanghoa.BackgroundImage")));
            this.pnlLanghoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLanghoa.Location = new System.Drawing.Point(6, 676);
            this.pnlLanghoa.Name = "pnlLanghoa";
            this.pnlLanghoa.Size = new System.Drawing.Size(292, 121);
            this.pnlLanghoa.TabIndex = 10;
            // 
            // btnThongke
            // 
            this.btnThongke.BorderColor = System.Drawing.Color.White;
            this.btnThongke.BorderRadius = 15;
            this.btnThongke.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnThongke.BorderThickness = 3;
            this.btnThongke.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThongke.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThongke.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThongke.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThongke.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongke.ForeColor = System.Drawing.Color.Black;
            this.btnThongke.Image = ((System.Drawing.Image)(resources.GetObject("btnThongke.Image")));
            this.btnThongke.Location = new System.Drawing.Point(36, 451);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(218, 45);
            this.btnThongke.TabIndex = 7;
            this.btnThongke.Text = "Thống kê";
            // 
            // btnHoadon
            // 
            this.btnHoadon.BorderColor = System.Drawing.Color.White;
            this.btnHoadon.BorderRadius = 15;
            this.btnHoadon.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnHoadon.BorderThickness = 3;
            this.btnHoadon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHoadon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHoadon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHoadon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHoadon.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoadon.ForeColor = System.Drawing.Color.Black;
            this.btnHoadon.Image = ((System.Drawing.Image)(resources.GetObject("btnHoadon.Image")));
            this.btnHoadon.Location = new System.Drawing.Point(36, 377);
            this.btnHoadon.Name = "btnHoadon";
            this.btnHoadon.Size = new System.Drawing.Size(218, 45);
            this.btnHoadon.TabIndex = 5;
            this.btnHoadon.Text = "Hoá Đơn";
            // 
            // btnKhachhang
            // 
            this.btnKhachhang.BorderColor = System.Drawing.Color.White;
            this.btnKhachhang.BorderRadius = 15;
            this.btnKhachhang.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnKhachhang.BorderThickness = 3;
            this.btnKhachhang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKhachhang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKhachhang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKhachhang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKhachhang.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachhang.ForeColor = System.Drawing.Color.Black;
            this.btnKhachhang.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachhang.Image")));
            this.btnKhachhang.Location = new System.Drawing.Point(36, 301);
            this.btnKhachhang.Name = "btnKhachhang";
            this.btnKhachhang.Size = new System.Drawing.Size(218, 45);
            this.btnKhachhang.TabIndex = 2;
            this.btnKhachhang.Text = "Khách Hàng";
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLogo.BackgroundImage")));
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(295, 159);
            this.pnlLogo.TabIndex = 0;
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.BorderColor = System.Drawing.Color.White;
            this.btnQuaylai.BorderRadius = 15;
            this.btnQuaylai.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnQuaylai.BorderThickness = 3;
            this.btnQuaylai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnQuaylai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnQuaylai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnQuaylai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnQuaylai.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuaylai.ForeColor = System.Drawing.Color.Black;
            this.btnQuaylai.Location = new System.Drawing.Point(36, 517);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(108, 45);
            this.btnQuaylai.TabIndex = 12;
            this.btnQuaylai.Text = "Quay lại";
            // 
            // frmSanphamNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1638, 937);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSanphamNV";
            this.Text = "frmSanphamNV";
            this.pnlMain.ResumeLayout(false);
            this.pnlXinchao.ResumeLayout(false);
            this.pnlXinchao.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2Panel pnlXinchao;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaythang;
        private System.Windows.Forms.Label lblTenvaitro;
        private System.Windows.Forms.Label lblVaitro;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblXinchao;
        private Guna.UI2.WinForms.Guna2Panel pnlAnhchao;
        private Guna.UI2.WinForms.Guna2Panel pnlMenu;
        private Guna.UI2.WinForms.Guna2Button btnSanpham;
        private Guna.UI2.WinForms.Guna2Panel pnlLanghoa;
        private Guna.UI2.WinForms.Guna2Button btnThongke;
        private Guna.UI2.WinForms.Guna2Button btnHoadon;
        private Guna.UI2.WinForms.Guna2Button btnKhachhang;
        private Guna.UI2.WinForms.Guna2Panel pnlLogo;
        private Guna.UI2.WinForms.Guna2Button btnQuaylai;
    }
}