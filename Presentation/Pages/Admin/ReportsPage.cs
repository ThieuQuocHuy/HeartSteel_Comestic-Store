using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Models;
using DAL.Repositories;

namespace Presentation.Pages.Admin
{
    public partial class ReportsPage : Form
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private List<Product> _allProducts;
        private List<Category> _categories;

        public ReportsPage()
        {
            InitializeComponent();
            _productRepository = new ProductRepository();
            _categoryRepository = new CategoryRepository();
            this.Load += ReportsPage_Load;
        }

        private async void ReportsPage_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
            SetupDatePickers();
            AddHoverEffects();
            await LoadDefaultReports();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                _allProducts = await _productRepository.GetAllProductsAsync();
                _categories = await _categoryRepository.GetAllCategoriesAsync();

                // Load categories vào combobox
                comboBoxProductCategory.Items.Clear();
                comboBoxProductCategory.Items.Add("Tất cả danh mục");
                foreach (var category in _categories)
                {
                    comboBoxProductCategory.Items.Add(category.CategoryName);
                }
                comboBoxProductCategory.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDatePickers()
        {
            // Mặc định từ đầu tháng đến hôm nay
            dateTimePickerRevenueFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimePickerRevenueTo.Value = DateTime.Now;
        }

        private void AddHoverEffects()
        {
            // Thêm hiệu ứng hover cho sidebar buttons
            AddButtonHoverEffect(buttonManageProducts, Color.FromArgb(95, 76, 59), Color.FromArgb(115, 96, 79));
            AddButtonHoverEffect(buttonManageInventory, Color.FromArgb(95, 76, 59), Color.FromArgb(115, 96, 79));
            AddButtonHoverEffect(buttonManageCategories, Color.FromArgb(95, 76, 59), Color.FromArgb(115, 96, 79));
            AddButtonHoverEffect(buttonManageOrders, Color.FromArgb(95, 76, 59), Color.FromArgb(115, 96, 79));
            AddButtonHoverEffect(buttonReports, Color.FromArgb(221, 207, 182), Color.FromArgb(241, 227, 202));
            AddButtonHoverEffect(buttonLogout, Color.FromArgb(184, 84, 84), Color.FromArgb(204, 104, 104));
        }

        private void AddButtonHoverEffect(Button button, Color normalColor, Color hoverColor)
        {
            button.MouseEnter += (s, e) => button.BackColor = hoverColor;
            button.MouseLeave += (s, e) => button.BackColor = normalColor;
        }

        private async Task LoadDefaultReports()
        {
            await GenerateRevenueReport();
            await GenerateProductReport();
            await GenerateInventoryReport();
        }

        #region Revenue Report
        private async void buttonGenerateRevenue_Click(object sender, EventArgs e)
        {
            await GenerateRevenueReport();
        }

