namespace QLCUAHANGHOATUOI.GUI
{
    partial class frmNhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanvien));
            this.pnlMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDangxuat = new Guna.UI2.WinForms.Guna2Button();
            this.btnThanhtoan = new Guna.UI2.WinForms.Guna2Button();
            this.btnTrangchu = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCuahang = new System.Windows.Forms.Label();
            this.lblTieude = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ptbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnlLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.uC_TongquanNV1 = new QLCUAHANGHOATUOI.All_User_control.UC_TongquanNV();
            this.pnlMenu.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlMenu.BorderRadius = 1;
            this.pnlMenu.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.pnlMenu.BorderThickness = 2;
            this.pnlMenu.Controls.Add(this.btnDangxuat);
            this.pnlMenu.Controls.Add(this.btnThanhtoan);
            this.pnlMenu.Controls.Add(this.btnTrangchu);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.CustomBorderColor = System.Drawing.Color.Black;
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(316, 1055);
            this.pnlMenu.TabIndex = 1;
            // 
            // btnDangxuat
            // 
            this.btnDangxuat.BorderRadius = 5;
            this.btnDangxuat.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnDangxuat.BorderThickness = 2;
            this.btnDangxuat.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDangxuat.CustomBorderColor = System.Drawing.Color.Black;
            this.btnDangxuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangxuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangxuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangxuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangxuat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangxuat.ForeColor = System.Drawing.Color.Black;
            this.btnDangxuat.Location = new System.Drawing.Point(50, 480);
            this.btnDangxuat.Name = "btnDangxuat";
            this.btnDangxuat.Size = new System.Drawing.Size(215, 53);
            this.btnDangxuat.TabIndex = 7;
            this.btnDangxuat.Text = "➡️ Đăng xuất";
            this.btnDangxuat.Click += new System.EventHandler(this.btnDangxuat_Click_1);
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.BorderRadius = 5;
            this.btnThanhtoan.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnThanhtoan.BorderThickness = 2;
            this.btnThanhtoan.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnThanhtoan.CustomBorderColor = System.Drawing.Color.Black;
            this.btnThanhtoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhtoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhtoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhtoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhtoan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhtoan.ForeColor = System.Drawing.Color.Black;
            this.btnThanhtoan.Location = new System.Drawing.Point(50, 380);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(215, 53);
            this.btnThanhtoan.TabIndex = 4;
            this.btnThanhtoan.Text = "🧾 Thanh toán";
            // 
            // btnTrangchu
            // 
            this.btnTrangchu.BorderRadius = 5;
            this.btnTrangchu.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnTrangchu.BorderThickness = 2;
            this.btnTrangchu.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTrangchu.CustomBorderColor = System.Drawing.Color.Black;
            this.btnTrangchu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTrangchu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTrangchu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTrangchu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTrangchu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrangchu.ForeColor = System.Drawing.Color.Black;
            this.btnTrangchu.Location = new System.Drawing.Point(50, 280);
            this.btnTrangchu.Name = "btnTrangchu";
            this.btnTrangchu.Size = new System.Drawing.Size(215, 53);
            this.btnTrangchu.TabIndex = 1;
            this.btnTrangchu.Text = "🏠 Trang Chủ";
            this.btnTrangchu.Click += new System.EventHandler(this.btnTrangchu_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.guna2Panel1.Controls.Add(this.ptbLogo);
            this.guna2Panel1.Controls.Add(this.lblCuahang);
            this.guna2Panel1.Controls.Add(this.lblTieude);
            this.guna2Panel1.Location = new System.Drawing.Point(322, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1673, 143);
            this.guna2Panel1.TabIndex = 3;
            // 
            // lblCuahang
            // 
            this.lblCuahang.AutoSize = true;
            this.lblCuahang.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuahang.ForeColor = System.Drawing.Color.Brown;
            this.lblCuahang.Location = new System.Drawing.Point(75, 73);
            this.lblCuahang.Name = "lblCuahang";
            this.lblCuahang.Size = new System.Drawing.Size(617, 60);
            this.lblCuahang.TabIndex = 1;
            this.lblCuahang.Text = "Moon Florist , Flower Shop";
            // 
            // lblTieude
            // 
            this.lblTieude.AutoSize = true;
            this.lblTieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieude.Location = new System.Drawing.Point(119, 9);
            this.lblTieude.Name = "lblTieude";
            this.lblTieude.Size = new System.Drawing.Size(491, 46);
            this.lblTieude.TabIndex = 0;
            this.lblTieude.Text = "TỔNG QUAN NHÂN VIÊN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uC_TongquanNV1);
            this.panel1.Location = new System.Drawing.Point(322, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1621, 886);
            this.panel1.TabIndex = 4;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // ptbLogo
            // 
            this.ptbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbLogo.Image = ((System.Drawing.Image)(resources.GetObject("ptbLogo.Image")));
            this.ptbLogo.ImageRotate = 0F;
            this.ptbLogo.Location = new System.Drawing.Point(1394, 36);
            this.ptbLogo.Name = "ptbLogo";
            this.ptbLogo.Size = new System.Drawing.Size(225, 74);
            this.ptbLogo.TabIndex = 2;
            this.ptbLogo.TabStop = false;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlLogo.BackgroundImage")));
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Location = new System.Drawing.Point(4, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(312, 217);
            this.pnlLogo.TabIndex = 0;
            // 
            // uC_TongquanNV1
            // 
            this.uC_TongquanNV1.BackColor = System.Drawing.SystemColors.Info;
            this.uC_TongquanNV1.Location = new System.Drawing.Point(3, 3);
            this.uC_TongquanNV1.Name = "uC_TongquanNV1";
            this.uC_TongquanNV1.Size = new System.Drawing.Size(1621, 886);
            this.uC_TongquanNV1.TabIndex = 0;
            // 
            // frmNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1942, 1055);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNhanvien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMenu.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlMenu;
        private Guna.UI2.WinForms.Guna2Button btnDangxuat;
        private Guna.UI2.WinForms.Guna2Button btnThanhtoan;
        private Guna.UI2.WinForms.Guna2Button btnTrangchu;
        private Guna.UI2.WinForms.Guna2Panel pnlLogo;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox ptbLogo;
        private System.Windows.Forms.Label lblCuahang;
        private System.Windows.Forms.Label lblTieude;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private All_User_control.UC_TongquanNV uC_TongquanNV1;
    }
}