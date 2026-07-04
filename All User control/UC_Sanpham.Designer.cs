namespace QLCUAHANGHOATUOI.GUI
{
    partial class UC_Sanpham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSanpham = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.pnlSanpham = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCapNhat = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.cboTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboPhanLoai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.lblTensp = new System.Windows.Forms.Label();
            this.lblSoluong = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblPhanloai = new System.Windows.Forms.Label();
            this.lblTrangthai = new System.Windows.Forms.Label();
            this.lblMasp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).BeginInit();
            this.pnlSanpham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSanpham
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvSanpham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvSanpham.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanpham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvSanpham.ColumnHeadersHeight = 29;
            this.dgvSanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSanpham.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvSanpham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSanpham.Location = new System.Drawing.Point(97, 37);
            this.dgvSanpham.Name = "dgvSanpham";
            this.dgvSanpham.RowHeadersVisible = false;
            this.dgvSanpham.RowHeadersWidth = 51;
            this.dgvSanpham.RowTemplate.Height = 24;
            this.dgvSanpham.Size = new System.Drawing.Size(1401, 374);
            this.dgvSanpham.TabIndex = 0;
            this.dgvSanpham.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSanpham.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSanpham.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSanpham.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSanpham.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSanpham.ThemeStyle.BackColor = System.Drawing.Color.AliceBlue;
            this.dgvSanpham.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSanpham.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvSanpham.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSanpham.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSanpham.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSanpham.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSanpham.ThemeStyle.HeaderStyle.Height = 29;
            this.dgvSanpham.ThemeStyle.ReadOnly = false;
            this.dgvSanpham.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSanpham.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSanpham.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSanpham.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSanpham.ThemeStyle.RowsStyle.Height = 24;
            this.dgvSanpham.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSanpham.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã SP";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên SP";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giá";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Phân loại";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Trạng thái";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // pnlSanpham
            // 
            this.pnlSanpham.BackColor = System.Drawing.SystemColors.Window;
            this.pnlSanpham.Controls.Add(this.btnCapNhat);
            this.pnlSanpham.Controls.Add(this.btnXoa);
            this.pnlSanpham.Controls.Add(this.btnSua);
            this.pnlSanpham.Controls.Add(this.btnThem);
            this.pnlSanpham.Controls.Add(this.cboTrangThai);
            this.pnlSanpham.Controls.Add(this.cboPhanLoai);
            this.pnlSanpham.Controls.Add(this.numSoLuong);
            this.pnlSanpham.Controls.Add(this.txtGia);
            this.pnlSanpham.Controls.Add(this.txtTenSP);
            this.pnlSanpham.Controls.Add(this.txtMaSP);
            this.pnlSanpham.Controls.Add(this.lblTensp);
            this.pnlSanpham.Controls.Add(this.lblSoluong);
            this.pnlSanpham.Controls.Add(this.lblGia);
            this.pnlSanpham.Controls.Add(this.lblPhanloai);
            this.pnlSanpham.Controls.Add(this.lblTrangthai);
            this.pnlSanpham.Controls.Add(this.lblMasp);
            this.pnlSanpham.Location = new System.Drawing.Point(97, 470);
            this.pnlSanpham.Name = "pnlSanpham";
            this.pnlSanpham.Size = new System.Drawing.Size(1401, 369);
            this.pnlSanpham.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BorderRadius = 15;
            this.btnCapNhat.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnCapNhat.BorderThickness = 2;
            this.btnCapNhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCapNhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhat.Location = new System.Drawing.Point(1062, 279);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(180, 45);
            this.btnCapNhat.TabIndex = 126;
            this.btnCapNhat.Text = "CẬP NHẬT";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.BorderRadius = 15;
            this.btnXoa.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnXoa.BorderThickness = 2;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(768, 279);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(180, 45);
            this.btnXoa.TabIndex = 125;
            this.btnXoa.Text = "XOÁ";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.BorderRadius = 15;
            this.btnSua.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnSua.BorderThickness = 2;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Location = new System.Drawing.Point(489, 279);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(180, 45);
            this.btnSua.TabIndex = 124;
            this.btnSua.Text = "SỬA";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.BorderRadius = 15;
            this.btnThem.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnThem.BorderThickness = 2;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(200, 279);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(180, 45);
            this.btnThem.TabIndex = 123;
            this.btnThem.Text = "THÊM";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cboTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboTrangThai.ItemHeight = 30;
            this.cboTrangThai.Location = new System.Drawing.Point(815, 181);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(334, 36);
            this.cboTrangThai.TabIndex = 14;
            // 
            // cboPhanLoai
            // 
            this.cboPhanLoai.BackColor = System.Drawing.Color.Transparent;
            this.cboPhanLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPhanLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhanLoai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboPhanLoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboPhanLoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboPhanLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboPhanLoai.ItemHeight = 30;
            this.cboPhanLoai.Location = new System.Drawing.Point(815, 124);
            this.cboPhanLoai.Name = "cboPhanLoai";
            this.cboPhanLoai.Size = new System.Drawing.Size(334, 36);
            this.cboPhanLoai.TabIndex = 13;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(201, 195);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(268, 22);
            this.numSoLuong.TabIndex = 25;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(815, 66);
            this.txtGia.Multiline = true;
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(334, 35);
            this.txtGia.TabIndex = 122;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(201, 125);
            this.txtTenSP.Multiline = true;
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(268, 35);
            this.txtTenSP.TabIndex = 10;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(201, 60);
            this.txtMaSP.Multiline = true;
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(268, 35);
            this.txtMaSP.TabIndex = 9;
            // 
            // lblTensp
            // 
            this.lblTensp.AutoSize = true;
            this.lblTensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTensp.Location = new System.Drawing.Point(49, 131);
            this.lblTensp.Name = "lblTensp";
            this.lblTensp.Size = new System.Drawing.Size(100, 29);
            this.lblTensp.TabIndex = 8;
            this.lblTensp.Text = "Tên SP:";
            // 
            // lblSoluong
            // 
            this.lblSoluong.AutoSize = true;
            this.lblSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoluong.Location = new System.Drawing.Point(49, 195);
            this.lblSoluong.Name = "lblSoluong";
            this.lblSoluong.Size = new System.Drawing.Size(115, 29);
            this.lblSoluong.TabIndex = 7;
            this.lblSoluong.Text = "Số lượng:";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.Location = new System.Drawing.Point(654, 66);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(56, 29);
            this.lblGia.TabIndex = 6;
            this.lblGia.Text = "Giá:";
            // 
            // lblPhanloai
            // 
            this.lblPhanloai.AutoSize = true;
            this.lblPhanloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhanloai.Location = new System.Drawing.Point(654, 131);
            this.lblPhanloai.Name = "lblPhanloai";
            this.lblPhanloai.Size = new System.Drawing.Size(119, 29);
            this.lblPhanloai.TabIndex = 5;
            this.lblPhanloai.Text = "Phân loại:";
            // 
            // lblTrangthai
            // 
            this.lblTrangthai.AutoSize = true;
            this.lblTrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangthai.Location = new System.Drawing.Point(654, 188);
            this.lblTrangthai.Name = "lblTrangthai";
            this.lblTrangthai.Size = new System.Drawing.Size(127, 29);
            this.lblTrangthai.TabIndex = 4;
            this.lblTrangthai.Text = "Trạng thái:";
            // 
            // lblMasp
            // 
            this.lblMasp.AutoSize = true;
            this.lblMasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasp.Location = new System.Drawing.Point(49, 66);
            this.lblMasp.Name = "lblMasp";
            this.lblMasp.Size = new System.Drawing.Size(90, 29);
            this.lblMasp.TabIndex = 0;
            this.lblMasp.Text = "Mã SP:";
            // 
            // UC_Sanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.pnlSanpham);
            this.Controls.Add(this.dgvSanpham);
            this.Name = "UC_Sanpham";
            this.Size = new System.Drawing.Size(1621, 886);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).EndInit();
            this.pnlSanpham.ResumeLayout(false);
            this.pnlSanpham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvSanpham;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Panel pnlSanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label lblMasp;
        private System.Windows.Forms.Label lblTensp;
        private System.Windows.Forms.Label lblSoluong;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblPhanloai;
        private System.Windows.Forms.Label lblTrangthai;
        private Guna.UI2.WinForms.Guna2ComboBox cboPhanLoai;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private Guna.UI2.WinForms.Guna2ComboBox cboTrangThai;
        public System.Windows.Forms.NumericUpDown numSoLuong;
        public System.Windows.Forms.TextBox txtGia;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnCapNhat;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnSua;
    }
}
