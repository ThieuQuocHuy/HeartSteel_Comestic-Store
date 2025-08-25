using Customer.Models;

namespace Customer.Admin
{
    public partial class ProductAddEditForm : Form
    {
        public Product Product { get; private set; }
        private bool _isEditMode;

        public ProductAddEditForm()
        {
            InitializeComponent();
            _isEditMode = false;
            Product = new Product();
            InitializeForm();
        }

        public ProductAddEditForm(Product product)
        {
            InitializeComponent();
            _isEditMode = true;
            Product = product;
            InitializeForm();
            LoadProductData();
        }

        private void InitializeForm()
        {
            this.Text = _isEditMode ? "S?a s?n ph?m" : "Thêm s?n ph?m m?i";
            labelTitle.Text = _isEditMode ? "S?a thông tin s?n ph?m" : "Thêm s?n ph?m m?i";

            // Thêm danh m?c m?u
            comboBoxCategory.Items.AddRange(new string[]
            {
                "Son môi",
                "Kem n?n",
                "Mascara",
                "Ph?n ph?",
                "Skincare",
                "T?y trang",
                "Kem dý?ng",
                "Serum"
            });

            checkBoxActive.Checked = true;
            numericUpDownStock.Minimum = 0;
            numericUpDownStock.Maximum = 999999;
            numericUpDownPrice.Minimum = 0;
            numericUpDownPrice.Maximum = 99999999;
            numericUpDownPrice.DecimalPlaces = 0;
        }

        private void LoadProductData()
        {
            if (Product != null)
            {
                textBoxName.Text = Product.Name;
                textBoxDescription.Text = Product.Description;
                numericUpDownPrice.Value = Product.Price;
                numericUpDownStock.Value = Product.Stock;
                
                if (comboBoxCategory.Items.Contains(Product.Category))
                {
                    comboBoxCategory.SelectedItem = Product.Category;
                }
                else
                {
                    comboBoxCategory.Text = Product.Category;
                }
                
                textBoxImagePath.Text = Product.ImagePath;
                checkBoxActive.Checked = Product.IsActive;
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Vui l?ng nh?p tên s?n ph?m!", "L?i", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(comboBoxCategory.Text))
            {
                MessageBox.Show("Vui l?ng ch?n ho?c nh?p danh m?c!", "L?i", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxCategory.Focus();
                return false;
            }

            if (numericUpDownPrice.Value <= 0)
            {
                MessageBox.Show("Giá s?n ph?m ph?i l?n hõn 0!", "L?i", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericUpDownPrice.Focus();
                return false;
            }

            return true;
        }

        private void SaveProduct()
        {
            Product.Name = textBoxName.Text.Trim();
            Product.Description = textBoxDescription.Text.Trim();
            Product.Price = numericUpDownPrice.Value;
            Product.Stock = (int)numericUpDownStock.Value;
            Product.Category = comboBoxCategory.Text.Trim();
            Product.ImagePath = textBoxImagePath.Text.Trim();
            Product.IsActive = checkBoxActive.Checked;

            if (!_isEditMode)
            {
                Product.CreatedDate = DateTime.Now;
            }
            Product.UpdatedDate = DateTime.Now;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                SaveProduct();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonBrowseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Ch?n h?nh ?nh s?n ph?m";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxImagePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                buttonSave_Click(sender, e);
            }
        }
    }
}