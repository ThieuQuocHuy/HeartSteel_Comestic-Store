using DAL.Models;
using DAL.Repositories;
using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Presentation.Pages.Admin
{
    public partial class OrderDetailForm : Form
    {
        private readonly Order _order;
        private readonly IOrderItemRepository _orderItemRepository;
        private readonly IUserRepository _userRepository;

        public OrderDetailForm(Order order)
        {
            InitializeComponent();
            _order = order;
            _orderItemRepository = new OrderItemRepository();
            _userRepository = new UserRepository();
            this.Load += OrderDetailForm_Load;
        }

        private async void OrderDetailForm_Load(object sender, EventArgs e)
        {
            if (_order != null)
            {
                textBoxOrderId.Text = _order.OrderId.ToString();
                textBoxCustomerId.Text = _order.UserId.ToString();

                var customer = await _userRepository.GetByIdAsync(_order.UserId);
                textBoxCustomerName.Text = customer?.Fullname ?? "Không xác định";

                dateTimePickerOrderDate.Value = _order.OrderDate;

                var currentStatus = _order.OrderStatuses.OrderByDescending(s => s.OrderStatusId).FirstOrDefault();
                textBoxStatus.Text = currentStatus?.Status ?? "Không xác định";

                textBoxShippingAddress.Text = _order.ShippingAddress ?? "Không có thông tin địa chỉ.";

                if (currentStatus?.Status == "Đã hủy" || currentStatus?.Status == "Hoàn trả")
                {
                    labelCancelReason.Visible = true;
                    textBoxCancelReason.Visible = true;
                    textBoxCancelReason.Text = _order.CancelReason?.Description ?? "Không có lý do.";
                }

                labelGrandTotal.Text = $"Tổng tiền: {_order.OrderTotal.ToString("N0", new CultureInfo("vi-VN"))} VND";

                var orderItems = await _orderItemRepository.GetOrderItemsByOrderIdAsync(_order.OrderId);

                var displayData = orderItems.Select(item => new {
                    OrderItemId = item.OrderDetailId,
                    ProductName = item.Product?.ProductName ?? "N/A",
                    Quantity = item.Quantity,
                    Price = item.Price
                }).ToList();

                dataGridViewOrderItems.DataSource = displayData;
                SetupDataGridView();
            }
        }

        private void SetupDataGridView()
        {
            if (dataGridViewOrderItems.Columns.Contains("OrderItemId"))
                dataGridViewOrderItems.Columns["OrderItemId"].HeaderText = "ID Mục";

            if (dataGridViewOrderItems.Columns.Contains("ProductName"))
                dataGridViewOrderItems.Columns["ProductName"].HeaderText = "Tên Sản Phẩm";

            if (dataGridViewOrderItems.Columns.Contains("Quantity"))
                dataGridViewOrderItems.Columns["Quantity"].HeaderText = "Số Lượng";

            if (dataGridViewOrderItems.Columns.Contains("Price"))
            {
                dataGridViewOrderItems.Columns["Price"].HeaderText = "Đơn Giá";
                dataGridViewOrderItems.Columns["Price"].DefaultCellStyle.Format = "N0";
            }
        }
    }
}