namespace QLCUAHANGHOATUOI.GUI
{
    partial class UC_Taikhoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblQuanlitk = new System.Windows.Forms.Label();
            this.dgvTaikhoan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSanpham = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCapnhat = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.cboQuyen = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtManv = new System.Windows.Forms.TextBox();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtTentk = new System.Windows.Forms.TextBox();
            this.lblMatkhau = new System.Windows.Forms.Label();
            this.lblQuyen = new System.Windows.Forms.Label();
            this.lblManv = new System.Windows.Forms.Label();
            this.lblTenTK = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaikhoan)).BeginInit();
            this.pnlSanpham.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuanlitk
            // 
            this.lblQuanlitk.AutoSize = true;
            this.lblQuanlitk.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanlitk.Location = new System.Drawing.Point(97, 49);
            this.lblQuanlitk.Name = "lblQuanlitk";
            this.lblQuanlitk.Size = new System.Drawing.Size(409, 42);
            this.lblQuanlitk.TabIndex = 1;
            this.lblQuanlitk.Text = "QUẢN LÝ TÀI KHOẢN";
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
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTaikhoan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTaikhoan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTaikhoan.Location = new System.Drawing.Point(104, 120);
            this.dgvTaikhoan.Name = "dgvTaikhoan";
            this.dgvTaikhoan.RowHeadersVisible = false;
            this.dgvTaikhoan.RowHeadersWidth = 53;
            this.dgvTaikhoan.RowTemplate.Height = 24;
            this.dgvTaikhoan.Size = new System.Drawing.Size(1430, 413);
            this.dgvTaikhoan.TabIndex = 2;
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
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên TK";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mật khẩu";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quyền truy cập";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Mã nhân viên";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // pnlSanpham
            // 
            this.pnlSanpham.BackColor = System.Drawing.SystemColors.Window;
            this.pnlSanpham.Controls.Add(this.btnCapnhat);
            this.pnlSanpham.Controls.Add(this.btnXoa);
            this.pnlSanpham.Controls.Add(this.btnSua);
            this.pnlSanpham.Controls.Add(this.btnThem);
            this.pnlSanpham.Controls.Add(this.cboQuyen);
            this.pnlSanpham.Controls.Add(this.txtManv);
            this.pnlSanpham.Controls.Add(this.txtMatkhau);
            this.pnlSanpham.Controls.Add(this.txtTentk);
            this.pnlSanpham.Controls.Add(this.lblMatkhau);
            this.pnlSanpham.Controls.Add(this.lblQuyen);
            this.pnlSanpham.Controls.Add(this.lblManv);
            this.pnlSanpham.Controls.Add(this.lblTenTK);
            this.pnlSanpham.Location = new System.Drawing.Point(104, 562);
            this.pnlSanpham.Name = "pnlSanpham";
            this.pnlSanpham.Size = new System.Drawing.Size(1430, 308);
            this.pnlSanpham.TabIndex = 3;
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.BorderRadius = 15;
            this.btnCapnhat.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnCapnhat.BorderThickness = 2;
            this.btnCapnhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCapnhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCapnhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCapnhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCapnhat.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapnhat.ForeColor = System.Drawing.Color.Black;
            this.btnCapnhat.Location = new System.Drawing.Point(1060, 227);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(180, 45);
            this.btnCapnhat.TabIndex = 126;
            this.btnCapnhat.Text = "CẬP NHẬT";
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(769, 227);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(180, 45);
            this.btnXoa.TabIndex = 125;
            this.btnXoa.Text = "XOÁ";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnSua.Location = new System.Drawing.Point(489, 227);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(180, 45);
            this.btnSua.TabIndex = 124;
            this.btnSua.Text = "SỬA";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnThem.Location = new System.Drawing.Point(201, 227);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(180, 45);
            this.btnThem.TabIndex = 123;
            this.btnThem.Text = "THÊM";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cboQuyen
            // 
            this.cboQuyen.BackColor = System.Drawing.Color.Transparent;
            this.cboQuyen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuyen.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboQuyen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboQuyen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboQuyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboQuyen.ItemHeight = 30;
            this.cboQuyen.Location = new System.Drawing.Point(853, 66);
            this.cboQuyen.Name = "cboQuyen";
            this.cboQuyen.Size = new System.Drawing.Size(334, 36);
            this.cboQuyen.TabIndex = 13;
            
            // 
            // txtManv
            // 
            this.txtManv.Location = new System.Drawing.Point(853, 127);
            this.txtManv.Multiline = true;
            this.txtManv.Name = "txtManv";
            this.txtManv.Size = new System.Drawing.Size(334, 35);
            this.txtManv.TabIndex = 122;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Location = new System.Drawing.Point(201, 125);
            this.txtMatkhau.Multiline = true;
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(268, 35);
            this.txtMatkhau.TabIndex = 10;
            // 
            // txtTentk
            // 
            this.txtTentk.Location = new System.Drawing.Point(201, 60);
            this.txtTentk.Multiline = true;
            this.txtTentk.Name = "txtTentk";
            this.txtTentk.Size = new System.Drawing.Size(268, 35);
            this.txtTentk.TabIndex = 9;
            // 
            // lblMatkhau
            // 
            this.lblMatkhau.AutoSize = true;
            this.lblMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatkhau.Location = new System.Drawing.Point(49, 131);
            this.lblMatkhau.Name = "lblMatkhau";
            this.lblMatkhau.Size = new System.Drawing.Size(115, 29);
            this.lblMatkhau.TabIndex = 8;
            this.lblMatkhau.Text = "Mật khẩu:";
            // 
            // lblQuyen
            // 
            this.lblQuyen.AutoSize = true;
            this.lblQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuyen.Location = new System.Drawing.Point(654, 66);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(178, 29);
            this.lblQuyen.TabIndex = 6;
            this.lblQuyen.Text = "Quyền truy cập:";
            // 
            // lblManv
            // 
            this.lblManv.AutoSize = true;
            this.lblManv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManv.Location = new System.Drawing.Point(654, 131);
            this.lblManv.Name = "lblManv";
            this.lblManv.Size = new System.Drawing.Size(91, 29);
            this.lblManv.TabIndex = 5;
            this.lblManv.Text = "Mã NV:";
            // 
            // lblTenTK
            // 
            this.lblTenTK.AutoSize = true;
            this.lblTenTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTK.Location = new System.Drawing.Point(49, 66);
            this.lblTenTK.Name = "lblTenTK";
            this.lblTenTK.Size = new System.Drawing.Size(100, 29);
            this.lblTenTK.TabIndex = 0;
            this.lblTenTK.Text = "Tên TK:";
            // 
            // UC_Taikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.pnlSanpham);
            this.Controls.Add(this.dgvTaikhoan);
            this.Controls.Add(this.lblQuanlitk);
            this.Name = "UC_Taikhoan";
            this.Size = new System.Drawing.Size(1621, 909);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaikhoan)).EndInit();
            this.pnlSanpham.ResumeLayout(false);
            this.pnlSanpham.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuanlitk;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTaikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private Guna.UI2.WinForms.Guna2Panel pnlSanpham;
        private Guna.UI2.WinForms.Guna2Button btnCapnhat;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2ComboBox cboQuyen;
        public System.Windows.Forms.TextBox txtManv;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtTentk;
        private System.Windows.Forms.Label lblMatkhau;
        private System.Windows.Forms.Label lblManv;
        private System.Windows.Forms.Label lblTenTK;
        private System.Windows.Forms.Label lblQuyen;
    }
}
