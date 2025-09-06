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
            panelSidebar.Margin = new Padding(3, 2, 3, 2);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(192, 538);
            panelSidebar.TabIndex = 0;
            // 
            // buttonManageOrders
            // 
            buttonManageOrders.BackColor = Color.FromArgb(95, 76, 59);
            buttonManageOrders.FlatAppearance.BorderSize = 0;
            buttonManageOrders.FlatStyle = FlatStyle.Flat;
            buttonManageOrders.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonManageOrders.ForeColor = Color.White;
            buttonManageOrders.Location = new Point(9, 248);
            buttonManageOrders.Margin = new Padding(3, 2, 3, 2);
            buttonManageOrders.Name = "buttonManageOrders";
            buttonManageOrders.Padding = new Padding(4, 0, 0, 0);
            buttonManageOrders.Size = new Size(175, 38);
            buttonManageOrders.TabIndex = 8;
            buttonManageOrders.Text = "📜 Quản lý đơn hàng\r\n";
            buttonManageOrders.TextAlign = ContentAlignment.MiddleLeft;
            buttonManageOrders.UseVisualStyleBackColor = false;
            buttonManageOrders.Click += buttonManageOrders_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Location = new Point(9, 8);
            pictureBoxLogo.Margin = new Padding(3, 2, 3, 2);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(175, 90);
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
            buttonManageProducts.Location = new Point(9, 112);
            buttonManageProducts.Margin = new Padding(3, 2, 3, 2);
            buttonManageProducts.Name = "buttonManageProducts";
            buttonManageProducts.Padding = new Padding(4, 0, 0, 0);
            buttonManageProducts.Size = new Size(175, 38);
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
            buttonManageInventory.Location = new Point(9, 158);
            buttonManageInventory.Margin = new Padding(3, 2, 3, 2);
            buttonManageInventory.Name = "buttonManageInventory";
            buttonManageInventory.Padding = new Padding(4, 0, 0, 0);
            buttonManageInventory.Size = new Size(175, 38);
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
            buttonManageCategories.Location = new Point(9, 202);
            buttonManageCategories.Margin = new Padding(3, 2, 3, 2);
            buttonManageCategories.Name = "buttonManageCategories";
            buttonManageCategories.Padding = new Padding(4, 0, 0, 0);
            buttonManageCategories.Size = new Size(175, 38);
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
            buttonReports.Location = new Point(9, 292);
            buttonReports.Margin = new Padding(3, 2, 3, 2);
            buttonReports.Name = "buttonReports";
            buttonReports.Padding = new Padding(4, 0, 0, 0);
            buttonReports.Size = new Size(175, 38);
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
            buttonLogout.Location = new Point(9, 472);
            buttonLogout.Margin = new Padding(3, 2, 3, 2);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Padding = new Padding(4, 0, 0, 0);
            buttonLogout.Size = new Size(175, 38);
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
            panelMain.Location = new Point(192, 0);
            panelMain.Margin = new Padding(3, 2, 3, 2);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1038, 538);
            panelMain.TabIndex = 1;
            // 
            // tabControlReports
            // 
            tabControlReports.Controls.Add(tabPageRevenue);
            tabControlReports.Controls.Add(tabPageProducts);
            tabControlReports.Controls.Add(tabPageInventory);
            tabControlReports.Dock = DockStyle.Fill;
            tabControlReports.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            tabControlReports.Location = new Point(0, 52);
            tabControlReports.Margin = new Padding(3, 2, 3, 2);
            tabControlReports.Name = "tabControlReports";
            tabControlReports.SelectedIndex = 0;
            tabControlReports.Size = new Size(1038, 486);
            tabControlReports.TabIndex = 1;
            // 
            // tabPageRevenue
            // 
            tabPageRevenue.BackColor = Color.FromArgb(250, 245, 238);
            tabPageRevenue.Controls.Add(panelRevenueSummary);
            tabPageRevenue.Controls.Add(dataGridViewRevenue);
            tabPageRevenue.Controls.Add(panelRevenueFilter);
            tabPageRevenue.Location = new Point(4, 26);
            tabPageRevenue.Margin = new Padding(3, 2, 3, 2);
            tabPageRevenue.Name = "tabPageRevenue";
            tabPageRevenue.Padding = new Padding(3, 2, 3, 2);
            tabPageRevenue.Size = new Size(1030, 456);
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
            panelRevenueSummary.Location = new Point(3, 378);
            panelRevenueSummary.Margin = new Padding(3, 2, 3, 2);
            panelRevenueSummary.Name = "panelRevenueSummary";
            panelRevenueSummary.Padding = new Padding(13, 11, 13, 11);
            panelRevenueSummary.Size = new Size(1024, 76);
            panelRevenueSummary.TabIndex = 2;
            // 
            // labelAverageOrder
            // 
            labelAverageOrder.AutoSize = true;
            labelAverageOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelAverageOrder.ForeColor = Color.FromArgb(230, 126, 34);
            labelAverageOrder.Location = new Point(16, 41);
            labelAverageOrder.Name = "labelAverageOrder";
            labelAverageOrder.Size = new Size(183, 21);
            labelAverageOrder.TabIndex = 2;
            labelAverageOrder.Text = "Giá trị đơn hàng TB: ₫0";
            // 
            // labelTotalOrders
            // 
            labelTotalOrders.AutoSize = true;
            labelTotalOrders.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTotalOrders.ForeColor = Color.FromArgb(74, 144, 226);
            labelTotalOrders.Location = new Point(306, 19);
            labelTotalOrders.Name = "labelTotalOrders";
            labelTotalOrders.Size = new Size(123, 21);
            labelTotalOrders.TabIndex = 1;
            labelTotalOrders.Text = "Số đơn hàng: 0";
            // 
            // labelTotalRevenue
            // 
            labelTotalRevenue.AutoSize = true;
            labelTotalRevenue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTotalRevenue.ForeColor = Color.FromArgb(39, 174, 96);
            labelTotalRevenue.Location = new Point(16, 15);
            labelTotalRevenue.Name = "labelTotalRevenue";
            labelTotalRevenue.Size = new Size(189, 25);
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
            dataGridViewRevenue.Location = new Point(3, 78);
            dataGridViewRevenue.Margin = new Padding(3, 2, 3, 2);
            dataGridViewRevenue.Name = "dataGridViewRevenue";
            dataGridViewRevenue.ReadOnly = true;
            dataGridViewRevenue.RowHeadersWidth = 51;
            dataGridViewRevenue.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRevenue.Size = new Size(1024, 376);
            dataGridViewRevenue.TabIndex = 1;
            // 
            // panelRevenueFilter
            // 
            panelRevenueFilter.BackColor = Color.White;
            panelRevenueFilter.BorderStyle = BorderStyle.FixedSingle;
            panelRevenueFilter.Controls.Add(buttonExportRevenuePDF);
            panelRevenueFilter.Controls.Add(buttonExportRevenueExcel);
            panelRevenueFilter.Controls.Add(labelRevenueTo);
            panelRevenueFilter.Controls.Add(labelRevenueFrom);
            panelRevenueFilter.Controls.Add(dateTimePickerRevenueTo);
            panelRevenueFilter.Controls.Add(dateTimePickerRevenueFrom);
            panelRevenueFilter.Controls.Add(labelRevenueTitle);
            panelRevenueFilter.Dock = DockStyle.Top;
            panelRevenueFilter.Location = new Point(3, 2);
            panelRevenueFilter.Margin = new Padding(3, 2, 3, 2);
            panelRevenueFilter.Name = "panelRevenueFilter";
            panelRevenueFilter.Padding = new Padding(13, 11, 13, 11);
            panelRevenueFilter.Size = new Size(1024, 76);
            panelRevenueFilter.TabIndex = 0;
            // 
            // buttonExportRevenuePDF
            // 
            buttonExportRevenuePDF.BackColor = Color.FromArgb(220, 53, 69);
            buttonExportRevenuePDF.FlatAppearance.BorderSize = 0;
            buttonExportRevenuePDF.FlatStyle = FlatStyle.Flat;
            buttonExportRevenuePDF.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonExportRevenuePDF.ForeColor = Color.White;
            buttonExportRevenuePDF.Location = new Point(543, 34);
            buttonExportRevenuePDF.Margin = new Padding(3, 2, 3, 2);
            buttonExportRevenuePDF.Name = "buttonExportRevenuePDF";
            buttonExportRevenuePDF.Size = new Size(105, 30);
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
            buttonExportRevenueExcel.Location = new Point(421, 34);
            buttonExportRevenueExcel.Margin = new Padding(3, 2, 3, 2);
            buttonExportRevenueExcel.Name = "buttonExportRevenueExcel";
            buttonExportRevenueExcel.Size = new Size(105, 30);
            buttonExportRevenueExcel.TabIndex = 6;
            buttonExportRevenueExcel.Text = "📄 Xuất Excel";
            buttonExportRevenueExcel.UseVisualStyleBackColor = false;
            buttonExportRevenueExcel.Click += buttonExportRevenueExcel_Click;
            // 
            // labelRevenueTo
            // 
            labelRevenueTo.AutoSize = true;
            labelRevenueTo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelRevenueTo.Location = new Point(227, 40);
            labelRevenueTo.Name = "labelRevenueTo";
            labelRevenueTo.Size = new Size(39, 19);
            labelRevenueTo.TabIndex = 4;
            labelRevenueTo.Text = "Đến:";
            // 
            // labelRevenueFrom
            // 
            labelRevenueFrom.AutoSize = true;
            labelRevenueFrom.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelRevenueFrom.Location = new Point(16, 40);
            labelRevenueFrom.Name = "labelRevenueFrom";
            labelRevenueFrom.Size = new Size(67, 19);
            labelRevenueFrom.TabIndex = 3;
            labelRevenueFrom.Text = "Từ ngày:";
            // 
            // dateTimePickerRevenueTo
            // 
            dateTimePickerRevenueTo.Font = new Font("Segoe UI", 10F);
            dateTimePickerRevenueTo.Format = DateTimePickerFormat.Short;
            dateTimePickerRevenueTo.Location = new Point(272, 38);
            dateTimePickerRevenueTo.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerRevenueTo.Name = "dateTimePickerRevenueTo";
            dateTimePickerRevenueTo.Size = new Size(132, 25);
            dateTimePickerRevenueTo.TabIndex = 2;
            // 
            // dateTimePickerRevenueFrom
            // 
            dateTimePickerRevenueFrom.Font = new Font("Segoe UI", 10F);
            dateTimePickerRevenueFrom.Format = DateTimePickerFormat.Short;
            dateTimePickerRevenueFrom.Location = new Point(89, 38);
            dateTimePickerRevenueFrom.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerRevenueFrom.Name = "dateTimePickerRevenueFrom";
            dateTimePickerRevenueFrom.Size = new Size(132, 25);
            dateTimePickerRevenueFrom.TabIndex = 1;
            // 
            // labelRevenueTitle
            // 
            labelRevenueTitle.AutoSize = true;
            labelRevenueTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelRevenueTitle.ForeColor = Color.FromArgb(77, 58, 41);
            labelRevenueTitle.Location = new Point(16, 11);
            labelRevenueTitle.Name = "labelRevenueTitle";
            labelRevenueTitle.Size = new Size(189, 21);
            labelRevenueTitle.TabIndex = 0;
            labelRevenueTitle.Text = "Chọn khoảng thời gian:";
            // 
            // tabPageProducts
            // 
            tabPageProducts.BackColor = Color.FromArgb(250, 245, 238);
            tabPageProducts.Controls.Add(panelProductSummary);
            tabPageProducts.Controls.Add(dataGridViewProducts);
            tabPageProducts.Controls.Add(panelProductFilter);
            tabPageProducts.Location = new Point(4, 26);
            tabPageProducts.Margin = new Padding(3, 2, 3, 2);
            tabPageProducts.Name = "tabPageProducts";
            tabPageProducts.Padding = new Padding(3, 2, 3, 2);
            tabPageProducts.Size = new Size(1030, 456);
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
            panelProductSummary.Location = new Point(3, 378);
            panelProductSummary.Margin = new Padding(3, 2, 3, 2);
            panelProductSummary.Name = "panelProductSummary";
            panelProductSummary.Padding = new Padding(13, 11, 13, 11);
            panelProductSummary.Size = new Size(1024, 76);
            panelProductSummary.TabIndex = 2;
            // 
            // labelTopSellingProduct
            // 
            labelTopSellingProduct.AutoSize = true;
            labelTopSellingProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelTopSellingProduct.ForeColor = Color.FromArgb(39, 174, 96);
            labelTopSellingProduct.Location = new Point(16, 41);
            labelTopSellingProduct.Name = "labelTopSellingProduct";
            labelTopSellingProduct.Size = new Size(206, 21);
            labelTopSellingProduct.TabIndex = 2;
            labelTopSellingProduct.Text = "Sản phẩm bán chạy nhất: ";
            // 
            // labelLowStockProducts
            // 
            labelLowStockProducts.AutoSize = true;
            labelLowStockProducts.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelLowStockProducts.ForeColor = Color.FromArgb(220, 53, 69);
            labelLowStockProducts.Location = new Point(306, 19);
            labelLowStockProducts.Name = "labelLowStockProducts";
            labelLowStockProducts.Size = new Size(161, 21);
            labelLowStockProducts.TabIndex = 1;
            labelLowStockProducts.Text = "Sản phẩm ít hàng: 0";
            // 
            // labelTotalProducts
            // 
            labelTotalProducts.AutoSize = true;
            labelTotalProducts.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTotalProducts.ForeColor = Color.FromArgb(74, 144, 226);
            labelTotalProducts.Location = new Point(16, 15);
            labelTotalProducts.Name = "labelTotalProducts";
            labelTotalProducts.Size = new Size(170, 25);
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
            dataGridViewProducts.Location = new Point(3, 78);
            dataGridViewProducts.Margin = new Padding(3, 2, 3, 2);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.ReadOnly = true;
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProducts.Size = new Size(1024, 376);
            dataGridViewProducts.TabIndex = 1;
            // 
            // panelProductFilter
            // 
            panelProductFilter.BackColor = Color.White;
            panelProductFilter.BorderStyle = BorderStyle.FixedSingle;
            panelProductFilter.Controls.Add(buttonExportProductPDF);
            panelProductFilter.Controls.Add(buttonExportProductExcel);
            panelProductFilter.Controls.Add(labelProductCategory);
            panelProductFilter.Controls.Add(comboBoxProductCategory);
            panelProductFilter.Controls.Add(labelProductTitle);
            panelProductFilter.Dock = DockStyle.Top;
            panelProductFilter.Location = new Point(3, 2);
            panelProductFilter.Margin = new Padding(3, 2, 3, 2);
            panelProductFilter.Name = "panelProductFilter";
            panelProductFilter.Padding = new Padding(13, 11, 13, 11);
            panelProductFilter.Size = new Size(1024, 76);
            panelProductFilter.TabIndex = 0;
            // 
            // buttonExportProductPDF
            // 
            buttonExportProductPDF.BackColor = Color.FromArgb(220, 53, 69);
            buttonExportProductPDF.FlatAppearance.BorderSize = 0;
            buttonExportProductPDF.FlatStyle = FlatStyle.Flat;
            buttonExportProductPDF.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonExportProductPDF.ForeColor = Color.White;
            buttonExportProductPDF.Location = new Point(429, 34);
            buttonExportProductPDF.Margin = new Padding(3, 2, 3, 2);
            buttonExportProductPDF.Name = "buttonExportProductPDF";
            buttonExportProductPDF.Size = new Size(105, 30);
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
            buttonExportProductExcel.Location = new Point(306, 34);
            buttonExportProductExcel.Margin = new Padding(3, 2, 3, 2);
            buttonExportProductExcel.Name = "buttonExportProductExcel";
            buttonExportProductExcel.Size = new Size(105, 30);
            buttonExportProductExcel.TabIndex = 4;
            buttonExportProductExcel.Text = "📄 Xuất Excel";
            buttonExportProductExcel.UseVisualStyleBackColor = false;
            buttonExportProductExcel.Click += buttonExportProductExcel_Click;
            // 
            // labelProductCategory
            // 
            labelProductCategory.AutoSize = true;
            labelProductCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelProductCategory.Location = new Point(16, 40);
            labelProductCategory.Name = "labelProductCategory";
            labelProductCategory.Size = new Size(79, 19);
            labelProductCategory.TabIndex = 2;
            labelProductCategory.Text = "Danh mục:";
            // 
            // comboBoxProductCategory
            // 
            comboBoxProductCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProductCategory.Font = new Font("Segoe UI", 10F);
            comboBoxProductCategory.FormattingEnabled = true;
            comboBoxProductCategory.Location = new Point(105, 38);
            comboBoxProductCategory.Margin = new Padding(3, 2, 3, 2);
            comboBoxProductCategory.Name = "comboBoxProductCategory";
            comboBoxProductCategory.Size = new Size(176, 25);
            comboBoxProductCategory.TabIndex = 1;
            // 
            // labelProductTitle
            // 
            labelProductTitle.AutoSize = true;
            labelProductTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelProductTitle.ForeColor = Color.FromArgb(77, 58, 41);
            labelProductTitle.Location = new Point(16, 11);
            labelProductTitle.Name = "labelProductTitle";
            labelProductTitle.Size = new Size(163, 21);
            labelProductTitle.TabIndex = 0;
            labelProductTitle.Text = "Thống kê sản phẩm:";
            // 
            // tabPageInventory
            // 
            tabPageInventory.BackColor = Color.FromArgb(250, 245, 238);
            tabPageInventory.Controls.Add(panelInventorySummary);
            tabPageInventory.Controls.Add(dataGridViewInventory);
            tabPageInventory.Controls.Add(panelInventoryFilter);
            tabPageInventory.Location = new Point(4, 26);
            tabPageInventory.Margin = new Padding(3, 2, 3, 2);
            tabPageInventory.Name = "tabPageInventory";
            tabPageInventory.Padding = new Padding(3, 2, 3, 2);
            tabPageInventory.Size = new Size(1030, 456);
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
            panelInventorySummary.Location = new Point(3, 378);
            panelInventorySummary.Margin = new Padding(3, 2, 3, 2);
            panelInventorySummary.Name = "panelInventorySummary";
            panelInventorySummary.Padding = new Padding(13, 11, 13, 11);
            panelInventorySummary.Size = new Size(1024, 76);
            panelInventorySummary.TabIndex = 2;
            // 
            // labelOutOfStockCount
            // 
            labelOutOfStockCount.AutoSize = true;
            labelOutOfStockCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelOutOfStockCount.ForeColor = Color.FromArgb(220, 53, 69);
            labelOutOfStockCount.Location = new Point(16, 41);
            labelOutOfStockCount.Name = "labelOutOfStockCount";
            labelOutOfStockCount.Size = new Size(97, 21);
            labelOutOfStockCount.TabIndex = 2;
            labelOutOfStockCount.Text = "Hết hàng: 0";
            // 
            // labelLowStockCount
            // 
            labelLowStockCount.AutoSize = true;
            labelLowStockCount.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelLowStockCount.ForeColor = Color.FromArgb(255, 193, 7);
            labelLowStockCount.Location = new Point(306, 19);
            labelLowStockCount.Name = "labelLowStockCount";
            labelLowStockCount.Size = new Size(127, 21);
            labelLowStockCount.TabIndex = 1;
            labelLowStockCount.Text = "Sắp hết hàng: 0";
            // 
            // labelTotalStockValue
            // 
            labelTotalStockValue.AutoSize = true;
            labelTotalStockValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTotalStockValue.ForeColor = Color.FromArgb(39, 174, 96);
            labelTotalStockValue.Location = new Point(16, 15);
            labelTotalStockValue.Name = "labelTotalStockValue";
            labelTotalStockValue.Size = new Size(188, 25);
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
            dataGridViewInventory.Location = new Point(3, 78);
            dataGridViewInventory.Margin = new Padding(3, 2, 3, 2);
            dataGridViewInventory.Name = "dataGridViewInventory";
            dataGridViewInventory.ReadOnly = true;
            dataGridViewInventory.RowHeadersWidth = 51;
            dataGridViewInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewInventory.Size = new Size(1024, 376);
            dataGridViewInventory.TabIndex = 1;
            // 
            // panelInventoryFilter
            // 
            panelInventoryFilter.BackColor = Color.White;
            panelInventoryFilter.BorderStyle = BorderStyle.FixedSingle;
            panelInventoryFilter.Controls.Add(buttonExportInventoryPDF);
            panelInventoryFilter.Controls.Add(buttonExportInventoryExcel);
            panelInventoryFilter.Controls.Add(labelStockThreshold);
            panelInventoryFilter.Controls.Add(numericUpDownStockThreshold);
            panelInventoryFilter.Controls.Add(checkBoxShowLowStock);
            panelInventoryFilter.Controls.Add(labelInventoryTitle);
            panelInventoryFilter.Dock = DockStyle.Top;
            panelInventoryFilter.Location = new Point(3, 2);
            panelInventoryFilter.Margin = new Padding(3, 2, 3, 2);
            panelInventoryFilter.Name = "panelInventoryFilter";
            panelInventoryFilter.Padding = new Padding(13, 11, 13, 11);
            panelInventoryFilter.Size = new Size(1024, 76);
            panelInventoryFilter.TabIndex = 0;
            // 
            // buttonExportInventoryPDF
            // 
            buttonExportInventoryPDF.BackColor = Color.FromArgb(220, 53, 69);
            buttonExportInventoryPDF.FlatAppearance.BorderSize = 0;
            buttonExportInventoryPDF.FlatStyle = FlatStyle.Flat;
            buttonExportInventoryPDF.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonExportInventoryPDF.ForeColor = Color.White;
            buttonExportInventoryPDF.Location = new Point(593, 35);
            buttonExportInventoryPDF.Margin = new Padding(3, 2, 3, 2);
            buttonExportInventoryPDF.Name = "buttonExportInventoryPDF";
            buttonExportInventoryPDF.Size = new Size(105, 30);
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
            buttonExportInventoryExcel.Location = new Point(471, 35);
            buttonExportInventoryExcel.Margin = new Padding(3, 2, 3, 2);
            buttonExportInventoryExcel.Name = "buttonExportInventoryExcel";
            buttonExportInventoryExcel.Size = new Size(105, 30);
            buttonExportInventoryExcel.TabIndex = 5;
            buttonExportInventoryExcel.Text = "📄 Xuất Excel";
            buttonExportInventoryExcel.UseVisualStyleBackColor = false;
            buttonExportInventoryExcel.Click += buttonExportInventoryExcel_Click;
            // 
            // labelStockThreshold
            // 
            labelStockThreshold.AutoSize = true;
            labelStockThreshold.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelStockThreshold.Location = new Point(242, 41);
            labelStockThreshold.Name = "labelStockThreshold";
            labelStockThreshold.Size = new Size(133, 19);
            labelStockThreshold.TabIndex = 3;
            labelStockThreshold.Text = "Ngưỡng cảnh báo:";
            // 
            // numericUpDownStockThreshold
            // 
            numericUpDownStockThreshold.Font = new Font("Segoe UI", 10F);
            numericUpDownStockThreshold.Location = new Point(381, 41);
            numericUpDownStockThreshold.Margin = new Padding(3, 2, 3, 2);
            numericUpDownStockThreshold.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownStockThreshold.Name = "numericUpDownStockThreshold";
            numericUpDownStockThreshold.Size = new Size(70, 25);
            numericUpDownStockThreshold.TabIndex = 2;
            numericUpDownStockThreshold.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // checkBoxShowLowStock
            // 
            checkBoxShowLowStock.AutoSize = true;
            checkBoxShowLowStock.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            checkBoxShowLowStock.Location = new Point(16, 40);
            checkBoxShowLowStock.Margin = new Padding(3, 2, 3, 2);
            checkBoxShowLowStock.Name = "checkBoxShowLowStock";
            checkBoxShowLowStock.Size = new Size(220, 23);
            checkBoxShowLowStock.TabIndex = 1;
            checkBoxShowLowStock.Text = "Chỉ hiển thị sản phẩm ít hàng";
            checkBoxShowLowStock.UseVisualStyleBackColor = true;
            // 
            // labelInventoryTitle
            // 
            labelInventoryTitle.AutoSize = true;
            labelInventoryTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelInventoryTitle.ForeColor = Color.FromArgb(77, 58, 41);
            labelInventoryTitle.Location = new Point(16, 11);
            labelInventoryTitle.Name = "labelInventoryTitle";
            labelInventoryTitle.Size = new Size(137, 21);
            labelInventoryTitle.TabIndex = 0;
            labelInventoryTitle.Text = "Báo cáo tồn kho:";
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(77, 58, 41);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 2, 3, 2);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1038, 52);
            panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(26, 15);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(143, 32);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "📈 Báo cáo";
            // 
            // ReportsPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 538);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MaximumSize = new Size(1246, 577);
            MinimumSize = new Size(1246, 577);
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