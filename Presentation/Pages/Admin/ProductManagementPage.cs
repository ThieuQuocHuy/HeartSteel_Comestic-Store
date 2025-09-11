using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Services;
using DAL.Models;
using DAL.Repositories;
using Presentation.Services;

namespace Presentation.Pages.Admin
{
    public partial class ProductManagementPage : Form
    {
        private readonly IProductRepository _productRepository = null!;
        private readonly ICategoryRepository _categoryRepository = null!;
        private List<Product> _allProducts = new List<Product>();
        private List<Category> _categories = new List<Category>();
        private bool _isEditing = false;
        private int? _currentProductId = null;
        private string? _selectedImagePath = null;

        public ProductManagementPage()
        {
            try
            {
                InitializeComponent();
                _productRepository = new ProductRepository();
                _categoryRepository = new CategoryRepository();

                this.Load += ProductManagementPage_Load;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"ProductManagementPage Constructor Error: {ex.Message}");
                MessageBox.Show($"Lỗi khởi tạo trang quản lý sản phẩm: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ProductManagementPage_Load(object? sender, EventArgs e)
        {
            try
            {
                await LoadCategoriesAsync();
                await LoadProductsAsync();
                SetupDataGridView();
                ClearForm();
                SetFormMode(false);
                AddHoverEffects();
                WireUpEventHandlers();
                LoadLogo();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải trang: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool _eventHandlersWired = false;
        private bool _isDeleting = false;
        private bool _isSaving = false;

        private void WireUpEventHandlers()
        {
            if (_eventHandlersWired) return; // Prevent duplicate event handler wiring

            try
            {
                // Wire up event handlers
                if (buttonSave != null) buttonSave.Click += buttonSave_Click;
                if (buttonCancel != null) buttonCancel.Click += buttonCancel_Click;
                if (buttonAdd != null) buttonAdd.Click += buttonAdd_Click;
                if (buttonEdit != null) buttonEdit.Click += buttonEdit_Click;
                if (buttonDelete != null) buttonDelete.Click += buttonDelete_Click;
                if (buttonRefresh != null) buttonRefresh.Click += buttonRefresh_Click;
                if (buttonSearch != null) buttonSearch.Click += buttonSearch_Click;
                if (dataGridViewProducts != null) dataGridViewProducts.SelectionChanged += dataGridViewProducts_SelectionChanged;
                if (comboBoxCategory != null) comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
                if (buttonChangeImage != null) buttonChangeImage.Click += buttonChangeImage_Click;
                

                _eventHandlersWired = true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"WireUpEventHandlers Error: {ex.Message}");
            }
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
                        System.Diagnostics.Debug.WriteLine("Logo loaded successfully for ProductManagementPage");
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("Failed to load logo image for ProductManagementPage");
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"LoadLogo Error: {ex.Message}");
            }
        }

        private void AddHoverEffects()
        {
            try
            {
                // Thêm hiệu ứng hover cho sidebar buttons
                AddButtonHoverEffect(buttonManageProducts, Color.FromArgb(221, 207, 182), Color.FromArgb(241, 227, 202));
                AddButtonHoverEffect(buttonManageInventory, Color.FromArgb(95, 76, 59), Color.FromArgb(115, 96, 79));
                AddButtonHoverEffect(buttonManageCategories, Color.FromArgb(95, 76, 59), Color.FromArgb(115, 96, 79));
                AddButtonHoverEffect(buttonManageOrders, Color.FromArgb(95, 76, 59), Color.FromArgb(115, 96, 79));
                AddButtonHoverEffect(buttonReports, Color.FromArgb(95, 76, 59), Color.FromArgb(115, 96, 79));
                AddButtonHoverEffect(buttonLogout, Color.FromArgb(184, 84, 84), Color.FromArgb(204, 104, 104));
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"AddHoverEffects Error: {ex.Message}");
            }
        }

        private void AddButtonHoverEffect(Button button, Color normalColor, Color hoverColor)
        {
            if (button != null)
            {
                button.MouseEnter += (s, e) => button.BackColor = hoverColor;
                button.MouseLeave += (s, e) => button.BackColor = normalColor;
            }
        }

