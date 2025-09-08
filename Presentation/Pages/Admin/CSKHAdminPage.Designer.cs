namespace Presentation.Pages.Admin
{
    partial class CSKHAdminPage
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
            panelHeader = new System.Windows.Forms.Panel();
            labelTitle = new System.Windows.Forms.Label();
            panelSidebar = new System.Windows.Forms.Panel();
            panelSidebarInner = new System.Windows.Forms.Panel();
            buttonAdminCSKH = new System.Windows.Forms.Button();
            buttonAdminHome = new System.Windows.Forms.Button();
            buttonManageOrders = new System.Windows.Forms.Button();
            pictureBoxLogo = new System.Windows.Forms.PictureBox();
            buttonManageProducts = new System.Windows.Forms.Button();
            buttonManageInventory = new System.Windows.Forms.Button();
            buttonManageCategories = new System.Windows.Forms.Button();
            buttonReports = new System.Windows.Forms.Button();
            buttonLogout = new System.Windows.Forms.Button();
            panelMain = new System.Windows.Forms.Panel();
            panelActions = new System.Windows.Forms.Panel();
            labelSearch = new System.Windows.Forms.Label();
            textBoxSearch = new System.Windows.Forms.TextBox();
            labelFrom = new System.Windows.Forms.Label();
            dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            buttonFilterLatest = new System.Windows.Forms.Button();
            buttonRefresh = new System.Windows.Forms.Button();
            buttonViewDetail = new System.Windows.Forms.Button();
            dataGridViewRequirements = new System.Windows.Forms.DataGridView();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBoxLogo)).BeginInit();
            panelMain.SuspendLayout();
            panelActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridViewRequirements)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = System.Drawing.Color.FromArgb(77, 58, 41);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            panelHeader.Location = new System.Drawing.Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new System.Drawing.Size(1184, 70);
            panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            labelTitle.ForeColor = System.Drawing.Color.White;
            labelTitle.Location = new System.Drawing.Point(30, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(504, 41);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "💬 Yêu cầu hỗ trợ của khách hàng";
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = System.Drawing.Color.FromArgb(77, 58, 41);
            panelSidebar.Controls.Add(panelSidebarInner);
            panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            panelSidebar.Location = new System.Drawing.Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new System.Drawing.Size(220, 709);
            panelSidebar.TabIndex = 2;
            // 
            // panelSidebarInner
            // 
            panelSidebarInner.BackColor = System.Drawing.Color.FromArgb(77, 58, 41);
            panelSidebarInner.Controls.Add(buttonAdminCSKH);
            panelSidebarInner.Controls.Add(buttonAdminHome);
            panelSidebarInner.Controls.Add(buttonManageOrders);
            panelSidebarInner.Controls.Add(pictureBoxLogo);
            panelSidebarInner.Controls.Add(buttonManageProducts);
            panelSidebarInner.Controls.Add(buttonManageInventory);
            panelSidebarInner.Controls.Add(buttonManageCategories);
            panelSidebarInner.Controls.Add(buttonReports);
            panelSidebarInner.Controls.Add(buttonLogout);
            panelSidebarInner.Dock = System.Windows.Forms.DockStyle.Left;
            panelSidebarInner.Location = new System.Drawing.Point(0, 0);
            panelSidebarInner.Name = "panelSidebarInner";
            panelSidebarInner.Size = new System.Drawing.Size(220, 709);
            panelSidebarInner.TabIndex = 1;
            // 
            // buttonAdminCSKH
            // 
            buttonAdminCSKH.BackColor = System.Drawing.Color.FromArgb(221, 207, 182);
            buttonAdminCSKH.FlatAppearance.BorderSize = 0;
            buttonAdminCSKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonAdminCSKH.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            buttonAdminCSKH.ForeColor = System.Drawing.Color.FromArgb(77, 58, 41);
            buttonAdminCSKH.Location = new System.Drawing.Point(10, 510);
            buttonAdminCSKH.Name = "buttonAdminCSKH";
            buttonAdminCSKH.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            buttonAdminCSKH.Size = new System.Drawing.Size(200, 50);
            buttonAdminCSKH.TabIndex = 10;
            buttonAdminCSKH.Text = "💬 Trang CSKH";
            buttonAdminCSKH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAdminCSKH.UseVisualStyleBackColor = false;
            buttonAdminCSKH.Click += new System.EventHandler(this.buttonAdminCSKH_Click);
            // 
            // buttonAdminHome
            // 
            buttonAdminHome.BackColor = System.Drawing.Color.FromArgb(95, 76, 59);
            buttonAdminHome.FlatAppearance.BorderSize = 0;
            buttonAdminHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonAdminHome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            buttonAdminHome.ForeColor = System.Drawing.Color.White;
            buttonAdminHome.Location = new System.Drawing.Point(10, 150);
            buttonAdminHome.Name = "buttonAdminHome";
            buttonAdminHome.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            buttonAdminHome.Size = new System.Drawing.Size(200, 50);
            buttonAdminHome.TabIndex = 9;
            buttonAdminHome.Text = "🏠 Trang chủ HeartSteel Cosmetic";
            buttonAdminHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAdminHome.UseVisualStyleBackColor = false;
            buttonAdminHome.Click += new System.EventHandler(this.buttonAdminHome_Click);
            // 
            // buttonManageOrders
            // 
            buttonManageOrders.BackColor = System.Drawing.Color.FromArgb(95, 76, 59);
            buttonManageOrders.FlatAppearance.BorderSize = 0;
            buttonManageOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonManageOrders.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            buttonManageOrders.ForeColor = System.Drawing.Color.White;
            buttonManageOrders.Location = new System.Drawing.Point(10, 390);
            buttonManageOrders.Name = "buttonManageOrders";
            buttonManageOrders.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            buttonManageOrders.Size = new System.Drawing.Size(200, 50);
            buttonManageOrders.TabIndex = 8;
            buttonManageOrders.Text = "📜 Quản lý đơn hàng";
            buttonManageOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonManageOrders.UseVisualStyleBackColor = false;
            buttonManageOrders.Click += new System.EventHandler(this.buttonManageOrders_Click);
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Location = new System.Drawing.Point(10, 10);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new System.Drawing.Size(200, 120);
            pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // buttonManageProducts
            // 
            buttonManageProducts.BackColor = System.Drawing.Color.FromArgb(95, 76, 59);
            buttonManageProducts.FlatAppearance.BorderSize = 0;
            buttonManageProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonManageProducts.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            buttonManageProducts.ForeColor = System.Drawing.Color.White;
            buttonManageProducts.Location = new System.Drawing.Point(10, 210);
            buttonManageProducts.Name = "buttonManageProducts";
            buttonManageProducts.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            buttonManageProducts.Size = new System.Drawing.Size(200, 50);
            buttonManageProducts.TabIndex = 1;
            buttonManageProducts.Text = "📦 Quản lý sản phẩm";
            buttonManageProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonManageProducts.UseVisualStyleBackColor = false;
            buttonManageProducts.Click += new System.EventHandler(this.buttonManageProducts_Click);
            // 
            // buttonManageInventory
            // 
            buttonManageInventory.BackColor = System.Drawing.Color.FromArgb(95, 76, 59);
            buttonManageInventory.FlatAppearance.BorderSize = 0;
            buttonManageInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonManageInventory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            buttonManageInventory.ForeColor = System.Drawing.Color.White;
            buttonManageInventory.Location = new System.Drawing.Point(10, 270);
            buttonManageInventory.Name = "buttonManageInventory";
            buttonManageInventory.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            buttonManageInventory.Size = new System.Drawing.Size(200, 50);
            buttonManageInventory.TabIndex = 2;
            buttonManageInventory.Text = "📊 Quản lý kho hàng";
            buttonManageInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonManageInventory.UseVisualStyleBackColor = false;
            buttonManageInventory.Click += new System.EventHandler(this.buttonManageInventory_Click);
            // 
            // buttonManageCategories
            // 
            buttonManageCategories.BackColor = System.Drawing.Color.FromArgb(95, 76, 59);
            buttonManageCategories.FlatAppearance.BorderSize = 0;
            buttonManageCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonManageCategories.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            buttonManageCategories.ForeColor = System.Drawing.Color.White;
            buttonManageCategories.Location = new System.Drawing.Point(10, 330);
            buttonManageCategories.Name = "buttonManageCategories";
            buttonManageCategories.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            buttonManageCategories.Size = new System.Drawing.Size(200, 50);
            buttonManageCategories.TabIndex = 3;
            buttonManageCategories.Text = "📂 Quản lý danh mục";
            buttonManageCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonManageCategories.UseVisualStyleBackColor = false;
            buttonManageCategories.Click += new System.EventHandler(this.buttonManageCategories_Click);
            // 
            // buttonReports
            // 
            buttonReports.BackColor = System.Drawing.Color.FromArgb(95, 76, 59);
            buttonReports.FlatAppearance.BorderSize = 0;
            buttonReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonReports.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            buttonReports.ForeColor = System.Drawing.Color.White;
            buttonReports.Location = new System.Drawing.Point(10, 450);
            buttonReports.Name = "buttonReports";
            buttonReports.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            buttonReports.Size = new System.Drawing.Size(200, 50);
            buttonReports.TabIndex = 4;
            buttonReports.Text = "📈 Báo cáo";
            buttonReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonReports.UseVisualStyleBackColor = false;
            buttonReports.Click += new System.EventHandler(this.buttonReports_Click);
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = System.Drawing.Color.FromArgb(184, 84, 84);
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            buttonLogout.ForeColor = System.Drawing.Color.White;
            buttonLogout.Location = new System.Drawing.Point(10, 630);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            buttonLogout.Size = new System.Drawing.Size(200, 50);
            buttonLogout.TabIndex = 5;
            buttonLogout.Text = "🚪 Đăng xuất";
            buttonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // panelMain
            // 
            panelMain.Controls.Add(dataGridViewRequirements);
            panelMain.Controls.Add(panelActions);
            panelMain.Controls.Add(panelHeader);
            panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMain.Location = new System.Drawing.Point(220, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new System.Drawing.Size(1184, 709);
            panelMain.TabIndex = 3;
            // 
            // panelActions
            // 
            panelActions.Controls.Add(buttonViewDetail);
            panelActions.Controls.Add(buttonRefresh);
            panelActions.Controls.Add(buttonFilterLatest);
            panelActions.Controls.Add(labelFrom);
            panelActions.Controls.Add(dateTimePickerFrom);
            panelActions.Controls.Add(labelSearch);
            panelActions.Controls.Add(textBoxSearch);
            panelActions.Dock = System.Windows.Forms.DockStyle.Top;
            panelActions.Location = new System.Drawing.Point(0, 70);
            panelActions.Name = "panelActions";
            panelActions.Size = new System.Drawing.Size(1184, 60);
            panelActions.TabIndex = 0;
            // 
            // labelSearch
            // 
            labelSearch.AutoSize = true;
            labelSearch.Location = new System.Drawing.Point(12, 20);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new System.Drawing.Size(62, 20);
            labelSearch.TabIndex = 1;
            labelSearch.Text = "Tìm tên";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new System.Drawing.Point(80, 16);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new System.Drawing.Size(200, 27);
            textBoxSearch.TabIndex = 0;
            // 
            // labelFrom
            // 
            labelFrom.AutoSize = true;
            labelFrom.Location = new System.Drawing.Point(300, 20);
            labelFrom.Name = "labelFrom";
            labelFrom.Size = new System.Drawing.Size(64, 20);
            labelFrom.TabIndex = 3;
            labelFrom.Text = "Từ ngày";
            // 
            // dateTimePickerFrom
            // 
            dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimePickerFrom.Location = new System.Drawing.Point(370, 16);
            dateTimePickerFrom.Name = "dateTimePickerFrom";
            dateTimePickerFrom.Size = new System.Drawing.Size(130, 27);
            dateTimePickerFrom.TabIndex = 2;
            // 
            // buttonFilterLatest
            // 
            buttonFilterLatest.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            buttonFilterLatest.Location = new System.Drawing.Point(510, 14);
            buttonFilterLatest.Name = "buttonFilterLatest";
            buttonFilterLatest.Size = new System.Drawing.Size(140, 35);
            buttonFilterLatest.TabIndex = 4;
            buttonFilterLatest.Text = "📋 Lọc mới nhất";
            buttonFilterLatest.UseVisualStyleBackColor = false;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            buttonRefresh.Location = new System.Drawing.Point(660, 14);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new System.Drawing.Size(120, 35);
            buttonRefresh.TabIndex = 5;
            buttonRefresh.Text = "🔄 Làm mới";
            buttonRefresh.UseVisualStyleBackColor = false;
            // 
            // buttonViewDetail
            // 
            buttonViewDetail.BackColor = System.Drawing.Color.FromArgb(0, 192, 0);
            buttonViewDetail.Location = new System.Drawing.Point(790, 14);
            buttonViewDetail.Name = "buttonViewDetail";
            buttonViewDetail.Size = new System.Drawing.Size(160, 35);
            buttonViewDetail.TabIndex = 6;
            buttonViewDetail.Text = "👁 Xem/Phản hồi";
            buttonViewDetail.UseVisualStyleBackColor = false;
            // 
            // dataGridViewRequirements
            // 
            dataGridViewRequirements.BackgroundColor = System.Drawing.Color.White;
            dataGridViewRequirements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRequirements.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewRequirements.Location = new System.Drawing.Point(0, 130);
            dataGridViewRequirements.Name = "dataGridViewRequirements";
            dataGridViewRequirements.RowHeadersWidth = 51;
            dataGridViewRequirements.Size = new System.Drawing.Size(1184, 579);
            dataGridViewRequirements.TabIndex = 1;
            // 
            // CSKHAdminPage
            // 
            this.ClientSize = new System.Drawing.Size(1404, 709);
            this.Controls.Add(panelMain);
            this.Controls.Add(panelSidebar);
            this.Name = "CSKHAdminPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSKH - HeartSteel Cosmetic";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridViewRequirements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pictureBoxLogo)).EndInit();
            panelMain.ResumeLayout(false);
            panelActions.ResumeLayout(false);
            panelActions.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelSidebarInner;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Button buttonFilterLatest;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonViewDetail;
        private System.Windows.Forms.DataGridView dataGridViewRequirements;
        private System.Windows.Forms.Button buttonAdminCSKH;
        private System.Windows.Forms.Button buttonAdminHome;
        private System.Windows.Forms.Button buttonManageOrders;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonManageProducts;
        private System.Windows.Forms.Button buttonManageInventory;
        private System.Windows.Forms.Button buttonManageCategories;
        private System.Windows.Forms.Button buttonReports;
        private System.Windows.Forms.Button buttonLogout;
    }
}