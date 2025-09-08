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

            // Thêm hiệu ứng hover cho các button
            AddHoverEffects();

            //Load ảnh logo và trang chủ
            LoadImages();
        }

        private void LoadImages()
        {
            try
            {
                // Load logo
                if (pictureBoxLogo != null)
                {
                    var logoImage = Presentation.Services.ResourceImageLoader.LoadByFileName("logoden.png");
                    if (logoImage != null)
                    {
                        pictureBoxLogo.Image = logoImage;
                        System.Diagnostics.Debug.WriteLine("Logo loaded successfully for HomePage");
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("Failed to load logo image for HomePage");
                    }
                }

                // Load trangchu2.png vào pictureBox2
                if (pictureBox2 != null)
                {
                    var trangchuImage = Presentation.Services.ResourceImageLoader.LoadByFileName("trangchu2.png");
                    if (trangchuImage != null)
                    {
                        pictureBox2.Image = trangchuImage;
                        System.Diagnostics.Debug.WriteLine("Trangchu2 image loaded successfully for HomePage");
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("Failed to load trangchu2 image for HomePage");
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"LoadImages Error: {ex.Message}");
            }
        }


        private void AddHoverEffects()
        {
            // Thêm hiệu ứng hover cho sidebar buttons
            AddButtonHoverEffect(buttonManageProducts, Color.FromArgb(95, 76, 59), Color.FromArgb(115, 96, 79));
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

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void buttonManageProducts_Click_1(object sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new ProductManagementPage());
        }

        private void buttonAdminCSKH_Click(object sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new CSKHAdminPage());
        }
    }
}