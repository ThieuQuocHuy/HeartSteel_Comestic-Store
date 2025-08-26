namespace Presentation.Pages.Customer
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            // Gán sự kiện cho nút Sản phẩm
            buttonProducts.Click += buttonProducts_Click;
            // Gán sự kiện cho nút Giỏ hàng
            buttonCart.Click += buttonCart_Click;
            // Gán sự kiện cho nút Đơn mua
            buttonOrders.Click += buttonOrders_Click;
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
            var form = new ProductPage();
            this.Hide();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }

        private void buttonCart_Click(object? sender, EventArgs e)
        {
            var form = new CartPage();
            this.Hide();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }

        private void buttonOrders_Click(object? sender, EventArgs e)
        {
            var form = new OrderListPage();
            this.Hide();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }
    }
}
