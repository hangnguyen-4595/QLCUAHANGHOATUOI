namespace QLCUAHANGHOATUOI.GUI
{
    partial class frmTaikhoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaikhoan));
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvTaikhoan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colTenDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVaitro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTaikhoan = new System.Windows.Forms.Label();
            this.pnlXinchao = new Guna.UI2.WinForms.Guna2Panel();
            this.dtpNgaythang = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblTenvaitro = new System.Windows.Forms.Label();
            this.lblVaitro = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblXinchao = new System.Windows.Forms.Label();
            this.pnlMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnQuaylai = new Guna.UI2.WinForms.Guna2Button();
            this.pnlAnhchao = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlLanghoa = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDangxuat = new Guna.UI2.WinForms.Guna2Button();
            this.btnTaikhoan = new Guna.UI2.WinForms.Guna2Button();
            this.btnThongke = new Guna.UI2.WinForms.Guna2Button();
            this.btnBanhang = new Guna.UI2.WinForms.Guna2Button();
            this.btnSanpham = new Guna.UI2.WinForms.Guna2Button();
            this.btnTrangchu = new Guna.UI2.WinForms.Guna2Button();
            this.pnlLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.dtpNgaysinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblGioitinh = new System.Windows.Forms.Label();
            this.cboGioitinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnThemnv = new Guna.UI2.WinForms.Guna2Button();
            this.txtDiachi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSdt = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenTK = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaTK = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblThemtk = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaikhoan)).BeginInit();
            this.pnlXinchao.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlMain.BorderColor = System.Drawing.Color.Black;
            this.pnlMain.BorderRadius = 3;
            this.pnlMain.Controls.Add(this.lblNgaysinh);
            this.pnlMain.Controls.Add(this.dtpNgaysinh);
            this.pnlMain.Controls.Add(this.lblGioitinh);
            this.pnlMain.Controls.Add(this.cboGioitinh);
            this.pnlMain.Controls.Add(this.btnThemnv);
            this.pnlMain.Controls.Add(this.txtDiachi);
            this.pnlMain.Controls.Add(this.txtSdt);
            this.pnlMain.Controls.Add(this.txtTenTK);
            this.pnlMain.Controls.Add(this.txtMaTK);
            this.pnlMain.Controls.Add(this.lblThemtk);
            this.pnlMain.Controls.Add(this.dgvTaikhoan);
            this.pnlMain.Controls.Add(this.lblTaikhoan);
            this.pnlMain.Controls.Add(this.pnlXinchao);
            this.pnlMain.Controls.Add(this.pnlMenu);
            this.pnlMain.Location = new System.Drawing.Point(12, 21);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1510, 800);
            this.pnlMain.TabIndex = 1;
            // 
            // dgvTaikhoan
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTaikhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTaikhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTaikhoan.ColumnHeadersHeight = 18;
            this.dgvTaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTaikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenDN,
            this.colMatkhau,
            this.colHoten,
            this.colVaitro,
            this.colGioitinh,
            this.colSdt});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTaikhoan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTaikhoan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTaikhoan.Location = new System.Drawing.Point(343, 220);
            this.dgvTaikhoan.Name = "dgvTaikhoan";
            this.dgvTaikhoan.RowHeadersVisible = false;
            this.dgvTaikhoan.RowHeadersWidth = 51;
            this.dgvTaikhoan.RowTemplate.Height = 24;
            this.dgvTaikhoan.Size = new System.Drawing.Size(587, 430);
            this.dgvTaikhoan.TabIndex = 3;
            this.dgvTaikhoan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTaikhoan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTaikhoan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTaikhoan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTaikhoan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTaikhoan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTaikhoan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTaikhoan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTaikhoan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTaikhoan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTaikhoan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTaikhoan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTaikhoan.ThemeStyle.HeaderStyle.Height = 18;
            this.dgvTaikhoan.ThemeStyle.ReadOnly = false;
            this.dgvTaikhoan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTaikhoan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTaikhoan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTaikhoan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTaikhoan.ThemeStyle.RowsStyle.Height = 24;
            this.dgvTaikhoan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTaikhoan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colTenDN
            // 
            this.colTenDN.HeaderText = "Tên ĐN";
            this.colTenDN.MinimumWidth = 6;
            this.colTenDN.Name = "colTenDN";
            // 
            // colMatkhau
            // 
            this.colMatkhau.HeaderText = "Mật Khẩu";
            this.colMatkhau.MinimumWidth = 6;
            this.colMatkhau.Name = "colMatkhau";
            // 
            // colHoten
            // 
            this.colHoten.HeaderText = "Họ Tên";
            this.colHoten.MinimumWidth = 6;
            this.colHoten.Name = "colHoten";
            // 
            // colVaitro
            // 
            this.colVaitro.HeaderText = "Vai trò";
            this.colVaitro.MinimumWidth = 6;
            this.colVaitro.Name = "colVaitro";
            // 
            // colGioitinh
            // 
            this.colGioitinh.HeaderText = "Giới Tính ";
            this.colGioitinh.MinimumWidth = 6;
            this.colGioitinh.Name = "colGioitinh";
            // 
            // colSdt
            // 
            this.colSdt.HeaderText = "SĐT";
            this.colSdt.MinimumWidth = 6;
            this.colSdt.Name = "colSdt";
            // 
            // lblTaikhoan
            // 
            this.lblTaikhoan.AutoSize = true;
            this.lblTaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaikhoan.Location = new System.Drawing.Point(492, 154);
            this.lblTaikhoan.Name = "lblTaikhoan";
            this.lblTaikhoan.Size = new System.Drawing.Size(160, 36);
            this.lblTaikhoan.TabIndex = 2;
            this.lblTaikhoan.Text = "Tài Khoản";
            this.lblTaikhoan.Click += new System.EventHandler(this.lblTaikhoan_Click);
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
            this.pnlMenu.Controls.Add(this.btnQuaylai);
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
            this.btnQuaylai.Location = new System.Drawing.Point(36, 602);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(136, 45);
            this.btnQuaylai.TabIndex = 23;
            this.btnQuaylai.Text = "Quay lại";
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
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
            this.btnDangxuat.Location = new System.Drawing.Point(36, 541);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Size = new System.Drawing.Size(218, 45);
            this.btnDangxuat.TabIndex = 9;
            this.btnDangxuat.Text = "Đăng xuất";
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
            this.btnTaikhoan.Location = new System.Drawing.Point(36, 467);
            this.btnTaikhoan.Name = "btnTaikhoan";
            this.btnTaikhoan.Size = new System.Drawing.Size(218, 45);
            this.btnTaikhoan.TabIndex = 8;
            this.btnTaikhoan.Text = "Tài khoản";
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
            this.btnThongke.Location = new System.Drawing.Point(36, 394);
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
            this.btnBanhang.Location = new System.Drawing.Point(36, 324);
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
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaysinh.Location = new System.Drawing.Point(1029, 492);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(90, 22);
            this.lblNgaysinh.TabIndex = 30;
            this.lblNgaysinh.Text = "Ngày sinh";
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Checked = true;
            this.dtpNgaysinh.FillColor = System.Drawing.Color.White;
            this.dtpNgaysinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgaysinh.Location = new System.Drawing.Point(1142, 492);
            this.dtpNgaysinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaysinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(200, 36);
            this.dtpNgaysinh.TabIndex = 29;
            this.dtpNgaysinh.Value = new System.DateTime(2026, 6, 7, 13, 19, 32, 395);
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.AutoSize = true;
            this.lblGioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioitinh.Location = new System.Drawing.Point(1029, 452);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(76, 22);
            this.lblGioitinh.TabIndex = 28;
            this.lblGioitinh.Text = "Giới tính";
            // 
            // cboGioitinh
            // 
            this.cboGioitinh.BackColor = System.Drawing.Color.Transparent;
            this.cboGioitinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioitinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboGioitinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboGioitinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboGioitinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboGioitinh.ItemHeight = 30;
            this.cboGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioitinh.Location = new System.Drawing.Point(1142, 438);
            this.cboGioitinh.Name = "cboGioitinh";
            this.cboGioitinh.Size = new System.Drawing.Size(193, 36);
            this.cboGioitinh.TabIndex = 27;
            // 
            // btnThemnv
            // 
            this.btnThemnv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemnv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemnv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemnv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemnv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemnv.ForeColor = System.Drawing.Color.White;
            this.btnThemnv.Location = new System.Drawing.Point(1142, 567);
            this.btnThemnv.Name = "btnThemnv";
            this.btnThemnv.Size = new System.Drawing.Size(180, 45);
            this.btnThemnv.TabIndex = 26;
            this.btnThemnv.Text = "Thêm NV";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiachi.DefaultText = "";
            this.txtDiachi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiachi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiachi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiachi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiachi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiachi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiachi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiachi.Location = new System.Drawing.Point(1245, 360);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.PlaceholderText = "Địa chỉ";
            this.txtDiachi.SelectedText = "";
            this.txtDiachi.Size = new System.Drawing.Size(193, 48);
            this.txtDiachi.TabIndex = 25;
            // 
            // txtSdt
            // 
            this.txtSdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSdt.DefaultText = "";
            this.txtSdt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSdt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSdt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSdt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSdt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSdt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSdt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSdt.Location = new System.Drawing.Point(1005, 357);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.PlaceholderText = "SĐT";
            this.txtSdt.SelectedText = "";
            this.txtSdt.Size = new System.Drawing.Size(193, 48);
            this.txtSdt.TabIndex = 24;
            // 
            // txtTenTK
            // 
            this.txtTenTK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTK.DefaultText = "";
            this.txtTenTK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenTK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTK.Location = new System.Drawing.Point(1245, 283);
            this.txtTenTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.PlaceholderText = "Tên nhân viên";
            this.txtTenTK.SelectedText = "";
            this.txtTenTK.Size = new System.Drawing.Size(193, 48);
            this.txtTenTK.TabIndex = 23;
            // 
            // txtMaTK
            // 
            this.txtMaTK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaTK.DefaultText = "";
            this.txtMaTK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaTK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaTK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaTK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaTK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaTK.Location = new System.Drawing.Point(1005, 283);
            this.txtMaTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.PlaceholderText = "Mã tài khoản";
            this.txtMaTK.SelectedText = "";
            this.txtMaTK.Size = new System.Drawing.Size(193, 48);
            this.txtMaTK.TabIndex = 22;
            // 
            // lblThemtk
            // 
            this.lblThemtk.AutoSize = true;
            this.lblThemtk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemtk.Location = new System.Drawing.Point(1128, 210);
            this.lblThemtk.Name = "lblThemtk";
            this.lblThemtk.Size = new System.Drawing.Size(202, 29);
            this.lblThemtk.TabIndex = 21;
            this.lblThemtk.Text = "Thêm Tài khoản";
            this.lblThemtk.Click += new System.EventHandler(this.lblThemnv_Click);
            // 
            // frmTaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1638, 937);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTaikhoan";
            this.Text = "frmTaikhoan";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaikhoan)).EndInit();
            this.pnlXinchao.ResumeLayout(false);
            this.pnlXinchao.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlMain;
        private System.Windows.Forms.Label lblTaikhoan;
        private Guna.UI2.WinForms.Guna2Panel pnlXinchao;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaythang;
        private System.Windows.Forms.Label lblTenvaitro;
        private System.Windows.Forms.Label lblVaitro;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblXinchao;
        private Guna.UI2.WinForms.Guna2Panel pnlAnhchao;
        private Guna.UI2.WinForms.Guna2Panel pnlMenu;
        private Guna.UI2.WinForms.Guna2Panel pnlLanghoa;
        private Guna.UI2.WinForms.Guna2Button btnDangxuat;
        private Guna.UI2.WinForms.Guna2Button btnTaikhoan;
        private Guna.UI2.WinForms.Guna2Button btnThongke;
        private Guna.UI2.WinForms.Guna2Button btnBanhang;
        private Guna.UI2.WinForms.Guna2Button btnSanpham;
        private Guna.UI2.WinForms.Guna2Button btnTrangchu;
        private Guna.UI2.WinForms.Guna2Panel pnlLogo;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTaikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVaitro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSdt;
        private Guna.UI2.WinForms.Guna2Button btnQuaylai;
        private System.Windows.Forms.Label lblNgaysinh;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.Label lblGioitinh;
        private Guna.UI2.WinForms.Guna2ComboBox cboGioitinh;
        private Guna.UI2.WinForms.Guna2Button btnThemnv;
        private Guna.UI2.WinForms.Guna2TextBox txtDiachi;
        private Guna.UI2.WinForms.Guna2TextBox txtSdt;
        private Guna.UI2.WinForms.Guna2TextBox txtTenTK;
        private Guna.UI2.WinForms.Guna2TextBox txtMaTK;
        private System.Windows.Forms.Label lblThemtk;
    }
}