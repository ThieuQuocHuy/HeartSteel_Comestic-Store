using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Models;
using DAL.Repositories;

namespace Presentation.Pages.Admin
{
    public partial class OrderManagementPage : Form
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderStatusRepository _statusRepository;
        private List<Order> _allOrders = new List<Order>();
        // Sử dụng danh sách chuỗi cứng vì DB không có bảng định nghĩa các loại trạng thái.
        private readonly List<string> _statusOptions = new List<string> { "Chờ xử lý", "Đang giao", "Đã giao", "Hoàn trả" };
        private bool _isEditing = false;
        private int? _currentOrderId = null;

        public OrderManagementPage()
        {
            InitializeComponent();
            _orderRepository = new OrderRepository();
            _statusRepository = new OrderStatusRepository();
            this.Load += OrderManagementPage_Load;
            buttonSearch.Click += buttonSearch_Click;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
        }

        private async void OrderManagementPage_Load(object? sender, EventArgs e)
        {
            LoadStatusesIntoComboBox();
            await LoadOrdersAsync();
            SetupDataGridView();
            ClearForm();
            SetFormMode(false);
            AddHoverEffects();
        }

        #region UI Setup and Effects

        private void AddHoverEffects()
        {
            AddButtonHoverEffect(buttonManageOrders, Color.FromArgb(221, 207, 182), Color.FromArgb(241, 227, 202));
            AddButtonHoverEffect(buttonManageProducts, Color.FromArgb(95, 76, 59), Color.FromArgb(115, 96, 79));
            AddButtonHoverEffect(buttonManageInventory, Color.FromArgb(95, 76, 59), Color.FromArgb(115, 96, 79));
            AddButtonHoverEffect(buttonManageCategories, Color.FromArgb(95, 76, 59), Color.FromArgb(115, 96, 79));
            AddButtonHoverEffect(buttonReports, Color.FromArgb(95, 76, 59), Color.FromArgb(115, 96, 79));
            AddButtonHoverEffect(buttonLogout, Color.FromArgb(184, 84, 84), Color.FromArgb(204, 104, 104));
        }

        private void AddButtonHoverEffect(Button button, Color normalColor, Color hoverColor)
        {
            button.MouseEnter += (s, e) => button.BackColor = hoverColor;
            button.MouseLeave += (s, e) => button.BackColor = normalColor;
        }

        #endregion

        #region Data Loading and Display

        private void LoadStatusesIntoComboBox()
        {
            comboBoxStatus.DataSource = _statusOptions;
            comboBoxStatus.SelectedIndex = -1;
        }

