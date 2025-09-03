using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Services;
using DAL.Models;
using DAL.Repositories;

namespace Presentation.Pages.Admin
{
    public partial class ProductManagementPage : Form
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private List<Product> _allProducts;
        private List<Category> _categories;
        private bool _isEditing = false;
        private int? _currentProductId = null;

        public ProductManagementPage()
        {
            InitializeComponent();
            _productRepository = new ProductRepository();
            _categoryRepository = new CategoryRepository();
            this.Load += ProductManagementPage_Load;
        }

        private async void ProductManagementPage_Load(object sender, EventArgs e)
        {
            await LoadCategoriesAsync();
            await LoadProductsAsync();
            SetupDataGridView();
            ClearForm();
            SetFormMode(false);
            AddHoverEffects();
        }

        private void AddHoverEffects()
        {
            // Thêm hiệu ứng hover cho sidebar buttons
            AddButtonHoverEffect(buttonManageProducts, Color.FromArgb(221, 207, 182), Color.FromArgb(241, 227, 202));
            AddButtonHoverEffect(buttonManageInventory, Color.FromArgb(95, 76, 59), Color.FromArgb(115, 96, 79));
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

        private async Task LoadCategoriesAsync()
        {
            try
            {
                _categories = await _categoryRepository.GetAllCategoriesAsync();
                
                // Load categories vào combobox tìm kiếm
                comboBoxCategory.Items.Clear();
                comboBoxCategory.Items.Add("Tất cả danh mục");
                foreach (var category in _categories)
                {
                    comboBoxCategory.Items.Add(category.CategoryName);
                }
                comboBoxCategory.SelectedIndex = 0;

                // Load categories vào combobox sản phẩm
                comboBoxProductCategory.Items.Clear();
                comboBoxProductCategory.Items.Add("Chọn danh mục");
                foreach (var category in _categories)
                {
                    comboBoxProductCategory.Items.Add($"{category.CategoryId} - {category.CategoryName}");
                }
                comboBoxProductCategory.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh mục: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadProductsAsync()
        {
            try
            {
                _allProducts = await _productRepository.GetAllProductsAsync();
                UpdateDataGridView(_allProducts);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải sản phẩm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupDataGridView()
        {
            dataGridViewProducts.AutoGenerateColumns = false;
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
                Name = "ProductInStock",
                HeaderText = "Tồn kho",
                DataPropertyName = "ProductInStock",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                }
            });

            dataGridViewProducts.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Description",
                HeaderText = "Mô tả",
                DataPropertyName = "Description",
                Width = 150
            });
        }

        private void UpdateDataGridView(List<Product> products)
        {
            var displayData = products.Select(p => new
            {
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                CategoryName = p.Category?.CategoryName ?? "Chưa phân loại",
                StockPrice = p.StockPrice,
                SellPrice = p.SellPrice,
                ProductInStock = p.ProductInStock,
                Description = p.Description
            }).ToList();

            dataGridViewProducts.DataSource = displayData;
        }

        private void SetFormMode(bool isEditing)
        {
            _isEditing = isEditing;
            groupBoxProductInfo.Enabled = isEditing;
            buttonSave.Visible = isEditing;
            buttonCancel.Visible = isEditing;
            
            buttonAdd.Enabled = !isEditing;
            buttonEdit.Enabled = !isEditing && dataGridViewProducts.CurrentRow != null;
            buttonDelete.Enabled = !isEditing && dataGridViewProducts.CurrentRow != null;
        }

        private void ClearForm()
        {
            textBoxProductId.Text = "";
            textBoxProductName.Text = "";
            comboBoxProductCategory.SelectedIndex = 0;
            numericUpDownCostPrice.Value = 0;
            numericUpDownSellPrice.Value = 0;
            numericUpDownStock.Value = 0;
            textBoxDescription.Text = "";
            _currentProductId = null;
        }

        private void LoadProductToForm(Product product)
        {
            textBoxProductId.Text = product.ProductId.ToString();
            textBoxProductName.Text = product.ProductName;
            
            // Tìm và chọn category
            var categoryItem = comboBoxProductCategory.Items.Cast<string>()
                .FirstOrDefault(item => item.StartsWith($"{product.CategoryId} -"));
            if (categoryItem != null)
            {
                comboBoxProductCategory.SelectedItem = categoryItem;
            }

            numericUpDownCostPrice.Value = product.StockPrice ?? 0;
            numericUpDownSellPrice.Value = product.SellPrice ?? 0;
            numericUpDownStock.Value = product.ProductInStock;
            textBoxDescription.Text = product.Description ?? "";
            _currentProductId = product.ProductId;
        }

