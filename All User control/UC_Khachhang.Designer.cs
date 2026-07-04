namespace QLCUAHANGHOATUOI.GUI
{
    partial class UC_Khachhang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblKhachhang = new System.Windows.Forms.Label();
            this.dgvKhachhang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.pnlSanpham = new Guna.UI2.WinForms.Guna2Panel();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblTenkh = new System.Windows.Forms.Label();
            this.lblSdt = new System.Windows.Forms.Label();
            this.lblMakh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachhang)).BeginInit();
            this.pnlSanpham.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKhachhang
            // 
            this.lblKhachhang.AutoSize = true;
            this.lblKhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachhang.Location = new System.Drawing.Point(88, 60);
            this.lblKhachhang.Name = "lblKhachhang";
            this.lblKhachhang.Size = new System.Drawing.Size(248, 38);
            this.lblKhachhang.TabIndex = 0;
            this.lblKhachhang.Text = "KHÁCH HÀNG";
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
            this.dgvKhachhang.ColumnHeadersHeight = 35;
            this.dgvKhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachhang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKhachhang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvKhachhang.Location = new System.Drawing.Point(53, 129);
            this.dgvKhachhang.Name = "dgvKhachhang";
            this.dgvKhachhang.RowHeadersVisible = false;
            this.dgvKhachhang.RowHeadersWidth = 51;
            this.dgvKhachhang.RowTemplate.Height = 24;
            this.dgvKhachhang.Size = new System.Drawing.Size(856, 704);
            this.dgvKhachhang.TabIndex = 1;
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
            this.dgvKhachhang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvKhachhang.ThemeStyle.HeaderStyle.Height = 35;
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
            // Column1
            // 
            this.Column1.HeaderText = "Mã KH";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên KH";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "SĐT";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Địa chỉ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // pnlSanpham
            // 
            this.pnlSanpham.BackColor = System.Drawing.SystemColors.Window;
            this.pnlSanpham.Controls.Add(this.txtDiaChi);
            this.pnlSanpham.Controls.Add(this.txtSDT);
            this.pnlSanpham.Controls.Add(this.lblDiachi);
            this.pnlSanpham.Controls.Add(this.btnXoa);
            this.pnlSanpham.Controls.Add(this.btnSua);
            this.pnlSanpham.Controls.Add(this.btnThem);
            this.pnlSanpham.Controls.Add(this.txtTenKH);
            this.pnlSanpham.Controls.Add(this.txtMaKH);
            this.pnlSanpham.Controls.Add(this.lblTenkh);
            this.pnlSanpham.Controls.Add(this.lblSdt);
            this.pnlSanpham.Controls.Add(this.lblMakh);
            this.pnlSanpham.Location = new System.Drawing.Point(972, 159);
            this.pnlSanpham.Name = "pnlSanpham";
            this.pnlSanpham.Size = new System.Drawing.Size(587, 495);
            this.pnlSanpham.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(201, 261);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(303, 35);
            this.txtDiaChi.TabIndex = 128;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(201, 195);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(303, 35);
            this.txtSDT.TabIndex = 127;
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiachi.Location = new System.Drawing.Point(49, 261);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(97, 29);
            this.lblDiachi.TabIndex = 126;
            this.lblDiachi.Text = "Địa Chỉ:";
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
            this.btnXoa.Location = new System.Drawing.Point(426, 383);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(127, 47);
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
            this.btnSua.Location = new System.Drawing.Point(244, 385);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(127, 45);
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
            this.btnThem.Location = new System.Drawing.Point(70, 385);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(127, 45);
            this.btnThem.TabIndex = 123;
            this.btnThem.Text = "THÊM";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(201, 125);
            this.txtTenKH.Multiline = true;
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(303, 35);
            this.txtTenKH.TabIndex = 10;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(201, 60);
            this.txtMaKH.Multiline = true;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(303, 35);
            this.txtMaKH.TabIndex = 9;
            // 
            // lblTenkh
            // 
            this.lblTenkh.AutoSize = true;
            this.lblTenkh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenkh.Location = new System.Drawing.Point(49, 131);
            this.lblTenkh.Name = "lblTenkh";
            this.lblTenkh.Size = new System.Drawing.Size(101, 29);
            this.lblTenkh.TabIndex = 8;
            this.lblTenkh.Text = "Tên KH:";
            // 
            // lblSdt
            // 
            this.lblSdt.AutoSize = true;
            this.lblSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSdt.Location = new System.Drawing.Point(49, 195);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(68, 29);
            this.lblSdt.TabIndex = 7;
            this.lblSdt.Text = "SĐT:";
            // 
            // lblMakh
            // 
            this.lblMakh.AutoSize = true;
            this.lblMakh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMakh.Location = new System.Drawing.Point(49, 66);
            this.lblMakh.Name = "lblMakh";
            this.lblMakh.Size = new System.Drawing.Size(91, 29);
            this.lblMakh.TabIndex = 0;
            this.lblMakh.Text = "Mã KH:";
            // 
            // UC_Khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.pnlSanpham);
            this.Controls.Add(this.dgvKhachhang);
            this.Controls.Add(this.lblKhachhang);
            this.Name = "UC_Khachhang";
            this.Size = new System.Drawing.Size(1621, 886);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachhang)).EndInit();
            this.pnlSanpham.ResumeLayout(false);
            this.pnlSanpham.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKhachhang;
        private Guna.UI2.WinForms.Guna2DataGridView dgvKhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Panel pnlSanpham;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblDiachi;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblTenkh;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.Label lblMakh;
        private System.Windows.Forms.TextBox txtDiaChi;
    }
}
