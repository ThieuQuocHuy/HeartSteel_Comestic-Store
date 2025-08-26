using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DAL.Models;
using System.Drawing;

namespace Presentation.Pages.Customer
{
    public partial class OrderDetailPage : Form
    {
        private readonly Order _order;

        public OrderDetailPage(Order order)
        {
            InitializeComponent();
            _order = order;
            this.Load += OrderDetailPage_Load;
        }

        private void OrderDetailPage_Load(object? sender, EventArgs e)
        {
            LoadOrderDetails();
        }

        private void LoadOrderDetails()
        {
            try
            {
                // Hiển thị thông tin đơn hàng
                labelOrderId.Text = $"Đơn hàng #{_order.OrderId}";
                labelOrderDate.Text = $"Ngày đặt: {_order.OrderDate:dd/MM/yyyy HH:mm}";
                labelTotalAmount.Text = $"Tổng tiền: {_order.OrderTotal:N0} ₫";
                labelShippingAddress.Text = $"Địa chỉ giao hàng: {_order.ShippingAddress}";

                // Hiển thị trạng thái đơn hàng
                var latestStatus = _order.OrderStatuses?.OrderByDescending(os => os.ChangedAt).FirstOrDefault()?.Status ?? "Chờ xử lý";
                labelStatus.Text = $"Trạng thái: {latestStatus}";
                labelStatus.ForeColor = GetStatusColor(latestStatus);

                // Hiển thị danh sách sản phẩm
                DisplayOrderItems();

                // Hiển thị lịch sử trạng thái
                DisplayStatusHistory();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải chi tiết đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayOrderItems()
        {
            flowLayoutPanelOrderItems.Controls.Clear();

            if (_order.OrderDetails == null || _order.OrderDetails.Count == 0)
            {
                var emptyLabel = new Label
                {
                    Text = "Không có sản phẩm nào",
                    Font = new Font("Segoe UI", 12, FontStyle.Regular),
                    ForeColor = Color.Gray,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new Size(500, 50),
                    Dock = DockStyle.Fill
                };
                flowLayoutPanelOrderItems.Controls.Add(emptyLabel);
                return;
            }

            foreach (var orderDetail in _order.OrderDetails)
            {
                var itemPanel = CreateOrderItemPanel(orderDetail);
                flowLayoutPanelOrderItems.Controls.Add(itemPanel);
            }
        }

        private Panel CreateOrderItemPanel(OrderDetail orderDetail)
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
                Text = orderDetail.Product?.ProductName ?? "Không có tên",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.FromArgb(77, 58, 41),
                Location = new Point(15, 15),
                Size = new Size(300, 25),
                AutoSize = false
            };

            // Số lượng
            var labelQuantity = new Label
            {
                Text = $"Số lượng: {orderDetail.Quantity}",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.FromArgb(77, 58, 41),
                Location = new Point(15, 45),
                Size = new Size(150, 20),
                AutoSize = false
            };

            // Giá mỗi sản phẩm
            var unitPrice = orderDetail.Price / orderDetail.Quantity;
            var labelUnitPrice = new Label
            {
                Text = $"Đơn giá: {unitPrice:N0} ₫",
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = Color.FromArgb(77, 58, 41),
                Location = new Point(200, 45),
                Size = new Size(150, 20),
                AutoSize = false
            };

            // Tổng tiền cho sản phẩm này
            var labelTotal = new Label
            {
                Text = $"Tổng: {orderDetail.Price:N0} ₫",
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
            panel.Controls.Add(labelUnitPrice);
            panel.Controls.Add(labelTotal);

            return panel;
        }

        private void DisplayStatusHistory()
        {
            flowLayoutPanelStatusHistory.Controls.Clear();

            if (_order.OrderStatuses == null || _order.OrderStatuses.Count == 0)
            {
                var emptyLabel = new Label
                {
                    Text = "Chưa có lịch sử trạng thái",
                    Font = new Font("Segoe UI", 10, FontStyle.Regular),
                    ForeColor = Color.Gray,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new Size(300, 30),
                    Dock = DockStyle.Fill
                };
                flowLayoutPanelStatusHistory.Controls.Add(emptyLabel);
                return;
            }

            var sortedStatuses = _order.OrderStatuses.OrderBy(os => os.ChangedAt).ToList();
            foreach (var status in sortedStatuses)
            {
                var statusPanel = CreateStatusPanel(status);
                flowLayoutPanelStatusHistory.Controls.Add(statusPanel);
            }
        }

        private Panel CreateStatusPanel(OrderStatus orderStatus)
        {
            var panel = new Panel
            {
                BackColor = Color.FromArgb(255, 255, 255),
                Size = new Size(300, 60),
                Margin = new Padding(5),
                BorderStyle = BorderStyle.FixedSingle
            };

            // Trạng thái
            var labelStatus = new Label
            {
                Text = orderStatus.Status,
                Font = new Font("Segoe UI", 11, FontStyle.Bold),
                ForeColor = GetStatusColor(orderStatus.Status),
                Location = new Point(10, 10),
                Size = new Size(280, 20),
                AutoSize = false
            };

            // Thời gian thay đổi
            var labelTime = new Label
            {
                Text = orderStatus.ChangedAt.ToString("dd/MM/yyyy HH:mm"),
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                ForeColor = Color.Gray,
                Location = new Point(10, 35),
                Size = new Size(280, 15),
                AutoSize = false
            };

            panel.Controls.Add(labelStatus);
            panel.Controls.Add(labelTime);

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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
