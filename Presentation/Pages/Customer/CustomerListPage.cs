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
                u.Email,
                u.Phone
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
            var idobj = gridCustomers.CurrentRow.Cells["UserId"]?.Value;
            if (idobj == null) return;
            int userId = Convert.ToInt32(idobj);
            var detail = new CustomerDetailPage(userId);
            detail.ShowDialog(this);
        }
    }
}

namespace Presentation.Pages.Customer
{
    partial class CustomerListPage
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView gridCustomers;
        private System.Windows.Forms.Button buttonViewDetail;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.gridCustomers = new System.Windows.Forms.DataGridView();
            this.buttonViewDetail = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).BeginInit();
            this.SuspendLayout();
            this.textBoxSearch.Left = 20;
            this.textBoxSearch.Top = 20;
            this.textBoxSearch.Width = 300;
            this.buttonSearch.Left = 330;
            this.buttonSearch.Top = 18;
            this.buttonSearch.Width = 100;
            this.buttonSearch.Text = "Tìm";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);

            this.gridCustomers.Left = 20;
            this.gridCustomers.Top = 60;
            this.gridCustomers.Width = 820;
            this.gridCustomers.Height = 440;
            this.gridCustomers.ReadOnly = true;
            this.gridCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCustomers.MultiSelect = false;
            this.gridCustomers.AutoGenerateColumns = false;
            this.gridCustomers.AllowUserToAddRows = false;
            this.gridCustomers.AllowUserToDeleteRows = false;
            this.gridCustomers.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "UserId", Width = 60 });
            this.gridCustomers.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "Tên đăng nhập", DataPropertyName = "Username", Width = 150 });
            this.gridCustomers.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "Họ tên", DataPropertyName = "Fullname", Width = 200 });
            this.gridCustomers.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "Email", DataPropertyName = "Email", Width = 200 });
            this.gridCustomers.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn { HeaderText = "Điện thoại", DataPropertyName = "Phone", Width = 120 });
            this.buttonViewDetail.Left = 20;
            this.buttonViewDetail.Top = 510;
            this.buttonViewDetail.Width = 160;
            this.buttonViewDetail.Text = "Xem chi tiết";
            this.buttonViewDetail.UseVisualStyleBackColor = true;
            this.buttonViewDetail.Click += new System.EventHandler(this.ButtonViewDetail_Click);
            this.Text = "Quản lý khách hàng";
            this.Width = 900;
            this.Height = 600;
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.gridCustomers);
            this.Controls.Add(this.buttonViewDetail);
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).EndInit();
            this.ResumeLayout(false);
        }
    }
}