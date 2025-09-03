namespace Presentation.Pages.Admin
{
    partial class InventoryManagementPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryManagementPage));
            panelHeader = new Panel();
            labelTitle = new Label();
            panelSidebar = new Panel();
            panel1 = new Panel();
            buttonManageOrders = new Button();
            pictureBoxLogo = new PictureBox();
            buttonManageProducts = new Button();
            buttonManageInventory = new Button();
            buttonManageCategories = new Button();
            buttonReports = new Button();
            buttonLogout = new Button();
            panelMain = new Panel();
            tabControlInventory = new TabControl();
            tabPageInventory = new TabPage();
            dataGridViewInventory = new DataGridView();
            panelInventoryActions = new Panel();
            buttonRefreshStock = new Button();
            buttonCheckInventory = new Button();
            buttonStockIn = new Button();
            buttonStockOut = new Button();
            tabPageStockAlerts = new TabPage();
            dataGridViewStockAlerts = new DataGridView();
            panelAlertActions = new Panel();
            buttonMarkAllRead = new Button();
            panelHeader.SuspendLayout();
            panelSidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelMain.SuspendLayout();
            tabControlInventory.SuspendLayout();
            tabPageInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).BeginInit();
            panelInventoryActions.SuspendLayout();
            tabPageStockAlerts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStockAlerts).BeginInit();
            SuspendLayout();
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
            labelTitle.Size = new Size(316, 41);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "📊 Quản lý kho hàng";
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(77, 58, 41);
            panelSidebar.Controls.Add(panel1);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(220, 709);
            panelSidebar.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(77, 58, 41);
            panel1.Controls.Add(buttonManageOrders);
            panel1.Controls.Add(pictureBoxLogo);
            panel1.Controls.Add(buttonManageProducts);
            panel1.Controls.Add(buttonManageInventory);
            panel1.Controls.Add(buttonManageCategories);
            panel1.Controls.Add(buttonReports);
            panel1.Controls.Add(buttonLogout);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(220, 709);
            panel1.TabIndex = 1;
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
            buttonManageProducts.Click += buttonManageProducts_Click_1;
            // 
            // buttonManageInventory
            // 
            buttonManageInventory.BackColor = Color.FromArgb(221, 207, 182);
            buttonManageInventory.FlatAppearance.BorderSize = 0;
            buttonManageInventory.FlatStyle = FlatStyle.Flat;
            buttonManageInventory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonManageInventory.ForeColor = Color.FromArgb(77, 58, 41);
            buttonManageInventory.Location = new Point(10, 210);
            buttonManageInventory.Name = "buttonManageInventory";
            buttonManageInventory.Padding = new Padding(5, 0, 0, 0);
            buttonManageInventory.Size = new Size(200, 50);
            buttonManageInventory.TabIndex = 2;
            buttonManageInventory.Text = "📊 Quản lý kho hàng";
            buttonManageInventory.TextAlign = ContentAlignment.MiddleLeft;
            buttonManageInventory.UseVisualStyleBackColor = false;
            buttonManageInventory.Click += buttonManageInventory_Click_1;
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
            buttonManageCategories.Click += buttonManageCategories_Click_1;
            // 
            // buttonReports
            // 
            buttonReports.BackColor = Color.FromArgb(95, 76, 59);
            buttonReports.FlatAppearance.BorderSize = 0;
            buttonReports.FlatStyle = FlatStyle.Flat;
            buttonReports.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonReports.ForeColor = Color.White;
            buttonReports.Location = new Point(10, 390);
            buttonReports.Name = "buttonReports";
            buttonReports.Padding = new Padding(5, 0, 0, 0);
            buttonReports.Size = new Size(200, 50);
            buttonReports.TabIndex = 4;
            buttonReports.Text = "📈 Báo cáo";
            buttonReports.TextAlign = ContentAlignment.MiddleLeft;
            buttonReports.UseVisualStyleBackColor = false;
            buttonReports.Click += buttonReports_Click_1;
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
            buttonLogout.Click += buttonLogout_Click_1;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(tabControlInventory);
            panelMain.Controls.Add(panelHeader);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(220, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1184, 709);
            panelMain.TabIndex = 3;
            // 
            // tabControlInventory
            // 
            tabControlInventory.Controls.Add(tabPageInventory);
            tabControlInventory.Controls.Add(tabPageStockAlerts);
            tabControlInventory.Dock = DockStyle.Fill;
            tabControlInventory.Location = new Point(0, 70);
            tabControlInventory.Name = "tabControlInventory";
            tabControlInventory.SelectedIndex = 0;
            tabControlInventory.Size = new Size(1184, 639);
            tabControlInventory.TabIndex = 1;
            // 
            // tabPageInventory
            // 
            tabPageInventory.Controls.Add(dataGridViewInventory);
            tabPageInventory.Controls.Add(panelInventoryActions);
            tabPageInventory.Location = new Point(4, 29);
            tabPageInventory.Name = "tabPageInventory";
            tabPageInventory.Padding = new Padding(3);
            tabPageInventory.Size = new Size(1176, 606);
            tabPageInventory.TabIndex = 0;
            tabPageInventory.Text = "Quản lý tồn kho";
            tabPageInventory.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInventory
            // 
            dataGridViewInventory.BackgroundColor = Color.White;
            dataGridViewInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInventory.Dock = DockStyle.Fill;
            dataGridViewInventory.Location = new Point(3, 63);
            dataGridViewInventory.Name = "dataGridViewInventory";
            dataGridViewInventory.RowHeadersWidth = 51;
            dataGridViewInventory.Size = new Size(1170, 540);
            dataGridViewInventory.TabIndex = 1;
            // 
            // panelInventoryActions
            // 
            panelInventoryActions.Controls.Add(buttonRefreshStock);
            panelInventoryActions.Controls.Add(buttonCheckInventory);
            panelInventoryActions.Controls.Add(buttonStockIn);
            panelInventoryActions.Controls.Add(buttonStockOut);
            panelInventoryActions.Dock = DockStyle.Top;
            panelInventoryActions.Location = new Point(3, 3);
            panelInventoryActions.Name = "panelInventoryActions";
            panelInventoryActions.Size = new Size(1170, 60);
            panelInventoryActions.TabIndex = 0;
            // 
            // buttonRefreshStock
            // 
            buttonRefreshStock.BackColor = Color.FromArgb(0, 123, 255);
            buttonRefreshStock.Location = new Point(441, 14);
            buttonRefreshStock.Name = "buttonRefreshStock";
            buttonRefreshStock.Size = new Size(140, 40);
            buttonRefreshStock.TabIndex = 0;
            buttonRefreshStock.Text = "🔄 Làm mới";
            buttonRefreshStock.UseVisualStyleBackColor = false;
            buttonRefreshStock.Click += buttonRefreshStock_Click;
            // 
            // buttonCheckInventory
            // 
            buttonCheckInventory.BackColor = Color.FromArgb(52, 152, 219);
            buttonCheckInventory.Location = new Point(295, 14);
            buttonCheckInventory.Name = "buttonCheckInventory";
            buttonCheckInventory.Size = new Size(140, 40);
            buttonCheckInventory.TabIndex = 1;
            buttonCheckInventory.Text = "📋 Kiểm kê";
            buttonCheckInventory.UseVisualStyleBackColor = false;
            buttonCheckInventory.Click += buttonCheckInventory_Click;
            // 
            // buttonStockIn
            // 
            buttonStockIn.BackColor = Color.FromArgb(0, 192, 0);
            buttonStockIn.Location = new Point(3, 14);
            buttonStockIn.Name = "buttonStockIn";
            buttonStockIn.Size = new Size(140, 40);
            buttonStockIn.TabIndex = 3;
            buttonStockIn.Text = "➕ Nhập hàng";
            buttonStockIn.UseVisualStyleBackColor = false;
            buttonStockIn.Click += buttonStockIn_Click_1;
            // 
            // buttonStockOut
            // 
            buttonStockOut.BackColor = Color.FromArgb(192, 64, 0);
            buttonStockOut.Location = new Point(149, 14);
            buttonStockOut.Name = "buttonStockOut";
            buttonStockOut.Size = new Size(140, 40);
            buttonStockOut.TabIndex = 2;
            buttonStockOut.Text = "➖ Xuất hàng";
            buttonStockOut.UseVisualStyleBackColor = false;
            buttonStockOut.Click += buttonStockOut_Click_1;
            // 
            // tabPageStockAlerts
            // 
            tabPageStockAlerts.Controls.Add(dataGridViewStockAlerts);
            tabPageStockAlerts.Controls.Add(panelAlertActions);
            tabPageStockAlerts.Location = new Point(4, 29);
            tabPageStockAlerts.Name = "tabPageStockAlerts";
            tabPageStockAlerts.Padding = new Padding(3);
            tabPageStockAlerts.Size = new Size(1176, 606);
            tabPageStockAlerts.TabIndex = 1;
            tabPageStockAlerts.Text = "Cảnh báo hết hàng";
            tabPageStockAlerts.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStockAlerts
            // 
            dataGridViewStockAlerts.BackgroundColor = Color.White;
            dataGridViewStockAlerts.ColumnHeadersHeight = 29;
            dataGridViewStockAlerts.Location = new Point(0, 0);
            dataGridViewStockAlerts.Name = "dataGridViewStockAlerts";
            dataGridViewStockAlerts.RowHeadersWidth = 51;
            dataGridViewStockAlerts.Size = new Size(1177, 341);
            dataGridViewStockAlerts.TabIndex = 0;
            // 
            // panelAlertActions
            // 
            panelAlertActions.Location = new Point(0, 0);
            panelAlertActions.Name = "panelAlertActions";
            panelAlertActions.Size = new Size(200, 100);
            panelAlertActions.TabIndex = 1;
            // 
            // buttonMarkAllRead
            // 
            buttonMarkAllRead.Location = new Point(0, 0);
            buttonMarkAllRead.Name = "buttonMarkAllRead";
            buttonMarkAllRead.Size = new Size(75, 23);
            buttonMarkAllRead.TabIndex = 0;
            buttonMarkAllRead.Text = "Đánh dấu đã đọc";
            // 
            // InventoryManagementPage
            // 
            ClientSize = new Size(1404, 709);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            Name = "InventoryManagementPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý kho hàng - HeartSteel Cosmetic";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelSidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelMain.ResumeLayout(false);
            tabControlInventory.ResumeLayout(false);
            tabPageInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInventory).EndInit();
            panelInventoryActions.ResumeLayout(false);
            tabPageStockAlerts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStockAlerts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // Khai báo các biến control
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TabControl tabControlInventory;
        private System.Windows.Forms.TabPage tabPageInventory;
        private System.Windows.Forms.TabPage tabPageStockAlerts;
        private System.Windows.Forms.DataGridView dataGridViewInventory;
        private System.Windows.Forms.Panel panelInventoryActions;
        private System.Windows.Forms.Button buttonStockIn;
        private System.Windows.Forms.Button buttonStockOut;
        private System.Windows.Forms.Button buttonCheckInventory;
        private System.Windows.Forms.Button buttonRefreshStock;
        private System.Windows.Forms.DataGridView dataGridViewStockAlerts;
        private System.Windows.Forms.Panel panelAlertActions;
        private System.Windows.Forms.Button buttonMarkAllRead;
        private Panel panel1;
        private Button buttonManageOrders;
        private PictureBox pictureBoxLogo;
        private Button buttonManageProducts;
        private Button buttonManageInventory;
        private Button buttonManageCategories;
        private Button buttonReports;
        private Button buttonLogout;
    }
}