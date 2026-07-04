namespace QLCUAHANGHOATUOI.All_User_control
{
    partial class UC_Nhanvien1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblQuanlinv = new System.Windows.Forms.Label();
            this.pnlNhanvien = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvNhanvien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoanv = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuanv = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemmoi = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.lblTimkiem = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblTongsonv = new System.Windows.Forms.Label();
            this.lblSonv = new System.Windows.Forms.Label();
            this.pnlTongsonv = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDanglamviec = new System.Windows.Forms.Label();
            this.lblSodanglam = new System.Windows.Forms.Label();
            this.pnlDanglamviec = new Guna.UI2.WinForms.Guna2Panel();
            this.lblNghiphep = new System.Windows.Forms.Label();
            this.lblSonghiphep = new System.Windows.Forms.Label();
            this.pnlNghiphep = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlNhanvien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).BeginInit();
            this.pnlTongsonv.SuspendLayout();
            this.pnlDanglamviec.SuspendLayout();
            this.pnlNghiphep.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuanlinv
            // 
            this.lblQuanlinv.AutoSize = true;
            this.lblQuanlinv.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanlinv.Location = new System.Drawing.Point(71, 38);
            this.lblQuanlinv.Name = "lblQuanlinv";
            this.lblQuanlinv.Size = new System.Drawing.Size(411, 42);
            this.lblQuanlinv.TabIndex = 0;
            this.lblQuanlinv.Text = "QUẢN LÝ NHÂN VIÊN";
            this.lblQuanlinv.Click += new System.EventHandler(this.lblQuanlinv_Click);
            // 
            // pnlNhanvien
            // 
            this.pnlNhanvien.BackColor = System.Drawing.Color.SeaShell;
            this.pnlNhanvien.BorderColor = System.Drawing.Color.Black;
            this.pnlNhanvien.BorderRadius = 15;
            this.pnlNhanvien.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.pnlNhanvien.BorderThickness = 3;
            this.pnlNhanvien.Controls.Add(this.dgvNhanvien);
            this.pnlNhanvien.Controls.Add(this.btnXoanv);
            this.pnlNhanvien.Controls.Add(this.btnSuanv);
            this.pnlNhanvien.Controls.Add(this.btnThemmoi);
            this.pnlNhanvien.Controls.Add(this.txtTimkiem);
            this.pnlNhanvien.Controls.Add(this.lblTimkiem);
            this.pnlNhanvien.Location = new System.Drawing.Point(87, 307);
            this.pnlNhanvien.Name = "pnlNhanvien";
            this.pnlNhanvien.Size = new System.Drawing.Size(1448, 523);
            this.pnlNhanvien.TabIndex = 6;
            // 
            // dgvNhanvien
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvNhanvien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNhanvien.ColumnHeadersHeight = 25;
            this.dgvNhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNhanvien.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNhanvien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhanvien.Location = new System.Drawing.Point(92, 124);
            this.dgvNhanvien.Name = "dgvNhanvien";
            this.dgvNhanvien.RowHeadersVisible = false;
            this.dgvNhanvien.RowHeadersWidth = 51;
            this.dgvNhanvien.RowTemplate.Height = 24;
            this.dgvNhanvien.Size = new System.Drawing.Size(1243, 367);
            this.dgvNhanvien.TabIndex = 5;
            this.dgvNhanvien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhanvien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvNhanvien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvNhanvien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvNhanvien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvNhanvien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhanvien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhanvien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvNhanvien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNhanvien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNhanvien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNhanvien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNhanvien.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvNhanvien.ThemeStyle.ReadOnly = false;
            this.dgvNhanvien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNhanvien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNhanvien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNhanvien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNhanvien.ThemeStyle.RowsStyle.Height = 24;
            this.dgvNhanvien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNhanvien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã NV";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên NV";
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
            this.Column4.HeaderText = "Chức vụ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Trạng thái";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // btnXoanv
            // 
            this.btnXoanv.BackColor = System.Drawing.Color.Transparent;
            this.btnXoanv.BorderRadius = 15;
            this.btnXoanv.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnXoanv.BorderThickness = 2;
            this.btnXoanv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoanv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoanv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoanv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoanv.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnXoanv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoanv.ForeColor = System.Drawing.Color.Black;
            this.btnXoanv.Location = new System.Drawing.Point(1142, 40);
            this.btnXoanv.Name = "btnXoanv";
            this.btnXoanv.Size = new System.Drawing.Size(180, 45);
            this.btnXoanv.TabIndex = 4;
            this.btnXoanv.Text = "🗑️ Xoá NV";
            // 
            // btnSuanv
            // 
            this.btnSuanv.BackColor = System.Drawing.Color.Transparent;
            this.btnSuanv.BorderRadius = 15;
            this.btnSuanv.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnSuanv.BorderThickness = 2;
            this.btnSuanv.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuanv.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuanv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuanv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuanv.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSuanv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuanv.ForeColor = System.Drawing.Color.Black;
            this.btnSuanv.Location = new System.Drawing.Point(937, 40);
            this.btnSuanv.Name = "btnSuanv";
            this.btnSuanv.Size = new System.Drawing.Size(180, 45);
            this.btnSuanv.TabIndex = 3;
            this.btnSuanv.Text = "📝 Sửa NV";
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.BackColor = System.Drawing.Color.Transparent;
            this.btnThemmoi.BorderRadius = 15;
            this.btnThemmoi.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnThemmoi.BorderThickness = 2;
            this.btnThemmoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemmoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemmoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemmoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemmoi.FillColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnThemmoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemmoi.ForeColor = System.Drawing.Color.Black;
            this.btnThemmoi.Location = new System.Drawing.Point(731, 40);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(180, 45);
            this.btnThemmoi.TabIndex = 2;
            this.btnThemmoi.Text = "✏️ Thêm mới";
            this.btnThemmoi.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTimkiem.Location = new System.Drawing.Point(251, 40);
            this.txtTimkiem.Multiline = true;
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(270, 33);
            this.txtTimkiem.TabIndex = 1;
            this.txtTimkiem.Text = "🔍 Tên nhân viên...";
            // 
            // lblTimkiem
            // 
            this.lblTimkiem.AutoSize = true;
            this.lblTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimkiem.Location = new System.Drawing.Point(21, 48);
            this.lblTimkiem.Name = "lblTimkiem";
            this.lblTimkiem.Size = new System.Drawing.Size(224, 25);
            this.lblTimkiem.TabIndex = 0;
            this.lblTimkiem.Text = "TÌM KIẾM NHÂN VIÊN: ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblTongsonv
            // 
            this.lblTongsonv.AutoSize = true;
            this.lblTongsonv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongsonv.Location = new System.Drawing.Point(17, 20);
            this.lblTongsonv.Name = "lblTongsonv";
            this.lblTongsonv.Size = new System.Drawing.Size(298, 32);
            this.lblTongsonv.TabIndex = 0;
            this.lblTongsonv.Text = "👤 TỔNG SỐ NHÂN VIÊN";
            // 
            // lblSonv
            // 
            this.lblSonv.AutoSize = true;
            this.lblSonv.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonv.ForeColor = System.Drawing.Color.IndianRed;
            this.lblSonv.Location = new System.Drawing.Point(62, 71);
            this.lblSonv.Name = "lblSonv";
            this.lblSonv.Size = new System.Drawing.Size(55, 39);
            this.lblSonv.TabIndex = 3;
            this.lblSonv.Text = "12";
            // 
            // pnlTongsonv
            // 
            this.pnlTongsonv.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlTongsonv.BorderColor = System.Drawing.Color.Black;
            this.pnlTongsonv.BorderRadius = 18;
            this.pnlTongsonv.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.pnlTongsonv.BorderThickness = 2;
            this.pnlTongsonv.Controls.Add(this.lblSonv);
            this.pnlTongsonv.Controls.Add(this.lblTongsonv);
            this.pnlTongsonv.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlTongsonv.Location = new System.Drawing.Point(78, 118);
            this.pnlTongsonv.Name = "pnlTongsonv";
            this.pnlTongsonv.Size = new System.Drawing.Size(404, 129);
            this.pnlTongsonv.TabIndex = 1;
            // 
            // lblDanglamviec
            // 
            this.lblDanglamviec.AutoSize = true;
            this.lblDanglamviec.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanglamviec.Location = new System.Drawing.Point(63, 20);
            this.lblDanglamviec.Name = "lblDanglamviec";
            this.lblDanglamviec.Size = new System.Drawing.Size(241, 32);
            this.lblDanglamviec.TabIndex = 0;
            this.lblDanglamviec.Text = "💼 ĐANG LÀM VIỆC";
            // 
            // lblSodanglam
            // 
            this.lblSodanglam.AutoSize = true;
            this.lblSodanglam.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSodanglam.ForeColor = System.Drawing.Color.IndianRed;
            this.lblSodanglam.Location = new System.Drawing.Point(62, 71);
            this.lblSodanglam.Name = "lblSodanglam";
            this.lblSodanglam.Size = new System.Drawing.Size(55, 39);
            this.lblSodanglam.TabIndex = 3;
            this.lblSodanglam.Text = "08";
            // 
            // pnlDanglamviec
            // 
            this.pnlDanglamviec.BackColor = System.Drawing.Color.Honeydew;
            this.pnlDanglamviec.BorderColor = System.Drawing.Color.Black;
            this.pnlDanglamviec.BorderRadius = 18;
            this.pnlDanglamviec.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.pnlDanglamviec.BorderThickness = 2;
            this.pnlDanglamviec.Controls.Add(this.lblSodanglam);
            this.pnlDanglamviec.Controls.Add(this.lblDanglamviec);
            this.pnlDanglamviec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlDanglamviec.Location = new System.Drawing.Point(619, 118);
            this.pnlDanglamviec.Name = "pnlDanglamviec";
            this.pnlDanglamviec.Size = new System.Drawing.Size(404, 129);
            this.pnlDanglamviec.TabIndex = 4;
            // 
            // lblNghiphep
            // 
            this.lblNghiphep.AutoSize = true;
            this.lblNghiphep.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNghiphep.Location = new System.Drawing.Point(25, 20);
            this.lblNghiphep.Name = "lblNghiphep";
            this.lblNghiphep.Size = new System.Drawing.Size(299, 32);
            this.lblNghiphep.TabIndex = 0;
            this.lblNghiphep.Text = "❌ NGHỈ PHÉP HÔM NAY";
            this.lblNghiphep.Click += new System.EventHandler(this.lblNghiphep_Click);
            // 
            // lblSonghiphep
            // 
            this.lblSonghiphep.AutoSize = true;
            this.lblSonghiphep.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonghiphep.ForeColor = System.Drawing.Color.IndianRed;
            this.lblSonghiphep.Location = new System.Drawing.Point(62, 71);
            this.lblSonghiphep.Name = "lblSonghiphep";
            this.lblSonghiphep.Size = new System.Drawing.Size(55, 39);
            this.lblSonghiphep.TabIndex = 3;
            this.lblSonghiphep.Text = "01";
            // 
            // pnlNghiphep
            // 
            this.pnlNghiphep.BackColor = System.Drawing.Color.Turquoise;
            this.pnlNghiphep.BorderColor = System.Drawing.Color.Black;
            this.pnlNghiphep.BorderRadius = 18;
            this.pnlNghiphep.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.pnlNghiphep.BorderThickness = 2;
            this.pnlNghiphep.Controls.Add(this.lblSonghiphep);
            this.pnlNghiphep.Controls.Add(this.lblNghiphep);
            this.pnlNghiphep.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlNghiphep.Location = new System.Drawing.Point(1148, 118);
            this.pnlNghiphep.Name = "pnlNghiphep";
            this.pnlNghiphep.Size = new System.Drawing.Size(404, 129);
            this.pnlNghiphep.TabIndex = 5;
            // 
            // UC_Nhanvien1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.Controls.Add(this.pnlNhanvien);
            this.Controls.Add(this.pnlNghiphep);
            this.Controls.Add(this.pnlDanglamviec);
            this.Controls.Add(this.pnlTongsonv);
            this.Controls.Add(this.lblQuanlinv);
            this.Name = "UC_Nhanvien1";
            this.Size = new System.Drawing.Size(1621, 886);
            this.pnlNhanvien.ResumeLayout(false);
            this.pnlNhanvien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanvien)).EndInit();
            this.pnlTongsonv.ResumeLayout(false);
            this.pnlTongsonv.PerformLayout();
            this.pnlDanglamviec.ResumeLayout(false);
            this.pnlDanglamviec.PerformLayout();
            this.pnlNghiphep.ResumeLayout(false);
            this.pnlNghiphep.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuanlinv;
        private Guna.UI2.WinForms.Guna2Panel pnlNhanvien;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label lblTimkiem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Guna.UI2.WinForms.Guna2Button btnThemmoi;
        private Guna.UI2.WinForms.Guna2Button btnXoanv;
        private Guna.UI2.WinForms.Guna2Button btnSuanv;
        private Guna.UI2.WinForms.Guna2DataGridView dgvNhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label lblTongsonv;
        private System.Windows.Forms.Label lblSonv;
        private Guna.UI2.WinForms.Guna2Panel pnlTongsonv;
        private System.Windows.Forms.Label lblDanglamviec;
        private System.Windows.Forms.Label lblSodanglam;
        private Guna.UI2.WinForms.Guna2Panel pnlDanglamviec;
        private System.Windows.Forms.Label lblNghiphep;
        private System.Windows.Forms.Label lblSonghiphep;
        private Guna.UI2.WinForms.Guna2Panel pnlNghiphep;
    }
}
