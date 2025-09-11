using System;
using System.Windows.Forms;

namespace Presentation.Pages.Customer
{
    public partial class SupportDetailForm : Form
    {
        public string CustomerName { get => labelCustomerValue.Text; set => labelCustomerValue.Text = value; }
        public string UserId { get => labelUserIdValue.Text; set => labelUserIdValue.Text = value; }
        public string StatusText { get => labelStatusValue.Text; set => labelStatusValue.Text = value; }
        public DateTime RequestDate { set => labelDateValue.Text = value.ToString("dd/MM/yyyy HH:mm"); }
        public string Conversation { get => textBoxDetail.Text; set => textBoxDetail.Text = (value ?? string.Empty).Replace("\r\n", Environment.NewLine).Replace("\n", Environment.NewLine); }

        public SupportDetailForm(string title, string conversation)
        {
            InitializeComponent();
            this.Text = title;
            Conversation = conversation;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


