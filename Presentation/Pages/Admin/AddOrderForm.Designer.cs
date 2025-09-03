namespace Presentation.Pages.Admin
{
    partial class AddOrderForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            groupBoxCustomer = new GroupBox();
            comboBoxCustomer = new ComboBox();
            groupBoxProduct = new GroupBox();
            buttonAddItem = new Button();
            numericUpDownQuantity = new NumericUpDown();
            labelQuantity = new Label();
            comboBoxProduct = new ComboBox();
            labelProduct = new Label();
            groupBoxItems = new GroupBox();
            dataGridViewItems = new DataGridView();
            panelTotal = new Panel();
            labelTotalAmount = new Label();
            labelTotalTitle = new Label();
            buttonSave = new Button();
            buttonCancel = new Button();
            groupBoxCustomer.SuspendLayout();
            groupBoxProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            groupBoxItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).BeginInit();
            panelTotal.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCustomer
            // 
            groupBoxCustomer.Controls.Add(comboBoxCustomer);
            groupBoxCustomer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxCustomer.Location = new Point(12, 15);
            groupBoxCustomer.Margin = new Padding(3, 4, 3, 4);
            groupBoxCustomer.Name = "groupBoxCustomer";
            groupBoxCustomer.Padding = new Padding(3, 4, 3, 4);
            groupBoxCustomer.Size = new Size(760, 100);
            groupBoxCustomer.TabIndex = 0;
            groupBoxCustomer.TabStop = false;
            groupBoxCustomer.Text = "Chọn khách hàng";
            // 
            // comboBoxCustomer
            // 
            comboBoxCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxCustomer.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxCustomer.Font = new Font("Segoe UI", 10F);
            comboBoxCustomer.FormattingEnabled = true;
            comboBoxCustomer.Location = new Point(15, 38);
            comboBoxCustomer.Margin = new Padding(3, 4, 3, 4);
            comboBoxCustomer.Name = "comboBoxCustomer";
            comboBoxCustomer.Size = new Size(725, 31);
            comboBoxCustomer.TabIndex = 0;
            // 
            // groupBoxProduct
            // 
            groupBoxProduct.Controls.Add(buttonAddItem);
            groupBoxProduct.Controls.Add(numericUpDownQuantity);
            groupBoxProduct.Controls.Add(labelQuantity);
            groupBoxProduct.Controls.Add(comboBoxProduct);
            groupBoxProduct.Controls.Add(labelProduct);
            groupBoxProduct.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxProduct.Location = new Point(12, 122);
            groupBoxProduct.Margin = new Padding(3, 4, 3, 4);
            groupBoxProduct.Name = "groupBoxProduct";
            groupBoxProduct.Padding = new Padding(3, 4, 3, 4);
            groupBoxProduct.Size = new Size(760, 125);
            groupBoxProduct.TabIndex = 1;
            groupBoxProduct.TabStop = false;
            groupBoxProduct.Text = "Thêm sản phẩm";
            // 
            // buttonAddItem
            // 
            buttonAddItem.BackColor = Color.FromArgb(0, 123, 255);
            buttonAddItem.ForeColor = Color.White;
            buttonAddItem.Location = new Point(590, 60);
            buttonAddItem.Margin = new Padding(3, 4, 3, 4);
            buttonAddItem.Name = "buttonAddItem";
            buttonAddItem.Size = new Size(150, 44);
            buttonAddItem.TabIndex = 4;
            buttonAddItem.Text = "➕ Thêm";
            buttonAddItem.UseVisualStyleBackColor = false;
            buttonAddItem.Click += buttonAddItem_Click;
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Font = new Font("Segoe UI", 10F);
            numericUpDownQuantity.Location = new Point(440, 62);
            numericUpDownQuantity.Margin = new Padding(3, 4, 3, 4);
            numericUpDownQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(120, 30);
            numericUpDownQuantity.TabIndex = 3;
            numericUpDownQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Location = new Point(436, 31);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(88, 23);
            labelQuantity.TabIndex = 2;
            labelQuantity.Text = "Số lượng:";
            // 
            // comboBoxProduct
            // 
            comboBoxProduct.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxProduct.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxProduct.Font = new Font("Segoe UI", 10F);
            comboBoxProduct.FormattingEnabled = true;
            comboBoxProduct.Location = new Point(15, 62);
            comboBoxProduct.Margin = new Padding(3, 4, 3, 4);
            comboBoxProduct.Name = "comboBoxProduct";
            comboBoxProduct.Size = new Size(400, 31);
            comboBoxProduct.TabIndex = 1;
            // 
            // labelProduct
            // 
            labelProduct.AutoSize = true;
            labelProduct.Location = new Point(15, 31);
            labelProduct.Name = "labelProduct";
            labelProduct.Size = new Size(95, 23);
            labelProduct.TabIndex = 0;
            labelProduct.Text = "Sản phẩm:";
            // 
            // groupBoxItems
            // 
            groupBoxItems.Controls.Add(dataGridViewItems);
            groupBoxItems.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxItems.Location = new Point(12, 255);
            groupBoxItems.Margin = new Padding(3, 4, 3, 4);
            groupBoxItems.Name = "groupBoxItems";
            groupBoxItems.Padding = new Padding(3, 4, 3, 4);
            groupBoxItems.Size = new Size(760, 350);
            groupBoxItems.TabIndex = 2;
            groupBoxItems.TabStop = false;
            groupBoxItems.Text = "Chi tiết đơn hàng";
            // 
            // dataGridViewItems
            // 
            dataGridViewItems.AllowUserToAddRows = false;
            dataGridViewItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItems.Dock = DockStyle.Fill;
            dataGridViewItems.Location = new Point(3, 27);
            dataGridViewItems.Margin = new Padding(3, 4, 3, 4);
            dataGridViewItems.Name = "dataGridViewItems";
            dataGridViewItems.RowHeadersWidth = 51;
            dataGridViewItems.Size = new Size(754, 319);
            dataGridViewItems.TabIndex = 0;
            dataGridViewItems.CellValueChanged += dataGridViewItems_CellValueChanged;
            dataGridViewItems.RowsAdded += dataGridViewItems_RowsAdded;
            dataGridViewItems.RowsRemoved += dataGridViewItems_RowsRemoved;
            // 
            // panelTotal
            // 
            panelTotal.Controls.Add(labelTotalAmount);
            panelTotal.Controls.Add(labelTotalTitle);
            panelTotal.Location = new Point(12, 612);
            panelTotal.Margin = new Padding(3, 4, 3, 4);
            panelTotal.Name = "panelTotal";
            panelTotal.Size = new Size(760, 62);
            panelTotal.TabIndex = 3;
            // 
            // labelTotalAmount
            // 
            labelTotalAmount.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTotalAmount.ForeColor = Color.Firebrick;
            labelTotalAmount.Location = new Point(440, 12);
            labelTotalAmount.Name = "labelTotalAmount";
            labelTotalAmount.Size = new Size(300, 40);
            labelTotalAmount.TabIndex = 1;
            labelTotalAmount.Text = "0";
            labelTotalAmount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelTotalTitle
            // 
            labelTotalTitle.AutoSize = true;
            labelTotalTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTotalTitle.Location = new Point(15, 15);
            labelTotalTitle.Name = "labelTotalTitle";
            labelTotalTitle.Size = new Size(108, 28);
            labelTotalTitle.TabIndex = 0;
            labelTotalTitle.Text = "Tổng tiền:";
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(40, 167, 69);
            buttonSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(482, 694);
            buttonSave.Margin = new Padding(3, 4, 3, 4);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(140, 56);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "💾 Lưu";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(108, 117, 125);
            buttonCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(632, 694);
            buttonCancel.Margin = new Padding(3, 4, 3, 4);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(140, 56);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "❌ Hủy";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // AddOrderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 764);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(panelTotal);
            Controls.Add(groupBoxItems);
            Controls.Add(groupBoxProduct);
            Controls.Add(groupBoxCustomer);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddOrderForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Thêm đơn hàng mới";
            Load += AddOrderForm_Load;
            groupBoxCustomer.ResumeLayout(false);
            groupBoxProduct.ResumeLayout(false);
            groupBoxProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            groupBoxItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).EndInit();
            panelTotal.ResumeLayout(false);
            panelTotal.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.GroupBox groupBoxProduct;
        private System.Windows.Forms.Label labelProduct;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.GroupBox groupBoxItems;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label labelTotalTitle;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}