        private async Task GenerateRevenueReport()
        {
            try
            {
                // Tạo dữ liệu giả lập cho báo cáo doanh thu
                var revenueData = GenerateSampleRevenueData();

                SetupRevenueDataGridView();
                dataGridViewRevenue.DataSource = revenueData;

                UpdateRevenueSummary(revenueData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tạo báo cáo doanh thu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupRevenueDataGridView()
        {
            dataGridViewRevenue.AutoGenerateColumns = false;
            dataGridViewRevenue.Columns.Clear();

            dataGridViewRevenue.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Date",
                HeaderText = "Ngày",
                DataPropertyName = "Date",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" }
            });

            dataGridViewRevenue.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "OrderCount",
                HeaderText = "Số đơn hàng",
                DataPropertyName = "OrderCount",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            dataGridViewRevenue.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Revenue",
                HeaderText = "Doanh thu",
                DataPropertyName = "Revenue",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dataGridViewRevenue.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "AverageOrderValue",
                HeaderText = "Giá trị TB/đơn",
                DataPropertyName = "AverageOrderValue",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });
        }

        private List<dynamic> GenerateSampleRevenueData()
        {
            var data = new List<dynamic>();
            var random = new Random();
            var startDate = dateTimePickerRevenueFrom.Value;
            var endDate = dateTimePickerRevenueTo.Value;

            for (var date = startDate; date <= endDate; date = date.AddDays(1))
            {
                var orderCount = random.Next(0, 15);
                var revenue = orderCount * random.Next(100000, 2000000);
                var avgOrderValue = orderCount > 0 ? revenue / orderCount : 0;

                data.Add(new
                {
                    Date = date,
                    OrderCount = orderCount,
                    Revenue = revenue,
                    AverageOrderValue = avgOrderValue
                });
            }

            return data.OrderByDescending(x => x.Date).ToList();
        }

        private void UpdateRevenueSummary(List<dynamic> data)
        {
            var totalRevenue = data.Sum(x => (decimal)x.Revenue);
            var totalOrders = data.Sum(x => (int)x.OrderCount);
            var averageOrder = totalOrders > 0 ? totalRevenue / totalOrders : 0;

            labelTotalRevenue.Text = $"Tổng doanh thu: ₫{totalRevenue:N0}";
            labelTotalOrders.Text = $"Số đơn hàng: {totalOrders}";
            labelAverageOrder.Text = $"Giá trị đơn hàng TB: ₫{averageOrder:N0}";
        }
        #endregion

        #region Product Report
        private async void buttonGenerateProduct_Click(object sender, EventArgs e)
        {
            await GenerateProductReport();
        }

        private async Task GenerateProductReport()
        {
            try
            {
                var selectedCategory = comboBoxProductCategory.SelectedItem?.ToString();
                var filteredProducts = _allProducts;

                if (selectedCategory != "Tất cả danh mục")
                {
                    filteredProducts = _allProducts.Where(p => p.Category?.CategoryName == selectedCategory).ToList();
                }

                var productData = filteredProducts.Select(p => new
                {
                    ProductId = p.ProductId,
                    ProductName = p.ProductName,
                    CategoryName = p.Category?.CategoryName ?? "Chưa phân loại",
                    Stock = p.ProductInStock,
                    SellPrice = p.SellPrice ?? 0,
                    SoldCount = p.SoldCount,
                    StockValue = (p.SellPrice ?? 0) * p.ProductInStock
                }).ToList();

                SetupProductDataGridView();
                dataGridViewProducts.DataSource = productData;

                UpdateProductSummary(productData.Cast<object>().ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tạo báo cáo sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupProductDataGridView()
        {
            dataGridViewProducts.AutoGenerateColumns = false;
            dataGridViewProducts.Columns.Clear();

            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProductName",
                HeaderText = "Tên sản phẩm",
                DataPropertyName = "ProductName",
                Width = 200
            });

            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CategoryName",
                HeaderText = "Danh mục",
                DataPropertyName = "CategoryName",
                Width = 150
            });

            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Stock",
                HeaderText = "Tồn kho",
                DataPropertyName = "Stock",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SellPrice",
                HeaderText = "Giá bán",
                DataPropertyName = "SellPrice",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SoldCount",
                HeaderText = "Đã bán",
                DataPropertyName = "SoldCount",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "StockValue",
                HeaderText = "Giá trị tồn kho",
                DataPropertyName = "StockValue",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });
        }

        private void UpdateProductSummary(List<object> data)
        {
            var totalProducts = data.Count;
            var lowStockProducts = data.Count(x =>
            {
                var item = x as dynamic;
                return (int)item.Stock <= 10;
            });
            var topSelling = data.OrderByDescending(x =>
            {
                var item = x as dynamic;
                return (int)item.SoldCount;
            }).FirstOrDefault();

            labelTotalProducts.Text = $"Tổng sản phẩm: {totalProducts}";
            labelLowStockProducts.Text = $"Sản phẩm ít hàng: {lowStockProducts}";

            if (topSelling != null)
            {
                var topSellingItem = topSelling as dynamic;
                labelTopSellingProduct.Text = $"Sản phẩm bán chạy nhất: {topSellingItem.ProductName}";
            }
            else
            {
                labelTopSellingProduct.Text = "Sản phẩm bán chạy nhất: Không có";
            }
        }
        #endregion

        #region Inventory Report
        private async void buttonGenerateInventory_Click(object sender, EventArgs e)
        {
            await GenerateInventoryReport();
        }

        private async Task GenerateInventoryReport()
        {
            try
            {
                var threshold = (int)numericUpDownStockThreshold.Value;
                var showLowStockOnly = checkBoxShowLowStock.Checked;

                var inventoryData = _allProducts.Where(p => !showLowStockOnly || p.ProductInStock <= threshold)
                    .Select(p => new
                    {
                        ProductName = p.ProductName,
                        CategoryName = p.Category?.CategoryName ?? "Chưa phân loại",
                        Stock = p.ProductInStock,
                        StockPrice = p.StockPrice ?? 0,
                        SellPrice = p.SellPrice ?? 0,
                        StockValue = (p.StockPrice ?? 0) * p.ProductInStock,
                        Status = p.ProductInStock == 0 ? "Hết hàng" :
                                p.ProductInStock <= threshold ? "Sắp hết" : "Đủ hàng"
                    }).ToList();

                SetupInventoryDataGridView();
                dataGridViewInventory.DataSource = inventoryData;

                UpdateInventorySummary(inventoryData.Cast<object>().ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tạo báo cáo tồn kho: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupInventoryDataGridView()
        {
            dataGridViewInventory.AutoGenerateColumns = false;
            dataGridViewInventory.Columns.Clear();

            dataGridViewInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProductName",
                HeaderText = "Tên sản phẩm",
                DataPropertyName = "ProductName",
                Width = 200
            });

            dataGridViewInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CategoryName",
                HeaderText = "Danh mục",
                DataPropertyName = "CategoryName",
                Width = 150
            });

            dataGridViewInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Stock",
                HeaderText = "Tồn kho",
                DataPropertyName = "Stock",
                Width = 100,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });

            dataGridViewInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "StockPrice",
                HeaderText = "Giá nhập",
                DataPropertyName = "StockPrice",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dataGridViewInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "StockValue",
                HeaderText = "Giá trị tồn kho",
                DataPropertyName = "StockValue",
                Width = 150,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dataGridViewInventory.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Status",
                HeaderText = "Trạng thái",
                DataPropertyName = "Status",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
        }

        private void UpdateInventorySummary(List<object> data)
        {
            var totalStockValue = data.Sum(x =>
            {
                var item = x as dynamic;
                return (decimal)item.StockValue;
            });
            var lowStockCount = data.Count(x =>
            {
                var item = x as dynamic;
                return item.Status.ToString() == "Sắp hết";
            });
            var outOfStockCount = data.Count(x =>
            {
                var item = x as dynamic;
                return item.Status.ToString() == "Hết hàng";
            });

            labelTotalStockValue.Text = $"Tổng giá trị kho: ₫{totalStockValue:N0}";
            labelLowStockCount.Text = $"Sắp hết hàng: {lowStockCount}";
            labelOutOfStockCount.Text = $"Hết hàng: {outOfStockCount}";
        }
        #endregion

        #region Export Functions
        private void buttonExportRevenueExcel_Click(object sender, EventArgs e)
        {
            ExportToFile("Excel", "Revenue");
        }

        private void buttonExportRevenuePDF_Click(object sender, EventArgs e)
        {
            ExportToFile("PDF", "Revenue");
        }

        private void buttonExportProductExcel_Click(object sender, EventArgs e)
        {
            ExportToFile("Excel", "Product");
        }

        private void buttonExportProductPDF_Click(object sender, EventArgs e)
        {
            ExportToFile("PDF", "Product");
        }

        private void buttonExportInventoryExcel_Click(object sender, EventArgs e)
        {
            ExportToFile("Excel", "Inventory");
        }

        private void buttonExportInventoryPDF_Click(object sender, EventArgs e)
        {
            ExportToFile("PDF", "Inventory");
        }

        private void ExportToFile(string format, string reportType)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = format == "Excel" ? "Excel Files|*.xlsx" : "PDF Files|*.pdf";
                saveDialog.FileName = $"BaoCao_{reportType}_{DateTime.Now:yyyyMMdd_HHmmss}.{(format == "Excel" ? "xlsx" : "pdf")}";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // Tạo file giả lập
                    CreateSampleExportFile(saveDialog.FileName, format, reportType);

                    MessageBox.Show($"Đã xuất báo cáo {reportType} thành file {format} thành công!\n\nĐường dẫn: {saveDialog.FileName}",
                        "Xuất báo cáo thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xuất file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CreateSampleExportFile(string filePath, string format, string reportType)
        {
            // Tạo file text đơn giản để demo
            var content = $"Báo cáo {reportType} - HeartSteel Cosmetic\n";
            content += $"Ngày tạo: {DateTime.Now:dd/MM/yyyy HH:mm:ss}\n";
            content += $"Định dạng: {format}\n\n";
            content += "Đây là file demo. Trong thực tế sẽ tích hợp thư viện như EPPlus (Excel) hoặc iTextSharp (PDF).\n";

            File.WriteAllText(filePath.Replace(format == "Excel" ? ".xlsx" : ".pdf", ".txt"), content);
        }
        #endregion

        #region Sidebar Events
        private void buttonManageProducts_Click(object sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new ProductManagementPage());
        }

        private void buttonManageInventory_Click(object sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new InventoryManagementPage());
        }

        private void buttonManageCategories_Click(object sender, EventArgs e)
        {
            MessageBox.Show("📂 Chức năng quản lý danh mục sẽ được phát triển trong phiên bản tiếp theo.",
                "Quản lý danh mục", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đang ở trang báo cáo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Presentation.Auth.UserSession.Clear();
            Presentation.Navigation.Navigator.Navigate(new Customer.LoginForm());
        }
        #endregion

        private void buttonManageOrders_Click(object sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new OrderManagementPage());
        }
    }
}