using Customer.Models;
using Customer.Services;

namespace Customer.Admin
{
    public partial class InventoryManagementForm : Form
    {
        private readonly InventoryService? _inventoryService;
        private readonly ProductService? _productService;

        public InventoryManagementForm()
        {
            try
            {
                InitializeComponent();
                
                _inventoryService = new InventoryService();
                _productService = new ProductService();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khởi tạo form: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load event handler - called after form is fully created
        private void InventoryManagementForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            LoadLowStockProducts();
            LoadInventoryReport();
        }

        private void LoadLowStockProducts()
        {
            try
            {
                if (_inventoryService == null || dataGridViewLowStock == null)
                {
                    return;
                }

                // Clear previous data
                dataGridViewLowStock.DataSource = null;
                
                var lowStockProducts = _inventoryService.GetLowStockProducts();
                
                if (lowStockProducts != null && lowStockProducts.Any())
                {
                    var dataSource = lowStockProducts.Select(p => new
                    {
                        ID = p.Id,
                        TenSanPham = p.Name,
                        SoLuongTon = p.Stock,
                        DanhMuc = p.Category,
                        Gia = p.Price.ToString("C0")
                    }).ToList();

                    dataGridViewLowStock.DataSource = dataSource;
                    
                    // Setup columns after data is bound
                    SetupDataGridViewColumns();
                }
                else
                {
                    // Show empty grid
                    dataGridViewLowStock.DataSource = new List<object>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải sản phẩm sắp hết hàng: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataGridViewColumns()
        {
            try
            {
                if (dataGridViewLowStock?.Columns == null || dataGridViewLowStock.Columns.Count == 0)
                {
                    return;
                }

                // Set column widths and headers
                foreach (DataGridViewColumn column in dataGridViewLowStock.Columns)
                {
                    switch (column.Name)
                    {
                        case "ID":
                            column.Width = 50;
                            column.HeaderText = "ID";
                            break;
                        case "TenSanPham":
                            column.Width = 200;
                            column.HeaderText = "Tên Sản Phẩm";
                            break;
                        case "SoLuongTon":
                            column.Width = 100;
                            column.HeaderText = "Số Lượng Tồn";
                            break;
                        case "DanhMuc":
                            column.Width = 120;
                            column.HeaderText = "Danh Mục";
                            break;
                        case "Gia":
                            column.Width = 100;
                            column.HeaderText = "Giá";
                            break;
                    }
                }

                // Set general DataGridView properties
                dataGridViewLowStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dataGridViewLowStock.AllowUserToResizeColumns = true;
                dataGridViewLowStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewLowStock.MultiSelect = false;
                dataGridViewLowStock.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thiết lập cột: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadInventoryReport()
        {
            try
            {
                if (_inventoryService == null)
                {
                    return;
                }

                var report = _inventoryService.GetInventoryReport();
                
                if (report != null)
                {
                    labelTotalProducts.Text = report.TotalProducts.ToString();
                    labelTotalValue.Text = report.TotalValue.ToString("C0");
                    labelLowStock.Text = report.LowStockCount.ToString();
                    labelOutOfStock.Text = report.OutOfStockCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải báo cáo: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                // Set default values
                labelTotalProducts.Text = "0";
                labelTotalValue.Text = "0 ₫";
                labelLowStock.Text = "0";
                labelOutOfStock.Text = "0";
            }
        }

        private void buttonRestock_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewLowStock?.SelectedRows == null || dataGridViewLowStock.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm cần nhập hàng!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = dataGridViewLowStock.SelectedRows[0];
                
                // Get cell values safely
                var idCell = selectedRow.Cells["ID"];
                var nameCell = selectedRow.Cells["TenSanPham"];

                if (idCell?.Value == null || nameCell?.Value == null)
                {
                    MessageBox.Show("Dữ liệu sản phẩm không hợp lệ!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var productId = Convert.ToInt32(idCell.Value);
                var productName = nameCell.Value.ToString() ?? "Không xác định";

                var restockForm = new RestockForm(productId, productName);
                if (restockForm.ShowDialog() == DialogResult.OK)
                {
                    LoadData(); // Refresh data after restock
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi nhập hàng: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData();
                MessageBox.Show("Dữ liệu đã được cập nhật!", "Thông báo", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi làm mới dữ liệu: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewLowStock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    buttonRestock_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở form nhập hàng: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}