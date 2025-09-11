using System;
using System.Windows.Forms;

namespace Presentation.Pages.Admin
{
    public partial class ResponseDialogForm : Form
    {
        public string? ResponseText { get; private set; }
        public string? CustomerName { get => textBoxCustomerName.Text; set => textBoxCustomerName.Text = value; }
        public string? UserId { get => textBoxUserId.Text; set => textBoxUserId.Text = value; }
        public DateTime RequestDate { set => dateTimePickerRequestDate.Value = value; }
        public string? Status { get => textBoxStatus.Text; set => textBoxStatus.Text = value; }
        public string? Content { get => textBoxContent.Text; set => textBoxContent.Text = value; }

        public ResponseDialogForm(string title, string detail)
        {
            InitializeComponent();
            this.Text = title;
            // Keep compatibility if a detail string is passed in
            if (!string.IsNullOrEmpty(detail))
            {
                var nl = System.Environment.NewLine;
                textBoxContent.Text = detail.Replace("\r\n", nl).Replace("\n", nl);
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            ResponseText = textBoxResponse.Text?.Trim();
            if (string.IsNullOrEmpty(ResponseText))
            {
                MessageBox.Show("Vui lòng nhập nội dung phản hồi.", "Thiếu nội dung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}


