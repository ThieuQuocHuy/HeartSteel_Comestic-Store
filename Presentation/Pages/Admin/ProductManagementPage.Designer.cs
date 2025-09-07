namespace Presentation.Pages.Admin
{
    partial class ProductManagementPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSidebar = new Panel();
            buttonManageOrders = new Button();
            pictureBoxLogo = new PictureBox();
            buttonManageProducts = new Button();
            buttonManageInventory = new Button();
            buttonManageCategories = new Button();
            buttonReports = new Button();
            buttonLogout = new Button();
            panelMain = new Panel();
            panelProductDetails = new Panel();
            groupBoxProductInfo = new GroupBox();
            textBoxDescription = new TextBox();
            labelDescription = new Label();
            buttonChangeImage = new Button();
            labelProductImage = new Label();
            numericUpDownSellPrice = new NumericUpDown();
            labelSellPrice = new Label();
            numericUpDownCostPrice = new NumericUpDown();
            labelCostPrice = new Label();
            comboBoxProductCategory = new ComboBox();
            labelProductCategory = new Label();
            textBoxProductName = new TextBox();
            labelProductName = new Label();
            textBoxProductId = new TextBox();
            labelProductId = new Label();
            buttonSave = new Button();
            buttonCancel = new Button();
            dataGridViewProducts = new DataGridView();
            panelActions = new Panel();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonRefresh = new Button();
            panelSearch = new Panel();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            comboBoxCategory = new ComboBox();
            labelCategory = new Label();
            labelSearch = new Label();
            panelHeader = new Panel();
            labelTitle = new Label();
            buttonAdminCSKH = new Button();
            buttonAdminHome = new Button();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelMain.SuspendLayout();
            panelProductDetails.SuspendLayout();
            groupBoxProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSellPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCostPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            panelActions.SuspendLayout();
            panelSearch.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(77, 58, 41);
            panelSidebar.Controls.Add(buttonAdminHome);
            panelSidebar.Controls.Add(buttonAdminCSKH);
            panelSidebar.Controls.Add(buttonManageOrders);
            panelSidebar.Controls.Add(pictureBoxLogo);
            panelSidebar.Controls.Add(buttonManageProducts);
            panelSidebar.Controls.Add(buttonManageInventory);
            panelSidebar.Controls.Add(buttonManageCategories);
            panelSidebar.Controls.Add(buttonReports);
            panelSidebar.Controls.Add(buttonLogout);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(219, 707);
            panelSidebar.TabIndex = 0;
            // 
            // buttonManageOrders
            // 
            buttonManageOrders.BackColor = Color.FromArgb(95, 76, 59);
            buttonManageOrders.FlatAppearance.BorderSize = 0;
            buttonManageOrders.FlatStyle = FlatStyle.Flat;
            buttonManageOrders.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonManageOrders.ForeColor = Color.White;
            buttonManageOrders.Location = new Point(10, 390);
            buttonManageOrders.Name = "buttonManageOrders";
            buttonManageOrders.Padding = new Padding(5, 0, 0, 0);
            buttonManageOrders.Size = new Size(200, 51);
            buttonManageOrders.TabIndex = 8;
            buttonManageOrders.Text = "📜 Quản lý đơn hàng\r\n";
            buttonManageOrders.TextAlign = ContentAlignment.MiddleLeft;
            buttonManageOrders.UseVisualStyleBackColor = false;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Location = new Point(10, 11);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(200, 120);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // buttonManageProducts
            // 
            buttonManageProducts.BackColor = Color.FromArgb(221, 207, 182);
            buttonManageProducts.FlatAppearance.BorderSize = 0;
            buttonManageProducts.FlatStyle = FlatStyle.Flat;
            buttonManageProducts.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonManageProducts.ForeColor = Color.FromArgb(77, 58, 41);
            buttonManageProducts.Location = new Point(10, 210);
            buttonManageProducts.Name = "buttonManageProducts";
            buttonManageProducts.Padding = new Padding(5, 0, 0, 0);
            buttonManageProducts.Size = new Size(200, 51);
            buttonManageProducts.TabIndex = 1;
            buttonManageProducts.Text = "📦 Quản lý sản phẩm";
            buttonManageProducts.TextAlign = ContentAlignment.MiddleLeft;
            buttonManageProducts.UseVisualStyleBackColor = false;
            buttonManageProducts.Click += buttonManageProducts_Click;
            // 
            // buttonManageInventory
            // 
            buttonManageInventory.BackColor = Color.FromArgb(95, 76, 59);
            buttonManageInventory.FlatAppearance.BorderSize = 0;
            buttonManageInventory.FlatStyle = FlatStyle.Flat;
            buttonManageInventory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonManageInventory.ForeColor = Color.White;
            buttonManageInventory.Location = new Point(10, 270);
            buttonManageInventory.Name = "buttonManageInventory";
            buttonManageInventory.Padding = new Padding(5, 0, 0, 0);
            buttonManageInventory.Size = new Size(200, 51);
            buttonManageInventory.TabIndex = 2;
            buttonManageInventory.Text = "📊 Quản lý kho hàng";
            buttonManageInventory.TextAlign = ContentAlignment.MiddleLeft;
            buttonManageInventory.UseVisualStyleBackColor = false;
            buttonManageInventory.Click += buttonManageInventory_Click;
            // 
            // buttonManageCategories
            // 
            buttonManageCategories.BackColor = Color.FromArgb(95, 76, 59);
            buttonManageCategories.FlatAppearance.BorderSize = 0;
            buttonManageCategories.FlatStyle = FlatStyle.Flat;
            buttonManageCategories.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonManageCategories.ForeColor = Color.White;
            buttonManageCategories.Location = new Point(10, 330);
            buttonManageCategories.Name = "buttonManageCategories";
            buttonManageCategories.Padding = new Padding(5, 0, 0, 0);
            buttonManageCategories.Size = new Size(200, 51);
            buttonManageCategories.TabIndex = 3;
            buttonManageCategories.Text = "📂 Quản lý danh mục";
            buttonManageCategories.TextAlign = ContentAlignment.MiddleLeft;
            buttonManageCategories.UseVisualStyleBackColor = false;
            // 
            // buttonReports
            // 
            buttonReports.BackColor = Color.FromArgb(95, 76, 59);
            buttonReports.FlatAppearance.BorderSize = 0;
            buttonReports.FlatStyle = FlatStyle.Flat;
            buttonReports.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonReports.ForeColor = Color.White;
            buttonReports.Location = new Point(10, 450);
            buttonReports.Name = "buttonReports";
            buttonReports.Padding = new Padding(5, 0, 0, 0);
            buttonReports.Size = new Size(200, 51);
            buttonReports.TabIndex = 4;
            buttonReports.Text = "📈 Báo cáo";
            buttonReports.TextAlign = ContentAlignment.MiddleLeft;
            buttonReports.UseVisualStyleBackColor = false;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.FromArgb(184, 84, 84);
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonLogout.ForeColor = Color.White;
            buttonLogout.Location = new Point(10, 629);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Padding = new Padding(5, 0, 0, 0);
            buttonLogout.Size = new Size(200, 51);
            buttonLogout.TabIndex = 5;
            buttonLogout.Text = "🚪 Đăng xuất";
            buttonLogout.TextAlign = ContentAlignment.MiddleLeft;
            buttonLogout.UseVisualStyleBackColor = false;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panelProductDetails);
            panelMain.Controls.Add(dataGridViewProducts);
            panelMain.Controls.Add(panelActions);
            panelMain.Controls.Add(panelSearch);
            panelMain.Controls.Add(panelHeader);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(219, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1184, 707);
            panelMain.TabIndex = 1;
            // 
            // panelProductDetails
            // 
            panelProductDetails.BackColor = Color.FromArgb(250, 245, 238);
            panelProductDetails.Controls.Add(groupBoxProductInfo);
            panelProductDetails.Controls.Add(buttonSave);
            panelProductDetails.Controls.Add(buttonCancel);
            panelProductDetails.Dock = DockStyle.Fill;
            panelProductDetails.Location = new Point(680, 209);
            panelProductDetails.Name = "panelProductDetails";
            panelProductDetails.Padding = new Padding(21, 20, 21, 20);
            panelProductDetails.Size = new Size(504, 498);
            panelProductDetails.TabIndex = 4;
            // 
            // groupBoxProductInfo
            // 
            groupBoxProductInfo.Controls.Add(textBoxDescription);
            groupBoxProductInfo.Controls.Add(labelDescription);
            groupBoxProductInfo.Controls.Add(buttonChangeImage);
            groupBoxProductInfo.Controls.Add(labelProductImage);
            groupBoxProductInfo.Controls.Add(numericUpDownSellPrice);
            groupBoxProductInfo.Controls.Add(labelSellPrice);
            groupBoxProductInfo.Controls.Add(numericUpDownCostPrice);
            groupBoxProductInfo.Controls.Add(labelCostPrice);
            groupBoxProductInfo.Controls.Add(comboBoxProductCategory);
            groupBoxProductInfo.Controls.Add(labelProductCategory);
            groupBoxProductInfo.Controls.Add(textBoxProductName);
            groupBoxProductInfo.Controls.Add(labelProductName);
            groupBoxProductInfo.Controls.Add(textBoxProductId);
            groupBoxProductInfo.Controls.Add(labelProductId);
            groupBoxProductInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBoxProductInfo.Location = new Point(23, 23);
            groupBoxProductInfo.Name = "groupBoxProductInfo";
            groupBoxProductInfo.Size = new Size(454, 380);
            groupBoxProductInfo.TabIndex = 0;
            groupBoxProductInfo.TabStop = false;
            groupBoxProductInfo.Text = "Thông tin sản phẩm";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Font = new Font("Segoe UI", 10F);
            textBoxDescription.Location = new Point(21, 291);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.PlaceholderText = "Nhập mô tả sản phẩm...";
            textBoxDescription.Size = new Size(410, 71);
            textBoxDescription.TabIndex = 13;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelDescription.Location = new Point(21, 264);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(62, 23);
            labelDescription.TabIndex = 12;
            labelDescription.Text = "Mô tả:";
            // 
            // buttonChangeImage
            // 
            buttonChangeImage.BackColor = Color.FromArgb(74, 144, 226);
            buttonChangeImage.FlatAppearance.BorderSize = 0;
            buttonChangeImage.FlatStyle = FlatStyle.Flat;
            buttonChangeImage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonChangeImage.ForeColor = Color.White;
            buttonChangeImage.Location = new Point(231, 223);
            buttonChangeImage.Name = "buttonChangeImage";
            buttonChangeImage.Size = new Size(200, 48);
            buttonChangeImage.TabIndex = 11;
            buttonChangeImage.Text = "🖼️ Thay đổi hình ảnh";
            buttonChangeImage.UseVisualStyleBackColor = false;
            buttonChangeImage.Click += buttonChangeImage_Click;
            // 
            // labelProductImage
            // 
            labelProductImage.AutoSize = true;
            labelProductImage.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelProductImage.Location = new Point(230, 195);
            labelProductImage.Name = "labelProductImage";
            labelProductImage.Size = new Size(169, 23);
            labelProductImage.TabIndex = 10;
            labelProductImage.Text = "Hình ảnh sản phẩm:";
            // 
            // numericUpDownSellPrice
            // 
            numericUpDownSellPrice.Font = new Font("Segoe UI", 10F);
            numericUpDownSellPrice.Location = new Point(21, 220);
            numericUpDownSellPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownSellPrice.Name = "numericUpDownSellPrice";
            numericUpDownSellPrice.Size = new Size(200, 30);
            numericUpDownSellPrice.TabIndex = 9;
            // 
            // labelSellPrice
            // 
            labelSellPrice.AutoSize = true;
            labelSellPrice.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelSellPrice.Location = new Point(21, 195);
            labelSellPrice.Name = "labelSellPrice";
            labelSellPrice.Size = new Size(76, 23);
            labelSellPrice.TabIndex = 8;
            labelSellPrice.Text = "Giá bán:";
            // 
            // numericUpDownCostPrice
            // 
            numericUpDownCostPrice.Font = new Font("Segoe UI", 10F);
            numericUpDownCostPrice.Location = new Point(230, 149);
            numericUpDownCostPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDownCostPrice.Name = "numericUpDownCostPrice";
            numericUpDownCostPrice.Size = new Size(200, 30);
            numericUpDownCostPrice.TabIndex = 7;
            // 
            // labelCostPrice
            // 
            labelCostPrice.AutoSize = true;
            labelCostPrice.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelCostPrice.Location = new Point(230, 124);
            labelCostPrice.Name = "labelCostPrice";
            labelCostPrice.Size = new Size(86, 23);
            labelCostPrice.TabIndex = 6;
            labelCostPrice.Text = "Giá nhập:";
            // 
            // comboBoxProductCategory
            // 
            comboBoxProductCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProductCategory.Font = new Font("Segoe UI", 10F);
            comboBoxProductCategory.FormattingEnabled = true;
            comboBoxProductCategory.Location = new Point(21, 149);
            comboBoxProductCategory.Name = "comboBoxProductCategory";
            comboBoxProductCategory.Size = new Size(201, 31);
            comboBoxProductCategory.TabIndex = 5;
            // 
            // labelProductCategory
            // 
            labelProductCategory.AutoSize = true;
            labelProductCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelProductCategory.Location = new Point(21, 124);
            labelProductCategory.Name = "labelProductCategory";
            labelProductCategory.Size = new Size(96, 23);
            labelProductCategory.TabIndex = 4;
            labelProductCategory.Text = "Danh mục:";
            // 
            // textBoxProductName
            // 
            textBoxProductName.Font = new Font("Segoe UI", 10F);
            textBoxProductName.Location = new Point(21, 80);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.PlaceholderText = "Nhập tên sản phẩm...";
            textBoxProductName.Size = new Size(410, 30);
            textBoxProductName.TabIndex = 3;
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelProductName.Location = new Point(21, 53);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(124, 23);
            labelProductName.TabIndex = 2;
            labelProductName.Text = "Tên sản phẩm:";
            // 
            // textBoxProductId
            // 
            textBoxProductId.Font = new Font("Segoe UI", 10F);
            textBoxProductId.Location = new Point(230, 80);
            textBoxProductId.Name = "textBoxProductId";
            textBoxProductId.ReadOnly = true;
            textBoxProductId.Size = new Size(201, 30);
            textBoxProductId.TabIndex = 1;
            textBoxProductId.Visible = false;
            // 
            // labelProductId
            // 
            labelProductId.AutoSize = true;
            labelProductId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelProductId.Location = new Point(230, 53);
            labelProductId.Name = "labelProductId";
            labelProductId.Size = new Size(122, 23);
            labelProductId.TabIndex = 0;
            labelProductId.Text = "Mã sản phẩm:";
            labelProductId.Visible = false;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(39, 174, 96);
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(23, 420);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(150, 45);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "💾 Lưu";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(108, 117, 125);
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(200, 420);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(150, 45);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "❌ Hủy";
            buttonCancel.UseVisualStyleBackColor = false;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToDeleteRows = false;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts.BackgroundColor = Color.White;
            dataGridViewProducts.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Dock = DockStyle.Left;
            dataGridViewProducts.Location = new Point(0, 209);
            dataGridViewProducts.MultiSelect = false;
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.Size = new Size(680, 498);
            dataGridViewProducts.TabIndex = 3;
            // 
            // panelActions
            // 
            panelActions.BackColor = Color.FromArgb(240, 240, 240);
            panelActions.BorderStyle = BorderStyle.FixedSingle;
            panelActions.Controls.Add(buttonAdd);
            panelActions.Controls.Add(buttonEdit);
            panelActions.Controls.Add(buttonDelete);
            panelActions.Controls.Add(buttonRefresh);
            panelActions.Dock = DockStyle.Top;
            panelActions.Location = new Point(0, 148);
            panelActions.Name = "panelActions";
            panelActions.Padding = new Padding(15, 11, 15, 11);
            panelActions.Size = new Size(1184, 61);
            panelActions.TabIndex = 2;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(39, 174, 96);
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(18, 15);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(120, 35);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "➕ Thêm mới";
            buttonAdd.UseVisualStyleBackColor = false;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(255, 193, 7);
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonEdit.ForeColor = Color.White;
            buttonEdit.Location = new Point(150, 15);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(120, 35);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "✏️ Sửa";
            buttonEdit.UseVisualStyleBackColor = false;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(220, 53, 69);
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(282, 15);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(120, 35);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "🗑️ Xóa";
            buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.FromArgb(74, 144, 226);
            buttonRefresh.FlatAppearance.BorderSize = 0;
            buttonRefresh.FlatStyle = FlatStyle.Flat;
            buttonRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonRefresh.ForeColor = Color.White;
            buttonRefresh.Location = new Point(414, 15);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(120, 35);
            buttonRefresh.TabIndex = 3;
            buttonRefresh.Text = "🔄 Làm mới";
            buttonRefresh.UseVisualStyleBackColor = false;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.White;
            panelSearch.BorderStyle = BorderStyle.FixedSingle;
            panelSearch.Controls.Add(textBoxSearch);
            panelSearch.Controls.Add(buttonSearch);
            panelSearch.Controls.Add(comboBoxCategory);
            panelSearch.Controls.Add(labelCategory);
            panelSearch.Controls.Add(labelSearch);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(0, 69);
            panelSearch.Name = "panelSearch";
            panelSearch.Padding = new Padding(15, 15, 15, 15);
            panelSearch.Size = new Size(1184, 79);
            panelSearch.TabIndex = 1;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 10F);
            textBoxSearch.Location = new Point(101, 25);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Tìm kiếm theo tên sản phẩm...";
            textBoxSearch.Size = new Size(250, 30);
            textBoxSearch.TabIndex = 1;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.FromArgb(74, 144, 226);
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Location = new Point(360, 20);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(101, 40);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "🔍 Tìm kiếm";
            buttonSearch.UseVisualStyleBackColor = false;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.Font = new Font("Segoe UI", 10F);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(567, 25);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(180, 31);
            comboBoxCategory.TabIndex = 3;
            comboBoxCategory.SelectedIndexChanged += comboBoxCategory_SelectedIndexChanged;
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelCategory.Location = new Point(470, 28);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(96, 23);
            labelCategory.TabIndex = 4;
            labelCategory.Text = "Danh mục:";
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelSearch.Location = new Point(18, 28);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(91, 23);
            labelSearch.TabIndex = 0;
            labelSearch.Text = "Tìm kiếm:";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(77, 58, 41);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1184, 69);
            panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(30, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(319, 41);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "📦 Quản lý sản phẩm";
            // 
            // buttonAdminCSKH
            // 
            buttonAdminCSKH.BackColor = Color.FromArgb(95, 76, 59);
            buttonAdminCSKH.FlatAppearance.BorderSize = 0;
            buttonAdminCSKH.FlatStyle = FlatStyle.Flat;
            buttonAdminCSKH.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAdminCSKH.ForeColor = Color.White;
            buttonAdminCSKH.Location = new Point(10, 510);
            buttonAdminCSKH.Name = "buttonAdminCSKH";
            buttonAdminCSKH.Padding = new Padding(5, 0, 0, 0);
            buttonAdminCSKH.Size = new Size(200, 51);
            buttonAdminCSKH.TabIndex = 9;
            buttonAdminCSKH.Text = "💬 Trang CSKH";
            buttonAdminCSKH.TextAlign = ContentAlignment.MiddleLeft;
            buttonAdminCSKH.UseVisualStyleBackColor = false;
            // 
            // buttonAdminHome
            // 
            buttonAdminHome.BackColor = Color.FromArgb(95, 76, 59);
            buttonAdminHome.FlatAppearance.BorderSize = 0;
            buttonAdminHome.FlatStyle = FlatStyle.Flat;
            buttonAdminHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAdminHome.ForeColor = Color.White;
            buttonAdminHome.Location = new Point(10, 150);
            buttonAdminHome.Name = "buttonAdminHome";
            buttonAdminHome.Padding = new Padding(5, 0, 0, 0);
            buttonAdminHome.Size = new Size(200, 51);
            buttonAdminHome.TabIndex = 10;
            buttonAdminHome.Text = "🏠 Trang chủ HeartSteel Cosmetic";
            buttonAdminHome.TextAlign = ContentAlignment.MiddleLeft;
            buttonAdminHome.UseVisualStyleBackColor = false;
            // 
            // ProductManagementPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 707);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(1421, 754);
            MinimumSize = new Size(1421, 754);
            Name = "ProductManagementPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sản phẩm - HeartSteel Cosmetic";
            panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelMain.ResumeLayout(false);
            panelProductDetails.ResumeLayout(false);
            groupBoxProductInfo.ResumeLayout(false);
            groupBoxProductInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSellPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCostPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            panelActions.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private PictureBox pictureBoxLogo;
        private Button buttonManageProducts;
        private Button buttonManageInventory;
        private Button buttonManageCategories;
        private Button buttonReports;
        private Button buttonLogout;
        private Panel panelMain;
        private Panel panelHeader;
        private Label labelTitle;
        private Panel panelSearch;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private ComboBox comboBoxCategory;
        private Label labelCategory;
        private Label labelSearch;
        private Panel panelActions;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private Button buttonRefresh;
        private DataGridView dataGridViewProducts;
        private Panel panelProductDetails;
        private GroupBox groupBoxProductInfo;
        private TextBox textBoxDescription;
        private Label labelDescription;
        private Button buttonChangeImage;
        private Label labelProductImage;
        private NumericUpDown numericUpDownSellPrice;
        private Label labelSellPrice;
        private NumericUpDown numericUpDownCostPrice;
        private Label labelCostPrice;
        private ComboBox comboBoxProductCategory;
        private Label labelProductCategory;
        private TextBox textBoxProductName;
        private Label labelProductName;
        private TextBox textBoxProductId;
        private Label labelProductId;
        private Button buttonSave;
        private Button buttonCancel;
        private Button buttonManageOrders;
        private Button buttonAdminHome;
        private Button buttonAdminCSKH;
    }
}