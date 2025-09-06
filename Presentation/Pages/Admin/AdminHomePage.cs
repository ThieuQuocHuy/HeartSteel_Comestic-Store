using System;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation.Pages.Admin
{
    public partial class AdminHomePage : Form
    {
        private System.Windows.Forms.Timer timeTimer;

        public AdminHomePage()
        {
            InitializeComponent();
            this.Load += AdminHomePage_Load;
            SetupTimer();
        }

        private void SetupTimer()
        {
            timeTimer = new System.Windows.Forms.Timer();
            timeTimer.Interval = 1000; // Cập nhật mỗi giây
            timeTimer.Tick += TimeTimer_Tick;
            timeTimer.Start();
        }

        private void TimeTimer_Tick(object? sender, EventArgs e)
        {
            labelCurrentTime.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
        }

        private void AdminHomePage_Load(object? sender, EventArgs e)
        {
            // Hiển thị tên admin đang đăng nhập
            labelAdminName.Text = $"Xin chào, {Presentation.Auth.UserSession.CurrentUser?.Fullname ?? "Admin"}! 👋";
            
            // Cập nhật thời gian ngay lập tức
            labelCurrentTime.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
            
            // Load thống kê dashboard (giả lập dữ liệu)
            LoadDashboardStats();
            
            // Thêm hiệu ứng hover cho các button
            AddHoverEffects();

            // Tự động chuyển đến trang quản lý sản phẩm
            NavigateToProductManagement();
        }

        private void NavigateToProductManagement()
        {
            // Dừng timer trước khi chuyển trang
            timeTimer?.Stop();
            timeTimer?.Dispose();
            
            // Chuyển đến trang quản lý sản phẩm
            Presentation.Navigation.Navigator.Navigate(new ProductManagementPage());
        }

        private void LoadDashboardStats()
        {
            // TODO: Thay thế bằng dữ liệu thực từ database
            labelProductCount.Text = "25";
            labelOrderCount.Text = "150"; // Tồn kho (kg)
            labelCategoryCount.Text = "8";
            labelRevenueAmount.Text = "₫125,500,000";
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
            
            // Thêm hiệu ứng hover cho quick action buttons
            AddButtonHoverEffect(buttonQuickAddProduct, Color.FromArgb(74, 144, 226), Color.FromArgb(94, 164, 246));
            AddButtonHoverEffect(buttonQuickManageInventory, Color.FromArgb(39, 174, 96), Color.FromArgb(59, 194, 116));
            AddButtonHoverEffect(buttonQuickViewReports, Color.FromArgb(230, 126, 34), Color.FromArgb(250, 146, 54));
        }

        private void AddButtonHoverEffect(Button button, Color normalColor, Color hoverColor)
        {
            button.MouseEnter += (s, e) => button.BackColor = hoverColor;
            button.MouseLeave += (s, e) => button.BackColor = normalColor;
        }

        private void buttonManageProducts_Click(object sender, EventArgs e)
        {
            // Navigate to Product Management Page
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
        private void buttonManageOrders_Click(object sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new OrderManagementPage());
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            // Navigate to Reports Page
            Presentation.Navigation.Navigator.Navigate(new ReportsPage());
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            // Dừng timer
            timeTimer?.Stop();
            timeTimer?.Dispose();
            
            // Clear session
            Presentation.Auth.UserSession.Clear();
            
            // Navigate to login
            Presentation.Navigation.Navigator.Navigate(new Customer.LoginForm());
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                timeTimer?.Stop();
                timeTimer?.Dispose();
                components?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}