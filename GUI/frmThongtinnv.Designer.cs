//namespace QLCUAHANGHOATUOI.GUI
//{
//    partial class frmThongtinnv
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.components = new System.ComponentModel.Container();
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(800, 450);
//            this.Text = "frmThongtinnv";
//        }

//        #endregion
//    }
//}
namespace QLCUAHANGHOATUOI.GUI
{
    partial class frmThongtinnv
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.lblGioitinh = new System.Windows.Forms.Label();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblNgaysinh = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblTieuDe.Location = new System.Drawing.Point(131, 26);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(291, 32);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblMaNV.ForeColor = System.Drawing.Color.Gray;
            this.lblMaNV.Location = new System.Drawing.Point(73, 82);
            this.lblMaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(119, 21);
            this.lblMaNV.TabIndex = 1;
            this.lblMaNV.Text = "Mã Nhân Viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMaNV.Location = new System.Drawing.Point(76, 107);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(425, 32);
            this.txtMaNV.TabIndex = 2;
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTenNV.ForeColor = System.Drawing.Color.Gray;
            this.lblTenNV.Location = new System.Drawing.Point(73, 156);
            this.lblTenNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(122, 21);
            this.lblTenNV.TabIndex = 3;
            this.lblTenNV.Text = "Tên Nhân Viên";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTenNV.Location = new System.Drawing.Point(76, 181);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(425, 32);
            this.txtTenNV.TabIndex = 4;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblChucVu.ForeColor = System.Drawing.Color.Gray;
            this.lblChucVu.Location = new System.Drawing.Point(75, 372);
            this.lblChucVu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(74, 21);
            this.lblChucVu.TabIndex = 5;
            this.lblChucVu.Text = "Chức Vụ";
            this.lblChucVu.Click += new System.EventHandler(this.lblChucVu_Click);
            // 
            // cboChucVu
            // 
            this.cboChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChucVu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Items.AddRange(new object[] {
            "Bán hàng",
            "Chăm sóc hoa",
            "Giao hàng"});
            this.cboChucVu.Location = new System.Drawing.Point(77, 397);
            this.cboChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(425, 33);
            this.cboChucVu.TabIndex = 6;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSDT.ForeColor = System.Drawing.Color.Gray;
            this.lblSDT.Location = new System.Drawing.Point(72, 434);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(116, 21);
            this.lblSDT.TabIndex = 7;
            this.lblSDT.Text = "Số Điện Thoại";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSDT.Location = new System.Drawing.Point(76, 470);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(425, 32);
            this.txtSDT.TabIndex = 8;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(161)))), ((int)(((byte)(114)))));
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(118, 548);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(156, 43);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "LƯU THAY ĐỔI";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.Gray;
            this.btnHuy.Location = new System.Drawing.Point(313, 548);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(169, 43);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "HỦY BỎ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.AutoSize = true;
            this.lblGioitinh.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblGioitinh.ForeColor = System.Drawing.Color.Gray;
            this.lblGioitinh.Location = new System.Drawing.Point(73, 228);
            this.lblGioitinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(79, 21);
            this.lblGioitinh.TabIndex = 11;
            this.lblGioitinh.Text = "Giới Tính";
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(77, 253);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(424, 36);
            this.guna2ComboBox1.TabIndex = 12;
            // 
            // lblNgaysinh
            // 
            this.lblNgaysinh.AutoSize = true;
            this.lblNgaysinh.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNgaysinh.ForeColor = System.Drawing.Color.Gray;
            this.lblNgaysinh.Location = new System.Drawing.Point(75, 302);
            this.lblNgaysinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNgaysinh.Name = "lblNgaysinh";
            this.lblNgaysinh.Size = new System.Drawing.Size(89, 21);
            this.lblNgaysinh.TabIndex = 13;
            this.lblNgaysinh.Text = "Ngày Sinh";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(76, 333);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(425, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // frmThongtinnv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(587, 617);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblNgaysinh);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.lblGioitinh);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.cboChucVu);
            this.Controls.Add(this.lblChucVu);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.lblTenNV);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.lblTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThongtinnv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cập Nhật Nhân Viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label lblGioitinh;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private System.Windows.Forms.Label lblNgaysinh;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}