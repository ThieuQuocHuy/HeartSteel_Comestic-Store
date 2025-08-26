using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Services;
using DAL.Models;
using System.Drawing;

namespace Presentation.Pages.Customer
{
    public partial class OrderPage : Form
    {
        private readonly IOrderService _orderService;
        private readonly List<CartItem> _cartItems;
        private readonly int _currentUserId;

        public OrderPage(List<CartItem> cartItems, int currentUserId)
        {
            InitializeComponent();
            _orderService = new OrderService();
            _cartItems = cartItems;
            _currentUserId = currentUserId;
            this.Load += OrderPage_Load;
        }

        private async void OrderPage_Load(object? sender, EventArgs e)
        {
            await LoadOrderSummary();
        }

        private async Task LoadOrderSummary()
        {
            try
            {
                if (_cartItems == null || _cartItems.Count == 0)
                {
                    MessageBox.Show("Giỏ hàng trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // Hiển thị tổng quan đơn hàng
                var totalAmount = await _orderService.CalculateOrderTotalAsync(_cartItems);
                labelTotalAmount.Text = $"Tổng tiền: {totalAmount:N0} ₫";

                // Hiển thị danh sách sản phẩm
                DisplayOrderItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải thông tin đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayOrderItems()
        {
            flowLayoutPanelOrderItems.Controls.Clear();

            foreach (var cartItem in _cartItems)
            {
                var orderItemPanel = CreateOrderItemPanel(cartItem);
                flowLayoutPanelOrderItems.Controls.Add(orderItemPanel);
            }
        }

        private Panel CreateOrderItemPanel(CartItem cartItem)
        {
            var panel = new Panel
            {
                BackColor = Color.FromArgb(237, 224, 207),
                Size = new Size(500, 80),
                Margin = new Padding(10)
            };

            // Tên sản phẩm
            var labelProductName = new Label
            {
                Text = cartItem.Product?.ProductName ?? "Không có tên",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(77, 58, 41),
                Location = new Point(15, 15),
                Size = new Size(300, 25),
                AutoSize = false
            };

            // Số lượng
            var labelQuantity = new Label
            {
                Text = $"Số lượng: {cartItem.Quantity}",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.FromArgb(77, 58, 41),
                Location = new Point(15, 45),
                Size = new Size(150, 20),
                AutoSize = false
            };

            // Tổng tiền cho sản phẩm này
            var totalPrice = (cartItem.Product?.SellPrice ?? 0) * cartItem.Quantity;
            var labelTotal = new Label
            {
                Text = $"Tổng: {totalPrice:N0} ₫",
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = Color.FromArgb(77, 58, 41),
                Location = new Point(320, 15),
                Size = new Size(150, 20),
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleRight
            };

            // Thêm controls vào panel
            panel.Controls.Add(labelProductName);
            panel.Controls.Add(labelQuantity);
            panel.Controls.Add(labelTotal);

            return panel;
        }

        private async void buttonPlaceOrder_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(textBoxShippingAddress.Text))
                {
                    MessageBox.Show("Vui lòng nhập địa chỉ giao hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxShippingAddress.Focus();
                    return;
                }

                buttonPlaceOrder.Enabled = false;
                buttonPlaceOrder.Text = "Đang xử lý...";

                // Lấy userId hiện tại từ session (ưu tiên), fallback về _currentUserId
                var sessionUserId = Presentation.Auth.UserSession.CurrentUserId.HasValue
                    ? Presentation.Auth.UserSession.CurrentUserId.Value
                    : _currentUserId;
                System.Diagnostics.Trace.WriteLine($"[CREATE_ORDER] userId={sessionUserId}, cartItems={_cartItems?.Count ?? 0}");

                // Tạo đơn hàng
                var success = await _orderService.CreateOrderFromCartAsync(
                    sessionUserId,
                    _cartItems,
                    textBoxShippingAddress.Text.Trim()
                );

                if (success)
                {
                    MessageBox.Show("Đặt hàng thành công! Đơn hàng của bạn đã được tạo.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Presentation.Navigation.Navigator.Navigate(new OrderListPage());
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Đặt hàng thất bại! Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi đặt hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                buttonPlaceOrder.Enabled = true;
                buttonPlaceOrder.Text = "Đặt hàng";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new CartPage());
        }
    }
}
