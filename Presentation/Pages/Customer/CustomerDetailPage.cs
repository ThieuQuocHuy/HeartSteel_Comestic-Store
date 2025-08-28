using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Services;

namespace Presentation.Pages.Customer
{
    public partial class CustomerDetailPage : Form
    {
        private readonly int _userId;
        private readonly IUserService _userService;
        private readonly IOrderService _orderService;

        private Label labelName;
        private Label labelEmail;
        private Label labelPhone;
        private Label labelAddress;
        private DataGridView gridOrders;

        public CustomerDetailPage(int userId)
        {
            _userId = userId;
            _userService = new UserService();
            _orderService = new OrderService();
            InitializeComponent();
            this.Load += CustomerDetailPage_Load;
        }

        private void InitializeComponent()
        {
            this.labelName = new Label();
            this.labelEmail = new Label();
            this.labelPhone = new Label();
            this.labelAddress = new Label();
            this.gridOrders = new DataGridView();
            this.SuspendLayout();

            // Labels
            this.labelName.Left = 20; this.labelName.Top = 20; this.labelName.Width = 500;
            this.labelEmail.Left = 20; this.labelEmail.Top = 45; this.labelEmail.Width = 500;
            this.labelPhone.Left = 20; this.labelPhone.Top = 70; this.labelPhone.Width = 500;
            this.labelAddress.Left = 20; this.labelAddress.Top = 95; this.labelAddress.Width = 800;

            // Orders grid
            this.gridOrders.Left = 20;
            this.gridOrders.Top = 130;
            this.gridOrders.Width = 840;
            this.gridOrders.Height = 400;
            this.gridOrders.ReadOnly = true;
            this.gridOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.gridOrders.MultiSelect = false;
            this.gridOrders.AutoGenerateColumns = false;
            this.gridOrders.AllowUserToAddRows = false;
            this.gridOrders.AllowUserToDeleteRows = false;

            this.gridOrders.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Mã đơn", DataPropertyName = "OrderId", Width = 80 });
            this.gridOrders.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ngày đặt", DataPropertyName = "OrderDate", Width = 150 });
            this.gridOrders.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Địa chỉ giao", DataPropertyName = "ShippingAddress", Width = 300 });
            this.gridOrders.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Tổng tiền", DataPropertyName = "Order Total", Width = 120 });
            this.gridOrders.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Trạng thái", DataPropertyName = "LatestStatus", Width = 150 });

            // Form
            this.Text = "Chi tiết khách hàng";
            this.Width = 900;
            this.Height = 600;
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.gridOrders);

            this.ResumeLayout(false);
        }

        private async void CustomerDetailPage_Load(object sender, EventArgs e)
        {
            await LoadCustomerAsync();
            await LoadOrdersAsync();
        }
        private async Task LoadCustomerAsync()
        {
            var user = await _userService.GetByIdAsync(_userId);
            if (user == null)
            {
                MessageBox.Show("Không tìm thấy khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            labelName.Text = $"Họ tên: {user.Fullname}";
            labelEmail.Text = $"Email: {user.Email}";
            labelPhone.Text = $"Điện thoại: (user.Phone]";
            labelAddress.Text = $"Địa chỉ: {user.Address}";
        }

        private async Task LoadOrdersAsync()
        {
            var orders = await _orderService.GetUserOrdersAsync(_userId);
            var binding = orders
                .Select(o => new
                {
                    o.OrderId,
                    OrderDate = o.OrderDate.ToString("dd/MM/yyyy HH:mm"),
                    o.ShippingAddress,
                    OrderTotal = o.OrderTotal.ToString("NO") + "d",
                    LatestStatus = o.OrderStatuses
                        .OrderByDescending(s => s.ChangedAt)
                        .FirstOrDefault()?.Status ?? "N/A"
                })
                .ToList();

            gridOrders.DataSource = binding;
        }
    }
}
