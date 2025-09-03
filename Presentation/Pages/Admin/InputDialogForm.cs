using System;
using System.Windows.Forms;

namespace Presentation.Pages.Admin
{
    public partial class InputDialogForm : Form
    {
        public int Quantity { get; private set; }

        public InputDialogForm(string title, string prompt)
        {
            InitializeComponent();
            this.Text = title;
            labelPrompt.Text = prompt;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxInput.Text, out int quantity) && quantity > 0)
            {
                Quantity = quantity;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số dương hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}