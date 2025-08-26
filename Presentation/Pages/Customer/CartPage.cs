using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq; // Added for .Sum()
using System.Drawing; // Added for Font
using System.ComponentModel;
using BLL.Services;
using DAL.Models; // Added for ContentAlignment

namespace Presentation.Pages.Customer
{
    public partial class CartPage : Form
    {
        private readonly ICartService _cartService;
        private int _currentUserId = 1; // default; will be overwritten by session if available
        private List<CartItem> _cartItems;

        public CartPage()
        {
            InitializeComponent();
            _cartService = new CartService();
            _cartItems = new List<CartItem>(); // Khởi tạo để tránh warning nullable
            this.Load += CartPage_Load;
            // Hiển thị tên người dùng đang đăng nhập
            label4.Text = Presentation.Auth.UserSession.CurrentUser?.Fullname ?? label4.Text;
            // lấy user id từ session nếu có
            if (Presentation.Auth.UserSession.CurrentUserId.HasValue)
            {
                _currentUserId = Presentation.Auth.UserSession.CurrentUserId.Value;
            }
            if (buttonLogout != null)
            {
                buttonLogout.Click += buttonLogout_Click;
            }
        }

        private void buttonLogout_Click(object? sender, EventArgs e)
        {
            Presentation.Auth.UserSession.Clear();
            Presentation.Navigation.Navigator.Navigate(new LoginForm());
        }

        private async void CartPage_Load(object? sender, EventArgs e)
        {
            await LoadCartItems();
        }

