namespace Presentation.Pages.Admin
{
    partial class OrderManagementPage
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
            panelSidebar = new Panel();
            buttonAdminHome = new Button();
            buttonAdminCSKH = new Button();
            buttonLogout = new Button();
            buttonManageInventory = new Button();
            buttonReports = new Button();
            buttonManageCategories = new Button();
            pictureBoxLogo = new PictureBox();
            buttonManageOrders = new Button();
            buttonManageProducts = new Button();
            panelMain = new Panel();
            panelOrderDetails = new Panel();
            groupBoxOrderInfo = new GroupBox();
            comboBoxStatus = new ComboBox();
            labelStatus = new Label();
            numericUpDownTotalAmount = new NumericUpDown();
            labelTotalAmount = new Label();
            dateTimePickerOrderDate = new DateTimePicker();
            labelOrderDate = new Label();
            textBoxCustomerName = new TextBox();
            labelCustomerName = new Label();
            textBoxOrderId = new TextBox();
            labelOrderId = new Label();
            buttonSave = new Button();
            buttonCancel = new Button();
            dataGridViewOrders = new DataGridView();
            panelActions = new Panel();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonRefresh = new Button();
            panelSearch = new Panel();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            labelSearch = new Label();
            panelHeader = new Panel();
            labelTitle = new Label();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelMain.SuspendLayout();
            panelOrderDetails.SuspendLayout();
            groupBoxOrderInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTotalAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
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
            panelSidebar.Controls.Add(buttonLogout);
            panelSidebar.Controls.Add(buttonManageInventory);
            panelSidebar.Controls.Add(buttonReports);
            panelSidebar.Controls.Add(buttonManageCategories);
            panelSidebar.Controls.Add(pictureBoxLogo);
            panelSidebar.Controls.Add(buttonManageOrders);
            panelSidebar.Controls.Add(buttonManageProducts);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(220, 709);
            panelSidebar.TabIndex = 0;
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
            buttonAdminHome.Size = new Size(200, 50);
            buttonAdminHome.TabIndex = 12;
            buttonAdminHome.Text = "🏠 Trang chủ HeartSteel Cosmetic";
            buttonAdminHome.TextAlign = ContentAlignment.MiddleLeft;
            buttonAdminHome.UseVisualStyleBackColor = false;
            buttonAdminHome.Click += buttonAdminHome_Click;
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
            buttonAdminCSKH.Size = new Size(200, 50);
            buttonAdminCSKH.TabIndex = 11;
            buttonAdminCSKH.Text = "💬 Trang CSKH";
            buttonAdminCSKH.TextAlign = ContentAlignment.MiddleLeft;
            buttonAdminCSKH.UseVisualStyleBackColor = false;
            buttonAdminCSKH.Click += buttonAdminCSKH_Click;
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
            buttonLogout.TabIndex = 10;
            buttonLogout.Text = "🚪 Đăng xuất";
            buttonLogout.TextAlign = ContentAlignment.MiddleLeft;
            buttonLogout.UseVisualStyleBackColor = false;
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
            buttonManageInventory.Size = new Size(200, 50);
            buttonManageInventory.TabIndex = 9;
            buttonManageInventory.Text = "📊 Quản lý kho hàng";
            buttonManageInventory.TextAlign = ContentAlignment.MiddleLeft;
            buttonManageInventory.UseVisualStyleBackColor = false;
            buttonManageInventory.Click += buttonManageInventory_Click_1;
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
            buttonReports.Size = new Size(200, 50);
            buttonReports.TabIndex = 8;
            buttonReports.Text = "📈 Báo cáo";
            buttonReports.TextAlign = ContentAlignment.MiddleLeft;
            buttonReports.UseVisualStyleBackColor = false;
            buttonReports.Click += buttonReports_Click_1;
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
            buttonManageCategories.Size = new Size(200, 50);
            buttonManageCategories.TabIndex = 7;
            buttonManageCategories.Text = "📂 Quản lý danh mục";
            buttonManageCategories.TextAlign = ContentAlignment.MiddleLeft;
            buttonManageCategories.UseVisualStyleBackColor = false;
            buttonManageCategories.Click += buttonManageCategories_Click_1;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Location = new Point(10, 10);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(200, 120);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // buttonManageOrders
            // 
            buttonManageOrders.BackColor = Color.FromArgb(221, 207, 182);
            buttonManageOrders.FlatAppearance.BorderSize = 0;
            buttonManageOrders.FlatStyle = FlatStyle.Flat;
            buttonManageOrders.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonManageOrders.ForeColor = Color.FromArgb(77, 58, 41);
            buttonManageOrders.Location = new Point(10, 390);
            buttonManageOrders.Name = "buttonManageOrders";
            buttonManageOrders.Padding = new Padding(5, 0, 0, 0);
            buttonManageOrders.Size = new Size(200, 50);
            buttonManageOrders.TabIndex = 1;
            buttonManageOrders.Text = "📜 Quản lý đơn hàng";
            buttonManageOrders.TextAlign = ContentAlignment.MiddleLeft;
            buttonManageOrders.UseVisualStyleBackColor = false;
            buttonManageOrders.Click += buttonManageOrders_Click;
            // 
            // buttonManageProducts
            // 
            buttonManageProducts.BackColor = Color.FromArgb(95, 76, 59);
            buttonManageProducts.FlatAppearance.BorderSize = 0;
            buttonManageProducts.FlatStyle = FlatStyle.Flat;
            buttonManageProducts.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonManageProducts.ForeColor = Color.White;
            buttonManageProducts.Location = new Point(10, 210);
            buttonManageProducts.Name = "buttonManageProducts";
            buttonManageProducts.Padding = new Padding(5, 0, 0, 0);
            buttonManageProducts.Size = new Size(200, 50);
            buttonManageProducts.TabIndex = 2;
            buttonManageProducts.Text = "📦 Quản lý sản phẩm";
            buttonManageProducts.TextAlign = ContentAlignment.MiddleLeft;
            buttonManageProducts.UseVisualStyleBackColor = false;
            buttonManageProducts.Click += buttonManageProducts_Click;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panelOrderDetails);
            panelMain.Controls.Add(dataGridViewOrders);
            panelMain.Controls.Add(panelActions);
            panelMain.Controls.Add(panelSearch);
            panelMain.Controls.Add(panelHeader);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(220, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1184, 709);
            panelMain.TabIndex = 1;
            // 
            // panelOrderDetails
            // 
            panelOrderDetails.BackColor = Color.FromArgb(250, 245, 238);
            panelOrderDetails.Controls.Add(groupBoxOrderInfo);
            panelOrderDetails.Controls.Add(buttonSave);
            panelOrderDetails.Controls.Add(buttonCancel);
            panelOrderDetails.Dock = DockStyle.Fill;
            panelOrderDetails.Location = new Point(680, 210);
            panelOrderDetails.Name = "panelOrderDetails";
            panelOrderDetails.Padding = new Padding(20);
            panelOrderDetails.Size = new Size(504, 499);
            panelOrderDetails.TabIndex = 4;
            // 
            // groupBoxOrderInfo
            // 
            groupBoxOrderInfo.Controls.Add(comboBoxStatus);
            groupBoxOrderInfo.Controls.Add(labelStatus);
            groupBoxOrderInfo.Controls.Add(numericUpDownTotalAmount);
            groupBoxOrderInfo.Controls.Add(labelTotalAmount);
            groupBoxOrderInfo.Controls.Add(dateTimePickerOrderDate);
            groupBoxOrderInfo.Controls.Add(labelOrderDate);
            groupBoxOrderInfo.Controls.Add(textBoxCustomerName);
            groupBoxOrderInfo.Controls.Add(labelCustomerName);
            groupBoxOrderInfo.Controls.Add(textBoxOrderId);
            groupBoxOrderInfo.Controls.Add(labelOrderId);
            groupBoxOrderInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBoxOrderInfo.Location = new Point(23, 23);
            groupBoxOrderInfo.Name = "groupBoxOrderInfo";
            groupBoxOrderInfo.Size = new Size(454, 380);
            groupBoxOrderInfo.TabIndex = 0;
            groupBoxOrderInfo.TabStop = false;
            groupBoxOrderInfo.Text = "Thông tin đơn hàng";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.Font = new Font("Segoe UI", 10F);
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(20, 310);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(410, 31);
            comboBoxStatus.TabIndex = 9;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelStatus.Location = new Point(20, 280);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(97, 23);
            labelStatus.TabIndex = 8;
            labelStatus.Text = "Trạng thái:";
            // 
            // numericUpDownTotalAmount
            // 
            numericUpDownTotalAmount.Font = new Font("Segoe UI", 10F);
            numericUpDownTotalAmount.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownTotalAmount.Location = new Point(20, 240);
            numericUpDownTotalAmount.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDownTotalAmount.Name = "numericUpDownTotalAmount";
            numericUpDownTotalAmount.ReadOnly = true;
            numericUpDownTotalAmount.Size = new Size(410, 30);
            numericUpDownTotalAmount.TabIndex = 7;
            numericUpDownTotalAmount.ThousandsSeparator = true;
            // 
            // labelTotalAmount
            // 
            labelTotalAmount.AutoSize = true;
            labelTotalAmount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelTotalAmount.Location = new Point(17, 210);
            labelTotalAmount.Name = "labelTotalAmount";
            labelTotalAmount.Size = new Size(92, 23);
            labelTotalAmount.TabIndex = 6;
            labelTotalAmount.Text = "Tổng tiền:";
            // 
            // dateTimePickerOrderDate
            // 
            dateTimePickerOrderDate.CustomFormat = "dd/MM/yyyy";
            dateTimePickerOrderDate.Font = new Font("Segoe UI", 10F);
            dateTimePickerOrderDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerOrderDate.Location = new Point(20, 170);
            dateTimePickerOrderDate.Name = "dateTimePickerOrderDate";
            dateTimePickerOrderDate.Size = new Size(410, 30);
            dateTimePickerOrderDate.TabIndex = 5;
            // 
            // labelOrderDate
            // 
            labelOrderDate.AutoSize = true;
            labelOrderDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelOrderDate.Location = new Point(20, 140);
            labelOrderDate.Name = "labelOrderDate";
            labelOrderDate.Size = new Size(89, 23);
            labelOrderDate.TabIndex = 4;
            labelOrderDate.Text = "Ngày đặt:";
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.Font = new Font("Segoe UI", 10F);
            textBoxCustomerName.Location = new Point(20, 100);
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.ReadOnly = true;
            textBoxCustomerName.Size = new Size(410, 30);
            textBoxCustomerName.TabIndex = 3;
            // 
            // labelCustomerName
            // 
            labelCustomerName.AutoSize = true;
            labelCustomerName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelCustomerName.Location = new Point(20, 70);
            labelCustomerName.Name = "labelCustomerName";
            labelCustomerName.Size = new Size(139, 23);
            labelCustomerName.TabIndex = 2;
            labelCustomerName.Text = "Tên khách hàng:";
            // 
            // textBoxOrderId
            // 
            textBoxOrderId.Font = new Font("Segoe UI", 10F);
            textBoxOrderId.Location = new Point(148, 33);
            textBoxOrderId.Name = "textBoxOrderId";
            textBoxOrderId.ReadOnly = true;
            textBoxOrderId.Size = new Size(100, 30);
            textBoxOrderId.TabIndex = 1;
            // 
            // labelOrderId
            // 
            labelOrderId.AutoSize = true;
            labelOrderId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            labelOrderId.Location = new Point(20, 35);
            labelOrderId.Name = "labelOrderId";
            labelOrderId.Size = new Size(122, 23);
            labelOrderId.TabIndex = 0;
            labelOrderId.Text = "Mã đơn hàng:";
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
            buttonSave.Click += buttonSave_Click;
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
            buttonCancel.Click += buttonCancel_Click;
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.AllowUserToAddRows = false;
            dataGridViewOrders.AllowUserToDeleteRows = false;
            dataGridViewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOrders.BackgroundColor = Color.White;
            dataGridViewOrders.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Dock = DockStyle.Left;
            dataGridViewOrders.Location = new Point(0, 210);
            dataGridViewOrders.MultiSelect = false;
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.ReadOnly = true;
            dataGridViewOrders.RowHeadersWidth = 51;
            dataGridViewOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOrders.Size = new Size(680, 499);
            dataGridViewOrders.TabIndex = 3;
            dataGridViewOrders.CellDoubleClick += dataGridViewOrders_CellDoubleClick;
            dataGridViewOrders.SelectionChanged += dataGridViewOrders_SelectionChanged;
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
            panelActions.Location = new Point(0, 150);
            panelActions.Name = "panelActions";
            panelActions.Padding = new Padding(15, 10, 15, 10);
            panelActions.Size = new Size(1184, 60);
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
            buttonAdd.Click += buttonAdd_Click;
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
            buttonEdit.Click += buttonEdit_Click;
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
            buttonDelete.Click += buttonDelete_Click;
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
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // panelSearch
            // 
            panelSearch.BackColor = Color.White;
            panelSearch.BorderStyle = BorderStyle.FixedSingle;
            panelSearch.Controls.Add(textBoxSearch);
            panelSearch.Controls.Add(buttonSearch);
            panelSearch.Controls.Add(labelSearch);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(0, 70);
            panelSearch.Name = "panelSearch";
            panelSearch.Padding = new Padding(15);
            panelSearch.Size = new Size(1184, 80);
            panelSearch.TabIndex = 1;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Segoe UI", 10F);
            textBoxSearch.Location = new Point(115, 25);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Tìm kiếm theo tên khách hàng...";
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
            buttonSearch.Location = new Point(375, 20);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(100, 40);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "🔍 Tìm kiếm";
            buttonSearch.UseVisualStyleBackColor = false;
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
            labelTitle.Size = new Size(319, 41);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "📜 Quản lý đơn hàng";
            // 
            // OrderManagementPage
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
            Name = "OrderManagementPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý đơn hàng - HeartSteel Cosmetic";
            panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelMain.ResumeLayout(false);
            panelOrderDetails.ResumeLayout(false);
            groupBoxOrderInfo.ResumeLayout(false);
            groupBoxOrderInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTotalAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            panelActions.ResumeLayout(false);
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonManageProducts;
        private System.Windows.Forms.Button buttonManageOrders;
        private System.Windows.Forms.Button buttonManageCategories;
        private Button buttonReports;
        private Button buttonManageInventory;
        private Button buttonLogout;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Panel panelOrderDetails;
        private System.Windows.Forms.GroupBox groupBoxOrderInfo;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrderDate;
        private System.Windows.Forms.Label labelOrderDate;
        private System.Windows.Forms.NumericUpDown numericUpDownTotalAmount;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxOrderId;
        private System.Windows.Forms.Label labelOrderId;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private Button buttonAdminHome;
        private Button buttonAdminCSKH;
    }
}