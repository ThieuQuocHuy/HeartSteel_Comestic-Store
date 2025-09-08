using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Models;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using Presentation.Services;

namespace Presentation.Pages.Admin
{
    public partial class CategoryManagementPage : Form
    {
        private readonly ICategoryRepository _categoryRepository = null!;
        private List<Category> _allCategories = new List<Category>();
        private bool _isEditing = false;
        private int? _currentCategoryId = null;

        public CategoryManagementPage()
        {
            try
            {
                InitializeComponent();
                _categoryRepository = new CategoryRepository();
                this.Load += CategoryManagementPage_Load;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"CategoryManagementPage Constructor Error: {ex.Message}");
                MessageBox.Show($"Lỗi khởi tạo trang quản lý danh mục: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CategoryManagementPage_Load(object? sender, EventArgs e)
        {
            try
            {
                SetupDataGridViews();
                await LoadAllDataAsync();
                AddHoverEffects();
                
                LoadLogo();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải trang: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Setup UI

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
                        System.Diagnostics.Debug.WriteLine("Logo loaded successfully for CategoryManagementPage");
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("Failed to load logo image for CategoryManagementPage");
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
            // Thêm hiệu ứng hover cho sidebar buttons
            AddButtonHoverEffect(buttonManageProducts, Color.FromArgb(95, 76, 59), Color.FromArgb(115, 96, 79));
            AddButtonHoverEffect(buttonManageInventory, Color.FromArgb(95, 76, 59), Color.FromArgb(115, 96, 79));
            AddButtonHoverEffect(buttonManageCategories, Color.FromArgb(221, 207, 182), Color.FromArgb(241, 227, 202));
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
            SetupCategoriesDataGridView();
        }

        private void SetupCategoriesDataGridView()
        {
            dataGridViewCategories.AutoGenerateColumns = false;
            dataGridViewCategories.Columns.Clear();

            dataGridViewCategories.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CategoryId",
                HeaderText = "Mã DM",
                DataPropertyName = "CategoryId",
                Width = 80
            });

            dataGridViewCategories.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CategoryName",
                HeaderText = "Tên danh mục",
                DataPropertyName = "CategoryName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dataGridViewCategories.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ProductCount",
                HeaderText = "Số sản phẩm",
                DataPropertyName = "ProductCount",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Alignment = DataGridViewContentAlignment.MiddleCenter }
            });
        }

        private bool _eventHandlersWired = false;
        private bool _isDeleting = false;
        private bool _isSaving = false;


        #endregion

        #region Data Loading

        private async Task LoadAllDataAsync()
        {
            await LoadCategoriesAsync();
        }

        private async Task LoadCategoriesAsync()
        {
            try
            {
                var categories = await _categoryRepository.GetAllCategoriesAsync();
                _allCategories = categories ?? new List<Category>();
                UpdateDataGridView(_allCategories);
                System.Diagnostics.Debug.WriteLine($"Loaded {_allCategories.Count} categories");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"LoadCategoriesAsync Error: {ex.Message}");
                MessageBox.Show($"Lỗi tải danh mục: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _allCategories = new List<Category>(); // Ensure it's not null
            }
        }

        private async Task<bool> TestDatabaseConnectionAsync()
        {
            try
            {
                using var db = new DAL.Models.shopdbContext();
                var testQuery = await db.Categories.CountAsync();
                System.Diagnostics.Debug.WriteLine($"Database connection test successful. Categories count: {testQuery}");
                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Database connection test failed: {ex.Message}");
                return false;
            }
        }

        private async Task TestCategoryCreationAsync()
        {
            try
            {
                System.Diagnostics.Debug.WriteLine("=== Testing Category Creation ===");
                var testCategory = new Category { CategoryName = "TestCategory_" + DateTime.Now.Ticks };
                var result = await _categoryRepository.CreateCategoryAsync(testCategory);
                System.Diagnostics.Debug.WriteLine($"Test creation result: {result}, CategoryId: {testCategory.CategoryId}");

                if (result)
                {
                    // Clean up test category
                    await _categoryRepository.DeleteCategoryAsync(testCategory.CategoryId);
                    System.Diagnostics.Debug.WriteLine("Test category cleaned up");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"TestCategoryCreationAsync Error: {ex.Message}");
            }
        }

        private void UpdateDataGridView(List<Category> categories)
        {
            try
            {
                if (dataGridViewCategories == null) return;

                var displayData = categories.Select(c => new
                {
                    CategoryId = c.CategoryId,
                    CategoryName = c.CategoryName ?? "Không có tên",
                    ProductCount = c.Products?.Count ?? 0
                }).ToList();

                dataGridViewCategories.DataSource = displayData;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"UpdateDataGridView Error: {ex.Message}");
            }
        }

        #endregion

        #region Form Management

        private void SetFormMode(bool isEditing)
        {
            try
            {
                _isEditing = isEditing;

                if (groupBoxCategoryInfo != null)
                    groupBoxCategoryInfo.Enabled = isEditing;

                if (buttonSave != null)
                    buttonSave.Visible = isEditing;

                if (buttonCancel != null)
                    buttonCancel.Visible = isEditing;

                if (buttonAdd != null)
                    buttonAdd.Enabled = !isEditing;

                if (buttonEdit != null)
                    buttonEdit.Enabled = !isEditing && dataGridViewCategories?.CurrentRow != null;

                if (buttonDelete != null)
                    buttonDelete.Enabled = !isEditing && dataGridViewCategories?.CurrentRow != null;
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
                if (textBoxCategoryId != null) textBoxCategoryId.Text = "";
                if (textBoxCategoryName != null) textBoxCategoryName.Text = "";

                _currentCategoryId = null;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"ClearForm Error: {ex.Message}");
            }
        }

        private void LoadCategoryToForm(Category category)
        {
            try
            {
                if (category == null) return;

                if (textBoxCategoryId != null) textBoxCategoryId.Text = category.CategoryId.ToString();
                if (textBoxCategoryName != null) textBoxCategoryName.Text = category.CategoryName ?? "";

                _currentCategoryId = category.CategoryId;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"LoadCategoryToForm Error: {ex.Message}");
            }
        }

        private Category CreateCategoryFromForm()
        {
            try
            {
                var category = new Category
                {
                    CategoryName = textBoxCategoryName?.Text?.Trim() ?? ""
                };

                // Only set CategoryId for updates, not for new categories
                if (_currentCategoryId.HasValue)
                {
                    category.CategoryId = _currentCategoryId.Value;
                }

                System.Diagnostics.Debug.WriteLine($"CreateCategoryFromForm: CategoryId={category.CategoryId}, CategoryName='{category.CategoryName}'");
                return category;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"CreateCategoryFromForm Error: {ex.Message}");
                return new Category(); // Return empty category on error
            }
        }

        private bool ValidateForm()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxCategoryName?.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên danh mục!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxCategoryName?.Focus();
                    return false;
                }

                var categoryName = textBoxCategoryName.Text.Trim();

                // Check for duplicate category name (only for new categories or when name is changed)
                if (!_currentCategoryId.HasValue ||
                    (_allCategories.FirstOrDefault(c => c.CategoryId == _currentCategoryId)?.CategoryName?.ToLower() != categoryName.ToLower()))
                {
                    var existingCategory = _allCategories.FirstOrDefault(c =>
                        c.CategoryName?.ToLower() == categoryName.ToLower() &&
                        c.CategoryId != _currentCategoryId);

                    if (existingCategory != null)
                    {
                        MessageBox.Show("Tên danh mục đã tồn tại! Vui lòng chọn tên khác.", "Validation",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        textBoxCategoryName?.Focus();
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"ValidateForm Error: {ex.Message}");
                return false;
            }
        }

        #endregion

        #region Event Handlers

        // Sidebar Event Handlers
        private void buttonManageProducts_Click(object? sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new ProductManagementPage());
        }

        private void buttonManageInventory_Click(object? sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new InventoryManagementPage());
        }

        private void buttonManageCategories_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Bạn đang ở trang quản lý danh mục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // Category Management Event Handlers
        private void buttonAdd_Click(object? sender, EventArgs e)
        {
            ClearForm();
            SetFormMode(true);
            textBoxCategoryName?.Focus();
        }

        private void buttonEdit_Click(object? sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCategories?.CurrentRow != null)
                {
                    var categoryIdCell = dataGridViewCategories.CurrentRow.Cells["CategoryId"];
                    if (categoryIdCell?.Value != null && int.TryParse(categoryIdCell.Value.ToString(), out int categoryId))
                    {
                        var category = _allCategories.FirstOrDefault(c => c.CategoryId == categoryId);

                        if (category != null)
                        {
                            LoadCategoryToForm(category);
                            SetFormMode(true);
                            textBoxCategoryName?.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi chỉnh sửa danh mục: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (dataGridViewCategories?.CurrentRow != null)
                {
                    var categoryIdCell = dataGridViewCategories.CurrentRow.Cells["CategoryId"];
                    var categoryNameCell = dataGridViewCategories.CurrentRow.Cells["CategoryName"];
                    var productCountCell = dataGridViewCategories.CurrentRow.Cells["ProductCount"];

                    if (categoryIdCell?.Value != null && categoryNameCell?.Value != null &&
                        int.TryParse(categoryIdCell.Value.ToString(), out int categoryId))
                    {
                        var categoryName = categoryNameCell.Value.ToString();
                        var productCount = productCountCell?.Value?.ToString() ?? "0";

                        if (int.TryParse(productCount, out int count) && count > 0)
                        {
                            MessageBox.Show($"Không thể xóa danh mục '{categoryName}' vì còn {count} sản phẩm!\n\nVui lòng xóa hoặc chuyển tất cả sản phẩm sang danh mục khác trước khi xóa danh mục này.",
                                "Không thể xóa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        var result = MessageBox.Show(
                            $"Bạn có chắc chắn muốn xóa danh mục '{categoryName}' không?\n\nHành động này không thể hoàn tác!",
                            "Xác nhận xóa",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            _isDeleting = true; // Set flag to prevent multiple operations

                            try
                            {
                                var success = await _categoryRepository.DeleteCategoryAsync(categoryId);
                                if (success)
                                {
                                    MessageBox.Show("Xóa danh mục thành công!", "Thành công",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    await LoadCategoriesAsync();
                                    ClearForm();
                                }
                                else
                                {
                                    MessageBox.Show("Không thể xóa danh mục! Có thể danh mục đang được sử dụng bởi sản phẩm.", "Lỗi",
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
                MessageBox.Show($"Lỗi khi xóa danh mục: {ex.Message}", "Lỗi",
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
                // Test database connection first
                var connectionOk = await TestDatabaseConnectionAsync();
                if (!connectionOk)
                {
                    MessageBox.Show("Không thể kết nối đến database!\n\nVui lòng kiểm tra:\n• SQL Server đang chạy\n• Connection string đúng\n• Database tồn tại", "Lỗi kết nối",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Test category creation for debugging
                if (!_currentCategoryId.HasValue)
                {
                    await TestCategoryCreationAsync();
                }

                var category = CreateCategoryFromForm();
                bool success;

                // Debug information
                System.Diagnostics.Debug.WriteLine($"Saving category - ID: {category.CategoryId}, Name: {category.CategoryName}");

                if (_currentCategoryId.HasValue)
                {
                    // Cập nhật danh mục
                    System.Diagnostics.Debug.WriteLine($"Updating existing category with ID: {_currentCategoryId}");
                    success = await _categoryRepository.UpdateCategoryAsync(category);
                    if (success)
                    {
                        MessageBox.Show("Cập nhật danh mục thành công!", "Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadCategoriesAsync();
                        SetFormMode(false);
                        ClearForm();
                        return;
                    }
                    else
                    {
                        // Check for specific error conditions
                        var categoryName = category.CategoryName?.Trim();
                        var existingCategory = _allCategories.FirstOrDefault(c =>
                            c.CategoryName?.ToLower() == categoryName?.ToLower() &&
                            c.CategoryId != _currentCategoryId);

                        if (existingCategory != null)
                        {
                            MessageBox.Show($"Tên danh mục '{categoryName}' đã tồn tại!\n\nVui lòng chọn tên khác.", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            MessageBox.Show("Không thể cập nhật danh mục!\n\nCó thể:\n• Danh mục không tồn tại\n• Có lỗi kết nối database\n\nVui lòng kiểm tra Debug Output để biết chi tiết lỗi.", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        return;
                    }
                }
                else
                {
                    // Thêm danh mục mới
                    System.Diagnostics.Debug.WriteLine($"Creating new category: '{category.CategoryName}'");
                    success = await _categoryRepository.CreateCategoryAsync(category);
                    System.Diagnostics.Debug.WriteLine($"CreateCategoryAsync result: {success}");

                    if (success)
                    {
                        System.Diagnostics.Debug.WriteLine($"Category created successfully with ID: {category.CategoryId}");
                        MessageBox.Show("Thêm danh mục mới thành công!", "Thành công",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadCategoriesAsync();
                        SetFormMode(false);
                        ClearForm();
                        return;
                    }
                    else
                    {
                        // Reload categories to check if it was actually created despite false return
                        await LoadCategoriesAsync();
                        var categoryName = category.CategoryName?.Trim();
                        var newlyCreatedCategory = _allCategories.FirstOrDefault(c =>
                            c.CategoryName?.ToLower() == categoryName?.ToLower());

                        if (newlyCreatedCategory != null)
                        {
                            // Category was actually created successfully, just the return value was wrong
                            System.Diagnostics.Debug.WriteLine($"Category was actually created successfully with ID: {newlyCreatedCategory.CategoryId}");
                            // Không hiển thị thông báo thành công ở đây nữa để tránh trùng lặp
                            SetFormMode(false);
                            ClearForm();
                            return;
                        }
                        else
                        {
                            // Check for specific error conditions
                            var existingCategory = _allCategories.FirstOrDefault(c =>
                                c.CategoryName?.ToLower() == categoryName?.ToLower());

                            if (existingCategory != null)
                            {
                                System.Diagnostics.Debug.WriteLine($"Category name '{categoryName}' already exists in local list");
                                MessageBox.Show($"Tên danh mục '{categoryName}' đã tồn tại!\n\nVui lòng chọn tên khác.", "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                System.Diagnostics.Debug.WriteLine($"Failed to create category '{categoryName}' - unknown error");
                                MessageBox.Show("Không thể thêm danh mục mới!\n\nCó thể có lỗi kết nối database.\n\nVui lòng kiểm tra Debug Output để biết chi tiết lỗi.", "Lỗi",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"buttonSave_Click Error: {ex.Message}\nStack Trace: {ex.StackTrace}");
                MessageBox.Show($"Lỗi khi lưu danh mục: {ex.Message}\n\nChi tiết lỗi đã được ghi vào Debug Output.", "Lỗi",
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
                await LoadCategoriesAsync();
                ClearForm();
                SetFormMode(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi làm mới: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewCategories_SelectionChanged(object? sender, EventArgs e)
        {
            try
            {
                if (!_isEditing && dataGridViewCategories?.CurrentRow != null)
                {
                    var categoryIdCell = dataGridViewCategories.CurrentRow.Cells["CategoryId"];
                    if (categoryIdCell?.Value != null && int.TryParse(categoryIdCell.Value.ToString(), out int categoryId))
                    {
                        var category = _allCategories.FirstOrDefault(c => c.CategoryId == categoryId);

                        if (category != null)
                        {
                            LoadCategoryToForm(category);
                        }
                    }

                    if (buttonEdit != null) buttonEdit.Enabled = true;
                    if (buttonDelete != null) buttonDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"dataGridViewCategories_SelectionChanged Error: {ex.Message}");
            }
        }

        #endregion

        private void groupBoxCategoryInfo_Enter(object? sender, EventArgs e)
        {

        }

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