        private Product CreateProductFromForm()
        {
            var selectedCategory = comboBoxProductCategory.SelectedItem?.ToString();
            int? categoryId = null;
            
            if (!string.IsNullOrEmpty(selectedCategory) && selectedCategory != "Chọn danh mục")
            {
                var parts = selectedCategory.Split(" - ");
                if (parts.Length > 0 && int.TryParse(parts[0], out int catId))
                {
                    categoryId = catId;
                }
            }

            return new Product
            {
                ProductId = _currentProductId ?? 0,
                ProductName = textBoxProductName.Text.Trim(),
                CategoryId = categoryId,
                StockPrice = numericUpDownCostPrice.Value,
                SellPrice = numericUpDownSellPrice.Value,
                ProductInStock = (int)numericUpDownStock.Value,
                Description = textBoxDescription.Text.Trim(),
                SoldCount = 0,
                StockInDate = DateOnly.FromDateTime(DateTime.Now)
            };
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(textBoxProductName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxProductName.Focus();
                return false;
            }

            if (comboBoxProductCategory.SelectedIndex <= 0)
            {
                MessageBox.Show("Vui lòng chọn danh mục sản phẩm!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxProductCategory.Focus();
                return false;
            }

            if (numericUpDownSellPrice.Value <= 0)
            {
                MessageBox.Show("Giá bán phải lớn hơn 0!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericUpDownSellPrice.Focus();
                return false;
            }

            return true;
        }

        // Sidebar Event Handlers
        private void buttonManageProducts_Click(object sender, EventArgs e)
        {
            // Đã ở trang quản lý sản phẩm rồi, không cần làm gì
            MessageBox.Show("Bạn đang ở trang quản lý sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonManageInventory_Click(object sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new InventoryManagementPage());
        }

        private void buttonManageCategories_Click(object sender, EventArgs e)
        {
            MessageBox.Show("📂 Chức năng quản lý danh mục sẽ được phát triển trong phiên bản tiếp theo.\n\nTính năng bao gồm:\n• Tạo danh mục mới\n• Sửa đổi danh mục\n• Sắp xếp thứ tự\n• Quản lý cấp bậc", 
                "Quản lý danh mục", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonManageOrders_Click(object sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new OrderManagementPage());
        }
        private void buttonReports_Click(object sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new ReportsPage());
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            // Clear session
            Presentation.Auth.UserSession.Clear();
            
            // Navigate to login
            Presentation.Navigation.Navigator.Navigate(new Customer.LoginForm());
        }

        // Product Management Event Handlers
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ClearForm();
            SetFormMode(true);
            textBoxProductName.Focus();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.CurrentRow != null)
            {
                var productId = (int)dataGridViewProducts.CurrentRow.Cells["ProductId"].Value;
                var product = _allProducts.FirstOrDefault(p => p.ProductId == productId);
                
                if (product != null)
                {
                    LoadProductToForm(product);
                    SetFormMode(true);
                    textBoxProductName.Focus();
                }
            }
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.CurrentRow != null)
            {
                var productId = (int)dataGridViewProducts.CurrentRow.Cells["ProductId"].Value;
                var productName = dataGridViewProducts.CurrentRow.Cells["ProductName"].Value.ToString();

                var result = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa sản phẩm '{productName}' không?\n\nHành động này không thể hoàn tác!",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
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
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xóa sản phẩm: {ex.Message}", "Lỗi", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            try
            {
                var product = CreateProductFromForm();
                bool success;

                if (_currentProductId.HasValue)
                {
                    // Cập nhật sản phẩm
                    success = await _productRepository.UpdateProductAsync(product);
                    if (success)
                    {
                        MessageBox.Show("Cập nhật sản phẩm thành công!", "Thành công", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật sản phẩm!", "Lỗi", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    // Thêm sản phẩm mới
                    success = await _productRepository.CreateProductAsync(product);
                    if (success)
                    {
                        MessageBox.Show("Thêm sản phẩm mới thành công!", "Thành công", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm sản phẩm mới!", "Lỗi", 
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
                MessageBox.Show($"Lỗi khi lưu sản phẩm: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            SetFormMode(false);
            ClearForm();
        }

        private async void buttonRefresh_Click(object sender, EventArgs e)
        {
            await LoadProductsAsync();
            ClearForm();
            SetFormMode(false);
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            var searchText = textBoxSearch.Text.Trim().ToLower();
            var selectedCategory = comboBoxCategory.SelectedItem?.ToString();

            var filteredProducts = _allProducts.Where(p =>
            {
                var matchesSearch = string.IsNullOrEmpty(searchText) ||
                                   p.ProductName.ToLower().Contains(searchText) ||
                                   p.Description?.ToLower().Contains(searchText) == true;

                var matchesCategory = selectedCategory == "Tất cả danh mục" ||
                                     p.Category?.CategoryName == selectedCategory;

                return matchesSearch && matchesCategory;
            }).ToList();

            UpdateDataGridView(filteredProducts);
        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (!_isEditing && dataGridViewProducts.CurrentRow != null)
            {
                var productId = (int)dataGridViewProducts.CurrentRow.Cells["ProductId"].Value;
                var product = _allProducts.FirstOrDefault(p => p.ProductId == productId);
                
                if (product != null)
                {
                    LoadProductToForm(product);
                }

                buttonEdit.Enabled = true;
                buttonDelete.Enabled = true;
            }
        }
    }
}