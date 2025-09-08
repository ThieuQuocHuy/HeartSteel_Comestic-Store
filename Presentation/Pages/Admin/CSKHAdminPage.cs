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
using System.Threading.Tasks;
using System.Linq;
using Presentation.Navigation;

namespace Presentation.Pages.Admin
{
    public partial class CSKHAdminPage : Form
    {
        private readonly ICustomerRequirementRepository _requirementRepo;
        private readonly IRequirementStatusRepository _statusRepo;
        private List<CustomerRequirement> _allRequirements = new List<CustomerRequirement>();

        public CSKHAdminPage()
        {
            InitializeComponent();
            _requirementRepo = new CustomerRequirementRepository();
            _statusRepo = new RequirementStatusRepository();
            this.Load += CSKHAdminPage_Load;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            buttonFilterLatest.Click += buttonFilterLatest_Click;
            buttonRefresh.Click += async (s, e) => await LoadDataAsync();
            buttonViewDetail.Click += buttonViewDetail_Click;
        }

        private async void CSKHAdminPage_Load(object? sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            _allRequirements = await _requirementRepo.GetAllAsync();
            BindGrid(_allRequirements);
        }

        private void BindGrid(List<CustomerRequirement> data)
        {
            dataGridViewRequirements.AutoGenerateColumns = false;
            dataGridViewRequirements.Columns.Clear();

            dataGridViewRequirements.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(CustomerRequirement.RequirementId), HeaderText = "ID", Width = 60 });
            dataGridViewRequirements.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(CustomerRequirement.CustomerName), HeaderText = "Khách hàng", Width = 180 });
            dataGridViewRequirements.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(CustomerRequirement.Phone), HeaderText = "SĐT", Width = 120 });
            dataGridViewRequirements.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(CustomerRequirement.Content), HeaderText = "Nội dung", Width = 400 });
            dataGridViewRequirements.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(CustomerRequirement.RequestDate), HeaderText = "Ngày yêu cầu", Width = 150 });
            dataGridViewRequirements.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StatusName", HeaderText = "Trạng thái", Width = 140 });

            var binding = data.Select(r => new
            {
                r.RequirementId,
                r.CustomerName,
                r.Phone,
                r.Content,
                RequestDate = r.RequestDate?.ToString("yyyy-MM-dd HH:mm") ?? string.Empty,
                StatusName = r.Status?.StatusName ?? string.Empty
            }).ToList();

            dataGridViewRequirements.DataSource = binding;
        }

        private void textBoxSearch_TextChanged(object? sender, EventArgs e)
        {
            var keyword = textBoxSearch.Text?.Trim() ?? string.Empty;
            var filtered = string.IsNullOrWhiteSpace(keyword)
                ? _allRequirements
                : _allRequirements.Where(r => r.CustomerName.Contains(keyword, StringComparison.OrdinalIgnoreCase)).ToList();
            BindGrid(filtered);
        }

        private void buttonFilterLatest_Click(object? sender, EventArgs e)
        {
            var fromDate = dateTimePickerFrom.Value.Date;
            var filtered = _allRequirements.Where(r => r.RequestDate.HasValue && r.RequestDate.Value.Date >= fromDate).ToList();
            BindGrid(filtered);
        }

        private async void buttonViewDetail_Click(object? sender, EventArgs e)
        {
            if (dataGridViewRequirements.CurrentRow == null) return;
            var idObj = dataGridViewRequirements.CurrentRow.Cells[0].Value;
            if (idObj == null) return;
            if (!int.TryParse(idObj.ToString(), out var requirementId)) return;

            var entity = await _requirementRepo.GetByIdAsync(requirementId);
            if (entity == null) return;

            var detail = $"Khách hàng: {entity.CustomerName}\nSĐT: {entity.Phone}\nNgày: {entity.RequestDate}\nTrạng thái: {entity.Status?.StatusName}\n\nNội dung:\n{entity.Content}";

            var response = ShowInputDialog("Nhập phản hồi cho yêu cầu", detail);
            if (response == null) return; // user cancelled

            var ok = await _requirementRepo.AddResponseAndMarkAnsweredAsync(requirementId, response);
            if (ok)
            {
                await LoadDataAsync();
                MessageBox.Show("Đã gửi phản hồi và cập nhật trạng thái 'Đã trả lời'", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể cập nhật yêu cầu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string? ShowInputDialog(string title, string detail)
        {
            using var form = new Form();
            form.Text = title;
            form.Width = 700;
            form.Height = 500;
            form.StartPosition = FormStartPosition.CenterParent;

            var textDetail = new TextBox { Multiline = true, ReadOnly = true, Left = 10, Top = 10, Width = 660, Height = 260, ScrollBars = ScrollBars.Vertical, Text = detail };
            var textResponse = new TextBox { Multiline = true, Left = 10, Top = 280, Width = 660, Height = 140, ScrollBars = ScrollBars.Vertical };
            var buttonOk = new Button { Text = "Gửi phản hồi", Left = 480, Top = 430, Width = 90, DialogResult = DialogResult.OK };
            var buttonCancel = new Button { Text = "Hủy", Left = 580, Top = 430, Width = 90, DialogResult = DialogResult.Cancel };

            form.Controls.Add(textDetail);
            form.Controls.Add(textResponse);
            form.Controls.Add(buttonOk);
            form.Controls.Add(buttonCancel);

            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            return form.ShowDialog(this) == DialogResult.OK ? textResponse.Text : null;
        }

        private void buttonManageProducts_Click(object sender, EventArgs e)
        {
            Navigator.Navigate(new ProductManagementPage());
        }

        private void buttonManageInventory_Click(object sender, EventArgs e)
        {
            Navigator.Navigate(new InventoryManagementPage());
        }

        private void buttonManageCategories_Click(object sender, EventArgs e)
        {
            Navigator.Navigate(new CategoryManagementPage());
        }

        private void buttonManageOrders_Click(object sender, EventArgs e)
        {
            Navigator.Navigate(new OrderManagementPage());
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            Navigator.Navigate(new ReportsPage());
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Presentation.Auth.UserSession.Clear();
            Navigator.Navigate(new Customer.LoginForm());
        }

        private void buttonAdminHome_Click(object sender, EventArgs e)
        {
            Navigator.Navigate(new AdminHomePage());
        }

        private void buttonAdminCSKH_Click(object sender, EventArgs e)
        {
            // already here; optionally reload
            _ = LoadDataAsync();
        }
    }
}
