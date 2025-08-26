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
