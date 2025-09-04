using System;
using System.Windows.Forms;


namespace Presentation.Pages.Admin
{
    public partial class InputDialogForm : Form
    {
        // Chỉ giữ lại thuộc tính Quantity để trả về số lượng người dùng đã nhập.
        public int Quantity { get; private set; }

        // Bỏ ProductId, CurrentStock, và _productRepository.

        public InputDialogForm(string title, string prompt)
        {
            InitializeComponent();
            this.Text = title;
            labelPrompt.Text = prompt;
        }

        // Đã đổi tên thành buttonOk_Click để nhất quán
        private void buttonOk_Click(object sender, EventArgs e)
        {
            // Chỉ kiểm tra, lấy giá trị và đóng form. KHÔNG cập nhật database ở đây.
            if (int.TryParse(textBoxInput.Text, out int quantity) && quantity > 0)
            {
                this.Quantity = quantity; // Gán giá trị để form chính có thể lấy
                this.DialogResult = DialogResult.OK; // Báo hiệu thành công
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số dương hợp lệ.", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}