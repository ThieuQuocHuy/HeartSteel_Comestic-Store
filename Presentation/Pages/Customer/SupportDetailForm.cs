using System;
using System.Windows.Forms;

namespace Presentation.Pages.Customer
{
    public partial class SupportDetailForm : Form
    {
        public SupportDetailForm(string title, string conversation)
        {
            InitializeComponent();
            this.Text = title;
            var nl = Environment.NewLine;
            textBoxDetail.Text = (conversation ?? string.Empty).Replace("\r\n", nl).Replace("\n", nl);
        }
    }
}


