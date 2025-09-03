using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Models;
using DAL.Repositories;

namespace Presentation.Pages.Admin
{
    public partial class InventoryManagementPage : Form
    {
        private readonly InventoryRepository _inventoryRepository;
        private List<Product> _allProducts;
        private const int ALERT_THRESHOLD = 10;

        public InventoryManagementPage()
        {
            InitializeComponent();
            _inventoryRepository = new InventoryRepository();
            this.Load += InventoryManagementPage_Load;
        }

        private async void InventoryManagementPage_Load(object sender, EventArgs e)
        {
            SetupDataGridViews();
            await LoadAllDataAsync();
            AddHoverEffects();
        }

        #region Setup UI

        private void AddHoverEffects()
        {
            // Thêm hiệu ứng hover cho sidebar buttons
            AddButtonHoverEffect(buttonManageProducts, Color.FromArgb(95, 76, 59), Color.FromArgb(115, 96, 79));
            AddButtonHoverEffect(buttonManageInventory, Color.FromArgb(221, 207, 182), Color.FromArgb(241, 227, 202));
            AddButtonHoverEffect(buttonManageCategories, Color.FromArgb(95, 76, 59), Color.FromArgb(115, 96, 79));
            AddButtonHoverEffect(buttonManageOrders, Color.FromArgb(95, 76, 59), Color.FromArgb(115, 96, 79));
            AddButtonHoverEffect(buttonReports, Color.FromArgb(95, 76, 59), Color.FromArgb(115, 96, 79));
            AddButtonHoverEffect(buttonLogout, Color.FromArgb(184, 84, 84), Color.FromArgb(204, 104, 104));
        }

        private void AddButtonHoverEffect(Button button, Color normalColor, Color hoverColor)
        {
            button.MouseEnter += (s, e) => button.BackColor = hoverColor;
            button.MouseLeave += (s, e) => button.BackColor = normalColor;
        }

        private void SetupDataGridViews()
        {
            SetupInventoryDataGridView();
            SetupStockAlertsDataGridView();
        }

        private void SetupInventoryDataGridView()
        {
            dataGridViewInventory.AutoGenerateColumns = false;
            dataGridViewInventory.Columns.Clear();

            dataGridViewInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProductId",
                HeaderText = "Mã SP",
                DataPropertyName = "ProductId",
                Width = 80
            });

            dataGridViewInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProductName",
                HeaderText = "Tên sản phẩm",
                DataPropertyName = "ProductName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dataGridViewInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProductInStock",
                HeaderText = "Tồn kho",
                DataPropertyName = "ProductInStock",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
        }

        private void SetupStockAlertsDataGridView()
        {
            dataGridViewStockAlerts.AutoGenerateColumns = false;
            dataGridViewStockAlerts.Columns.Clear();

            dataGridViewStockAlerts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProductId",
                HeaderText = "Mã SP",
                DataPropertyName = "ProductId",
                Width = 80
            });
            dataGridViewStockAlerts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProductName",
                HeaderText = "Tên sản phẩm",
                DataPropertyName = "ProductName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dataGridViewStockAlerts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProductInStock",
                HeaderText = "Tồn kho",
                DataPropertyName = "ProductInStock",
                Width = 100
            });
            dataGridViewStockAlerts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                HeaderText = "Tình trạng",
                DataPropertyName = "Status",
                Width = 120
            });
        }

        private async Task LoadAllDataAsync()
        {
            try
            {
                _allProducts = (await _inventoryRepository.GetInventoryProductsAsync()).ToList();
                UpdateInventoryDataGridView(_allProducts);
                UpdateStockAlertsDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu tồn kho: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateInventoryDataGridView(List<Product> products)
        {
            var displayData = products.Select(p => new
            {
                p.ProductId,
                p.ProductName,
                p.ProductInStock
            }).ToList();
            dataGridViewInventory.DataSource = displayData;
        }

        private void UpdateStockAlertsDataGridView()
        {
            var alertProducts = _allProducts.Where(p => p.ProductInStock < ALERT_THRESHOLD).ToList();
            var displayData = alertProducts.Select(p => new
            {
                p.ProductId,
                p.ProductName,
                p.ProductInStock,
                Status = "Dưới ngưỡng"
            }).ToList();

            dataGridViewStockAlerts.DataSource = displayData;

            foreach (DataGridViewRow row in dataGridViewStockAlerts.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }

        private void buttonManageInventory_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đang ở trang quản lý kho hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonManageProducts_Click_1(object sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new ProductManagementPage());
        }

        private void buttonManageCategories_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("📂 Chức năng quản lý danh mục sẽ được phát triển trong phiên bản tiếp theo.",
                "Quản lý danh mục", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonReports_Click_1(object sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new ReportsPage());
        }

        private void buttonLogout_Click_1(object sender, EventArgs e)
        {
            Presentation.Auth.UserSession.Clear();
            Presentation.Navigation.Navigator.Navigate(new Customer.LoginForm());
        }

        private void buttonManageOrders_Click(object sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new OrderManagementPage());
        }

        private async void buttonStockIn_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewInventory.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để nhập kho.", "Chưa chọn sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var productId = (int)dataGridViewInventory.CurrentRow.Cells["ProductId"].Value;
            var product = _allProducts.FirstOrDefault(p => p.ProductId == productId);
            if (product == null) return;

            using (var dialog = new InputDialogForm("Nhập kho", $"Nhập số lượng cho sản phẩm: {product.ProductName}"))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    int newStock = product.ProductInStock + dialog.Quantity;
                    bool success = await _inventoryRepository.UpdateStockAsync(product.ProductId, newStock);
                    if (success)
                    {
                        MessageBox.Show("Nhập kho thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadAllDataAsync(); // Tải lại dữ liệu
                    }
                    else
                    {
                        MessageBox.Show("Nhập kho thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void buttonStockOut_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewInventory.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xuất kho.", "Chưa chọn sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var productId = (int)dataGridViewInventory.CurrentRow.Cells["ProductId"].Value;
            var product = _allProducts.FirstOrDefault(p => p.ProductId == productId);
            if (product == null) return;

            using (var dialog = new InputDialogForm("Xuất kho", $"Nhập số lượng xuất cho: {product.ProductName}"))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    if (dialog.Quantity > product.ProductInStock)
                    {
                        MessageBox.Show("Số lượng xuất kho không thể lớn hơn tồn kho.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int newStock = product.ProductInStock - dialog.Quantity;
                    bool success = await _inventoryRepository.UpdateStockAsync(product.ProductId, newStock);
                    if (success)
                    {
                        MessageBox.Show("Xuất kho thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadAllDataAsync(); 
                    }
                    else
                    {
                        MessageBox.Show("Xuất kho thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void buttonCheckInventory_Click(object sender, EventArgs e)
        {
            if (_allProducts == null || !_allProducts.Any())
            {
                MessageBox.Show("Không có dữ liệu tồn kho.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int totalProducts = _allProducts.Count;
            int totalStock = _allProducts.Sum(p => p.ProductInStock);
            int outOfStockProducts = _allProducts.Count(p => p.ProductInStock == 0);

            string message = $"--- Báo cáo kiểm kê nhanh ---\n\n" +
                             $"Tổng số loại sản phẩm: {totalProducts}\n" +
                             $"Tổng số lượng tồn kho: {totalStock}\n" +
                             $"Số sản phẩm đã hết hàng: {outOfStockProducts}";

            MessageBox.Show(message, "Thông tin kiểm kê", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      

        private async void buttonRefreshStock_Click(object sender, EventArgs e)
        {
            await LoadAllDataAsync();
            MessageBox.Show("Đã làm mới dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    #endregion
}