using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

public partial class UC_ThanhToan : UserControl
{
    // Giả lập danh sách sản phẩm (Trong thực tế, bạn lấy từ SQL)
    private List<Product> allProducts = new List<Product> {
        new Product { Id = 1, Name = "Hoa Hồng Đà Lạt", Price = 50000 },
        new Product { Id = 2, Name = "Hoa Ly Trắng", Price = 80000 },
        new Product { Id = 3, Name = "Hoa Hướng Dương", Price = 30000 }
    };

    private BindingList<CartItem> cartList = new BindingList<CartItem>();

    public UC_ThanhToan()
    {
        InitializeComponent();
        dataGridViewCart.DataSource = cartList;
    }

    // Xử lý tìm kiếm
    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        string keyword = txtSearch.Text.ToLower();
        var filtered = allProducts.Where(p => p.Name.ToLower().Contains(keyword)).ToList();

        flowLayoutPanelProducts.Controls.Clear();
        foreach (var p in filtered)
        {
            Button btn = new Button { Text = p.Name + "\n" + p.Price + "đ", Size = new System.Drawing.Size(120, 60) };
            btn.Click += (s, ev) => AddToCart(p);
            flowLayoutPanelProducts.Controls.Add(btn);
        }
    }

    private void AddToCart(Product p)
    {
        var item = cartList.FirstOrDefault(c => c.Name == p.Name);
        if (item != null) item.Qty++;
        else cartList.Add(new CartItem { Name = p.Name, Price = p.Price, Qty = 1 });

        UpdateTotal();
    }

    private void UpdateTotal()
    {
        decimal total = cartList.Sum(x => x.Price * x.Qty);
        lblTotal.Text = $"Tổng tiền: {total:N0} VNĐ";
    }

    private void btnThanhToan_Click(object sender, EventArgs e)
    {
        string billId = "HD-" + DateTime.Now.Ticks.ToString().Substring(10);
        MessageBox.Show($"Hóa đơn {billId} đã tạo! Tổng tiền: {lblTotal.Text}");
        // Code in hóa đơn tại đây...
    }

    private Label lblTimkiem;
    private Guna.UI2.WinForms.Guna2ColorTransition guna2ColorTransition1;
    private IContainer components;

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.lblTimkiem = new System.Windows.Forms.Label();
            this.guna2ColorTransition1 = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
            this.SuspendLayout();
            // 
            // lblTimkiem
            // 
            this.lblTimkiem.AutoSize = true;
            this.lblTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimkiem.Location = new System.Drawing.Point(76, 40);
            this.lblTimkiem.Name = "lblTimkiem";
            this.lblTimkiem.Size = new System.Drawing.Size(128, 29);
            this.lblTimkiem.TabIndex = 0;
            this.lblTimkiem.Text = "Tìm kiếm ";
            // 
            // guna2ColorTransition1
            // 
            this.guna2ColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            // 
            // UC_ThanhToan
            // 
            this.Controls.Add(this.lblTimkiem);
            this.Name = "UC_ThanhToan";
            this.Size = new System.Drawing.Size(1621, 886);
            this.ResumeLayout(false);
            this.PerformLayout();

    }
}