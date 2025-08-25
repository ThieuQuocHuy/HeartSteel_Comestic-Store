using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Customer.Services;
using DAL.Models;
using System.Drawing;
using System.Linq;

namespace Customer
{
    public partial class OrderListPage : Form
    {
        private readonly IOrderService _orderService;
        private int _currentUserId = 1; // Tạm thời hardcode, sau này sẽ lấy từ login
        private List<Order> _orders;

        public OrderListPage()
        {
            InitializeComponent();
            _orderService = new OrderService();
            _orders = new List<Order>();
            this.Load += OrderListPage_Load;
        }

        private async void OrderListPage_Load(object? sender, EventArgs e)
        {
            await LoadOrders();
        }

        private async Task LoadOrders()
        {
            try
            {
                _orders = await _orderService.GetUserOrdersAsync(_currentUserId);
                DisplayOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayOrders()
        {
            flowLayoutPanelOrders.Controls.Clear();

            if (_orders == null || _orders.Count == 0)
            {
                var emptyLabel = new Label
                {
                    Text = "Bạn chưa có đơn hàng nào",
                    Font = new Font("Segoe UI", 14, FontStyle.Regular),
                    ForeColor = Color.Gray,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new Size(600, 100),
                    Dock = DockStyle.Fill
                };
                flowLayoutPanelOrders.Controls.Add(emptyLabel);
                return;
            }

            foreach (var order in _orders)
            {
                var orderPanel = CreateOrderPanel(order);
                flowLayoutPanelOrders.Controls.Add(orderPanel);
            }
        }

        private Panel CreateOrderPanel(Order order)
        {
            var panel = new Panel
            {
                BackColor = Color.FromArgb(237, 224, 207),
                Size = new Size(700, 120),
                Margin = new Padding(10),
                Tag = order.OrderId
            };

            // Mã đơn hàng
            var labelOrderId = new Label
            {
                Text = $"Đơn hàng #{order.OrderId}",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.FromArgb(77, 58, 41),
                Location = new Point(15, 15),
                Size = new Size(200, 25),
                AutoSize = false
            };

            // Ngày đặt hàng
            var labelOrderDate = new Label
            {
                Text = $"Ngày: {order.OrderDate:dd/MM/yyyy HH:mm}",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.FromArgb(77, 58, 41),
                Location = new Point(15, 45),
                Size = new Size(200, 20),
                AutoSize = false
            };

            // Tổng tiền
            var labelTotal = new Label
            {
                Text = $"Tổng tiền: {order.OrderTotal:N0} ₫",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(77, 58, 41),
                Location = new Point(15, 70),
                Size = new Size(200, 20),
                AutoSize = false
            };

            // Số lượng sản phẩm
            var itemCount = order.OrderDetails?.Count ?? 0;
            var labelItemCount = new Label
            {
                Text = $"{itemCount} sản phẩm",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.FromArgb(77, 58, 41),
                Location = new Point(250, 15),
                Size = new Size(150, 20),
                AutoSize = false
            };

            // Địa chỉ giao hàng
            var labelAddress = new Label
            {
                Text = $"Địa chỉ: {order.ShippingAddress}",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.FromArgb(77, 58, 41),
                Location = new Point(250, 45),
                Size = new Size(400, 20),
                AutoSize = false
            };

            // Trạng thái đơn hàng (lấy từ OrderStatus mới nhất)
            var latestStatus = order.OrderStatuses?.OrderByDescending(os => os.ChangedAt).FirstOrDefault()?.Status ?? "Chờ xử lý";
            var labelStatus = new Label
            {
                Text = $"Trạng thái: {latestStatus}",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = GetStatusColor(latestStatus),
                Location = new Point(250, 70),
                Size = new Size(200, 20),
                AutoSize = false
            };

            // Nút xem chi tiết
            var buttonViewDetail = new Button
            {
                Text = "Xem chi tiết",
                BackColor = Color.FromArgb(40, 167, 69),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(550, 70),
                Size = new Size(120, 35),
                Tag = order.OrderId
            };
            buttonViewDetail.Click += ButtonViewDetail_Click;

            // Thêm controls vào panel
            panel.Controls.Add(labelOrderId);
            panel.Controls.Add(labelOrderDate);
            panel.Controls.Add(labelTotal);
            panel.Controls.Add(labelItemCount);
            panel.Controls.Add(labelAddress);
            panel.Controls.Add(labelStatus);
            panel.Controls.Add(buttonViewDetail);

            return panel;
        }

        private Color GetStatusColor(string status)
        {
            return status.ToLower() switch
            {
                "pending" or "chờ xử lý" => Color.Orange,
                "processing" or "đang xử lý" => Color.Blue,
                "shipped" or "đã giao hàng" => Color.Green,
                "delivered" or "đã nhận hàng" => Color.DarkGreen,
                "cancelled" or "đã hủy" => Color.Red,
                _ => Color.Gray
            };
        }

        private void ButtonViewDetail_Click(object sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is int orderId)
            {
                var order = _orders.FirstOrDefault(o => o.OrderId == orderId);
                if (order != null)
                {
                    var orderDetailPage = new OrderDetailPage(order);
                    this.Hide();
                    orderDetailPage.FormClosed += (s, args) => this.Show();
                    orderDetailPage.Show();
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
