using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Repositories;
using DAL.Models;

namespace Presentation.Pages.Customer
{
    public partial class CSKHPage : Form
    {
        private readonly ICustomerRequirementRepository _requirementRepo = new CustomerRequirementRepository();
        private readonly IRequirementStatusRepository _statusRepo = new RequirementStatusRepository();

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
            // Load yêu cầu của người dùng hiện tại
            _ = LoadMyRequestsAsync();
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
                dataGridRequests.Columns.Add("UserId", "User ID");
                dataGridRequests.Columns.Add("Customer", "Khách hàng");
                dataGridRequests.Columns.Add("Phone", "Số điện thoại");
                dataGridRequests.Columns.Add("Content", "Nội dung yêu cầu");
                dataGridRequests.Columns.Add("CreatedAt", "Ngày gửi");
                dataGridRequests.Columns.Add("Status", "Trạng thái");
                var btnCol = new DataGridViewButtonColumn();
                btnCol.Name = "Detail";
                btnCol.HeaderText = "Chi tiết";
                btnCol.Text = "Xem";
                btnCol.UseColumnTextForButtonValue = true;
                btnCol.Width = 70;
                dataGridRequests.Columns.Add(btnCol);
                dataGridRequests.CellContentClick += dataGridRequests_CellContentClick;
            }
        }

        private async void ButtonSend_Click(object? sender, EventArgs e)
        {
            var content = textSupportContent.Text.Trim();
            if (string.IsNullOrEmpty(content))
            {
                MessageBox.Show("Vui lòng nhập nội dung yêu cầu.");
                return;
            }
            var currentUser = Presentation.Auth.UserSession.CurrentUser;
            if (currentUser == null)
            {
                MessageBox.Show("Vui lòng đăng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var pending = await _statusRepo.GetByNameAsync("Đang xử lý");
            if (pending == null)
            {
                MessageBox.Show("Không tìm thấy trạng thái 'Đang xử lý' trong hệ thống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var requirement = new CustomerRequirement
            {
                UserId = currentUser.UserId,
                CustomerName = currentUser.Fullname ?? currentUser.Username,
                Phone = currentUser.Phone ?? string.Empty,
                Content = content,
                RequestDate = DateTime.Now,
                StatusId = pending.StatusId
            };

            var ok = await _requirementRepo.CreateAsync(requirement);
            if (!ok)
            {
                MessageBox.Show("Gửi yêu cầu thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textSupportContent.Clear();
            await LoadMyRequestsAsync();
            MessageBox.Show("Đã gửi yêu cầu hỗ trợ!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private async void dataGridRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            var grid = (DataGridView)sender;
            if (grid.Columns[e.ColumnIndex].Name != "Detail") return;

            var currentUser = Presentation.Auth.UserSession.CurrentUser;
            if (currentUser == null) return;
            var list = await _requirementRepo.GetByUserIdAsync(currentUser.UserId);
            if (e.RowIndex >= list.Count) return;
            var entity = list[e.RowIndex];
            using (var dlg = new SupportDetailForm("Chi tiết yêu cầu", entity.Content ?? string.Empty))
            {
                dlg.ShowDialog(this);
            }
        }

        private async Task LoadMyRequestsAsync()
        {
            try
            {
                var currentUser = Presentation.Auth.UserSession.CurrentUser;
                if (currentUser == null) return;
                var list = await _requirementRepo.GetByUserIdAsync(currentUser.UserId);
                dataGridRequests.Rows.Clear();
                foreach (var r in list)
                {
                    dataGridRequests.Rows.Add(
                        r.UserId,
                        r.CustomerName,
                        r.Phone,
                        r.Content,
                        (r.RequestDate ?? DateTime.Now).ToString("dd/MM/yyyy HH:mm"),
                        r.Status?.StatusName ?? string.Empty
                    );
                }
            }
            catch
            {
            }
        }
    }
}
