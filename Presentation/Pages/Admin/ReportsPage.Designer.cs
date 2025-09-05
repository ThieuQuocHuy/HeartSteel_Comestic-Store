namespace Presentation.Pages.Admin
{
    partial class ReportsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsPage));
            panelSidebar = new Panel();
            buttonManageOrders = new Button();
            pictureBoxLogo = new PictureBox();
            buttonManageProducts = new Button();
            buttonManageInventory = new Button();
            buttonManageCategories = new Button();
            buttonReports = new Button();
            buttonLogout = new Button();
            panelMain = new Panel();
            tabControlReports = new TabControl();
            tabPageRevenue = new TabPage();
            panelRevenueSummary = new Panel();
            labelAverageOrder = new Label();
            labelTotalOrders = new Label();
            labelTotalRevenue = new Label();
            dataGridViewRevenue = new DataGridView();
            panelRevenueFilter = new Panel();
            buttonExportRevenuePDF = new Button();
            buttonExportRevenueExcel = new Button();
            buttonGenerateRevenue = new Button();
            labelRevenueTo = new Label();
            labelRevenueFrom = new Label();
            dateTimePickerRevenueTo = new DateTimePicker();
            dateTimePickerRevenueFrom = new DateTimePicker();
            labelRevenueTitle = new Label();
            tabPageProducts = new TabPage();
            panelProductSummary = new Panel();
            labelTopSellingProduct = new Label();
            labelLowStockProducts = new Label();
            labelTotalProducts = new Label();
            dataGridViewProducts = new DataGridView();
            panelProductFilter = new Panel();
            buttonExportProductPDF = new Button();
            buttonExportProductExcel = new Button();
            buttonGenerateProduct = new Button();
            labelProductCategory = new Label();
            comboBoxProductCategory = new ComboBox();
            labelProductTitle = new Label();
            tabPageInventory = new TabPage();
            panelInventorySummary = new Panel();
            labelOutOfStockCount = new Label();
            labelLowStockCount = new Label();
            labelTotalStockValue = new Label();
            dataGridViewInventory = new DataGridView();
            panelInventoryFilter = new Panel();
            buttonExportInventoryPDF = new Button();
            buttonExportInventoryExcel = new Button();
            buttonGenerateInventory = new Button();
            labelStockThreshold = new Label();
            numericUpDownStockThreshold = new NumericUpDown();
            checkBoxShowLowStock = new CheckBox();
            labelInventoryTitle = new Label();
            panelHeader = new Panel();
            labelTitle = new Label();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelMain.SuspendLayout();
            tabControlReports.SuspendLayout();
            tabPageRevenue.SuspendLayout();
            panelRevenueSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRevenue).BeginInit();
            panelRevenueFilter.SuspendLayout();
            tabPageProducts.SuspendLayout();
            panelProductSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            panelProductFilter.SuspendLayout();
            tabPageInventory.SuspendLayout();
            panelInventorySummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).BeginInit();
            panelInventoryFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStockThreshold).BeginInit();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(77, 58, 41);
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
            panelSidebar.Size = new Size(220, 709);
            panelSidebar.TabIndex = 0;
            // 
            // buttonManageOrders
            // 
            buttonManageOrders.BackColor = Color.FromArgb(95, 76, 59);
            buttonManageOrders.FlatAppearance.BorderSize = 0;
            buttonManageOrders.FlatStyle = FlatStyle.Flat;
            buttonManageOrders.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonManageOrders.ForeColor = Color.White;
            buttonManageOrders.Location = new Point(10, 330);
            buttonManageOrders.Name = "buttonManageOrders";
            buttonManageOrders.Padding = new Padding(5, 0, 0, 0);
            buttonManageOrders.Size = new Size(200, 50);
            buttonManageOrders.TabIndex = 8;
            buttonManageOrders.Text = "📜 Quản lý đơn hàng\r\n";
            buttonManageOrders.TextAlign = ContentAlignment.MiddleLeft;
            buttonManageOrders.UseVisualStyleBackColor = false;
            buttonManageOrders.Click += buttonManageOrders_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(10, 10);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(200, 120);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // buttonManageProducts
            // 
            buttonManageProducts.BackColor = Color.FromArgb(95, 76, 59);
            buttonManageProducts.FlatAppearance.BorderSize = 0;
            buttonManageProducts.FlatStyle = FlatStyle.Flat;
            buttonManageProducts.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonManageProducts.ForeColor = Color.White;
            buttonManageProducts.Location = new Point(10, 150);
            buttonManageProducts.Name = "buttonManageProducts";
            buttonManageProducts.Padding = new Padding(5, 0, 0, 0);
            buttonManageProducts.Size = new Size(200, 50);
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
            buttonManageInventory.Location = new Point(10, 210);
            buttonManageInventory.Name = "buttonManageInventory";
            buttonManageInventory.Padding = new Padding(5, 0, 0, 0);
            buttonManageInventory.Size = new Size(200, 50);
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
            buttonManageCategories.Location = new Point(10, 270);
            buttonManageCategories.Name = "buttonManageCategories";
            buttonManageCategories.Padding = new Padding(5, 0, 0, 0);
            buttonManageCategories.Size = new Size(200, 50);
            buttonManageCategories.TabIndex = 3;
            buttonManageCategories.Text = "📂 Quản lý danh mục";
            buttonManageCategories.TextAlign = ContentAlignment.MiddleLeft;
            buttonManageCategories.UseVisualStyleBackColor = false;
            buttonManageCategories.Click += buttonManageCategories_Click;
            // 
            // buttonReports
            // 
            buttonReports.BackColor = Color.FromArgb(221, 207, 182);
            buttonReports.FlatAppearance.BorderSize = 0;
            buttonReports.FlatStyle = FlatStyle.Flat;
            buttonReports.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonReports.ForeColor = Color.FromArgb(77, 58, 41);
            buttonReports.Location = new Point(10, 390);
            buttonReports.Name = "buttonReports";
            buttonReports.Padding = new Padding(5, 0, 0, 0);
            buttonReports.Size = new Size(200, 50);
            buttonReports.TabIndex = 4;
            buttonReports.Text = "📈 Báo cáo";
            buttonReports.TextAlign = ContentAlignment.MiddleLeft;
            buttonReports.UseVisualStyleBackColor = false;
            buttonReports.Click += buttonReports_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.FromArgb(184, 84, 84);
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonLogout.ForeColor = Color.White;
            buttonLogout.Location = new Point(10, 630);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Padding = new Padding(5, 0, 0, 0);
            buttonLogout.Size = new Size(200, 50);
            buttonLogout.TabIndex = 5;
            buttonLogout.Text = "🚪 Đăng xuất";
            buttonLogout.TextAlign = ContentAlignment.MiddleLeft;
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(tabControlReports);
            panelMain.Controls.Add(panelHeader);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(220, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1184, 709);
            panelMain.TabIndex = 1;
            // 
            // tabControlReports
            // 
            tabControlReports.Controls.Add(tabPageRevenue);
            tabControlReports.Controls.Add(tabPageProducts);
            tabControlReports.Controls.Add(tabPageInventory);
            tabControlReports.Dock = DockStyle.Fill;
            tabControlReports.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tabControlReports.Location = new Point(0, 70);
            tabControlReports.Name = "tabControlReports";
            tabControlReports.SelectedIndex = 0;
            tabControlReports.Size = new Size(1184, 639);
            tabControlReports.TabIndex = 1;
            // 
            // tabPageRevenue
            // 
            tabPageRevenue.BackColor = Color.FromArgb(250, 245, 238);
            tabPageRevenue.Controls.Add(panelRevenueSummary);
            tabPageRevenue.Controls.Add(dataGridViewRevenue);
            tabPageRevenue.Controls.Add(panelRevenueFilter);
            tabPageRevenue.Location = new Point(4, 32);
            tabPageRevenue.Name = "tabPageRevenue";
            tabPageRevenue.Padding = new Padding(3);
            tabPageRevenue.Size = new Size(1176, 603);
            tabPageRevenue.TabIndex = 0;
            tabPageRevenue.Text = "💰 Báo cáo doanh thu";
            // 
            // panelRevenueSummary
            // 
            panelRevenueSummary.BackColor = Color.White;
            panelRevenueSummary.BorderStyle = BorderStyle.FixedSingle;
            panelRevenueSummary.Controls.Add(labelAverageOrder);
            panelRevenueSummary.Controls.Add(labelTotalOrders);
            panelRevenueSummary.Controls.Add(labelTotalRevenue);
            panelRevenueSummary.Dock = DockStyle.Bottom;
            panelRevenueSummary.Location = new Point(3, 500);
            panelRevenueSummary.Name = "panelRevenueSummary";
            panelRevenueSummary.Padding = new Padding(15);
            panelRevenueSummary.Size = new Size(1170, 100);
            panelRevenueSummary.TabIndex = 2;
            // 
            // labelAverageOrder
            // 
            labelAverageOrder.AutoSize = true;
            labelAverageOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelAverageOrder.ForeColor = Color.FromArgb(230, 126, 34);
            labelAverageOrder.Location = new Point(18, 55);
            labelAverageOrder.Name = "labelAverageOrder";
            labelAverageOrder.Size = new Size(235, 28);
            labelAverageOrder.TabIndex = 2;
            labelAverageOrder.Text = "Giá trị đơn hàng TB: ₫0";
            // 
            // labelTotalOrders
            // 
            labelTotalOrders.AutoSize = true;
            labelTotalOrders.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTotalOrders.ForeColor = Color.FromArgb(74, 144, 226);
            labelTotalOrders.Location = new Point(350, 25);
            labelTotalOrders.Name = "labelTotalOrders";
            labelTotalOrders.Size = new Size(155, 28);
            labelTotalOrders.TabIndex = 1;
            labelTotalOrders.Text = "Số đơn hàng: 0";
            // 
            // labelTotalRevenue
            // 
            labelTotalRevenue.AutoSize = true;
            labelTotalRevenue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTotalRevenue.ForeColor = Color.FromArgb(39, 174, 96);
            labelTotalRevenue.Location = new Point(18, 20);
            labelTotalRevenue.Name = "labelTotalRevenue";
            labelTotalRevenue.Size = new Size(241, 32);
            labelTotalRevenue.TabIndex = 0;
            labelTotalRevenue.Text = "Tổng doanh thu: ₫0";
            // 
            // dataGridViewRevenue
            // 
            dataGridViewRevenue.AllowUserToAddRows = false;
            dataGridViewRevenue.AllowUserToDeleteRows = false;
            dataGridViewRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRevenue.BackgroundColor = Color.White;
            dataGridViewRevenue.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewRevenue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRevenue.Dock = DockStyle.Fill;
            dataGridViewRevenue.Location = new Point(3, 103);
            dataGridViewRevenue.Name = "dataGridViewRevenue";
            dataGridViewRevenue.ReadOnly = true;
            dataGridViewRevenue.RowHeadersWidth = 51;
            dataGridViewRevenue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRevenue.Size = new Size(1170, 497);
            dataGridViewRevenue.TabIndex = 1;
            // 
            // panelRevenueFilter
            // 
            panelRevenueFilter.BackColor = Color.White;
            panelRevenueFilter.BorderStyle = BorderStyle.FixedSingle;
            panelRevenueFilter.Controls.Add(buttonExportRevenuePDF);
            panelRevenueFilter.Controls.Add(buttonExportRevenueExcel);
            panelRevenueFilter.Controls.Add(buttonGenerateRevenue);
            panelRevenueFilter.Controls.Add(labelRevenueTo);
            panelRevenueFilter.Controls.Add(labelRevenueFrom);
            panelRevenueFilter.Controls.Add(dateTimePickerRevenueTo);
            panelRevenueFilter.Controls.Add(dateTimePickerRevenueFrom);
            panelRevenueFilter.Controls.Add(labelRevenueTitle);
            panelRevenueFilter.Dock = DockStyle.Top;
            panelRevenueFilter.Location = new Point(3, 3);
            panelRevenueFilter.Name = "panelRevenueFilter";
            panelRevenueFilter.Padding = new Padding(15);
            panelRevenueFilter.Size = new Size(1170, 100);
            panelRevenueFilter.TabIndex = 0;
            // 
            // buttonExportRevenuePDF
            // 
            buttonExportRevenuePDF.BackColor = Color.FromArgb(220, 53, 69);
            buttonExportRevenuePDF.FlatAppearance.BorderSize = 0;
            buttonExportRevenuePDF.FlatStyle = FlatStyle.Flat;
            buttonExportRevenuePDF.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonExportRevenuePDF.ForeColor = Color.White;
            buttonExportRevenuePDF.Location = new Point(730, 45);
            buttonExportRevenuePDF.Name = "buttonExportRevenuePDF";
            buttonExportRevenuePDF.Size = new Size(120, 40);
            buttonExportRevenuePDF.TabIndex = 7;
            buttonExportRevenuePDF.Text = "📑 Xuất PDF";
            buttonExportRevenuePDF.UseVisualStyleBackColor = false;
            buttonExportRevenuePDF.Click += buttonExportRevenuePDF_Click;
            // 
            // buttonExportRevenueExcel
            // 
            buttonExportRevenueExcel.BackColor = Color.FromArgb(39, 174, 96);
            buttonExportRevenueExcel.FlatAppearance.BorderSize = 0;
            buttonExportRevenueExcel.FlatStyle = FlatStyle.Flat;
            buttonExportRevenueExcel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonExportRevenueExcel.ForeColor = Color.White;
            buttonExportRevenueExcel.Location = new Point(590, 45);
            buttonExportRevenueExcel.Name = "buttonExportRevenueExcel";
            buttonExportRevenueExcel.Size = new Size(120, 40);
            buttonExportRevenueExcel.TabIndex = 6;
            buttonExportRevenueExcel.Text = "📄 Xuất Excel";
            buttonExportRevenueExcel.UseVisualStyleBackColor = false;
            buttonExportRevenueExcel.Click += buttonExportRevenueExcel_Click;
            // 
            // buttonGenerateRevenue
            // 
            buttonGenerateRevenue.BackColor = Color.FromArgb(74, 144, 226);
            buttonGenerateRevenue.FlatAppearance.BorderSize = 0;
            buttonGenerateRevenue.FlatStyle = FlatStyle.Flat;
            buttonGenerateRevenue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonGenerateRevenue.ForeColor = Color.White;
            buttonGenerateRevenue.Location = new Point(450, 45);
            buttonGenerateRevenue.Name = "buttonGenerateRevenue";
            buttonGenerateRevenue.Size = new Size(120, 40);
            buttonGenerateRevenue.TabIndex = 5;
            buttonGenerateRevenue.Text = "📊 Tạo báo cáo";
            buttonGenerateRevenue.UseVisualStyleBackColor = false;
            buttonGenerateRevenue.Click += buttonGenerateRevenue_Click;
            // 
            // labelRevenueTo
            // 
            labelRevenueTo.AutoSize = true;
            labelRevenueTo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelRevenueTo.Location = new Point(240, 53);
            labelRevenueTo.Name = "labelRevenueTo";
            labelRevenueTo.Size = new Size(47, 23);
            labelRevenueTo.TabIndex = 4;
            labelRevenueTo.Text = "Đến:";
            // 
            // labelRevenueFrom
            // 
            labelRevenueFrom.AutoSize = true;
            labelRevenueFrom.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelRevenueFrom.Location = new Point(18, 53);
            labelRevenueFrom.Name = "labelRevenueFrom";
            labelRevenueFrom.Size = new Size(80, 23);
            labelRevenueFrom.TabIndex = 3;
            labelRevenueFrom.Text = "Từ ngày:";
            // 
            // dateTimePickerRevenueTo
            // 
            dateTimePickerRevenueTo.Font = new Font("Segoe UI", 10F);
            dateTimePickerRevenueTo.Format = DateTimePickerFormat.Short;
            dateTimePickerRevenueTo.Location = new Point(280, 50);
            dateTimePickerRevenueTo.Name = "dateTimePickerRevenueTo";
            dateTimePickerRevenueTo.Size = new Size(150, 30);
            dateTimePickerRevenueTo.TabIndex = 2;
            // 
            // dateTimePickerRevenueFrom
            // 
            dateTimePickerRevenueFrom.Font = new Font("Segoe UI", 10F);
            dateTimePickerRevenueFrom.Format = DateTimePickerFormat.Short;
            dateTimePickerRevenueFrom.Location = new Point(80, 50);
            dateTimePickerRevenueFrom.Name = "dateTimePickerRevenueFrom";
            dateTimePickerRevenueFrom.Size = new Size(150, 30);
            dateTimePickerRevenueFrom.TabIndex = 1;
            // 
            // labelRevenueTitle
            // 
            labelRevenueTitle.AutoSize = true;
            labelRevenueTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelRevenueTitle.ForeColor = Color.FromArgb(77, 58, 41);
            labelRevenueTitle.Location = new Point(18, 15);
            labelRevenueTitle.Name = "labelRevenueTitle";
            labelRevenueTitle.Size = new Size(233, 28);
            labelRevenueTitle.TabIndex = 0;
            labelRevenueTitle.Text = "Chọn khoảng thời gian:";
            // 
            // tabPageProducts
            // 
            tabPageProducts.BackColor = Color.FromArgb(250, 245, 238);
            tabPageProducts.Controls.Add(panelProductSummary);
            tabPageProducts.Controls.Add(dataGridViewProducts);
            tabPageProducts.Controls.Add(panelProductFilter);
            tabPageProducts.Location = new Point(4, 32);
            tabPageProducts.Name = "tabPageProducts";
            tabPageProducts.Padding = new Padding(3);
            tabPageProducts.Size = new Size(1176, 603);
            tabPageProducts.TabIndex = 1;
            tabPageProducts.Text = "📦 Thống kê sản phẩm";
            // 
            // panelProductSummary
            // 
            panelProductSummary.BackColor = Color.White;
            panelProductSummary.BorderStyle = BorderStyle.FixedSingle;
            panelProductSummary.Controls.Add(labelTopSellingProduct);
            panelProductSummary.Controls.Add(labelLowStockProducts);
            panelProductSummary.Controls.Add(labelTotalProducts);
            panelProductSummary.Dock = DockStyle.Bottom;
            panelProductSummary.Location = new Point(3, 500);
            panelProductSummary.Name = "panelProductSummary";
            panelProductSummary.Padding = new Padding(15);
            panelProductSummary.Size = new Size(1170, 100);
            panelProductSummary.TabIndex = 2;
            // 
            // labelTopSellingProduct
            // 
            labelTopSellingProduct.AutoSize = true;
            labelTopSellingProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTopSellingProduct.ForeColor = Color.FromArgb(39, 174, 96);
            labelTopSellingProduct.Location = new Point(18, 55);
            labelTopSellingProduct.Name = "labelTopSellingProduct";
            labelTopSellingProduct.Size = new Size(256, 28);
            labelTopSellingProduct.TabIndex = 2;
            labelTopSellingProduct.Text = "Sản phẩm bán chạy nhất: ";
            // 
            // labelLowStockProducts
            // 
            labelLowStockProducts.AutoSize = true;
            labelLowStockProducts.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelLowStockProducts.ForeColor = Color.FromArgb(220, 53, 69);
            labelLowStockProducts.Location = new Point(350, 25);
            labelLowStockProducts.Name = "labelLowStockProducts";
            labelLowStockProducts.Size = new Size(201, 28);
            labelLowStockProducts.TabIndex = 1;
            labelLowStockProducts.Text = "Sản phẩm ít hàng: 0";
            // 
            // labelTotalProducts
            // 
            labelTotalProducts.AutoSize = true;
            labelTotalProducts.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTotalProducts.ForeColor = Color.FromArgb(74, 144, 226);
            labelTotalProducts.Location = new Point(18, 20);
            labelTotalProducts.Name = "labelTotalProducts";
            labelTotalProducts.Size = new Size(218, 32);
            labelTotalProducts.TabIndex = 0;
            labelTotalProducts.Text = "Tổng sản phẩm: 0";
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.AllowUserToAddRows = false;
            dataGridViewProducts.AllowUserToDeleteRows = false;
            dataGridViewProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProducts.BackgroundColor = Color.White;
            dataGridViewProducts.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Dock = DockStyle.Fill;
            dataGridViewProducts.Location = new Point(3, 103);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.Size = new Size(1170, 497);
            dataGridViewProducts.TabIndex = 1;
            // 
            // panelProductFilter
            // 
            panelProductFilter.BackColor = Color.White;
            panelProductFilter.BorderStyle = BorderStyle.FixedSingle;
            panelProductFilter.Controls.Add(buttonExportProductPDF);
            panelProductFilter.Controls.Add(buttonExportProductExcel);
            panelProductFilter.Controls.Add(buttonGenerateProduct);
            panelProductFilter.Controls.Add(labelProductCategory);
            panelProductFilter.Controls.Add(comboBoxProductCategory);
            panelProductFilter.Controls.Add(labelProductTitle);
            panelProductFilter.Dock = DockStyle.Top;
            panelProductFilter.Location = new Point(3, 3);
            panelProductFilter.Name = "panelProductFilter";
            panelProductFilter.Padding = new Padding(15);
            panelProductFilter.Size = new Size(1170, 100);
            panelProductFilter.TabIndex = 0;
            // 
            // buttonExportProductPDF
            // 
            buttonExportProductPDF.BackColor = Color.FromArgb(220, 53, 69);
            buttonExportProductPDF.FlatAppearance.BorderSize = 0;
            buttonExportProductPDF.FlatStyle = FlatStyle.Flat;
            buttonExportProductPDF.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonExportProductPDF.ForeColor = Color.White;
            buttonExportProductPDF.Location = new Point(630, 45);
            buttonExportProductPDF.Name = "buttonExportProductPDF";
            buttonExportProductPDF.Size = new Size(120, 40);
            buttonExportProductPDF.TabIndex = 5;
            buttonExportProductPDF.Text = "📑 Xuất PDF";
            buttonExportProductPDF.UseVisualStyleBackColor = false;
            buttonExportProductPDF.Click += buttonExportProductPDF_Click;
            // 
            // buttonExportProductExcel
            // 
            buttonExportProductExcel.BackColor = Color.FromArgb(39, 174, 96);
            buttonExportProductExcel.FlatAppearance.BorderSize = 0;
            buttonExportProductExcel.FlatStyle = FlatStyle.Flat;
            buttonExportProductExcel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonExportProductExcel.ForeColor = Color.White;
            buttonExportProductExcel.Location = new Point(490, 45);
            buttonExportProductExcel.Name = "buttonExportProductExcel";
            buttonExportProductExcel.Size = new Size(120, 40);
            buttonExportProductExcel.TabIndex = 4;
            buttonExportProductExcel.Text = "📄 Xuất Excel";
            buttonExportProductExcel.UseVisualStyleBackColor = false;
            buttonExportProductExcel.Click += buttonExportProductExcel_Click;
            // 
            // buttonGenerateProduct
            // 
            buttonGenerateProduct.BackColor = Color.FromArgb(74, 144, 226);
            buttonGenerateProduct.FlatAppearance.BorderSize = 0;
            buttonGenerateProduct.FlatStyle = FlatStyle.Flat;
            buttonGenerateProduct.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonGenerateProduct.ForeColor = Color.White;
            buttonGenerateProduct.Location = new Point(350, 45);
            buttonGenerateProduct.Name = "buttonGenerateProduct";
            buttonGenerateProduct.Size = new Size(120, 40);
            buttonGenerateProduct.TabIndex = 3;
            buttonGenerateProduct.Text = "📊 Tạo báo cáo";
            buttonGenerateProduct.UseVisualStyleBackColor = false;
            buttonGenerateProduct.Click += buttonGenerateProduct_Click;
            // 
            // labelProductCategory
            // 
            labelProductCategory.AutoSize = true;
            labelProductCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelProductCategory.Location = new Point(18, 53);
            labelProductCategory.Name = "labelProductCategory";
            labelProductCategory.Size = new Size(96, 23);
            labelProductCategory.TabIndex = 2;
            labelProductCategory.Text = "Danh mục:";
            // 
            // comboBoxProductCategory
            // 
            comboBoxProductCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProductCategory.Font = new Font("Segoe UI", 10F);
            comboBoxProductCategory.FormattingEnabled = true;
            comboBoxProductCategory.Location = new Point(120, 50);
            comboBoxProductCategory.Name = "comboBoxProductCategory";
            comboBoxProductCategory.Size = new Size(200, 31);
            comboBoxProductCategory.TabIndex = 1;
            // 
            // labelProductTitle
            // 
            labelProductTitle.AutoSize = true;
            labelProductTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelProductTitle.ForeColor = Color.FromArgb(77, 58, 41);
            labelProductTitle.Location = new Point(18, 15);
            labelProductTitle.Name = "labelProductTitle";
            labelProductTitle.Size = new Size(202, 28);
            labelProductTitle.TabIndex = 0;
            labelProductTitle.Text = "Thống kê sản phẩm:";
            // 
            // tabPageInventory
            // 
            tabPageInventory.BackColor = Color.FromArgb(250, 245, 238);
            tabPageInventory.Controls.Add(panelInventorySummary);
            tabPageInventory.Controls.Add(dataGridViewInventory);
            tabPageInventory.Controls.Add(panelInventoryFilter);
            tabPageInventory.Location = new Point(4, 32);
            tabPageInventory.Name = "tabPageInventory";
            tabPageInventory.Padding = new Padding(3);
            tabPageInventory.Size = new Size(1176, 603);
            tabPageInventory.TabIndex = 2;
            tabPageInventory.Text = "📊 Báo cáo tồn kho";
            // 
            // panelInventorySummary
            // 
            panelInventorySummary.BackColor = Color.White;
            panelInventorySummary.BorderStyle = BorderStyle.FixedSingle;
            panelInventorySummary.Controls.Add(labelOutOfStockCount);
            panelInventorySummary.Controls.Add(labelLowStockCount);
            panelInventorySummary.Controls.Add(labelTotalStockValue);
            panelInventorySummary.Dock = DockStyle.Bottom;
            panelInventorySummary.Location = new Point(3, 500);
            panelInventorySummary.Name = "panelInventorySummary";
            panelInventorySummary.Padding = new Padding(15);
            panelInventorySummary.Size = new Size(1170, 100);
            panelInventorySummary.TabIndex = 2;
            // 
            // labelOutOfStockCount
            // 
            labelOutOfStockCount.AutoSize = true;
            labelOutOfStockCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelOutOfStockCount.ForeColor = Color.FromArgb(220, 53, 69);
            labelOutOfStockCount.Location = new Point(18, 55);
            labelOutOfStockCount.Name = "labelOutOfStockCount";
            labelOutOfStockCount.Size = new Size(122, 28);
            labelOutOfStockCount.TabIndex = 2;
            labelOutOfStockCount.Text = "Hết hàng: 0";
            // 
            // labelLowStockCount
            // 
            labelLowStockCount.AutoSize = true;
            labelLowStockCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelLowStockCount.ForeColor = Color.FromArgb(255, 193, 7);
            labelLowStockCount.Location = new Point(350, 25);
            labelLowStockCount.Name = "labelLowStockCount";
            labelLowStockCount.Size = new Size(159, 28);
            labelLowStockCount.TabIndex = 1;
            labelLowStockCount.Text = "Sắp hết hàng: 0";
            // 
            // labelTotalStockValue
            // 
            labelTotalStockValue.AutoSize = true;
            labelTotalStockValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTotalStockValue.ForeColor = Color.FromArgb(39, 174, 96);
            labelTotalStockValue.Location = new Point(18, 20);
            labelTotalStockValue.Name = "labelTotalStockValue";
            labelTotalStockValue.Size = new Size(241, 32);
            labelTotalStockValue.TabIndex = 0;
            labelTotalStockValue.Text = "Tổng giá trị kho: ₫0";
            // 
            // dataGridViewInventory
            // 
            dataGridViewInventory.AllowUserToAddRows = false;
            dataGridViewInventory.AllowUserToDeleteRows = false;
            dataGridViewInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewInventory.BackgroundColor = Color.White;
            dataGridViewInventory.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInventory.Dock = DockStyle.Fill;
            dataGridViewInventory.Location = new Point(3, 103);
            dataGridViewInventory.Name = "dataGridViewInventory";
            dataGridViewInventory.ReadOnly = true;
            dataGridViewInventory.RowHeadersWidth = 51;
            dataGridViewInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewInventory.Size = new Size(1170, 497);
            dataGridViewInventory.TabIndex = 1;
            // 
            // panelInventoryFilter
            // 
            panelInventoryFilter.BackColor = Color.White;
            panelInventoryFilter.BorderStyle = BorderStyle.FixedSingle;
            panelInventoryFilter.Controls.Add(buttonExportInventoryPDF);
            panelInventoryFilter.Controls.Add(buttonExportInventoryExcel);
            panelInventoryFilter.Controls.Add(buttonGenerateInventory);
            panelInventoryFilter.Controls.Add(labelStockThreshold);
            panelInventoryFilter.Controls.Add(numericUpDownStockThreshold);
            panelInventoryFilter.Controls.Add(checkBoxShowLowStock);
            panelInventoryFilter.Controls.Add(labelInventoryTitle);
            panelInventoryFilter.Dock = DockStyle.Top;
            panelInventoryFilter.Location = new Point(3, 3);
            panelInventoryFilter.Name = "panelInventoryFilter";
            panelInventoryFilter.Padding = new Padding(15);
            panelInventoryFilter.Size = new Size(1170, 100);
            panelInventoryFilter.TabIndex = 0;
            // 
            // buttonExportInventoryPDF
            // 
            buttonExportInventoryPDF.BackColor = Color.FromArgb(220, 53, 69);
            buttonExportInventoryPDF.FlatAppearance.BorderSize = 0;
            buttonExportInventoryPDF.FlatStyle = FlatStyle.Flat;
            buttonExportInventoryPDF.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonExportInventoryPDF.ForeColor = Color.White;
            buttonExportInventoryPDF.Location = new Point(780, 45);
            buttonExportInventoryPDF.Name = "buttonExportInventoryPDF";
            buttonExportInventoryPDF.Size = new Size(120, 40);
            buttonExportInventoryPDF.TabIndex = 6;
            buttonExportInventoryPDF.Text = "📑 Xuất PDF";
            buttonExportInventoryPDF.UseVisualStyleBackColor = false;
            buttonExportInventoryPDF.Click += buttonExportInventoryPDF_Click;
            // 
            // buttonExportInventoryExcel
            // 
            buttonExportInventoryExcel.BackColor = Color.FromArgb(39, 174, 96);
            buttonExportInventoryExcel.FlatAppearance.BorderSize = 0;
            buttonExportInventoryExcel.FlatStyle = FlatStyle.Flat;
            buttonExportInventoryExcel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonExportInventoryExcel.ForeColor = Color.White;
            buttonExportInventoryExcel.Location = new Point(640, 45);
            buttonExportInventoryExcel.Name = "buttonExportInventoryExcel";
            buttonExportInventoryExcel.Size = new Size(120, 40);
            buttonExportInventoryExcel.TabIndex = 5;
            buttonExportInventoryExcel.Text = "📄 Xuất Excel";
            buttonExportInventoryExcel.UseVisualStyleBackColor = false;
            buttonExportInventoryExcel.Click += buttonExportInventoryExcel_Click;
            // 
            // buttonGenerateInventory
            // 
            buttonGenerateInventory.BackColor = Color.FromArgb(74, 144, 226);
            buttonGenerateInventory.FlatAppearance.BorderSize = 0;
            buttonGenerateInventory.FlatStyle = FlatStyle.Flat;
            buttonGenerateInventory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonGenerateInventory.ForeColor = Color.White;
            buttonGenerateInventory.Location = new Point(500, 45);
            buttonGenerateInventory.Name = "buttonGenerateInventory";
            buttonGenerateInventory.Size = new Size(120, 40);
            buttonGenerateInventory.TabIndex = 4;
            buttonGenerateInventory.Text = "📊 Tạo báo cáo";
            buttonGenerateInventory.UseVisualStyleBackColor = false;
            buttonGenerateInventory.Click += buttonGenerateInventory_Click;
            // 
            // labelStockThreshold
            // 
            labelStockThreshold.AutoSize = true;
            labelStockThreshold.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelStockThreshold.Location = new Point(270, 53);
            labelStockThreshold.Name = "labelStockThreshold";
            labelStockThreshold.Size = new Size(159, 23);
            labelStockThreshold.TabIndex = 3;
            labelStockThreshold.Text = "Ngưỡng cảnh báo:";
            // 
            // numericUpDownStockThreshold
            // 
            numericUpDownStockThreshold.Font = new Font("Segoe UI", 10F);
            numericUpDownStockThreshold.Location = new Point(390, 50);
            numericUpDownStockThreshold.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownStockThreshold.Name = "numericUpDownStockThreshold";
            numericUpDownStockThreshold.Size = new Size(80, 30);
            numericUpDownStockThreshold.TabIndex = 2;
            numericUpDownStockThreshold.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // checkBoxShowLowStock
            // 
            checkBoxShowLowStock.AutoSize = true;
            checkBoxShowLowStock.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            checkBoxShowLowStock.Location = new Point(18, 53);
            checkBoxShowLowStock.Name = "checkBoxShowLowStock";
            checkBoxShowLowStock.Size = new Size(268, 27);
            checkBoxShowLowStock.TabIndex = 1;
            checkBoxShowLowStock.Text = "Chỉ hiển thị sản phẩm ít hàng";
            checkBoxShowLowStock.UseVisualStyleBackColor = true;
            // 
            // labelInventoryTitle
            // 
            labelInventoryTitle.AutoSize = true;
            labelInventoryTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelInventoryTitle.ForeColor = Color.FromArgb(77, 58, 41);
            labelInventoryTitle.Location = new Point(18, 15);
            labelInventoryTitle.Name = "labelInventoryTitle";
            labelInventoryTitle.Size = new Size(171, 28);
            labelInventoryTitle.TabIndex = 0;
            labelInventoryTitle.Text = "Báo cáo tồn kho:";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(77, 58, 41);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1184, 70);
            panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(30, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(177, 41);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "📈 Báo cáo";
            // 
            // ReportsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 709);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(1422, 756);
            MinimumSize = new Size(1422, 756);
            Name = "ReportsPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Báo cáo - HeartSteel Cosmetic";
            panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelMain.ResumeLayout(false);
            tabControlReports.ResumeLayout(false);
            tabPageRevenue.ResumeLayout(false);
            panelRevenueSummary.ResumeLayout(false);
            panelRevenueSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRevenue).EndInit();
            panelRevenueFilter.ResumeLayout(false);
            panelRevenueFilter.PerformLayout();
            tabPageProducts.ResumeLayout(false);
            panelProductSummary.ResumeLayout(false);
            panelProductSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            panelProductFilter.ResumeLayout(false);
            panelProductFilter.PerformLayout();
            tabPageInventory.ResumeLayout(false);
            panelInventorySummary.ResumeLayout(false);
            panelInventorySummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).EndInit();
            panelInventoryFilter.ResumeLayout(false);
            panelInventoryFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStockThreshold).EndInit();
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
        private TabControl tabControlReports;
        private TabPage tabPageRevenue;
        private Panel panelRevenueFilter;
        private Label labelRevenueTitle;
        private DateTimePicker dateTimePickerRevenueFrom;
        private DateTimePicker dateTimePickerRevenueTo;
        private Label labelRevenueFrom;
        private Label labelRevenueTo;
        private Button buttonGenerateRevenue;
        private Button buttonExportRevenueExcel;
        private Button buttonExportRevenuePDF;
        private DataGridView dataGridViewRevenue;
        private Panel panelRevenueSummary;
        private Label labelTotalRevenue;
        private Label labelTotalOrders;
        private Label labelAverageOrder;
        private TabPage tabPageProducts;
        private Panel panelProductFilter;
        private Label labelProductTitle;
        private ComboBox comboBoxProductCategory;
        private Label labelProductCategory;
        private Button buttonGenerateProduct;
        private Button buttonExportProductExcel;
        private Button buttonExportProductPDF;
        private DataGridView dataGridViewProducts;
        private Panel panelProductSummary;
        private Label labelTotalProducts;
        private Label labelLowStockProducts;
        private Label labelTopSellingProduct;
        private TabPage tabPageInventory;
        private Panel panelInventoryFilter;
        private Label labelInventoryTitle;
        private CheckBox checkBoxShowLowStock;
        private NumericUpDown numericUpDownStockThreshold;
        private Label labelStockThreshold;
        private Button buttonGenerateInventory;
        private Button buttonExportInventoryExcel;
        private Button buttonExportInventoryPDF;
        private DataGridView dataGridViewInventory;
        private Panel panelInventorySummary;
        private Label labelTotalStockValue;
        private Label labelLowStockCount;
        private Label labelOutOfStockCount;
        private Button buttonManageOrders;
    }
}