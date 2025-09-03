using OrderManagement.Services;
using OrderManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagement.Models
{
    public partial class AddOrderForm : Form
    {
        private OrderService _orderService = new OrderService();
        public AddOrderForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                Order newOrder = new Order
                {
                    UserId = Convert.ToInt32(txtUserId.Text),
                    OrderDate = dtpOrderDate.Value,
                    ShippingAddress = txtShippingAddress.Text,
                    OrderTotal = Convert.ToDecimal(txtOrderTotal.Text)
                };

                if (_orderService.AddOrder(newOrder))
                {
                    MessageBox.Show("Thêm đơn hàng thành công!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm đơn hàng thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
