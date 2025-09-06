namespace Presentation.Pages.Customer
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            // Hiển thị tên người dùng đang đăng nhập
            label4.Text = Presentation.Auth.UserSession.CurrentUser?.Fullname ?? label4.Text;
            // Gán sự kiện cho nút Sản phẩm
            buttonProducts.Click += buttonProducts_Click;
            // Gán sự kiện cho nút Giỏ hàng
            buttonCart.Click += buttonCart_Click;
            // Gán sự kiện cho nút Đơn mua
            buttonOrders.Click += buttonOrders_Click;
            // Gán sự kiện Logout nếu có nút
            if (buttonLogout != null)
            {
                buttonLogout.Click += buttonLogout_Click;
            }
            // Load ảnh
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
        private void buttonLogout_Click(object? sender, EventArgs e)
        {
            Presentation.Auth.UserSession.Clear();
            Presentation.Navigation.Navigator.Navigate(new LoginForm());
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void panelWelcome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelCustomer_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void buttonProducts_Click(object? sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new ProductPage());
        }

        private void buttonCart_Click(object? sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new CartPage());
        }

        private void buttonOrders_Click(object? sender, EventArgs e)
        {
            Presentation.Navigation.Navigator.Navigate(new OrderListPage());
        }
    }
}
