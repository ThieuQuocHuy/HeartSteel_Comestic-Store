using System;
using System.Windows.Forms;

namespace Presentation.Pages.Admin
{
    public partial class InventoryManagementPage : Form
    {
        public InventoryManagementPage()
        {
            // Form sẽ sử dụng Designer đã tạo trước đó
        }

        // Sidebar Event Handlers
        private void buttonManageProducts_Click(object sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new ProductManagementPage());
        }

        private void buttonManageInventory_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn đang ở trang quản lý kho hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonManageCategories_Click(object sender, EventArgs e)
        {
            // TODO: Navigate to Category Management Page
            MessageBox.Show("📂 Chức năng quản lý danh mục sẽ được phát triển trong phiên bản tiếp theo.", 
                "Quản lý danh mục", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new ReportsPage());
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Presentation.Auth.UserSession.Clear();
            Presentation.Navigation.Navigator.Navigate(new Presentation.Pages.Customer.LoginForm());
        }

        // Stock Management Event Handlers - Demo stubs
        private void buttonRefreshStock_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã làm mới dữ liệu tồn kho!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonStockIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng nhập hàng đang được phát triển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonStockOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng xuất hàng đang được phát triển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonFilterTransactions_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã lọc giao dịch theo tiêu chí!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonUpdateThreshold_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã cập nhật ngưỡng cảnh báo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonMarkAllRead_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã đánh dấu tất cả cảnh báo là đã đọc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}