using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Services;
using DAL.Models;
using System.Drawing;

namespace Presentation.Pages.Customer
{
    public partial class ProductPage : Form
    {
        private readonly IProductService _productService;
        private readonly ICartService _cartService;
        private int _currentUserId = 1; // default; will be overwritten by session if available
        private List<Product> _allProducts = new List<Product>();

        public ProductPage()
        {
            InitializeComponent();
            _productService = new ProductService(new DAL.Repositories.ProductRepository());
            _cartService = new CartService();
            // Hiển thị tên người dùng đang đăng nhập
            label4.Text = Presentation.Auth.UserSession.CurrentUser?.Fullname ?? label4.Text;
            this.Load += ProductPage_Load;
            // lấy user id từ session nếu có
            if (Presentation.Auth.UserSession.CurrentUserId.HasValue)
            {
                _currentUserId = Presentation.Auth.UserSession.CurrentUserId.Value;
            }
            
            // Gán sự kiện cho các nút điều hướng
            buttonHome.Click += buttonHome_Click;
            buttonCart.Click += buttonCart_Click;
            buttonOrders.Click += buttonOrders_Click;
            if (buttonLogout != null)
            {
                buttonLogout.Click += buttonLogout_Click;
            }
            // Load ảnh
            LoadImages();
        }

        private void LoadImages()
        {
            try
            {
                // Load logo
                if (pictureBoxLogo != null)
                {
                    var logoImage = Presentation.Services.ResourceImageLoader.LoadByFileName("logoden.png");
                    if (logoImage != null)
                    {
                        pictureBoxLogo.Image = logoImage;
                        System.Diagnostics.Debug.WriteLine("Logo loaded successfully for ProductPage");
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("Failed to load logo image for ProductPage");
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"LoadImages Error: {ex.Message}");
            }
        }
        private void buttonLogout_Click(object? sender, EventArgs e)
        {
            Presentation.Auth.UserSession.Clear();
            Presentation.Navigation.Navigator.Navigate(new LoginForm());
        }

        private async void ProductPage_Load(object? sender, EventArgs e)
        {
            await LoadProducts();
            WireUpFilterControls();
        }

        private async Task LoadProducts()
        {
            try
            {
                var products = await _productService.GetAllAsync();
                _allProducts = new List<Product>(products);

                // Xóa các panel cũ nếu có
                ClearProductPanels();

                if (products.Count > 0)
                {
                    ApplyFiltersAndRender();
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

                System.Diagnostics.Debug.WriteLine($"ProductPage: Loaded {products.Count} products");
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
                BorderStyle = BorderStyle.FixedSingle,
                Tag = product.ProductId // Lưu ProductId để sử dụng khi thêm vào giỏ hàng
            };

            // Hình ảnh sản phẩm (placeholder)
            var pictureBox = new PictureBox
            {
                Location = new Point(5, 4),
                Size = new Size(272, 191),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.LightGray,
                Cursor = Cursors.Hand,
                Tag = product.ProductId
            };
            pictureBox.Click += ProductCard_Click;
            // Load image from resources by Img field
            System.Diagnostics.Debug.WriteLine($"Loading image for product {product.ProductName}: {product.Img}");
            var img = Presentation.Services.ResourceImageLoader.LoadByFileName(product.Img);
            if (img != null)
            {
                pictureBox.Image = img;
                pictureBox.BackColor = Color.White;
                System.Diagnostics.Debug.WriteLine($"Successfully loaded image for {product.ProductName}");
            }
            else
            {
                System.Diagnostics.Debug.WriteLine($"Failed to load image for {product.ProductName}: {product.Img}");
            }

            // Tên sản phẩm (giữa, dưới ảnh)
            var labelName = new Label
            {
                BackColor = SystemColors.ControlLightLight,
                AutoSize = false,
                Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular),
                Location = new Point(10, 201),
                Size = new Size(262, 40),
                TextAlign = ContentAlignment.MiddleCenter,
                Text = product.ProductName ?? "Không có tên",
                Cursor = Cursors.Hand,
                Tag = product.ProductId
            };
            labelName.Click += ProductCard_Click;

            // Giá sản phẩm (bên trái) và Đã bán (bên phải)
            var labelPrice = new Label
            {
                BackColor = SystemColors.ControlLightLight,
                AutoSize = false,
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular),
                Location = new Point(10, 260),
                Size = new Size(130, 25),
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = Color.Red,
                Text = $"{(product.SellPrice ?? 0):N0} ₫"
            };

            var labelSold = new Label
            {
                BackColor = SystemColors.ControlLightLight,
                AutoSize = false,
                Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular),
                Location = new Point(142, 260), // 262 - 10 (padding phải) - 110 (width) = 142
                Size = new Size(130, 25),
                TextAlign = ContentAlignment.MiddleRight,
                Text = $"đã bán: {product.SoldCount}"
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
            panel.Controls.Add(labelName);
            panel.Controls.Add(labelPrice);
            panel.Controls.Add(labelSold);
            panel.Controls.Add(buttonAddToCart);

            return panel;
        }

