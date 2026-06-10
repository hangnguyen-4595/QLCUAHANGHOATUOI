namespace QLCUAHANGHOATUOI.GUI
{
    partial class frmManchinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManchinh));
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlXinchao = new Guna.UI2.WinForms.Guna2Panel();
            this.dtpNgaythang = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblTenvaitro = new System.Windows.Forms.Label();
            this.lblVaitro = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblXinchao = new System.Windows.Forms.Label();
            this.pnlMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlAnhchao = new Guna.UI2.WinForms.Guna2Panel();
            this.btnNhanvien = new Guna.UI2.WinForms.Guna2Button();
            this.pnlLanghoa = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDangxuat = new Guna.UI2.WinForms.Guna2Button();
            this.btnTaikhoan = new Guna.UI2.WinForms.Guna2Button();
            this.btnThongke = new Guna.UI2.WinForms.Guna2Button();
            this.btnBanhang = new Guna.UI2.WinForms.Guna2Button();
            this.btnSanpham = new Guna.UI2.WinForms.Guna2Button();
            this.btnTrangchu = new Guna.UI2.WinForms.Guna2Button();
            this.pnlLogo = new Guna.UI2.WinForms.Guna2Panel();
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
            this.pnlMain.Size = new System.Drawing.Size(1510, 800);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
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
            this.lblTenvaitro.Size = new System.Drawing.Size(125, 22);
            this.lblTenvaitro.TabIndex = 4;
            this.lblTenvaitro.Text = "Quản trị viên";
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
            this.lblTen.Size = new System.Drawing.Size(178, 22);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Nguyễn Thị Hằng !\r\n";
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
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlMenu.BorderThickness = 5;
            this.pnlMenu.Controls.Add(this.btnNhanvien);
            this.pnlMenu.Controls.Add(this.pnlLanghoa);
            this.pnlMenu.Controls.Add(this.btnDangxuat);
            this.pnlMenu.Controls.Add(this.btnTaikhoan);
            this.pnlMenu.Controls.Add(this.btnThongke);
            this.pnlMenu.Controls.Add(this.btnBanhang);
            this.pnlMenu.Controls.Add(this.btnSanpham);
            this.pnlMenu.Controls.Add(this.btnTrangchu);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.CustomBorderColor = System.Drawing.Color.Black;
            this.pnlMenu.Location = new System.Drawing.Point(0, 3);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(295, 797);
            this.pnlMenu.TabIndex = 0;
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
            // btnNhanvien
            // 
            this.btnNhanvien.BorderColor = System.Drawing.Color.White;
            this.btnNhanvien.BorderRadius = 15;
            this.btnNhanvien.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnNhanvien.BorderThickness = 3;
            this.btnNhanvien.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNhanvien.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNhanvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNhanvien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNhanvien.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanvien.ForeColor = System.Drawing.Color.Black;
            this.btnNhanvien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanvien.Image")));
            this.btnNhanvien.Location = new System.Drawing.Point(36, 321);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Size = new System.Drawing.Size(218, 45);
            this.btnNhanvien.TabIndex = 11;
            this.btnNhanvien.Text = "Nhân viên ";
            this.btnNhanvien.Click += new System.EventHandler(this.btnNhanvien_Click);
            // 
            // pnlLanghoa
            // 
            this.pnlLanghoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLanghoa.BackgroundImage")));
            this.pnlLanghoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLanghoa.Location = new System.Drawing.Point(0, 673);
            this.pnlLanghoa.Name = "pnlLanghoa";
            this.pnlLanghoa.Size = new System.Drawing.Size(292, 121);
            this.pnlLanghoa.TabIndex = 10;
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.BorderColor = System.Drawing.Color.White;
            this.btnDangxuat.BorderRadius = 15;
            this.btnDangxuat.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnDangxuat.BorderThickness = 3;
            this.btnDangxuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangxuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangxuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangxuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangxuat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangxuat.ForeColor = System.Drawing.Color.Black;
            this.btnDangxuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangxuat.Image")));
            this.btnDangxuat.Location = new System.Drawing.Point(36, 581);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Size = new System.Drawing.Size(218, 45);
            this.btnDangxuat.TabIndex = 9;
            this.btnDangxuat.Text = "Đăng xuất";
            this.btnDangxuat.Click += new System.EventHandler(this.btnDangxuat_Click);
            // 
            // btnTaikhoan
            // 
            this.btnTaikhoan.BorderColor = System.Drawing.Color.White;
            this.btnTaikhoan.BorderRadius = 15;
            this.btnTaikhoan.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnTaikhoan.BorderThickness = 3;
            this.btnTaikhoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTaikhoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTaikhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTaikhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTaikhoan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaikhoan.ForeColor = System.Drawing.Color.Black;
            this.btnTaikhoan.Image = ((System.Drawing.Image)(resources.GetObject("btnTaikhoan.Image")));
            this.btnTaikhoan.Location = new System.Drawing.Point(36, 517);
            this.btnTaikhoan.Name = "btnTaikhoan";
            this.btnTaikhoan.Size = new System.Drawing.Size(218, 45);
            this.btnTaikhoan.TabIndex = 8;
            this.btnTaikhoan.Text = "Tài khoản";
            this.btnTaikhoan.Click += new System.EventHandler(this.btnTaikhoan_Click);
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
            this.btnThongke.Location = new System.Drawing.Point(36, 454);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(218, 45);
            this.btnThongke.TabIndex = 7;
            this.btnThongke.Text = "Thống kê";
            // 
            // btnBanhang
            // 
            this.btnBanhang.BorderColor = System.Drawing.Color.White;
            this.btnBanhang.BorderRadius = 15;
            this.btnBanhang.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnBanhang.BorderThickness = 3;
            this.btnBanhang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBanhang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBanhang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBanhang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBanhang.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanhang.ForeColor = System.Drawing.Color.Black;
            this.btnBanhang.Image = ((System.Drawing.Image)(resources.GetObject("btnBanhang.Image")));
            this.btnBanhang.Location = new System.Drawing.Point(36, 385);
            this.btnBanhang.Name = "btnBanhang";
            this.btnBanhang.Size = new System.Drawing.Size(218, 45);
            this.btnBanhang.TabIndex = 5;
            this.btnBanhang.Text = "Lịch sử đơn hàng";
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
            this.btnSanpham.Location = new System.Drawing.Point(36, 256);
            this.btnSanpham.Name = "btnSanpham";
            this.btnSanpham.Size = new System.Drawing.Size(218, 45);
            this.btnSanpham.TabIndex = 2;
            this.btnSanpham.Text = "Sản phẩm";
            this.btnSanpham.Click += new System.EventHandler(this.btnSanpham_Click_1);
            // 
            // btnTrangchu
            // 
            this.btnTrangchu.BorderColor = System.Drawing.Color.White;
            this.btnTrangchu.BorderRadius = 15;
            this.btnTrangchu.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnTrangchu.BorderThickness = 3;
            this.btnTrangchu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTrangchu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTrangchu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTrangchu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTrangchu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangchu.ForeColor = System.Drawing.Color.Black;
            this.btnTrangchu.Image = ((System.Drawing.Image)(resources.GetObject("btnTrangchu.Image")));
            this.btnTrangchu.Location = new System.Drawing.Point(36, 191);
            this.btnTrangchu.Name = "btnTrangchu";
            this.btnTrangchu.Size = new System.Drawing.Size(218, 45);
            this.btnTrangchu.TabIndex = 1;
            this.btnTrangchu.Text = "Trang chủ";
            this.btnTrangchu.Click += new System.EventHandler(this.btnTrangchu_Click);
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
            // frmManchinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1638, 937);
            this.Controls.Add(this.pnlMain);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManchinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.pnlMain.ResumeLayout(false);
            this.pnlXinchao.ResumeLayout(false);
            this.pnlXinchao.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private Guna.UI2.WinForms.Guna2Panel pnlMenu;
        private Guna.UI2.WinForms.Guna2Panel pnlLogo;
        private Guna.UI2.WinForms.Guna2Button btnTrangchu;
        private Guna.UI2.WinForms.Guna2Button btnBanhang;
        private Guna.UI2.WinForms.Guna2Button btnSanpham;
        private Guna.UI2.WinForms.Guna2Button btnDangxuat;
        private Guna.UI2.WinForms.Guna2Button btnTaikhoan;
        private Guna.UI2.WinForms.Guna2Button btnThongke;
        private Guna.UI2.WinForms.Guna2Panel pnlLanghoa;
        private Guna.UI2.WinForms.Guna2Panel pnlXinchao;
        private Guna.UI2.WinForms.Guna2Panel pnlAnhchao;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblXinchao;
        private System.Windows.Forms.Label lblTenvaitro;
        private System.Windows.Forms.Label lblVaitro;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaythang;
        private Guna.UI2.WinForms.Guna2Button btnNhanvien;
    }
}