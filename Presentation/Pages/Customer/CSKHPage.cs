using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Pages.Customer
{
    public partial class CSKHPage : Form
    {
        public CSKHPage()
        {
            InitializeComponent();
            // Hiển thị tên người dùng đang đăng nhập
            label4.Text = Presentation.Auth.UserSession.CurrentUser?.Fullname ?? label4.Text;
            // Gán sự kiện cho các nút điều hướng
            buttonHome.Click += (_, __) => Presentation.Navigation.Navigator.Navigate(new HomePage());
            buttonProducts.Click += (_, __) => Presentation.Navigation.Navigator.Navigate(new ProductPage());
            buttonCart.Click += (_, __) => Presentation.Navigation.Navigator.Navigate(new CartPage());
            buttonOrders.Click += (_, __) => Presentation.Navigation.Navigator.Navigate(new OrderListPage());
            buttonLogout.Click += (_, __) => { Presentation.Auth.UserSession.Clear(); Presentation.Navigation.Navigator.Navigate(new LoginForm()); };
            buttonSend.Click += ButtonSend_Click;
            // Load ảnh logo nếu có
            LoadImages();
            // Cấu hình bảng danh sách
            ConfigureGrid();
        }

        private void LoadImages()
        {
            try
            {
                var logoImage = Presentation.Services.ResourceImageLoader.LoadByFileName("logoden.png");
                if (logoImage != null)
                {
                    pictureBoxLogo.Image = logoImage;
                }
            }
            catch { }
        }

        private void ConfigureGrid()
        {
            if (dataGridRequests.Columns.Count == 0)
            {
                dataGridRequests.Columns.Add("Id", "ID yêu cầu");
                dataGridRequests.Columns.Add("Customer", "Khách hàng");
                dataGridRequests.Columns.Add("Phone", "Số điện thoại");
                dataGridRequests.Columns.Add("Content", "Nội dung yêu cầu");
                dataGridRequests.Columns.Add("CreatedAt", "Ngày gửi");
            }
        }

        private void ButtonSend_Click(object? sender, EventArgs e)
        {
            var content = textSupportContent.Text.Trim();
            if (string.IsNullOrEmpty(content))
            {
                MessageBox.Show("Vui lòng nhập nội dung yêu cầu.");
                return;
            }
            // Hiện tại chỉ demo thêm vào bảng hiển thị
            dataGridRequests.Rows.Add(
                dataGridRequests.Rows.Count + 1,
                Presentation.Auth.UserSession.CurrentUser?.Fullname ?? "Khách",
                Presentation.Auth.UserSession.CurrentUser?.Phone ?? "",
                content,
                DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            textSupportContent.Clear();
            MessageBox.Show("Đã gửi yêu cầu hỗ trợ!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void dataGridRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