        private void ApplyFiltersAndRender()
        {
            IEnumerable<Product> query = _allProducts;

            // Lọc theo tên
            var keyword = textSearch?.Text?.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(p => (p.ProductName ?? string.Empty).IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0);
            }

            // Lọc theo danh mục
            if (comboCategory?.SelectedItem is ComboBoxItem catItem && catItem.Value is int catId && catId != -1)
            {
                query = query.Where(p => (p.CategoryId ?? -1) == catId);
            }

            // Sắp xếp theo giá
            if (comboSortPrice?.SelectedItem is ComboBoxItem sortItem)
            {
                switch (sortItem.Value)
                {
                    case "asc":
                        query = query.OrderBy(p => p.SellPrice ?? 0);
                        break;
                    case "desc":
                        query = query.OrderByDescending(p => p.SellPrice ?? 0);
                        break;
                }
            }

            // Render
            ClearProductPanels();
            foreach (var p in query)
            {
                flowLayoutPanelProducts.Controls.Add(CreateProductPanel(p));
            }
        }

        private void WireUpFilterControls()
        {
            // Categories
            comboCategory.Items.Clear();
            comboCategory.Items.Add(new ComboBoxItem("Tất cả danh mục", -1));
            var cats = _allProducts.Select(p => p.Category).Where(c => c != null).GroupBy(c => c!.CategoryId).Select(g => g.First()!).OrderBy(c => c.CategoryName);
            foreach (var c in cats)
            {
                comboCategory.Items.Add(new ComboBoxItem(c.CategoryName, c.CategoryId));
            }
            if (comboCategory.Items.Count > 0) comboCategory.SelectedIndex = 0;

            // Sort
            comboSortPrice.Items.Clear();
            comboSortPrice.Items.Add(new ComboBoxItem("Giá: mặc định", "none"));
            comboSortPrice.Items.Add(new ComboBoxItem("Giá: thấp đến cao", "asc"));
            comboSortPrice.Items.Add(new ComboBoxItem("Giá: cao đến thấp", "desc"));
            comboSortPrice.SelectedIndex = 0;

            // Events
            textSearch.TextChanged += (_, __) => ApplyFiltersAndRender();
            comboCategory.SelectedIndexChanged += (_, __) => ApplyFiltersAndRender();
            comboSortPrice.SelectedIndexChanged += (_, __) => ApplyFiltersAndRender();
        }

        private class ComboBoxItem
        {
            public string Text { get; }
            public object Value { get; }
            public ComboBoxItem(string text, object value)
            {
                Text = text;
                Value = value;
            }
            public override string ToString() => Text;
        }

        private void ProductCard_Click(object? sender, EventArgs e)
        {
            int? productId = null;
            switch (sender)
            {
                case Control c when c.Tag is int id:
                    productId = id;
                    break;
                case Control { Parent.Tag: int id2 }:
                    productId = id2;
                    break;
            }

            if (productId.HasValue)
            {
                Presentation.Navigation.Navigator.Navigate(new ProductDetailPage(productId.Value));
            }
        }

        private async void ButtonAddToCart_Click(object? sender, EventArgs e)
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
                // Đồng bộ lại user id từ session trước khi thêm giỏ hàng
                if (Presentation.Auth.UserSession.CurrentUserId.HasValue)
                {
                    _currentUserId = Presentation.Auth.UserSession.CurrentUserId.Value;
                }
                System.Diagnostics.Trace.WriteLine($"[ADD_CART] userId={_currentUserId}, productId={productId}, qty={quantity}");

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
            Presentation.Navigation.Navigator.Navigate(new HomePage());
        }

        private void buttonCart_Click(object? sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new CartPage());
        }

        private void buttonOrders_Click(object? sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new OrderListPage());
        }



        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

    }
}



