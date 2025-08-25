using Customer.Services;

namespace Customer.Admin
{
    public partial class RestockForm : Form
    {
        private readonly InventoryService _inventoryService;
        private readonly int _productId;
        private readonly string _productName;

        public RestockForm(int productId, string productName)
        {
            InitializeComponent();
            _inventoryService = new InventoryService();
            _productId = productId;
            _productName = productName;
            InitializeForm();
        }

        private void InitializeForm()
        {
            labelProductName.Text = $"S?n ph?m: {_productName}";
            numericUpDownQuantity.Minimum = 1;
            numericUpDownQuantity.Maximum = 9999;
            numericUpDownQuantity.Value = 1;
            numericUpDownQuantity.Focus();
        }

        private void buttonRestock_Click(object sender, EventArgs e)
        {
            var quantity = (int)numericUpDownQuantity.Value;
            var note = textBoxNote.Text.Trim();

            if (quantity <= 0)
            {
                MessageBox.Show("S? lý?ng nh?p ph?i l?n hõn 0!", "L?i",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show(
                $"Xác nh?n nh?p {quantity} s?n ph?m '{_productName}'?",
                "Xác nh?n nh?p hàng",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (_inventoryService.ProcessRestock(_productId, quantity, out string errorMessage))
                {
                    MessageBox.Show($"Nh?p hàng thành công!\nÐ? nh?p {quantity} s?n ph?m.", 
                        "Thành công",
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                    
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"L?i khi nh?p hàng: {errorMessage}", "L?i",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void numericUpDownQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                buttonRestock_Click(sender, e);
            }
        }

        private void RestockForm_Load(object sender, EventArgs e)
        {
            numericUpDownQuantity.Select();
        }
    }
}