namespace Customer.Admin
{
    partial class ProductManagementForm
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
            panelTop = new Panel();
            labelTitle = new Label();
            panelSearch = new Panel();
            buttonRefresh = new Button();
            comboBoxCategory = new ComboBox();
            label2 = new Label();
            textBoxSearch = new TextBox();
            label1 = new Label();
            panelButtons = new Panel();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonAdd = new Button();
            dataGridViewProducts = new DataGridView();
            panelTop.SuspendLayout();
            panelSearch.SuspendLayout();
            panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(44, 62, 80);
            panelTop.Controls.Add(labelTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1200, 80);
            panelTop.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(20, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(282, 46);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Quản lý sản phẩm";
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.FromArgb(236, 240, 241);
            panelSearch.Controls.Add(buttonRefresh);
            panelSearch.Controls.Add(comboBoxCategory);
            panelSearch.Controls.Add(label2);
            panelSearch.Controls.Add(textBoxSearch);
            panelSearch.Controls.Add(label1);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(0, 80);
            panelSearch.Name = "panelSearch";
            panelSearch.Padding = new Padding(20);
            panelSearch.Size = new Size(1200, 100);
            panelSearch.TabIndex = 1;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.FromArgb(52, 152, 219);
            buttonRefresh.FlatAppearance.BorderSize = 0;
            buttonRefresh.FlatStyle = FlatStyle.Flat;
            buttonRefresh.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            buttonRefresh.ForeColor = Color.White;
            buttonRefresh.Location = new Point(680, 40);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(100, 35);
            buttonRefresh.TabIndex = 4;
            buttonRefresh.Text = "🔄 Làm mới";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.Font = new Font("Microsoft Sans Serif", 10F);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(480, 45);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(180, 31);
            comboBoxCategory.TabIndex = 3;
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label2.Location = new Point(480, 20);
            label2.Name = "label2";
            label2.Size = new Size(94, 23);
            label2.TabIndex = 2;
            label2.Text = "Danh mục:";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Microsoft Sans Serif", 10F);
            textBoxSearch.Location = new Point(20, 45);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Nhập tên sản phẩm, mô tả...";
            textBoxSearch.Size = new Size(400, 30);
            textBoxSearch.TabIndex = 1;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(85, 23);
            label1.TabIndex = 0;
            label1.Text = "Tìm kiếm:";
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(236, 240, 241);
            panelButtons.Controls.Add(buttonDelete);
            panelButtons.Controls.Add(buttonEdit);
            panelButtons.Controls.Add(buttonAdd);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 600);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(20);
            panelButtons.Size = new Size(1200, 80);
            panelButtons.TabIndex = 2;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(231, 76, 60);
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(280, 20);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(120, 40);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "🗑️ Xóa";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(243, 156, 18);
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            buttonEdit.ForeColor = Color.White;
            buttonEdit.Location = new Point(150, 20);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(120, 40);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "✏️ Sửa";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(46, 204, 113);
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(20, 20);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(120, 40);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "➕ Thêm";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToDeleteRows = false;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts.BackgroundColor = Color.White;
            dataGridViewProducts.BorderStyle = BorderStyle.None;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Dock = DockStyle.Fill;
            dataGridViewProducts.Location = new Point(0, 180);
            dataGridViewProducts.MultiSelect = false;
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.Size = new Size(1200, 420);
            dataGridViewProducts.TabIndex = 3;
            dataGridViewProducts.CellDoubleClick += dataGridViewProducts_CellDoubleClick;
            // 
            // ProductManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 680);
            Controls.Add(dataGridViewProducts);
            Controls.Add(panelButtons);
            Controls.Add(panelSearch);
            Controls.Add(panelTop);
            Name = "ProductManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sản phẩm - HeartSteel Cosmetic";
            Load += ProductManagementForm_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label labelTitle;
        private Panel panelSearch;
        private TextBox textBoxSearch;
        private Label label1;
        private ComboBox comboBoxCategory;
        private Label label2;
        private Button buttonRefresh;
        private Panel panelButtons;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private DataGridView dataGridViewProducts;
    }
}