        private async Task LoadOrdersAsync()
        {
            try
            {
                // Sử dụng phương thức GetAllOrdersAsync từ interface
                _allOrders = await _orderRepository.GetAllOrdersAsync();
                UpdateDataGridView(_allOrders);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataGridView()
        {
            dataGridViewOrders.AutoGenerateColumns = false;
            dataGridViewOrders.Columns.Clear();
            dataGridViewOrders.Columns.Add(new DataGridViewTextBoxColumn { Name = "OrderId", HeaderText = "Mã ĐH", DataPropertyName = "OrderId", Width = 80 });
            dataGridViewOrders.Columns.Add(new DataGridViewTextBoxColumn { Name = "CustomerName", HeaderText = "Tên khách hàng", DataPropertyName = "CustomerName", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dataGridViewOrders.Columns.Add(new DataGridViewTextBoxColumn { Name = "OrderDate", HeaderText = "Ngày đặt", DataPropertyName = "OrderDate", Width = 120, DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" } });
            dataGridViewOrders.Columns.Add(new DataGridViewTextBoxColumn { Name = "TotalAmount", HeaderText = "Tổng tiền", DataPropertyName = "TotalAmount", Width = 120, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight } });
            dataGridViewOrders.Columns.Add(new DataGridViewTextBoxColumn { Name = "Status", HeaderText = "Trạng thái", DataPropertyName = "Status", Width = 150 });
        }

        private void UpdateDataGridView(List<Order> orders)
        {
            var displayData = orders.Select(o =>
            {
                var latestStatus = o.OrderStatuses?.OrderByDescending(os => os.ChangedAt).FirstOrDefault()?.Status ?? "Chưa xác định";
                return new
                {
                    o.OrderId,
                    CustomerName = o.User?.Fullname ?? "N/A",
                    o.OrderDate,
                    TotalAmount = o.OrderTotal,
                    Status = latestStatus
                };
            }).ToList();
            dataGridViewOrders.DataSource = displayData;
        }

        #endregion

        #region Form State and Data Binding

        private void SetFormMode(bool isEditing)
        {
            _isEditing = isEditing;
            groupBoxOrderInfo.Enabled = isEditing;
            buttonSave.Visible = isEditing;
            buttonCancel.Visible = isEditing;

            buttonAdd.Enabled = !isEditing;
            buttonEdit.Enabled = !isEditing && dataGridViewOrders.CurrentRow != null;
            buttonDelete.Enabled = !isEditing && dataGridViewOrders.CurrentRow != null;
        }

        private void ClearForm()
        {
            textBoxOrderId.Text = "";
            textBoxCustomerName.Text = "";
            dateTimePickerOrderDate.Value = DateTime.Now;
            numericUpDownTotalAmount.Value = 0;
            if (comboBoxStatus.Items.Count > 0)
                comboBoxStatus.SelectedIndex = -1;
            _currentOrderId = null;
        }

        private void LoadOrderToForm(Order order)
        {
            _currentOrderId = order.OrderId;
            textBoxOrderId.Text = order.OrderId.ToString();
            textBoxCustomerName.Text = order.User?.Fullname ?? "N/A";
            dateTimePickerOrderDate.Value = order.OrderDate;
            numericUpDownTotalAmount.Value = order.OrderTotal;

            var latestStatus = order.OrderStatuses.OrderByDescending(os => os.ChangedAt).FirstOrDefault();

            if (latestStatus != null)
            {
                comboBoxStatus.SelectedItem = latestStatus.Status;
            }
            else
            {
                comboBoxStatus.SelectedIndex = -1;
            }
        }

        private bool ValidateForm()
        {
            if (comboBoxStatus.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn trạng thái đơn hàng!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxStatus.Focus();
                return false;
            }
            return true;
        }

        #endregion

        #region Button Event Handlers (CRUD & Navigation)

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            var addOrderForm = new Admin.AddOrderForm();
            addOrderForm.ShowDialog();
            await LoadOrdersAsync();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.CurrentRow != null)
            {
                var orderId = (int)dataGridViewOrders.CurrentRow.Cells["OrderId"].Value;
                var order = _allOrders.FirstOrDefault(o => o.OrderId == orderId);

                if (order != null)
                {
                    LoadOrderToForm(order);
                    SetFormMode(true);
                }
            }
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders.CurrentRow?.Cells["OrderId"].Value != null)
            {
                var orderId = (int)dataGridViewOrders.CurrentRow.Cells["OrderId"].Value;
                var result = MessageBox.Show($"Bạn có chắc chắn muốn xóa đơn hàng mã '{orderId}' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Sử dụng phương thức DeleteOrderAsync từ interface
                        bool success = await _orderRepository.DeleteOrderAsync(orderId);
                        if (success)
                        {
                            MessageBox.Show("Xóa đơn hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await LoadOrdersAsync();
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa đơn hàng do có ràng buộc dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xóa đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm() || !_currentOrderId.HasValue) return;

            try
            {
                // Sử dụng GetOrderByIdAsync từ interface
                var existingOrder = await _orderRepository.GetOrderByIdAsync(_currentOrderId.Value);
                if (existingOrder == null)
                {
                    MessageBox.Show("Không tìm thấy đơn hàng để cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cập nhật các trường của đối tượng Order
                existingOrder.OrderDate = dateTimePickerOrderDate.Value;
                existingOrder.OrderTotal = numericUpDownTotalAmount.Value;
                // Sử dụng UpdateOrderAsync từ interface
                bool success = await _orderRepository.UpdateOrderAsync(existingOrder);

                if (!success)
                {
                    MessageBox.Show("Không thể cập nhật thông tin đơn hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Xử lý việc thay đổi trạng thái
                string newStatusText = comboBoxStatus.SelectedItem.ToString();
                var latestStatus = existingOrder.OrderStatuses.OrderByDescending(os => os.ChangedAt).FirstOrDefault();

                if (latestStatus == null || latestStatus.Status != newStatusText)
                {
                    var newStatusRecord = new OrderStatus
                    {
                        OrderId = existingOrder.OrderId,
                        Status = newStatusText,
                        ChangedAt = DateTime.Now
                    };
                    await _statusRepository.AddAsync(newStatusRecord);
                }

                MessageBox.Show("Cập nhật đơn hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadOrdersAsync();
                SetFormMode(false);
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu đơn hàng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            SetFormMode(false);
            ClearForm();
        }

        private async void buttonRefresh_Click(object sender, EventArgs e)
        {
            await LoadOrdersAsync();
            ClearForm();
            SetFormMode(false);
        }

        private void dataGridViewOrders_SelectionChanged(object? sender, EventArgs e)
        {
            if (!_isEditing && dataGridViewOrders.CurrentRow?.Cells["OrderId"].Value != null)
            {
                buttonEdit.Enabled = true;
                buttonDelete.Enabled = true;

                var orderId = (int)dataGridViewOrders.CurrentRow.Cells["OrderId"].Value;
                var order = _allOrders.FirstOrDefault(o => o.OrderId == orderId);
                if (order != null)
                {
                    LoadOrderToForm(order);
                }
            }
            else
            {
                buttonEdit.Enabled = false;
                buttonDelete.Enabled = false;
            }
        }

        private void buttonManageProducts_Click(object sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new ProductManagementPage());
        }

        private void buttonManageCategories_Click(object sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new CategoryManagementPage());
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new ReportsPage());
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Presentation.Auth.UserSession.Clear();
            Presentation.Navigation.Navigator.Navigate(new Customer.LoginForm());
        }

        private void buttonManageOrders_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đang ở trang quản lý đơn hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        private void dataGridViewOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewOrders.Rows[e.RowIndex].DataBoundItem != null)
            {
                var orderId = (int)dataGridViewOrders.Rows[e.RowIndex].Cells["OrderId"].Value;
                var selectedOrder = _allOrders.FirstOrDefault(o => o.OrderId == orderId);

                if (selectedOrder != null)
                {
                    var detailForm = new OrderDetailForm(selectedOrder);
                    detailForm.ShowDialog();
                }
            }
        }

        private void buttonReports_Click_1(object sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new ReportsPage());
        }

        private void buttonManageCategories_Click_1(object sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new CategoryManagementPage());
        }

        private void buttonManageInventory_Click_1(object sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new InventoryManagementPage());
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchText = textBoxSearch.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchText))
            {
                UpdateDataGridView(_allOrders);
                return;
            }

            var filteredOrders = _allOrders.Where(o => o.User?.Fullname != null && o.User.Fullname.ToLower().Contains(searchText.ToLower())).ToList();
            UpdateDataGridView(filteredOrders);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                UpdateDataGridView(_allOrders);
            }
        }
    }
}