        private async Task LoadCategoriesAsync()
        {
            try
            {
                var categories = await _categoryRepository.GetAllCategoriesAsync();
                _categories = categories ?? new List<Category>();

                // Load categories vào combobox tìm kiếm
                if (comboBoxCategory != null)
                {
                    comboBoxCategory.Items.Clear();
                    comboBoxCategory.Items.Add("Tất cả danh mục");
                    foreach (var category in _categories)
                    {
                        if (category != null && !string.IsNullOrEmpty(category.CategoryName))
                        {
                            comboBoxCategory.Items.Add(category.CategoryName);
                        }
                    }
                    if (comboBoxCategory.Items.Count > 0)
                    {
                        comboBoxCategory.SelectedIndex = 0;
                    }
                }

                // Load categories vào combobox sản phẩm
                if (comboBoxProductCategory != null)
                {
                    comboBoxProductCategory.Items.Clear();
                    comboBoxProductCategory.Items.Add("Chọn danh mục");
                    foreach (var category in _categories)
                    {
                        if (category != null && !string.IsNullOrEmpty(category.CategoryName))
                        {
                            comboBoxProductCategory.Items.Add($"{category.CategoryId} - {category.CategoryName}");
                        }
                    }
                    if (comboBoxProductCategory.Items.Count > 0)
                    {
                        comboBoxProductCategory.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh mục: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _categories = new List<Category>(); // Ensure it's not null
            }
        }

        private async Task LoadProductsAsync()
        {
            try
            {
                var products = await _productRepository.GetAllProductsAsync();
                _allProducts = products ?? new List<Product>();
                UpdateDataGridView(_allProducts);
                System.Diagnostics.Debug.WriteLine($"Loaded {_allProducts.Count} products");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _allProducts = new List<Product>(); // Ensure it's not null
            }
        }

        private void SetupDataGridView()
        {
            try
            {
                if (dataGridViewProducts == null) return;

                dataGridViewProducts.AutoGenerateColumns = false;
                dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dataGridViewProducts.Columns.Clear();

                dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "ProductId",
                    HeaderText = "Mã SP",
                    DataPropertyName = "ProductId",
                    Width = 80
                });

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
                    Width = 120
                });

                dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "StockPrice",
                    HeaderText = "Giá nhập",
                    DataPropertyName = "StockPrice",
                    Width = 100,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Format = "N0",
                        Alignment = DataGridViewContentAlignment.MiddleRight
                    }
                });

                dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "SellPrice",
                    HeaderText = "Giá bán",
                    DataPropertyName = "SellPrice",
                    Width = 100,
                    DefaultCellStyle = new DataGridViewCellStyle
                    {
                        Format = "N0",
                        Alignment = DataGridViewContentAlignment.MiddleRight
                    }
                });

                dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "ImageFileName",
                    HeaderText = "Hình ảnh",
                    DataPropertyName = "ImageFileName",
                    Width = 150
                });

                dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "Description",
                    HeaderText = "Mô tả",
                    DataPropertyName = "Description",
                    Width = 150
                });
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"SetupDataGridView Error: {ex.Message}");
            }
        }

        private void UpdateDataGridView(List<Product> products)
        {
            try
            {
                if (dataGridViewProducts == null) return;

                var displayData = products.Select(p => new
                {
                    ProductId = p.ProductId,
                    ProductName = p.ProductName ?? "Không có tên",
                    CategoryName = p.Category?.CategoryName ?? "Chưa phân loại",
                    StockPrice = p.StockPrice ?? 0,
                    SellPrice = p.SellPrice ?? 0,
                    ImageFileName = p.Img ?? "Không có hình",
                    Description = p.Description ?? ""
                }).ToList();

                dataGridViewProducts.DataSource = displayData;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"UpdateDataGridView Error: {ex.Message}");
            }
        }

        private void SetFormMode(bool isEditing)
        {
            try
            {
                _isEditing = isEditing;

                if (groupBoxProductInfo != null)
                    groupBoxProductInfo.Enabled = isEditing;

                if (buttonSave != null)
                    buttonSave.Visible = isEditing;

                if (buttonCancel != null)
                    buttonCancel.Visible = isEditing;

                if (buttonAdd != null)
                    buttonAdd.Enabled = !isEditing;

                if (buttonEdit != null)
                    buttonEdit.Enabled = !isEditing && dataGridViewProducts?.CurrentRow != null;

                if (buttonDelete != null)
                    buttonDelete.Enabled = !isEditing && dataGridViewProducts?.CurrentRow != null;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"SetFormMode Error: {ex.Message}");
            }
        }

        private void ClearForm()
        {
            try
            {
                if (textBoxProductId != null) textBoxProductId.Text = "";
                if (textBoxProductName != null) textBoxProductName.Text = "";
                if (comboBoxProductCategory != null && comboBoxProductCategory.Items.Count > 0)
                    comboBoxProductCategory.SelectedIndex = 0;
                if (numericUpDownCostPrice != null) numericUpDownCostPrice.Value = 0;
                if (numericUpDownSellPrice != null) numericUpDownSellPrice.Value = 0;
                if (textBoxDescription != null) textBoxDescription.Text = "";

                _currentProductId = null;
                _selectedImagePath = null;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"ClearForm Error: {ex.Message}");
            }
        }

        private void LoadProductToForm(Product product)
        {
            try
            {
                if (product == null) return;

                if (textBoxProductId != null) textBoxProductId.Text = product.ProductId.ToString();
                if (textBoxProductName != null) textBoxProductName.Text = product.ProductName ?? "";

                // Tìm và chọn category
                if (comboBoxProductCategory != null && product.CategoryId.HasValue)
                {
                    var categoryItem = comboBoxProductCategory.Items.Cast<string>()
                        .FirstOrDefault(item => item != null && item.StartsWith($"{product.CategoryId} -"));
                    if (categoryItem != null)
                    {
                        comboBoxProductCategory.SelectedItem = categoryItem;
                    }
                }

                if (numericUpDownCostPrice != null) numericUpDownCostPrice.Value = product.StockPrice ?? 0;
                if (numericUpDownSellPrice != null) numericUpDownSellPrice.Value = product.SellPrice ?? 0;
                if (textBoxDescription != null) textBoxDescription.Text = product.Description ?? "";

                _currentProductId = product.ProductId;
                _selectedImagePath = product.Img;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"LoadProductToForm Error: {ex.Message}");
            }
        }

        private Product CreateProductFromForm()
        {
            try
            {
                var selectedCategory = comboBoxProductCategory?.SelectedItem?.ToString();
                int? categoryId = null;

                if (!string.IsNullOrEmpty(selectedCategory) && selectedCategory != "Chọn danh mục")
                {
                    var parts = selectedCategory.Split(" - ");
                    if (parts.Length > 0 && int.TryParse(parts[0], out int catId))
                    {
                        categoryId = catId;
                    }
                }

                // Get existing product data if editing
                var existingProduct = _currentProductId.HasValue ?
                    _allProducts?.FirstOrDefault(p => p.ProductId == _currentProductId) : null;

                var product = new Product
                {
                    ProductId = _currentProductId ?? 0,
                    ProductName = textBoxProductName?.Text?.Trim() ?? "",
                    CategoryId = categoryId,
                    StockPrice = numericUpDownCostPrice?.Value ?? 0,
                    SellPrice = numericUpDownSellPrice?.Value ?? 0,
                    ProductInStock = existingProduct?.ProductInStock ?? 0,
                    Description = textBoxDescription?.Text?.Trim() ?? "",
                    SoldCount = existingProduct?.SoldCount ?? 0,
                    StockInDate = existingProduct?.StockInDate ?? DateOnly.FromDateTime(DateTime.Now),
                    Img = _selectedImagePath ?? existingProduct?.Img,
                    StatusId = existingProduct?.StatusId ?? 1, // Default status ID
                    MarketPrice = existingProduct?.MarketPrice ?? numericUpDownSellPrice?.Value ?? 0
                };

                return product;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"CreateProductFromForm Error: {ex.Message}");
                return new Product(); // Return empty product on error
            }
        }

        private bool ValidateForm()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxProductName?.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên sản phẩm!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxProductName?.Focus();
                    return false;
                }

                if (comboBoxProductCategory?.SelectedIndex <= 0)
                {
                    MessageBox.Show("Vui lòng chọn danh mục sản phẩm!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBoxProductCategory?.Focus();
                    return false;
                }

                if ((numericUpDownSellPrice?.Value ?? 0) <= 0)
                {
                    MessageBox.Show("Giá bán phải lớn hơn 0!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    numericUpDownSellPrice?.Focus();
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"ValidateForm Error: {ex.Message}");
                return false;
            }
        }

        #region Event Handlers

        // New method for handling image change
        private void buttonChangeImage_Click(object? sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                    openFileDialog.Title = "Chọn hình ảnh sản phẩm";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Get the source file path
                        string sourceFilePath = openFileDialog.FileName;
                        string fileName = System.IO.Path.GetFileName(sourceFilePath);

                        // Get the Resource directory path
                        string resourceDir = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource");

                        // Ensure Resource directory exists
                        if (!Directory.Exists(resourceDir))
                        {
                            Directory.CreateDirectory(resourceDir);
                        }

                        // Create destination path
                        string destinationPath = System.IO.Path.Combine(resourceDir, fileName);

                        // Copy the file to Resource directory
                        File.Copy(sourceFilePath, destinationPath, true);

                        // Store just the filename for database
                        _selectedImagePath = fileName;

                        MessageBox.Show($"Đã chọn và lưu hình ảnh: {fileName}", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi chọn hình ảnh: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Auto-filter when category selection changes
        private async void comboBoxCategory_SelectedIndexChanged(object? sender, EventArgs e)
        {
            try
            {
                await ApplyFilters();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"comboBoxCategory_SelectedIndexChanged Error: {ex.Message}");
            }
        }

        private Task ApplyFilters()
        {
            try
            {
                var searchText = textBoxSearch?.Text?.Trim()?.ToLower() ?? "";
                var selectedCategory = comboBoxCategory?.SelectedItem?.ToString();

                var filteredProducts = _allProducts.Where(p =>
                {
                    var matchesSearch = string.IsNullOrEmpty(searchText) ||
                                       (p.ProductName?.ToLower()?.Contains(searchText) == true) ||
                                       (p.Description?.ToLower()?.Contains(searchText) == true);

                    var matchesCategory = selectedCategory == "Tất cả danh mục" ||
                                         p.Category?.CategoryName == selectedCategory;

                    return matchesSearch && matchesCategory;
                }).ToList();

                UpdateDataGridView(filteredProducts);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"ApplyFilters Error: {ex.Message}");
            }
            return Task.CompletedTask;
        }

        // Sidebar Event Handlers
        private void buttonManageProducts_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Bạn đang ở trang quản lý sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonManageInventory_Click(object? sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new InventoryManagementPage());
        }

        private void buttonManageCategories_Click(object? sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new CategoryManagementPage());
        }

        private void buttonManageOrders_Click(object? sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new OrderManagementPage());
        }

        private void buttonReports_Click(object? sender, EventArgs e)
        {
            try
            {
                Presentation.Navigation.Navigator.Navigate(new ReportsPage());
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"buttonReports_Click Error: {ex.Message}");
                MessageBox.Show($"Lỗi khi chuyển đến trang báo cáo: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLogout_Click(object? sender, EventArgs e)
        {
            Presentation.Auth.UserSession.Clear();
            Presentation.Navigation.Navigator.Navigate(new Customer.LoginForm());
        }

        // Product Management Event Handlers
        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            ClearForm();
            SetFormMode(true);
            textBoxProductName?.Focus();
        }

        private void buttonEdit_Click(object? sender, EventArgs e)
        {
            try
            {
                if (dataGridViewProducts?.CurrentRow != null)
                {
                    var productIdCell = dataGridViewProducts.CurrentRow.Cells["ProductId"];
                    if (productIdCell?.Value != null && int.TryParse(productIdCell.Value.ToString(), out int productId))
                    {
                        var product = _allProducts.FirstOrDefault(p => p.ProductId == productId);

                        if (product != null)
                        {
                            LoadProductToForm(product);
                            SetFormMode(true);
                            textBoxProductName?.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi chỉnh sửa sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonDelete_Click(object? sender, EventArgs e)
        {
            // Prevent multiple delete operations
            if (_isDeleting)
            {
                return;
            }

            try
            {
                if (dataGridViewProducts?.CurrentRow != null)
                {
                    var productIdCell = dataGridViewProducts.CurrentRow.Cells["ProductId"];
                    var productNameCell = dataGridViewProducts.CurrentRow.Cells["ProductName"];

                    if (productIdCell?.Value != null && productNameCell?.Value != null &&
                        int.TryParse(productIdCell.Value.ToString(), out int productId))
                    {
                        var productName = productNameCell.Value.ToString();

                        var result = MessageBox.Show(
                            $"Bạn có chắc chắn muốn xóa sản phẩm '{productName}' không?\n\nHành động này không thể hoàn tác!",
                            "Xác nhận xóa",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            _isDeleting = true; // Set flag to prevent multiple operations

                            try
                            {
                                var success = await _productRepository.DeleteProductAsync(productId);
                                if (success)
                                {
                                    MessageBox.Show("Xóa sản phẩm thành công!", "Thành công",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    await LoadProductsAsync();
                                    ClearForm();
                                }
                                else
                                {
                                    MessageBox.Show("Không thể xóa sản phẩm!", "Lỗi",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            finally
                            {
                                _isDeleting = false; // Reset flag
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                _isDeleting = false; // Reset flag on error
                MessageBox.Show($"Lỗi khi xóa sản phẩm: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonSave_Click(object? sender, EventArgs e)
        {
            // Prevent multiple save operations
            if (_isSaving)
            {
                return;
            }

            if (!ValidateForm()) return;

            try
            {
                _isSaving = true; // Set flag to prevent multiple operations

                var product = CreateProductFromForm();
                bool success;

                // Debug information
                System.Diagnostics.Debug.WriteLine($"Saving product - ID: {product.ProductId}, Name: {product.ProductName}, CategoryId: {product.CategoryId}");

                if (_currentProductId.HasValue)
                {
                    // Cập nhật sản phẩm
                    System.Diagnostics.Debug.WriteLine($"Updating existing product with ID: {_currentProductId}");
                    success = await _productRepository.UpdateProductAsync(product);
                    if (success)
                    {
                        MessageBox.Show("Cập nhật sản phẩm thành công!", "Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật sản phẩm! Vui lòng kiểm tra lại thông tin.\n\nCó thể sản phẩm không tồn tại hoặc có lỗi database.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    // Thêm sản phẩm mới
                    System.Diagnostics.Debug.WriteLine("Creating new product");
                    success = await _productRepository.CreateProductAsync(product);
                    if (success)
                    {
                        MessageBox.Show("Thêm sản phẩm mới thành công!", "Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm sản phẩm mới! Vui lòng kiểm tra lại thông tin.\n\nCó thể tên sản phẩm đã tồn tại hoặc có lỗi database.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                await LoadProductsAsync();
                SetFormMode(false);
                ClearForm();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"buttonSave_Click Error: {ex.Message}\nStack Trace: {ex.StackTrace}");
                MessageBox.Show($"Lỗi khi lưu sản phẩm: {ex.Message}\n\nChi tiết lỗi đã được ghi vào Debug Output.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _isSaving = false; // Reset flag
            }
        }

        private void buttonCancel_Click(object? sender, EventArgs e)
        {
            SetFormMode(false);
            ClearForm();
        }

        private async void buttonRefresh_Click(object? sender, EventArgs e)
        {
            try
            {
                await LoadProductsAsync();
                ClearForm();
                SetFormMode(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi làm mới: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void buttonSearch_Click(object? sender, EventArgs e)
        {
            try
            {
                await ApplyFilters();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewProducts_SelectionChanged(object? sender, EventArgs e)
        {
            try
            {
                if (!_isEditing && dataGridViewProducts?.CurrentRow != null)
                {
                    var productIdCell = dataGridViewProducts.CurrentRow.Cells["ProductId"];
                    if (productIdCell?.Value != null && int.TryParse(productIdCell.Value.ToString(), out int productId))
                    {
                        var product = _allProducts.FirstOrDefault(p => p.ProductId == productId);

                        if (product != null)
                        {
                            LoadProductToForm(product);
                        }
                    }

                    if (buttonEdit != null) buttonEdit.Enabled = true;
                    if (buttonDelete != null) buttonDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"dataGridViewProducts_SelectionChanged Error: {ex.Message}");
            }
        }

        #endregion

        private void buttonAdminHome_Click(object sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new AdminHomePage());
        }

        private void buttonAdminCSKH_Click(object sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new CSKHAdminPage());
        }
    }
}