        private async Task LoadCartItems()
        {
            try
            {
                // Đồng bộ lại user id từ session trước khi gọi service
                if (Presentation.Auth.UserSession.CurrentUserId.HasValue)
                {
                    _currentUserId = Presentation.Auth.UserSession.CurrentUserId.Value;
                }
                System.Diagnostics.Trace.WriteLine($"[CART] SessionUserId={Presentation.Auth.UserSession.CurrentUserId}");
                _cartItems = await _cartService.GetUserCartAsync(_currentUserId);
                System.Diagnostics.Trace.WriteLine($"[CART] Loaded cart items count={_cartItems?.Count ?? 0} for userId={_currentUserId}");
                DisplayCartItems();
                UpdateCartSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải giỏ hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayCartItems()
        {
            flowLayoutPanelCartItems.Controls.Clear();

            if (_cartItems == null || _cartItems.Count == 0)
            {
                var emptyLabel = new Label
                {
                    Text = "Giỏ hàng trống",
                    Font = new Font("Segoe UI", 14, FontStyle.Regular),
                    ForeColor = System.Drawing.Color.Gray,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new System.Drawing.Size(600, 100),
                    Dock = DockStyle.Fill
                };
                flowLayoutPanelCartItems.Controls.Add(emptyLabel);
                return;
            }

            foreach (var cartItem in _cartItems)
            {
                var cartItemPanel = CreateCartItemPanel(cartItem);
                flowLayoutPanelCartItems.Controls.Add(cartItemPanel);
            }
        }

        private Panel CreateCartItemPanel(CartItem cartItem)
        {
            var panel = new Panel
            {
                BackColor = System.Drawing.Color.FromArgb(237, 224, 207),
                Size = new System.Drawing.Size(600, 150),
                Margin = new Padding(10),
                Tag = cartItem
            };

            // Tên sản phẩm
            var labelProductName = new Label
            {
                Text = cartItem.Product?.ProductName ?? "Không có tên",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = System.Drawing.Color.FromArgb(77, 58, 41),
                Location = new System.Drawing.Point(15, 20),
                Size = new System.Drawing.Size(380, 30),
                AutoSize = false
            };

            // Giá sản phẩm (lấy từ Product.SellPrice)
            var labelPrice = new Label
            {
                Text = $"{(cartItem.Product?.SellPrice ?? 0):N0} ₫",
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                ForeColor = System.Drawing.Color.FromArgb(77, 58, 41),
                Location = new System.Drawing.Point(15, 60),
                Size = new System.Drawing.Size(200, 25),
                AutoSize = false
            };

            // Số lượng
            var labelQuantity = new Label
            {
                Text = "Số lượng:",
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                ForeColor = System.Drawing.Color.FromArgb(77, 58, 41),
                Location = new System.Drawing.Point(15, 95),
                Size = new System.Drawing.Size(80, 25),
                AutoSize = false
            };

            var numericUpDownQuantity = new NumericUpDown
            {
                Minimum = 1,
                Maximum = cartItem.Product?.ProductInStock ?? 1, // Sử dụng ProductInStock thay vì Stock
                Value = cartItem.Quantity,
                Location = new System.Drawing.Point(100, 93),
                Size = new System.Drawing.Size(80, 30),
                Tag = cartItem
            };
            numericUpDownQuantity.ValueChanged += NumericUpDownQuantity_ValueChanged;

            // Tổng tiền cho sản phẩm này (tính từ Product.SellPrice)
            var totalPrice = (cartItem.Product?.SellPrice ?? 0) * cartItem.Quantity;
            var labelTotal = new Label
            {
                Text = $"Tổng: {totalPrice:N0} ₫",
                Font = new Font("Segoe UI", 13, FontStyle.Bold),
                ForeColor = System.Drawing.Color.FromArgb(77, 58, 41),
                Location = new System.Drawing.Point(380, 20),
                Size = new Size(230, 30),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleRight
            };

            // Nút xóa
            var buttonRemove = new Button
            {
                Text = "Xóa",
                BackColor = System.Drawing.Color.FromArgb(220, 53, 69),
                ForeColor = System.Drawing.Color.White,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Location = new System.Drawing.Point(480, 95),
                Size = new System.Drawing.Size(90, 35),
                Tag = cartItem,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            buttonRemove.Click += ButtonRemove_Click;

            // Thêm controls vào panel
            panel.Controls.Add(labelProductName);
            panel.Controls.Add(labelPrice);
            panel.Controls.Add(labelQuantity);
            panel.Controls.Add(numericUpDownQuantity);
            panel.Controls.Add(labelTotal);
            panel.Controls.Add(buttonRemove);

            return panel;
        }

        private async void NumericUpDownQuantity_ValueChanged(object? sender, EventArgs e)
        {
            if (sender is NumericUpDown numericUpDown && numericUpDown.Tag is CartItem cartItem)
            {
                try
                {
                    var newQuantity = (int)numericUpDown.Value;
                    var success = await _cartService.UpdateCartItemQuantityAsync(_currentUserId, cartItem.ProductId, newQuantity);

                    if (success)
                    {
                        cartItem.Quantity = newQuantity;
                        await LoadCartItems(); // Reload để cập nhật UI
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật số lượng. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        await LoadCartItems(); // Reload để reset về giá trị cũ
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi cập nhật số lượng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void ButtonRemove_Click(object? sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is CartItem cartItem)
            {
                try
                {
                    var result = MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này khỏi giỏ hàng?", "Xác nhận",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        var success = await _cartService.RemoveFromCartAsync(_currentUserId, cartItem.ProductId);
                        if (success)
                        {
                            await LoadCartItems();
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa sản phẩm. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi xóa sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateCartSummary()
        {
            if (_cartItems == null || _cartItems.Count == 0)
            {
                labelTotalItems.Text = "Tổng sản phẩm: 0";
                labelTotalAmount.Text = "Tổng tiền: 0 ₫";
                return;
            }

            var totalItems = _cartItems.Sum(ci => ci.Quantity);
            var totalAmount = _cartItems.Sum(ci =>
            {
                if (ci.Product?.SellPrice.HasValue == true)
                {
                    return ci.Product.SellPrice.Value * ci.Quantity;
                }
                return 0;
            });

            labelTotalItems.Text = $"Tổng sản phẩm: {totalItems}";
            labelTotalAmount.Text = $"Tổng tiền: {totalAmount:N0} ₫";
        }

        private async void buttonClearCart_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Bạn có chắc muốn xóa toàn bộ giỏ hàng?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var success = await _cartService.ClearCartAsync(_currentUserId);
                    if (success)
                    {
                        await LoadCartItems();
                        MessageBox.Show("Đã xóa toàn bộ giỏ hàng!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa giỏ hàng. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xóa giỏ hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            if (_cartItems == null || _cartItems.Count == 0)
            {
                MessageBox.Show("Giỏ hàng trống! Vui lòng thêm sản phẩm trước khi đặt hàng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Điều hướng qua Navigator để đóng CartPage và mở OrderPage
            Presentation.Navigation.Navigator.Navigate(new OrderPage(_cartItems, _currentUserId));
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new HomePage());
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new HomePage());
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new ProductPage());
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new OrderListPage());
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelCartItems_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelTotalAmount_Click(object sender, EventArgs e)
        {

        }


    }
}
