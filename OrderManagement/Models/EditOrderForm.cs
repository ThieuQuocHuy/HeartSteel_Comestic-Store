using OrderManagement.Models;
using OrderManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OrderManagement.Forms
{
    public partial class EditOrderForm : Form
    {
        private OrderService _orderService = new OrderService();
        private Order _order;

        public EditOrderForm(int orderId)
        {
            InitializeComponent();
            this.Text = "Sửa đơn hàng: " + orderId;
            LoadOrderData(orderId);
            // Gán sự kiện TextChanged cho txtUserId
            txtUserId.TextChanged += new System.EventHandler(this.txtUserId_TextChanged);
        }

        private void LoadOrderData(int orderId)
        {
            _order = _orderService.GetOrderById(orderId);
            if (_order != null)
            {
                txtUserId.Text = _order.UserId.ToString();
                dtpOrderDate.Value = _order.OrderDate;
                txtShippingAddress.Text = _order.ShippingAddress;
                txtOrderTotal.Text = _order.OrderTotal.ToString();

                // Tải thông tin người dùng
                DataTable userDetails = _orderService.GetUserById(_order.UserId);
                if (userDetails.Rows.Count > 0)
                {
                    txtFullname.Text = userDetails.Rows[0]["fullname"].ToString();
                    txtPhone.Text = userDetails.Rows[0]["phone"].ToString();
                    txtEmail.Text = userDetails.Rows[0]["email"].ToString();

                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy đơn hàng!");
                this.Close();
            }
        }

        // Phương thức xử lý sự kiện khi người dùng thay đổi UserId
        private void txtUserId_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtUserId.Text, out int userId))
            {
                DataTable userDetails = _orderService.GetUserById(userId);
                if (userDetails.Rows.Count > 0)
                {
                    txtFullname.Text = userDetails.Rows[0]["fullname"].ToString();
                    txtPhone.Text = userDetails.Rows[0]["phone"].ToString();
                    txtEmail.Text = userDetails.Rows[0]["email"].ToString();
                }
                else
                {
                    txtFullname.Text = "";
                    txtPhone.Text = "";
                    txtEmail.Text = "";
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _order.UserId = Convert.ToInt32(txtUserId.Text);
                _order.OrderDate = dtpOrderDate.Value;
                _order.ShippingAddress = txtShippingAddress.Text;
                _order.OrderTotal = Convert.ToDecimal(txtOrderTotal.Text);

                if (_orderService.UpdateOrder(_order))
                {
                    MessageBox.Show("Cập nhật đơn hàng thành công!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật đơn hàng thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}