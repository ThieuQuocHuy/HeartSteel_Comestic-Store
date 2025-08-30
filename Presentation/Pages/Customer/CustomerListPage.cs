using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Services;
namespace Presentation.Pages.Customer
{
    public partial class CustomerListPage : Form
    {
        private readonly IUserService _userService;
        public CustomerListPage()
        {
            _userService = new UserService();
            InitializeComponent();
            this.Load += CustomerListPage_Load;
        }
        private async void CustomerListPage_Load(object sender, EventArgs e)
        {
            await LoadCustomersAsync();
        }
        private async Task LoadCustomersAsync()
        {
            var keyword = textBoxSearch.Text?.Trim();
            var customers = await _userService.GetCustomersAsync(keyword);
            var binding = customers.Select(u => new
            {
                u.UserId,
                u.Username,
                u.Fullname,
                u.Phone,
                u.Email,
            }).ToList();
            gridCustomers.DataSource = binding;
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            await LoadCustomersAsync();
        }

        private void ButtonViewDetail_Click(object sender, EventArgs e)
        {
            if (gridCustomers.CurrentRow == null) return;
            var idObj = gridCustomers.CurrentRow.Cells["UserId"]?.Value;
            if (idObj == null) return;
            int userId = Convert.ToInt32(idObj);
            var detail = new CustomerDetailPage(userId);
            detail.ShowDialog(this);
        }
    }
}