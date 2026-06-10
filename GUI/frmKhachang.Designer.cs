namespace QLCUAHANGHOATUOI.GUI
{
    partial class frmKhachang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachang));
            this.pnlMain = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThemkh = new Guna.UI2.WinForms.Guna2Button();
            this.txtDiachi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSdt = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenkh = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMakh = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblThemkh = new System.Windows.Forms.Label();
            this.dgvKhachhang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblKhachhang = new System.Windows.Forms.Label();
            this.pnlXinchao = new Guna.UI2.WinForms.Guna2Panel();
            this.dtpNgaythang = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblTenvaitro = new System.Windows.Forms.Label();
            this.lblVaitro = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblXinchao = new System.Windows.Forms.Label();
            this.pnlAnhchao = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnQuaylai = new Guna.UI2.WinForms.Guna2Button();
            this.pnlLanghoa = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThongke = new Guna.UI2.WinForms.Guna2Button();
            this.btnHoaDon = new Guna.UI2.WinForms.Guna2Button();
            this.btnKhachang = new Guna.UI2.WinForms.Guna2Button();
            this.pnlLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachhang)).BeginInit();
            this.pnlXinchao.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlMain.BorderColor = System.Drawing.Color.Black;
            this.pnlMain.BorderRadius = 3;
            this.pnlMain.Controls.Add(this.btnThemkh);
            this.pnlMain.Controls.Add(this.txtDiachi);
            this.pnlMain.Controls.Add(this.txtSdt);
            this.pnlMain.Controls.Add(this.txtTenkh);
            this.pnlMain.Controls.Add(this.txtMakh);
            this.pnlMain.Controls.Add(this.lblThemkh);
            this.pnlMain.Controls.Add(this.dgvKhachhang);
            this.pnlMain.Controls.Add(this.lblKhachhang);
            this.pnlMain.Controls.Add(this.pnlXinchao);
            this.pnlMain.Controls.Add(this.pnlMenu);
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1510, 819);
            this.pnlMain.TabIndex = 2;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // btnThemkh
            // 
            this.btnThemkh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemkh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemkh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemkh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemkh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemkh.ForeColor = System.Drawing.Color.White;
            this.btnThemkh.Location = new System.Drawing.Point(1174, 445);
            this.btnThemkh.Name = "btnThemkh";
            this.btnThemkh.Size = new System.Drawing.Size(180, 45);
            this.btnThemkh.TabIndex = 9;
            this.btnThemkh.Text = "Thêm KH";
            this.btnThemkh.Click += new System.EventHandler(this.btnThemkh_Click);
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
            this.txtDiachi.Location = new System.Drawing.Point(1277, 341);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.PlaceholderText = "Địa chỉ";
            this.txtDiachi.SelectedText = "";
            this.txtDiachi.Size = new System.Drawing.Size(193, 48);
            this.txtDiachi.TabIndex = 8;
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
            this.txtSdt.Location = new System.Drawing.Point(1037, 341);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.PlaceholderText = "SĐT";
            this.txtSdt.SelectedText = "";
            this.txtSdt.Size = new System.Drawing.Size(193, 48);
            this.txtSdt.TabIndex = 7;
            // 
            // txtTenkh
            // 
            this.txtTenkh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenkh.DefaultText = "";
            this.txtTenkh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenkh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenkh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenkh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenkh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenkh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenkh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenkh.Location = new System.Drawing.Point(1277, 248);
            this.txtTenkh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenkh.Name = "txtTenkh";
            this.txtTenkh.PlaceholderText = "Tên khách hàng";
            this.txtTenkh.SelectedText = "";
            this.txtTenkh.Size = new System.Drawing.Size(193, 48);
            this.txtTenkh.TabIndex = 6;
            this.txtTenkh.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // txtMakh
            // 
            this.txtMakh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMakh.DefaultText = "";
            this.txtMakh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMakh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMakh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMakh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMakh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMakh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMakh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMakh.Location = new System.Drawing.Point(1037, 248);
            this.txtMakh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMakh.Name = "txtMakh";
            this.txtMakh.PlaceholderText = "Mã khách hàng";
            this.txtMakh.SelectedText = "";
            this.txtMakh.Size = new System.Drawing.Size(193, 48);
            this.txtMakh.TabIndex = 5;
            this.txtMakh.TextChanged += new System.EventHandler(this.txtMakh_TextChanged);
            // 
            // lblThemkh
            // 
            this.lblThemkh.AutoSize = true;
            this.lblThemkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThemkh.Location = new System.Drawing.Point(1160, 175);
            this.lblThemkh.Name = "lblThemkh";
            this.lblThemkh.Size = new System.Drawing.Size(227, 29);
            this.lblThemkh.TabIndex = 4;
            this.lblThemkh.Text = "Thêm Khách Hàng";
            this.lblThemkh.Click += new System.EventHandler(this.lblThemkh_Click);
            // 
            // dgvKhachhang
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvKhachhang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachhang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhachhang.ColumnHeadersHeight = 4;
            this.dgvKhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachhang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKhachhang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhachhang.Location = new System.Drawing.Point(348, 233);
            this.dgvKhachhang.Name = "dgvKhachhang";
            this.dgvKhachhang.RowHeadersVisible = false;
            this.dgvKhachhang.RowHeadersWidth = 51;
            this.dgvKhachhang.RowTemplate.Height = 24;
            this.dgvKhachhang.Size = new System.Drawing.Size(579, 395);
            this.dgvKhachhang.TabIndex = 3;
            this.dgvKhachhang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhachhang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvKhachhang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvKhachhang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvKhachhang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvKhachhang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhachhang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhachhang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvKhachhang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKhachhang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKhachhang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKhachhang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvKhachhang.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvKhachhang.ThemeStyle.ReadOnly = false;
            this.dgvKhachhang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhachhang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKhachhang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKhachhang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvKhachhang.ThemeStyle.RowsStyle.Height = 24;
            this.dgvKhachhang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhachhang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvKhachhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachhang_CellContentClick);
            // 
            // lblKhachhang
            // 
            this.lblKhachhang.AutoSize = true;
            this.lblKhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachhang.Location = new System.Drawing.Point(457, 166);
            this.lblKhachhang.Name = "lblKhachhang";
            this.lblKhachhang.Size = new System.Drawing.Size(207, 38);
            this.lblKhachhang.TabIndex = 2;
            this.lblKhachhang.Text = "Khách Hàng";
            this.lblKhachhang.Click += new System.EventHandler(this.lblHoadon_Click);
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
            this.pnlMenu.Controls.Add(this.pnlLanghoa);
            this.pnlMenu.Controls.Add(this.btnThongke);
            this.pnlMenu.Controls.Add(this.btnHoaDon);
            this.pnlMenu.Controls.Add(this.btnKhachang);
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
            this.btnQuaylai.Location = new System.Drawing.Point(36, 442);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(108, 45);
            this.btnQuaylai.TabIndex = 13;
            this.btnQuaylai.Text = "Quay lại";
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
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
            this.btnThongke.Location = new System.Drawing.Point(36, 378);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(218, 45);
            this.btnThongke.TabIndex = 7;
            this.btnThongke.Text = "Thống kê";
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.BorderColor = System.Drawing.Color.White;
            this.btnHoaDon.BorderRadius = 15;
            this.btnHoaDon.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnHoaDon.BorderThickness = 3;
            this.btnHoaDon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHoaDon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHoaDon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHoaDon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHoaDon.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDon.ForeColor = System.Drawing.Color.Black;
            this.btnHoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnHoaDon.Image")));
            this.btnHoaDon.Location = new System.Drawing.Point(36, 291);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(218, 45);
            this.btnHoaDon.TabIndex = 5;
            this.btnHoaDon.Text = "Hoá Đơn";
            // 
            // btnKhachang
            // 
            this.btnKhachang.BorderColor = System.Drawing.Color.White;
            this.btnKhachang.BorderRadius = 15;
            this.btnKhachang.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnKhachang.BorderThickness = 3;
            this.btnKhachang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKhachang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKhachang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKhachang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKhachang.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachang.ForeColor = System.Drawing.Color.Black;
            this.btnKhachang.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachang.Image")));
            this.btnKhachang.Location = new System.Drawing.Point(36, 215);
            this.btnKhachang.Name = "btnKhachang";
            this.btnKhachang.Size = new System.Drawing.Size(218, 45);
            this.btnKhachang.TabIndex = 2;
            this.btnKhachang.Text = "Khách Hàng";
            this.btnKhachang.Click += new System.EventHandler(this.btnKhachang_Click);
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
            // frmKhachang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1638, 937);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKhachang";
            this.Text = "frmKhachhang";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachhang)).EndInit();
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
        private Guna.UI2.WinForms.Guna2Panel pnlLanghoa;
        private Guna.UI2.WinForms.Guna2Button btnThongke;
        private Guna.UI2.WinForms.Guna2Button btnHoaDon;
        private Guna.UI2.WinForms.Guna2Button btnKhachang;
        private Guna.UI2.WinForms.Guna2Panel pnlLogo;
        private System.Windows.Forms.Label lblKhachhang;
        private Guna.UI2.WinForms.Guna2DataGridView dgvKhachhang;
        private Guna.UI2.WinForms.Guna2TextBox txtMakh;
        private System.Windows.Forms.Label lblThemkh;
        private Guna.UI2.WinForms.Guna2TextBox txtDiachi;
        private Guna.UI2.WinForms.Guna2TextBox txtSdt;
        private Guna.UI2.WinForms.Guna2TextBox txtTenkh;
        private Guna.UI2.WinForms.Guna2Button btnThemkh;
        private Guna.UI2.WinForms.Guna2Button btnQuaylai;
    }
}