using OrderManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderManagement.Forms;
using OrderManagement.Models;

namespace OrderManagement
{
    public partial class OrderManagementForm : Form
    {
        private OrderService _orderService = new OrderService();
        public OrderManagementForm()
        {
            InitializeComponent();
            LoadOrders();
            LoadOrders(txtSearch.Text, GetSelectedCategoryId());
            LoadCategories();
        }

        private void LoadCategories()
        {
            try
            {
                DataTable dt = _orderService.GetCategories();
                DataRow newRow = dt.NewRow();
                newRow["category_id"] = DBNull.Value;
                newRow["category_name"] = "Tất cả";
                dt.Rows.InsertAt(newRow, 0);

                cboCategory.DataSource = dt;
                cboCategory.DisplayMember = "category_name";
                cboCategory.ValueMember = "category_id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh mục: " + ex.Message);
            }
        }

        private void LoadOrders(string searchTerm = null, int? categoryId = null)
        {
            try
            {
                dgvOrders.DataSource = _orderService.GetFilteredOrders(searchTerm, categoryId);

                // Đổi tên các cột sang tiếng Việt
                if (dgvOrders.Columns.Contains("order_id"))
                {
                    dgvOrders.Columns["order_id"].HeaderText = "Mã đơn hàng";
                }
                if (dgvOrders.Columns.Contains("fullname"))
                {
                    dgvOrders.Columns["fullname"].HeaderText = "Tên người dùng";
                }
                if (dgvOrders.Columns.Contains("phone"))
                {
                    dgvOrders.Columns["phone"].HeaderText = "Số điện thoại";
                }
                if (dgvOrders.Columns.Contains("address"))
                {
                    dgvOrders.Columns["address"].HeaderText = "Địa chỉ";
                }
                if (dgvOrders.Columns.Contains("user_id"))
                {
                    dgvOrders.Columns["user_id"].HeaderText = "Mã người dùng";
                }
                if (dgvOrders.Columns.Contains("shipping_address"))
                {
                    dgvOrders.Columns["shipping_address"].HeaderText = "Địa chỉ giao hàng";
                }
                if (dgvOrders.Columns.Contains("status"))
                {
                    dgvOrders.Columns["status"].HeaderText = "Trạng thái";
                }
                if (dgvOrders.Columns.Contains("order_total"))
                {
                    dgvOrders.Columns["order_total"].HeaderText = "Tổng tiền";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách đơn hàng: " + ex.Message);
            }
        }

        // Bổ sung các phương thức xử lý sự kiện cho các nút
        private void btnThem_Click(object sender, EventArgs e)
        {
            AddOrderForm addForm = new AddOrderForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadOrders(); // Tải lại danh sách sau khi thêm thành công
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["order_id"].Value);

                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa đơn hàng đã chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    bool success = _orderService.DeleteOrder(orderId);
                    if (success)
                    {
                        MessageBox.Show("Xóa đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadOrders();
                    }
                    else
                    {
                        MessageBox.Show("Xóa đơn hàng thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một đơn hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["order_id"].Value);
                EditOrderForm editForm = new EditOrderForm(orderId);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadOrders(); // Tải lại danh sách sau khi sửa thành công
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một đơn hàng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            LoadOrders(txtSearch.Text, GetSelectedCategoryId());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadOrders(txtSearch.Text, GetSelectedCategoryId());
        }

        private int? GetSelectedCategoryId()
        {
            if (cboCategory.SelectedValue != null && cboCategory.SelectedValue != DBNull.Value)
            {
                return Convert.ToInt32(cboCategory.SelectedValue);
            }
            return null;
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvOrders.Rows[e.RowIndex];
                int orderId = Convert.ToInt32(row.Cells[0].Value);

                OrderDetailForm orderDetailForm = new OrderDetailForm(orderId);
                orderDetailForm.ShowDialog();
            }
        }
    }
}