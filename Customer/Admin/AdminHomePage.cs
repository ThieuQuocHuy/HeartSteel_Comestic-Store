using Customer.Services;

namespace Customer.Admin
{
    public partial class AdminHomePage : Form
    {
        private readonly ProductService _productService;

        public AdminHomePage()
        {
            InitializeComponent();
            _productService = new ProductService();
            
            try
            {
                LoadDashboardData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dashboard: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDashboardData()
        {
            try
            {
                labelTotalProducts.Text = _productService.GetTotalProducts().ToString();
                labelLowStock.Text = _productService.GetLowStockCount().ToString();
                labelInventoryValue.Text = _productService.GetTotalInventoryValue().ToString("C0");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu dashboard: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                // Set default values
                labelTotalProducts.Text = "0";
                labelLowStock.Text = "0";
                labelInventoryValue.Text = "0 ₫";
            }
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            try
            {
                var productManagementForm = new ProductManagementForm();
                productManagementForm.ShowDialog();
                // Refresh dashboard sau khi quay lại
                LoadDashboardData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở form quản lý sản phẩm: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            try
            {
                var inventoryManagementForm = new InventoryManagementForm();
                inventoryManagementForm.ShowDialog();
                // Refresh dashboard sau khi quay lại
                LoadDashboardData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở form quản lý kho hàng: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDashboardData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi làm mới dashboard: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng báo cáo đang được phát triển!", "Thông báo", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng cài đặt đang được phát triển!", "Thông báo", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDashboardData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi làm mới dashboard: {ex.Message}", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}