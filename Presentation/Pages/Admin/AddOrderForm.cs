using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Pages.Admin
{
    public partial class AddOrderForm : Form
    {
        private readonly IUserRepository _userRepository;
        private readonly IProductRepository _productRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderDetailRepository _orderDetailRepository;
        private readonly IOrderStatusRepository _orderStatusRepository;

        private List<User> _customers;
        private List<Product> _products;
        private BindingList<OrderDetail> _currentOrderItems = new BindingList<OrderDetail>();

        public AddOrderForm()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
            _productRepository = new ProductRepository();
            _orderRepository = new OrderRepository();
            _orderDetailRepository = new OrderDetailRepository();
            _orderStatusRepository = new OrderStatusRepository();
        }

        private async void AddOrderForm_Load(object sender, EventArgs e)
        {
            await LoadInitialDataAsync();
            SetupDataGridView();
        }

        private async Task LoadInitialDataAsync()
        {
            try
            {
                // Tải danh sách khách hàng
                _customers = (await _userRepository.GetAllAsync()).Where(u => u.Role.RoleName.ToLower() == "customer").ToList();

                // Tải và lọc danh sách sản phẩm, chỉ lấy sản phẩm có giá bán
                var allProducts = await _productRepository.GetAllProductsAsync();
                _products = allProducts.Where(p => p.SellPrice.HasValue && p.SellPrice > 0).ToList();

                comboBoxCustomer.DataSource = _customers;
                comboBoxCustomer.DisplayMember = "Fullname";
                comboBoxCustomer.ValueMember = "UserId";
                comboBoxCustomer.SelectedIndex = -1;

                comboBoxProduct.DataSource = _products;
                comboBoxProduct.DisplayMember = "ProductName";
                comboBoxProduct.ValueMember = "ProductId";
                comboBoxProduct.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataGridView()
        {
            dataGridViewItems.DataSource = _currentOrderItems;
            dataGridViewItems.AutoGenerateColumns = false;
            dataGridViewItems.Columns.Clear();

            dataGridViewItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tên sản phẩm", DataPropertyName = "Product.ProductName", Name = "ProductName", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, ReadOnly = true });
            dataGridViewItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Số lượng", DataPropertyName = "Quantity", Name = "Quantity", Width = 80 });
            dataGridViewItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Đơn giá", DataPropertyName = "Price", Name = "Price", Width = 100, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }, ReadOnly = true });
            dataGridViewItems.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Thành tiền", Name = "Subtotal", Width = 120, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }, ReadOnly = true });

            UpdateTotals();
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            // Kiểm tra an toàn để đảm bảo đối tượng được chọn hợp lệ
            if (comboBoxProduct.SelectedItem is Product selectedProduct)
            {
                // Kiểm tra lại giá bán (dù đã lọc) để chắc chắn
                if (!selectedProduct.SellPrice.HasValue)
                {
                    MessageBox.Show($"Sản phẩm '{selectedProduct.ProductName}' không có giá bán hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (numericUpDownQuantity.Value <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số lượng lớn hơn 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var existingItem = _currentOrderItems.FirstOrDefault(item => item.ProductId == selectedProduct.ProductId);

                if (existingItem != null)
                {
                    existingItem.Quantity += (int)numericUpDownQuantity.Value;
                }
                else
                {
                    var newItem = new OrderDetail
                    {
                        ProductId = selectedProduct.ProductId,
                        Product = selectedProduct,
                        Quantity = (int)numericUpDownQuantity.Value,
                        Price = selectedProduct.SellPrice.Value // Dùng .Value vì đã chắc chắn không null
                    };
                    _currentOrderItems.Add(newItem);
                }
                _currentOrderItems.ResetBindings(); // Cập nhật lại DataGridView
                UpdateTotals();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm từ danh sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e) => UpdateTotals();
        private void dataGridViewItems_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e) => UpdateTotals();
        private void dataGridViewItems_CellValueChanged(object sender, DataGridViewCellEventArgs e) => UpdateTotals();

        private void UpdateTotals()
        {
            decimal total = 0;
            foreach (var item in _currentOrderItems)
            {
                total += item.Quantity * item.Price;
            }

            // Cập nhật lại cột thành tiền trên lưới
            foreach (DataGridViewRow row in dataGridViewItems.Rows)
            {
                if (row.DataBoundItem is OrderDetail detail)
                {
                    row.Cells["Subtotal"].Value = detail.Quantity * detail.Price;
                }
            }

            labelTotalAmount.Text = $"{total:N0}";
        }


        private async void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxCustomer.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!_currentOrderItems.Any())
            {
                MessageBox.Show("Vui lòng thêm ít nhất một sản phẩm vào đơn hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 1. Tạo đơn hàng mới
                var newOrder = new Order
                {
                    UserId = (int)comboBoxCustomer.SelectedValue,
                    OrderDate = DateTime.Now,
                    OrderTotal = _currentOrderItems.Sum(item => item.Quantity * item.Price)
                };

                var createdOrder = await _orderRepository.AddOrderAsync(newOrder);
                if (createdOrder == null)
                {
                    throw new Exception("Không thể tạo đơn hàng mới.");
                }

                // 2. Thêm chi tiết đơn hàng
                foreach (var item in _currentOrderItems)
                {
                    item.OrderId = createdOrder.OrderId;
                    await _orderDetailRepository.AddAsync(item);
                }

                // 3. Thêm trạng thái ban đầu cho đơn hàng
                var initialStatus = new OrderStatus
                {
                    OrderId = createdOrder.OrderId,
                    Status = "Chờ xử lý",
                    ChangedAt = DateTime.Now
                };
                await _orderStatusRepository.AddAsync(initialStatus);

                MessageBox.Show("Tạo đơn hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi chi tiết hơn, bao gồm cả InnerException nếu có
                string errorMessage = $"Lỗi khi lưu đơn hàng:\n\nMessage: {ex.Message}";
                if (ex.InnerException != null)
                {
                    errorMessage += $"\n\nInner Exception: {ex.InnerException.Message}";
                }
                errorMessage += $"\n\nStackTrace: {ex.StackTrace}";

                MessageBox.Show(errorMessage, "Lỗi Chi Tiết", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}