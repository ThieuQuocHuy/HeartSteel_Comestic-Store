using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Services;
using DAL.Models;
using System.Drawing;
using System.Linq;

namespace Presentation.Pages.Customer
{
    public partial class OrderListPage : Form
    {
        private readonly IOrderService _orderService;
        private int _currentUserId = 1; // default; will be overwritten by session if available
        private List<Order> _orders;

        public OrderListPage()
        {
            InitializeComponent();
            _orderService = new OrderService();
            _orders = new List<Order>();
            this.Load += OrderListPage_Load;
            // Hiển thị tên người dùng đang đăng nhập
            label4.Text = Presentation.Auth.UserSession.CurrentUser?.Fullname ?? label4.Text;
            // lấy user id từ session nếu có
            if (Presentation.Auth.UserSession.CurrentUserId.HasValue)
            {
                _currentUserId = Presentation.Auth.UserSession.CurrentUserId.Value;
            }

            // Gán sự kiện cho các nút điều hướng
            buttonHome.Click += buttonHome_Click!;
            buttonProducts.Click += buttonProducts_Click!;
            buttonCart.Click += buttonCart_Click!;
            if (buttonLogout != null)
            {
                buttonLogout.Click += buttonLogout_Click!;
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
                        System.Diagnostics.Debug.WriteLine("Logo loaded successfully for OrderListPage");
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("Failed to load logo image for OrderListPage");
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

        private async void OrderListPage_Load(object? sender, EventArgs e)
        {
            await LoadOrders();
        }

        private async Task LoadOrders()
        {
            try
            {
                // Đồng bộ lại user id từ session trước khi gọi service
                if (Presentation.Auth.UserSession.CurrentUserId.HasValue)
                {
                    _currentUserId = Presentation.Auth.UserSession.CurrentUserId.Value;
                }
                System.Diagnostics.Trace.WriteLine($"[ORDERS] SessionUserId={Presentation.Auth.UserSession.CurrentUserId}");
                _orders = await _orderService.GetUserOrdersAsync(_currentUserId);
                System.Diagnostics.Trace.WriteLine($"[ORDERS] Loaded orders count={_orders.Count} for userId={_currentUserId}");
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

        private void ButtonViewDetail_Click(object? sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is int orderId)
            {
                var order = _orders.FirstOrDefault(o => o.OrderId == orderId);
                if (order != null)
                {
                    var orderDetailPage = new OrderDetailPage(order);
                    Presentation.Navigation.Navigator.Navigate(orderDetailPage);
                }
            }
        }

        private void buttonHome_Click(object? sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new HomePage());
        }

        private void buttonProducts_Click(object? sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new ProductPage());
        }

        private void buttonCart_Click(object? sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new CartPage());
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {

        }
    }
}
