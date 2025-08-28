using System;
using System.Windows.Forms;

namespace Presentation.Pages.Admin
{
    public partial class AdminHomeForm : Form
    {
        private Button buttonCustomers;
        public AdminHomeForm()
        {
            InitializeComponent();
        }    
        private void InitializeComponent()
        { 
            this.buttonCustomers = new Button();
            this. SuspendLayout();
            //
            // buttonCustomers
            //
            this.buttonCustomers.Text = "Quản lý khách hàng";
            this.buttonCustomers.Width = 200;
            this.buttonCustomers.Height = 40;
            this.buttonCustomers.Top = 20;
            this.buttonCustomers.Left = 20;
            this.buttonCustomers.Click += ButtonCustomers_Click;
            //
            // AdminHomeForm
            //
            this.Text = "Trang quản trị";
            this.Width = 900;
            this.Height = 600;
            this.Controls.Add(this.buttonCustomers);
            this.ResumeLayout(false);
        }
        private void ButtonCustomers_Click(object sender, EventArgs e)
        { 
            var page = new Customer.CustomerListPage();
            page.Show();
        }
    }
}
