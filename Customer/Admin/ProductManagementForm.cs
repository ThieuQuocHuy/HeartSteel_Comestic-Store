using Customer.Models;
using Customer.Services;

namespace Customer.Admin
{
    public partial class ProductManagementForm : Form
    {
        private readonly ProductService? _productService;
        private List<Product> _currentProducts;

        public ProductManagementForm()
        {
            try
            {
                InitializeComponent();
                _productService = new ProductService();
                _currentProducts = new List<Product>();
                
                // DON'T load data in constructor - wait for form to be shown
                // LoadProducts(); 
                // LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khởi tạo form: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Load event handler - called after form is fully created
        private void ProductManagementForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadProducts();
                LoadCategories();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProducts()
        {
            try
            {
                if (_productService == null)
                {
                    return;
                }

                _currentProducts = _productService.GetAllProducts();
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh sách sản phẩm: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                _currentProducts = new List<Product>();
            }
        }

        private void RefreshDataGridView()
        {
            try
            {
                if (dataGridViewProducts == null)
                {
                    return;
                }

                dataGridViewProducts.DataSource = null;
                
                if (_currentProducts?.Any() == true)
                {
                    var dataSource = _currentProducts.Select(p => new
                    {
                        ID = p.Id,
                        TenSanPham = p.Name,
                        MoTa = p.Description,
                        Gia = p.Price.ToString("C0"),
                        SoLuong = p.Stock,
                        DanhMuc = p.Category,
                        TrangThai = p.IsActive ? "Hoạt động" : "Ngưng bán",
                        NgayTao = p.CreatedDate.ToString("dd/MM/yyyy")
                    }).ToList();

                    dataGridViewProducts.DataSource = dataSource;

                    // Setup columns after data is bound
                    SetupProductDataGridViewColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi hiển thị dữ liệu: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupProductDataGridViewColumns()
        {
            try
            {
                if (dataGridViewProducts?.Columns == null || dataGridViewProducts.Columns.Count == 0)
                {
                    return;
                }

                // Set column widths and headers using foreach to avoid index issues
                foreach (DataGridViewColumn column in dataGridViewProducts.Columns)
                {
                    switch (column.Name)
                    {
                        case "ID":
                            column.Width = 50;
                            column.HeaderText = "ID";
                            break;
                        case "TenSanPham":
                            column.Width = 150;
                            column.HeaderText = "Tên Sản Phẩm";
                            break;
                        case "MoTa":
                            column.Width = 200;
                            column.HeaderText = "Mô Tả";
                            break;
                        case "Gia":
                            column.Width = 100;
                            column.HeaderText = "Giá";
                            break;
                        case "SoLuong":
                            column.Width = 80;
                            column.HeaderText = "Số Lượng";
                            break;
                        case "DanhMuc":
                            column.Width = 120;
                            column.HeaderText = "Danh Mục";
                            break;
                        case "TrangThai":
                            column.Width = 100;
                            column.HeaderText = "Trạng Thái";
                            break;
                        case "NgayTao":
                            column.Width = 100;
                            column.HeaderText = "Ngày Tạo";
                            break;
                    }
                }

                // Set general properties
                dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dataGridViewProducts.AllowUserToResizeColumns = true;
                dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewProducts.MultiSelect = false;
                dataGridViewProducts.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thiết lập cột sản phẩm: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCategories()
        {
            try
            {
                if (_productService == null || comboBoxCategory == null)
                {
                    return;
                }

                var categories = _productService.GetCategories();
                comboBoxCategory.Items.Clear();
                comboBoxCategory.Items.Add("Tất cả");
                
                if (categories?.Any() == true)
                {
                    foreach (var category in categories)
                    {
                        comboBoxCategory.Items.Add(category);
                    }
                }
                
                comboBoxCategory.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải danh mục: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (_productService == null)
                {
                    MessageBox.Show("Service chưa được khởi tạo!", "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var addForm = new ProductAddEditForm();
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    if (_productService.AddProduct(addForm.Product))
                    {
                        MessageBox.Show("Thêm sản phẩm thành công!", "Thành công", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProducts();
                        LoadCategories();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi thêm sản phẩm!", "Lỗi", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm sản phẩm: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (_productService == null)
                {
                    MessageBox.Show("Service chưa được khởi tạo!", "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dataGridViewProducts?.SelectedRows == null || dataGridViewProducts.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = dataGridViewProducts.SelectedRows[0];
                
                // Get cell value safely
                var idCell = selectedRow.Cells["ID"];
                if (idCell?.Value == null)
                {
                    MessageBox.Show("Dữ liệu sản phẩm không hợp lệ!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var productId = Convert.ToInt32(idCell.Value);
                var product = _productService.GetProductById(productId);

                if (product != null)
                {
                    var editForm = new ProductAddEditForm(product);
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        if (_productService.UpdateProduct(editForm.Product))
                        {
                            MessageBox.Show("Cập nhật sản phẩm thành công!", "Thành công", 
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadProducts();
                            LoadCategories();
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra khi cập nhật sản phẩm!", "Lỗi", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sản phẩm!", "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa sản phẩm: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_productService == null)
                {
                    MessageBox.Show("Service chưa được khởi tạo!", "Lỗi", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dataGridViewProducts?.SelectedRows == null || dataGridViewProducts.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = dataGridViewProducts.SelectedRows[0];
                
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
                var productName = nameCell.Value.ToString();

                var result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm '{productName}'?", 
                    "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (_productService.DeleteProduct(productId))
                    {
                        MessageBox.Show("Xóa sản phẩm thành công!", "Thành công", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProducts();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi xóa sản phẩm!", "Lỗi", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa sản phẩm: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FilterProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FilterProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lọc theo danh mục: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterProducts()
        {
            try
            {
                if (_productService == null)
                {
                    return;
                }

                var searchTerm = textBoxSearch?.Text?.Trim() ?? "";
                var selectedCategory = comboBoxCategory?.SelectedItem?.ToString();

                var filteredProducts = _productService.GetAllProducts();

                // Lọc theo từ khóa tìm kiếm
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    filteredProducts = filteredProducts.Where(p =>
                        p.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                        p.Description.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                        p.Category.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                        .ToList();
                }

                // Lọc theo danh mục
                if (!string.IsNullOrEmpty(selectedCategory) && selectedCategory != "Tất cả")
                {
                    filteredProducts = filteredProducts.Where(p => p.Category == selectedCategory).ToList();
                }

                _currentProducts = filteredProducts;
                RefreshDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lọc sản phẩm: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxSearch != null) textBoxSearch.Clear();
                if (comboBoxCategory != null) comboBoxCategory.SelectedIndex = 0;
                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi làm mới dữ liệu: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    buttonEdit_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở form chỉnh sửa: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}