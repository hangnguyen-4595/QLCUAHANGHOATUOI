namespace QLCUAHANGHOATUOI.GUI
{
    partial class frmDangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangnhap));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblTaikhoan = new System.Windows.Forms.Label();
            this.txtTaikhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMatkhau = new System.Windows.Forms.Label();
            this.txtMatkhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDangnhap = new Guna.UI2.WinForms.Guna2Button();
            this.btnDangky = new Guna.UI2.WinForms.Guna2Button();
            this.pnlOdangnhap = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlOdangnhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(1531, 217);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(286, 51);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.Text = "ĐĂNG NHẬP";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // lblTaikhoan
            // 
            this.lblTaikhoan.AutoSize = true;
            this.lblTaikhoan.BackColor = System.Drawing.Color.OldLace;
            this.lblTaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaikhoan.Location = new System.Drawing.Point(29, 87);
            this.lblTaikhoan.Name = "lblTaikhoan";
            this.lblTaikhoan.Size = new System.Drawing.Size(203, 42);
            this.lblTaikhoan.TabIndex = 16;
            this.lblTaikhoan.Text = "Tài khoản:";
            this.lblTaikhoan.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.BackColor = System.Drawing.Color.OldLace;
            this.txtTaikhoan.BorderRadius = 18;
            this.txtTaikhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaikhoan.DefaultText = "";
            this.txtTaikhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTaikhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTaikhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaikhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTaikhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaikhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTaikhoan.ForeColor = System.Drawing.Color.Black;
            this.txtTaikhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTaikhoan.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtTaikhoan.IconLeft")));
            this.txtTaikhoan.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtTaikhoan.Location = new System.Drawing.Point(272, 75);
            this.txtTaikhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.PlaceholderText = "Enter Username";
            this.txtTaikhoan.SelectedText = "";
            this.txtTaikhoan.Size = new System.Drawing.Size(295, 54);
            this.txtTaikhoan.TabIndex = 17;
            // 
            // lblMatkhau
            // 
            this.lblMatkhau.AutoSize = true;
            this.lblMatkhau.BackColor = System.Drawing.Color.OldLace;
            this.lblMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatkhau.Location = new System.Drawing.Point(29, 212);
            this.lblMatkhau.Name = "lblMatkhau";
            this.lblMatkhau.Size = new System.Drawing.Size(202, 42);
            this.lblMatkhau.TabIndex = 18;
            this.lblMatkhau.Text = "Mật khẩu: ";
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.BackColor = System.Drawing.Color.OldLace;
            this.txtMatkhau.BorderRadius = 18;
            this.txtMatkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatkhau.DefaultText = "";
            this.txtMatkhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatkhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatkhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatkhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatkhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatkhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMatkhau.ForeColor = System.Drawing.Color.Black;
            this.txtMatkhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatkhau.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtMatkhau.IconLeft")));
            this.txtMatkhau.IconLeftSize = new System.Drawing.Size(30, 30);
            this.txtMatkhau.Location = new System.Drawing.Point(272, 203);
            this.txtMatkhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PlaceholderText = "Enter Password";
            this.txtMatkhau.SelectedText = "";
            this.txtMatkhau.Size = new System.Drawing.Size(295, 51);
            this.txtMatkhau.TabIndex = 19;
            this.txtMatkhau.UseSystemPasswordChar = true;
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.BackColor = System.Drawing.Color.OldLace;
            this.btnDangnhap.BorderRadius = 18;
            this.btnDangnhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangnhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangnhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangnhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangnhap.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnDangnhap.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangnhap.ForeColor = System.Drawing.Color.White;
            this.btnDangnhap.Location = new System.Drawing.Point(57, 328);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(195, 59);
            this.btnDangnhap.TabIndex = 20;
            this.btnDangnhap.Text = "Đăng Nhập";
            // 
            // btnDangky
            // 
            this.btnDangky.BackColor = System.Drawing.Color.OldLace;
            this.btnDangky.BorderRadius = 18;
            this.btnDangky.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangky.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangky.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangky.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangky.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnDangky.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangky.ForeColor = System.Drawing.Color.White;
            this.btnDangky.Location = new System.Drawing.Point(342, 328);
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.Size = new System.Drawing.Size(188, 59);
            this.btnDangky.TabIndex = 21;
            this.btnDangky.Text = "Đăng Ký";
            this.btnDangky.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // pnlOdangnhap
            // 
            this.pnlOdangnhap.BackColor = System.Drawing.Color.OldLace;
            this.pnlOdangnhap.BorderColor = System.Drawing.Color.Black;
            this.pnlOdangnhap.BorderRadius = 23;
            this.pnlOdangnhap.BorderThickness = 3;
            this.pnlOdangnhap.Controls.Add(this.txtTaikhoan);
            this.pnlOdangnhap.Controls.Add(this.btnDangky);
            this.pnlOdangnhap.Controls.Add(this.lblTaikhoan);
            this.pnlOdangnhap.Controls.Add(this.btnDangnhap);
            this.pnlOdangnhap.Controls.Add(this.lblMatkhau);
            this.pnlOdangnhap.Controls.Add(this.txtMatkhau);
            this.pnlOdangnhap.CustomBorderColor = System.Drawing.Color.Transparent;
            this.pnlOdangnhap.FillColor = System.Drawing.Color.Transparent;
            this.pnlOdangnhap.ForeColor = System.Drawing.Color.Black;
            this.pnlOdangnhap.Location = new System.Drawing.Point(1369, 301);
            this.pnlOdangnhap.Name = "pnlOdangnhap";
            this.pnlOdangnhap.Size = new System.Drawing.Size(594, 440);
            this.pnlOdangnhap.TabIndex = 22;
            // 
            // frmDangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 955);
            this.Controls.Add(this.pnlOdangnhap);
            this.Controls.Add(this.lblLogin);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDangnhap_Load);
            this.pnlOdangnhap.ResumeLayout(false);
            this.pnlOdangnhap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblTaikhoan;
        private Guna.UI2.WinForms.Guna2TextBox txtTaikhoan;
        private System.Windows.Forms.Label lblMatkhau;
        private Guna.UI2.WinForms.Guna2TextBox txtMatkhau;
        private Guna.UI2.WinForms.Guna2Button btnDangnhap;
        private Guna.UI2.WinForms.Guna2Button btnDangky;
        private Guna.UI2.WinForms.Guna2Panel pnlOdangnhap;
    }
}