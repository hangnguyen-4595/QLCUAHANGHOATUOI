using System.Windows.Forms;

private void InitializeComponent()
{
    // Tìm kiếm
    this.txtSearch = new TextBox { Location = new System.Drawing.Point(20, 20), Width = 250 };
    this.txtSearch.TextChanged += txtSearch_TextChanged;

    // Danh sách sản phẩm
    this.flowLayoutPanelProducts = new FlowLayoutPanel { Location = new System.Drawing.Point(20, 60), Size = new System.Drawing.Size(300, 400) };

    // Bảng giỏ hàng
    this.dataGridViewCart = new DataGridView { Location = new System.Drawing.Point(350, 20), Size = new System.Drawing.Size(400, 350) };

    // Nhãn tổng tiền
    this.lblTotal = new Label { Location = new System.Drawing.Point(350, 380), Text = "Tổng tiền: 0 VNĐ", Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold) };

    // Nút thanh toán
    this.btnThanhToan = new Button { Location = new System.Drawing.Point(600, 380), Text = "Thanh Toán & In", Size = new System.Drawing.Size(150, 40), BackColor = System.Drawing.Color.LightGreen };
    this.btnThanhToan.Click += btnThanhToan_Click;

    this.Controls.AddRange(new Control[] { txtSearch, flowLayoutPanelProducts, dataGridViewCart, lblTotal, btnThanhToan });
}