using OrderManagement.Models;
using OrderManagement.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace OrderManagement.Forms
{
    public partial class OrderDetailForm : Form
    {
        private OrderService _orderService = new OrderService();
        private int _orderId;

        public OrderDetailForm(int orderId)
        {
            InitializeComponent();
            _orderId = orderId;
            LoadOrderDetails();
            this.Text = "Chi tiết đơn hàng: " + orderId;
        }

        private void LoadOrderDetails()
        {
            try
            {
                // Tải thông tin tổng quan của đơn hàng
                Order order = _orderService.GetOrderById(_orderId);
                if (order != null)
                {
                    // Gán dữ liệu vào các control
                    txtOrderId.Text = order.OrderId.ToString();
                    txtUserId.Text = order.UserId.ToString();
                    txtOrderDate.Text = order.OrderDate.ToString("dd/MM/yyyy");
                    txtShippingAddress.Text = order.ShippingAddress;
                    lblTotal.Text = "Tổng tiền: " + order.OrderTotal.ToString("N0") + " VNĐ";

                    // Tải thông tin người dùng
                    DataTable userDetails = _orderService.GetUserById(order.UserId);
                    if (userDetails.Rows.Count > 0)
                    {
                        txtFullname.Text = userDetails.Rows[0]["fullname"].ToString();
                        txtPhone.Text = userDetails.Rows[0]["phone"].ToString();
                        txtEmail.Text = userDetails.Rows[0]["email"].ToString();
                    }

                    // Tải chi tiết sản phẩm của đơn hàng vào DataGridView
                    DataTable dt = _orderService.GetOrderDetails(_orderId);

                    // Xóa các cột hiện có và thêm các cột thủ công
                    dgvOrderDetails.Columns.Clear();
                    dgvOrderDetails.AutoGenerateColumns = false;

                    // Thêm cột cho tên sản phẩm
                    DataGridViewTextBoxColumn productNameColumn = new DataGridViewTextBoxColumn();
                    productNameColumn.HeaderText = "Tên sản phẩm";
                    productNameColumn.Name = "product_name";
                    productNameColumn.DataPropertyName = "product_name";
                    dgvOrderDetails.Columns.Add(productNameColumn);

                    // Thêm cột cho số lượng
                    DataGridViewTextBoxColumn quantityColumn = new DataGridViewTextBoxColumn();
                    quantityColumn.HeaderText = "Số lượng";
                    quantityColumn.Name = "quantity";
                    quantityColumn.DataPropertyName = "quantity";
                    dgvOrderDetails.Columns.Add(quantityColumn);

                    // Thêm cột cho giá
                    DataGridViewTextBoxColumn priceColumn = new DataGridViewTextBoxColumn();
                    priceColumn.HeaderText = "Giá";
                    priceColumn.Name = "price";
                    priceColumn.DataPropertyName = "price";
                    dgvOrderDetails.Columns.Add(priceColumn);

                    // Ẩn cột orderDetail_id
                    // Do AutoGenerateColumns = false, cột này sẽ không được tạo, nên không cần ẩn nó nữa.

                    // Gán DataSource sau khi đã định nghĩa các cột
                    dgvOrderDetails.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy đơn hàng!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải chi tiết đơn hàng: " + ex.Message);
            }
        }
    }
}