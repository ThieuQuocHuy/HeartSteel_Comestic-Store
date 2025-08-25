using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Customer.Services;
using DAL.Models;
using System.Drawing;

namespace Customer
{
    public partial class ProductPage : Form
    {
        private readonly IProductService _productService;
        private readonly ICartService _cartService;
        private int _currentUserId = 1; // Tạm thời hardcode, sau này sẽ lấy từ login

        public ProductPage()
        {
            InitializeComponent();
            _productService = new Customer.Services.ProductService(new Customer.Repositories.ProductRepository());
            _cartService = new CartService();
            this.Load += ProductPage_Load;
        }

        private async void ProductPage_Load(object? sender, EventArgs e)
        {
            await LoadProducts();
        }

        private async Task LoadProducts()
        {
            try
            {
                var products = await _productService.GetAllAsync();
                
                // Xóa các panel cũ nếu có
                ClearProductPanels();
                
                if (products.Count > 0)
                {
                    // Tạo panel động cho từng sản phẩm
                    foreach (var product in products)
                    {
                        var productPanel = CreateProductPanel(product);
                        flowLayoutPanelProducts.Controls.Add(productPanel);
                    }
                }
                else
                {
                    // Hiển thị thông báo nếu không có sản phẩm
                    var emptyLabel = new Label
                    {
                        Text = "Không có sản phẩm nào",
                        Font = new Font("Segoe UI", 14, FontStyle.Regular),
                        ForeColor = Color.Gray,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Size = new Size(600, 100),
                        Dock = DockStyle.Fill
                    };
                    flowLayoutPanelProducts.Controls.Add(emptyLabel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearProductPanels()
        {
            if (flowLayoutPanelProducts != null)
            {
                flowLayoutPanelProducts.Controls.Clear();
            }
        }

        private Panel CreateProductPanel(Product product)
        {
            var panel = new Panel
            {
                BackColor = SystemColors.ControlLightLight,
                Size = new Size(282, 400),
                Margin = new Padding(10),
                Tag = product.ProductId // Lưu ProductId để sử dụng khi thêm vào giỏ hàng
            };

            // Hình ảnh sản phẩm (placeholder)
            var pictureBox = new PictureBox
            {
                Location = new Point(5, 4),
                Size = new Size(272, 191),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.LightGray
            };

            // Tên sản phẩm
            var textBoxName = new TextBox
            {
                BackColor = SystemColors.ControlLightLight,
                BorderStyle = BorderStyle.None,
                Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular),
                Location = new Point(32, 201),
                Size = new Size(226, 50),
                Multiline = true,
                ReadOnly = true,
                Text = product.ProductName ?? "Không có tên"
            };

            // Giá sản phẩm
            var textBoxPrice = new TextBox
            {
                BackColor = SystemColors.ControlLightLight,
                BorderStyle = BorderStyle.None,
                Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular),
                Location = new Point(58, 269),
                Size = new Size(161, 25),
                ReadOnly = true,
                TextAlign = HorizontalAlignment.Center,
                Text = $"{(product.SellPrice ?? 0):N0} ₫"
            };

            // Nút "Thêm vào giỏ hàng"
            var buttonAddToCart = new Button
            {
                BackColor = Color.FromArgb(237, 224, 207),
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Times New Roman", 13.8F, FontStyle.Bold),
                Location = new Point(44, 322),
                Size = new Size(186, 41),
                Text = "Thêm vào giỏ hàng",
                UseVisualStyleBackColor = false,
                Tag = product.ProductId // Lưu ProductId để sử dụng trong event handler
            };
            buttonAddToCart.Click += ButtonAddToCart_Click;

            // Thêm controls vào panel
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(textBoxName);
            panel.Controls.Add(textBoxPrice);
            panel.Controls.Add(buttonAddToCart);

            return panel;
        }

        private async void ButtonAddToCart_Click(object sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is int productId)
            {
                await AddToCart(productId, 1);
            }
        }

        private async Task AddToCart(int productId, int quantity)
        {
            try
            {
                var success = await _cartService.AddToCartAsync(_currentUserId, productId, quantity);
                
                if (success)
                {
                    MessageBox.Show("Đã thêm sản phẩm vào giỏ hàng!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể thêm sản phẩm vào giỏ hàng. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHome_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            var cartPage = new CartPage();
            this.Hide();
            cartPage.FormClosed += (s, args) => this.Show();
            cartPage.Show();
        }
    }
}



