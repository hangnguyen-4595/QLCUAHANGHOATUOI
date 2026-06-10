namespace QLCUAHANGHOATUOI.GUI
{
    partial class frmDangky
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangky));
            this.lblDangky = new System.Windows.Forms.Label();
            this.lblTendangnhap = new System.Windows.Forms.Label();
            this.lblMatkhau = new System.Windows.Forms.Label();
            this.lblNhaplaimk = new System.Windows.Forms.Label();
            this.lblHoten = new System.Windows.Forms.Label();
            this.lblSdtDkTaikhoan = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblVaitro = new System.Windows.Forms.Label();
            this.txtTendangnhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.txtMatkhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHoten = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNhaplaimk = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpNgaysinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblGioitinh = new System.Windows.Forms.Label();
            this.guna2ColorTransition1 = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
            this.cboGioitinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboVaitro = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDangki = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lblDangky
            // 
            this.lblDangky.AutoSize = true;
            this.lblDangky.BackColor = System.Drawing.Color.Transparent;
            this.lblDangky.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDangky.Location = new System.Drawing.Point(977, 128);
            this.lblDangky.Name = "lblDangky";
            this.lblDangky.Size = new System.Drawing.Size(296, 41);
            this.lblDangky.TabIndex = 0;
            this.lblDangky.Text = "Đăng Ký Tài Khoản";
            this.lblDangky.Click += new System.EventHandler(this.lblDangky_Click);
            // 
            // lblTendangnhap
            // 
            this.lblTendangnhap.AutoSize = true;
            this.lblTendangnhap.BackColor = System.Drawing.Color.Transparent;
            this.lblTendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTendangnhap.Location = new System.Drawing.Point(810, 198);
            this.lblTendangnhap.Name = "lblTendangnhap";
            this.lblTendangnhap.Size = new System.Drawing.Size(181, 29);
            this.lblTendangnhap.TabIndex = 1;
            this.lblTendangnhap.Text = "Tên đăng nhập:";
            this.lblTendangnhap.Click += new System.EventHandler(this.lblTendangnhap_Click);
            // 
            // lblMatkhau
            // 
            this.lblMatkhau.AutoSize = true;
            this.lblMatkhau.BackColor = System.Drawing.Color.Transparent;
            this.lblMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatkhau.Location = new System.Drawing.Point(1115, 198);
            this.lblMatkhau.Name = "lblMatkhau";
            this.lblMatkhau.Size = new System.Drawing.Size(115, 29);
            this.lblMatkhau.TabIndex = 2;
            this.lblMatkhau.Text = "Mật khẩu:";
            // 
            // lblNhaplaimk
            // 
            this.lblNhaplaimk.AutoSize = true;
            this.lblNhaplaimk.BackColor = System.Drawing.Color.Transparent;
            this.lblNhaplaimk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhaplaimk.Location = new System.Drawing.Point(1115, 313);
            this.lblNhaplaimk.Name = "lblNhaplaimk";
            this.lblNhaplaimk.Size = new System.Drawing.Size(210, 29);
            this.lblNhaplaimk.TabIndex = 3;
            this.lblNhaplaimk.Text = "Nhập lại mật khẩu:";
            this.lblNhaplaimk.Click += new System.EventHandler(this.lblNhaplaimk_Click);
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.BackColor = System.Drawing.Color.Transparent;
            this.lblHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoten.Location = new System.Drawing.Point(810, 313);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(89, 29);
            this.lblHoten.TabIndex = 4;
            this.lblHoten.Text = "Họ tên:";
            this.lblHoten.Click += new System.EventHandler(this.lblHoten_Click);
            // 
            // lblSdtDkTaikhoan
            // 
            this.lblSdtDkTaikhoan.AutoSize = true;
            this.lblSdtDkTaikhoan.BackColor = System.Drawing.Color.Transparent;
            this.lblSdtDkTaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSdtDkTaikhoan.Location = new System.Drawing.Point(1115, 426);
            this.lblSdtDkTaikhoan.Name = "lblSdtDkTaikhoan";
            this.lblSdtDkTaikhoan.Size = new System.Drawing.Size(88, 29);
            this.lblSdtDkTaikhoan.TabIndex = 5;
            this.lblSdtDkTaikhoan.Text = "Số ĐT:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(1123, 532);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(80, 29);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // lblVaitro
            // 
            this.lblVaitro.AutoSize = true;
            this.lblVaitro.BackColor = System.Drawing.Color.Transparent;
            this.lblVaitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVaitro.Location = new System.Drawing.Point(794, 644);
            this.lblVaitro.Name = "lblVaitro";
            this.lblVaitro.Size = new System.Drawing.Size(87, 29);
            this.lblVaitro.TabIndex = 7;
            this.lblVaitro.Text = "Vai trò:";
            // 
            // txtTendangnhap
            // 
            this.txtTendangnhap.BackColor = System.Drawing.Color.Transparent;
            this.txtTendangnhap.BorderRadius = 18;
            this.txtTendangnhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTendangnhap.DefaultText = "";
            this.txtTendangnhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTendangnhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTendangnhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTendangnhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTendangnhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTendangnhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTendangnhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTendangnhap.Location = new System.Drawing.Point(799, 245);
            this.txtTendangnhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTendangnhap.Name = "txtTendangnhap";
            this.txtTendangnhap.PlaceholderText = "";
            this.txtTendangnhap.SelectedText = "";
            this.txtTendangnhap.Size = new System.Drawing.Size(252, 48);
            this.txtTendangnhap.TabIndex = 8;
            this.txtTendangnhap.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.BackColor = System.Drawing.Color.Transparent;
            this.lblNgaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaysinh.Location = new System.Drawing.Point(810, 426);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(125, 29);
            this.lblNgaysinh.TabIndex = 9;
            this.lblNgaysinh.Text = "Ngày sinh:";
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.BackColor = System.Drawing.Color.Transparent;
            this.txtMatkhau.BorderRadius = 18;
            this.txtMatkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatkhau.DefaultText = "";
            this.txtMatkhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatkhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatkhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatkhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatkhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatkhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMatkhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatkhau.Location = new System.Drawing.Point(1120, 245);
            this.txtMatkhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PlaceholderText = "";
            this.txtMatkhau.SelectedText = "";
            this.txtMatkhau.Size = new System.Drawing.Size(250, 48);
            this.txtMatkhau.TabIndex = 10;
            this.txtMatkhau.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // txtHoten
            // 
            this.txtHoten.BackColor = System.Drawing.Color.Transparent;
            this.txtHoten.BorderRadius = 18;
            this.txtHoten.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoten.DefaultText = "";
            this.txtHoten.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoten.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoten.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoten.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoten.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoten.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtHoten.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoten.Location = new System.Drawing.Point(799, 356);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.PlaceholderText = "";
            this.txtHoten.SelectedText = "";
            this.txtHoten.Size = new System.Drawing.Size(252, 49);
            this.txtHoten.TabIndex = 11;
            // 
            // txtNhaplaimk
            // 
            this.txtNhaplaimk.BackColor = System.Drawing.Color.Transparent;
            this.txtNhaplaimk.BorderRadius = 18;
            this.txtNhaplaimk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhaplaimk.DefaultText = "";
            this.txtNhaplaimk.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNhaplaimk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNhaplaimk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhaplaimk.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhaplaimk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhaplaimk.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNhaplaimk.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhaplaimk.Location = new System.Drawing.Point(1122, 356);
            this.txtNhaplaimk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNhaplaimk.Name = "txtNhaplaimk";
            this.txtNhaplaimk.PlaceholderText = "";
            this.txtNhaplaimk.SelectedText = "";
            this.txtNhaplaimk.Size = new System.Drawing.Size(250, 49);
            this.txtNhaplaimk.TabIndex = 12;
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.BackColor = System.Drawing.Color.Black;
            this.dtpNgaysinh.Checked = true;
            this.dtpNgaysinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaysinh.FillColor = System.Drawing.Color.White;
            this.dtpNgaysinh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaysinh.ForeColor = System.Drawing.Color.Black;
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaysinh.Location = new System.Drawing.Point(797, 469);
            this.dtpNgaysinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaysinh.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(252, 42);
            this.dtpNgaysinh.TabIndex = 13;
            this.dtpNgaysinh.Value = new System.DateTime(2026, 6, 3, 21, 24, 9, 945);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TextBox1.BorderRadius = 18;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(1120, 469);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(250, 41);
            this.guna2TextBox1.TabIndex = 14;
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.AutoSize = true;
            this.lblGioitinh.BackColor = System.Drawing.Color.Transparent;
            this.lblGioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioitinh.Location = new System.Drawing.Point(800, 532);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(107, 29);
            this.lblGioitinh.TabIndex = 15;
            this.lblGioitinh.Text = "Giới tính:";
            // 
            // guna2ColorTransition1
            // 
            this.guna2ColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            // 
            // cboGioitinh
            // 
            this.cboGioitinh.BackColor = System.Drawing.Color.Transparent;
            this.cboGioitinh.BorderColor = System.Drawing.Color.White;
            this.cboGioitinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioitinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboGioitinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboGioitinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboGioitinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboGioitinh.ItemHeight = 30;
            this.cboGioitinh.Location = new System.Drawing.Point(799, 574);
            this.cboGioitinh.Name = "cboGioitinh";
            this.cboGioitinh.Size = new System.Drawing.Size(250, 36);
            this.cboGioitinh.TabIndex = 16;
            this.cboGioitinh.SelectedIndexChanged += new System.EventHandler(this.cboGioitinh_SelectedIndexChanged);
            // 
            // cboVaitro
            // 
            this.cboVaitro.BackColor = System.Drawing.Color.Transparent;
            this.cboVaitro.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboVaitro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVaitro.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboVaitro.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboVaitro.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboVaitro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboVaitro.ItemHeight = 30;
            this.cboVaitro.Location = new System.Drawing.Point(913, 637);
            this.cboVaitro.Name = "cboVaitro";
            this.cboVaitro.Size = new System.Drawing.Size(251, 36);
            this.cboVaitro.TabIndex = 17;
            this.cboVaitro.SelectedIndexChanged += new System.EventHandler(this.txtVaitro_SelectedIndexChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BorderRadius = 18;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(1122, 574);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(250, 44);
            this.txtEmail.TabIndex = 18;
            // 
            // btnDangki
            // 
            this.btnDangki.BackColor = System.Drawing.Color.Transparent;
            this.btnDangki.BorderColor = System.Drawing.Color.Transparent;
            this.btnDangki.BorderRadius = 18;
            this.btnDangki.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangki.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangki.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangki.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangki.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDangki.FocusedColor = System.Drawing.Color.Black;
            this.btnDangki.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangki.ForeColor = System.Drawing.Color.White;
            this.btnDangki.Location = new System.Drawing.Point(993, 724);
            this.btnDangki.Name = "btnDangki";
            this.btnDangki.Size = new System.Drawing.Size(180, 45);
            this.btnDangki.TabIndex = 19;
            this.btnDangki.Text = "Đăng Ký";
            this.btnDangki.Click += new System.EventHandler(this.btnDangki_Click);
            // 
            // frmDangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btnDangki);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cboVaitro);
            this.Controls.Add(this.cboGioitinh);
            this.Controls.Add(this.lblGioitinh);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.dtpNgaysinh);
            this.Controls.Add(this.txtNhaplaimk);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.lblNgaysinh);
            this.Controls.Add(this.txtTendangnhap);
            this.Controls.Add(this.lblVaitro);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSdtDkTaikhoan);
            this.Controls.Add(this.lblHoten);
            this.Controls.Add(this.lblNhaplaimk);
            this.Controls.Add(this.lblMatkhau);
            this.Controls.Add(this.lblTendangnhap);
            this.Controls.Add(this.lblDangky);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDangky";
            this.Text = "frmDangky";
            this.Load += new System.EventHandler(this.frmDangky_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDangky;
        private System.Windows.Forms.Label lblTendangnhap;
        private System.Windows.Forms.Label lblMatkhau;
        private System.Windows.Forms.Label lblNhaplaimk;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.Label lblSdtDkTaikhoan;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblVaitro;
        private Guna.UI2.WinForms.Guna2TextBox txtTendangnhap;
        private System.Windows.Forms.Label lblNgaysinh;
        private Guna.UI2.WinForms.Guna2TextBox txtMatkhau;
        private Guna.UI2.WinForms.Guna2TextBox txtHoten;
        private Guna.UI2.WinForms.Guna2TextBox txtNhaplaimk;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaysinh;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label lblGioitinh;
        private Guna.UI2.WinForms.Guna2ColorTransition guna2ColorTransition1;
        private Guna.UI2.WinForms.Guna2ComboBox cboGioitinh;
        private Guna.UI2.WinForms.Guna2ComboBox cboVaitro;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2Button btnDangki;
    }
}