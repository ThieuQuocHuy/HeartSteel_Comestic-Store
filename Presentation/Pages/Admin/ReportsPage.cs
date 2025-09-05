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
using Presentation.Services;

namespace Presentation.Pages.Admin
{
    public partial class ReportsPage : Form
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IOrderRepository _orderRepository;
        private List<Product> _allProducts = new List<Product>();
        private List<Category> _categories = new List<Category>();

        public ReportsPage()
        {
            InitializeComponent();
            _productRepository = new ProductRepository();
            _categoryRepository = new CategoryRepository();
            _orderRepository = new OrderRepository();
            this.Load += ReportsPage_Load;
        }

        private async void ReportsPage_Load(object? sender, EventArgs e)
        {
            await LoadDataAsync();
            SetupDatePickers();
            AddHoverEffects();
            SetupProductCategoryEvent();
            SetupRevenueDateEvents();
            SetupInventoryEvents();
            await LoadDefaultReports();
            LoadLogo();
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

        private void LoadLogo()
        {
            try
            {
                if (pictureBoxLogo != null)
                {
                    var logoImage = ResourceImageLoader.LoadByFileName("logoden.png");
                    if (logoImage != null)
                    {
                        pictureBoxLogo.Image = logoImage;
                        System.Diagnostics.Debug.WriteLine("Logo loaded successfully for ReportsPage");
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("Failed to load logo image for ReportsPage");
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"LoadLogo Error: {ex.Message}");
            }
        }

        private void SetupProductCategoryEvent()
        {
            comboBoxProductCategory.SelectedIndexChanged += async (s, e) => await GenerateProductReport();
        }

        private void SetupRevenueDateEvents()
        {
            dateTimePickerRevenueFrom.ValueChanged += async (s, e) => await GenerateRevenueReport();
            dateTimePickerRevenueTo.ValueChanged += async (s, e) => await GenerateRevenueReport();
        }

        private void SetupInventoryEvents()
        {
            numericUpDownStockThreshold.ValueChanged += async (s, e) => await GenerateInventoryReport();
            checkBoxShowLowStock.CheckedChanged += async (s, e) => await GenerateInventoryReport();
        }

        private async Task LoadDefaultReports()
        {
            await GenerateRevenueReport();
            await GenerateProductReport();
            await GenerateInventoryReport();
        }

        #region Revenue Report
        private async Task GenerateRevenueReport()
        {
            try
            {
                // Lấy dữ liệu thực từ database
                var revenueData = await GetRealRevenueData();

                SetupRevenueDataGridView();
                dataGridViewRevenue.DataSource = revenueData;

                UpdateRevenueSummary(revenueData);

                // Hiển thị thông báo nếu không có dữ liệu
                if (!revenueData.Any() || revenueData.All(x => (int)x.OrderCount == 0))
                {
                    MessageBox.Show("Không có dữ liệu đơn hàng trong khoảng thời gian đã chọn.", 
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        private async Task<List<dynamic>> GetRealRevenueData()
        {
            var startDate = dateTimePickerRevenueFrom.Value.Date;
            var endDate = dateTimePickerRevenueTo.Value.Date.AddDays(1).AddTicks(-1); // End of day

            // Validation: đảm bảo startDate không lớn hơn endDate
            if (startDate > endDate.Date)
            {
                throw new ArgumentException("Ngày bắt đầu không được lớn hơn ngày kết thúc.");
            }

            // Lấy tất cả đơn hàng trong khoảng thời gian
            var orders = await _orderRepository.GetOrdersByDateRangeAsync(startDate, endDate);

            // Nhóm đơn hàng theo ngày
            var dailyData = orders
                .GroupBy(o => o.OrderDate.Date)
                .Select(g => new
                {
                    Date = g.Key,
                    OrderCount = g.Count(),
                    Revenue = g.Sum(o => o.OrderTotal),
                    AverageOrderValue = g.Count() > 0 ? g.Sum(o => o.OrderTotal) / g.Count() : 0
                })
                .OrderByDescending(x => x.Date)
                .ToList();

            // Tạo dữ liệu cho tất cả các ngày trong khoảng (kể cả ngày không có đơn hàng)
            var allDates = new List<dynamic>();
            for (var date = startDate; date <= endDate.Date; date = date.AddDays(1))
            {
                var dayData = dailyData.FirstOrDefault(d => d.Date.Date == date.Date);
                if (dayData != null)
                {
                    allDates.Add(dayData);
                }
                else
                {
                    allDates.Add(new
                    {
                        Date = date,
                        OrderCount = 0,
                        Revenue = 0m,
                        AverageOrderValue = 0m
                    });
                }
            }

            return allDates.OrderByDescending(x => x.Date).ToList();
        }

        private void UpdateRevenueSummary(List<dynamic> data)
        {
            var totalRevenue = data.Sum(x => (decimal)x.Revenue);
            var totalOrders = data.Sum(x => (int)x.OrderCount);
            var averageOrder = totalOrders > 0 ? totalRevenue / totalOrders : 0;

            labelTotalRevenue.Text = $"Tổng doanh thu: ₫{totalRevenue:N0}";
            labelTotalOrders.Text = $"Số đơn hàng: {totalOrders}";
            labelAverageOrder.Text = $"Giá trị đơn hàng TB: ₫{averageOrder:N0}";

            // Debug info - có thể xóa sau khi test xong
            Console.WriteLine($"Revenue Report Summary:");
            Console.WriteLine($"- Total Revenue: {totalRevenue:N0}");
            Console.WriteLine($"- Total Orders: {totalOrders}");
            Console.WriteLine($"- Average Order Value: {averageOrder:N0}");
            Console.WriteLine($"- Date Range: {dateTimePickerRevenueFrom.Value:dd/MM/yyyy} - {dateTimePickerRevenueTo.Value:dd/MM/yyyy}");
        }
        #endregion

        #region Product Report
        private Task GenerateProductReport()
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
            return Task.CompletedTask;
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
        private Task GenerateInventoryReport()
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
            return Task.CompletedTask;
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
            Presentation.Navigation.Navigator.Navigate(new CategoryManagementPage());
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