namespace Presentation.Pages.Admin
{
    partial class CategoryManagementPage
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
            panelHeader = new Panel();
            labelTitle = new Label();
            panelSidebar = new Panel();
            panel1 = new Panel();
            buttonAdminCSKH = new Button();
            buttonAdminHome = new Button();
            buttonManageOrders = new Button();
            pictureBoxLogo = new PictureBox();
            buttonManageProducts = new Button();
            buttonManageInventory = new Button();
            buttonManageCategories = new Button();
            buttonReports = new Button();
            buttonLogout = new Button();
            panelMain = new Panel();
            tabControlCategories = new TabControl();
            tabPageCategories = new TabPage();
            dataGridViewCategories = new DataGridView();
            panelCategoryActions = new Panel();
            buttonRefresh = new Button();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonAdd = new Button();
            groupBoxCategoryInfo = new GroupBox();
            buttonCancel = new Button();
            buttonSave = new Button();
            textBoxCategoryName = new TextBox();
            labelCategoryName = new Label();
            textBoxCategoryId = new TextBox();
            labelCategoryId = new Label();
            panelHeader.SuspendLayout();
            panelSidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelMain.SuspendLayout();
            tabControlCategories.SuspendLayout();
            tabPageCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
            panelCategoryActions.SuspendLayout();
            groupBoxCategoryInfo.SuspendLayout();
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
            labelTitle.Size = new Size(322, 41);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "📂 Quản lý danh mục";
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
            panel1.Controls.Add(buttonAdminCSKH);
            panel1.Controls.Add(buttonAdminHome);
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
            buttonAdminCSKH.TabIndex = 10;
            buttonAdminCSKH.Text = "💬 Trang CSKH";
            buttonAdminCSKH.TextAlign = ContentAlignment.MiddleLeft;
            buttonAdminCSKH.UseVisualStyleBackColor = false;
            buttonAdminCSKH.Click += buttonAdminCSKH_Click;
            // 
            // buttonAdminHome
            // 
            buttonAdminHome.BackColor = Color.FromArgb(95, 76, 59);
            buttonAdminHome.FlatAppearance.BorderSize = 0;
            buttonAdminHome.FlatStyle = FlatStyle.Flat;
            buttonAdminHome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAdminHome.ForeColor = Color.White;
            buttonAdminHome.Location = new Point(3, 150);
            buttonAdminHome.Name = "buttonAdminHome";
            buttonAdminHome.Padding = new Padding(5, 0, 0, 0);
            buttonAdminHome.Size = new Size(200, 50);
            buttonAdminHome.TabIndex = 9;
            buttonAdminHome.Text = "🏠 Trang chủ HeartSteel Cosmetic";
            buttonAdminHome.TextAlign = ContentAlignment.MiddleLeft;
            buttonAdminHome.UseVisualStyleBackColor = false;
            buttonAdminHome.Click += buttonAdminHome_Click;
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
            buttonManageOrders.Size = new Size(200, 50);
            buttonManageOrders.TabIndex = 8;
            buttonManageOrders.Text = "📜 Quản lý đơn hàng\r\n";
            buttonManageOrders.TextAlign = ContentAlignment.MiddleLeft;
            buttonManageOrders.UseVisualStyleBackColor = false;
            buttonManageOrders.Click += buttonManageOrders_Click;
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
            buttonManageInventory.Size = new Size(200, 50);
            buttonManageInventory.TabIndex = 2;
            buttonManageInventory.Text = "📊 Quản lý kho hàng";
            buttonManageInventory.TextAlign = ContentAlignment.MiddleLeft;
            buttonManageInventory.UseVisualStyleBackColor = false;
            buttonManageInventory.Click += buttonManageInventory_Click;
            // 
            // buttonManageCategories
            // 
            buttonManageCategories.BackColor = Color.FromArgb(221, 207, 182);
            buttonManageCategories.FlatAppearance.BorderSize = 0;
            buttonManageCategories.FlatStyle = FlatStyle.Flat;
            buttonManageCategories.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonManageCategories.ForeColor = Color.FromArgb(77, 58, 41);
            buttonManageCategories.Location = new Point(10, 330);
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
            buttonReports.BackColor = Color.FromArgb(95, 76, 59);
            buttonReports.FlatAppearance.BorderSize = 0;
            buttonReports.FlatStyle = FlatStyle.Flat;
            buttonReports.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonReports.ForeColor = Color.White;
            buttonReports.Location = new Point(10, 450);
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
            panelMain.Controls.Add(tabControlCategories);
            panelMain.Controls.Add(panelHeader);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(220, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1184, 709);
            panelMain.TabIndex = 3;
            // 
            // tabControlCategories
            // 
            tabControlCategories.Controls.Add(tabPageCategories);
            tabControlCategories.Dock = DockStyle.Fill;
            tabControlCategories.Location = new Point(0, 70);
            tabControlCategories.Name = "tabControlCategories";
            tabControlCategories.SelectedIndex = 0;
            tabControlCategories.Size = new Size(1184, 639);
            tabControlCategories.TabIndex = 1;
            // 
            // tabPageCategories
            // 
            tabPageCategories.Controls.Add(dataGridViewCategories);
            tabPageCategories.Controls.Add(panelCategoryActions);
            tabPageCategories.Controls.Add(groupBoxCategoryInfo);
            tabPageCategories.Location = new Point(4, 29);
            tabPageCategories.Name = "tabPageCategories";
            tabPageCategories.Padding = new Padding(3);
            tabPageCategories.Size = new Size(1176, 606);
            tabPageCategories.TabIndex = 0;
            tabPageCategories.Text = "Quản lý danh mục";
            tabPageCategories.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCategories
            // 
            dataGridViewCategories.BackgroundColor = Color.White;
            dataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategories.Dock = DockStyle.Fill;
            dataGridViewCategories.Location = new Point(3, 183);
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.RowHeadersWidth = 51;
            dataGridViewCategories.Size = new Size(1170, 420);
            dataGridViewCategories.TabIndex = 2;
            dataGridViewCategories.SelectionChanged += dataGridViewCategories_SelectionChanged;
            // 
            // panelCategoryActions
            // 
            panelCategoryActions.Controls.Add(buttonRefresh);
            panelCategoryActions.Controls.Add(buttonDelete);
            panelCategoryActions.Controls.Add(buttonEdit);
            panelCategoryActions.Controls.Add(buttonAdd);
            panelCategoryActions.Dock = DockStyle.Top;
            panelCategoryActions.Location = new Point(3, 123);
            panelCategoryActions.Name = "panelCategoryActions";
            panelCategoryActions.Size = new Size(1170, 60);
            panelCategoryActions.TabIndex = 1;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.FromArgb(0, 123, 255);
            buttonRefresh.FlatAppearance.BorderSize = 0;
            buttonRefresh.FlatStyle = FlatStyle.Flat;
            buttonRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonRefresh.ForeColor = Color.White;
            buttonRefresh.Location = new Point(441, 14);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(140, 40);
            buttonRefresh.TabIndex = 3;
            buttonRefresh.Text = "🔄 Làm mới";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(220, 53, 69);
            buttonDelete.FlatAppearance.BorderSize = 0;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(295, 14);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(140, 40);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "🗑️ Xóa";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(255, 193, 7);
            buttonEdit.FlatAppearance.BorderSize = 0;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonEdit.ForeColor = Color.White;
            buttonEdit.Location = new Point(149, 14);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(140, 40);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "✏️ Sửa";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(40, 167, 69);
            buttonAdd.FlatAppearance.BorderSize = 0;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(3, 14);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(140, 40);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "➕ Thêm mới";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // groupBoxCategoryInfo
            // 
            groupBoxCategoryInfo.BackColor = Color.White;
            groupBoxCategoryInfo.Controls.Add(buttonCancel);
            groupBoxCategoryInfo.Controls.Add(buttonSave);
            groupBoxCategoryInfo.Controls.Add(textBoxCategoryName);
            groupBoxCategoryInfo.Controls.Add(labelCategoryName);
            groupBoxCategoryInfo.Controls.Add(textBoxCategoryId);
            groupBoxCategoryInfo.Controls.Add(labelCategoryId);
            groupBoxCategoryInfo.Dock = DockStyle.Top;
            groupBoxCategoryInfo.Enabled = false;
            groupBoxCategoryInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxCategoryInfo.ForeColor = Color.FromArgb(77, 58, 41);
            groupBoxCategoryInfo.Location = new Point(3, 3);
            groupBoxCategoryInfo.Name = "groupBoxCategoryInfo";
            groupBoxCategoryInfo.Size = new Size(1170, 120);
            groupBoxCategoryInfo.TabIndex = 0;
            groupBoxCategoryInfo.TabStop = false;
            groupBoxCategoryInfo.Text = "Thông tin danh mục";
            groupBoxCategoryInfo.Enter += groupBoxCategoryInfo_Enter;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(108, 117, 125);
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(591, 40);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(100, 40);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "❌ Hủy";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Visible = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(40, 167, 69);
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(481, 40);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(100, 40);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "💾 Lưu";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Visible = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxCategoryName
            // 
            textBoxCategoryName.Font = new Font("Segoe UI", 10F);
            textBoxCategoryName.Location = new Point(146, 50);
            textBoxCategoryName.Name = "textBoxCategoryName";
            textBoxCategoryName.Size = new Size(300, 30);
            textBoxCategoryName.TabIndex = 3;
            // 
            // labelCategoryName
            // 
            labelCategoryName.AutoSize = true;
            labelCategoryName.Font = new Font("Segoe UI", 10F);
            labelCategoryName.ForeColor = Color.FromArgb(77, 58, 41);
            labelCategoryName.Location = new Point(20, 53);
            labelCategoryName.Name = "labelCategoryName";
            labelCategoryName.Size = new Size(122, 23);
            labelCategoryName.TabIndex = 2;
            labelCategoryName.Text = "Tên danh mục:";
            // 
            // textBoxCategoryId
            // 
            textBoxCategoryId.Font = new Font("Segoe UI", 10F);
            textBoxCategoryId.Location = new Point(146, 20);
            textBoxCategoryId.Name = "textBoxCategoryId";
            textBoxCategoryId.ReadOnly = true;
            textBoxCategoryId.Size = new Size(100, 30);
            textBoxCategoryId.TabIndex = 1;
            textBoxCategoryId.Text = "Tự động";
            // 
            // labelCategoryId
            // 
            labelCategoryId.AutoSize = true;
            labelCategoryId.Font = new Font("Segoe UI", 10F);
            labelCategoryId.ForeColor = Color.FromArgb(77, 58, 41);
            labelCategoryId.Location = new Point(20, 23);
            labelCategoryId.Name = "labelCategoryId";
            labelCategoryId.Size = new Size(120, 23);
            labelCategoryId.TabIndex = 0;
            labelCategoryId.Text = "Mã danh mục:";
            // 
            // CategoryManagementPage
            // 
            ClientSize = new Size(1404, 709);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            Name = "CategoryManagementPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý danh mục - HeartSteel Cosmetic";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelSidebar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelMain.ResumeLayout(false);
            tabControlCategories.ResumeLayout(false);
            tabPageCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
            panelCategoryActions.ResumeLayout(false);
            groupBoxCategoryInfo.ResumeLayout(false);
            groupBoxCategoryInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // Khai báo các biến control
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TabControl tabControlCategories;
        private System.Windows.Forms.TabPage tabPageCategories;
        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.Panel panelCategoryActions;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.GroupBox groupBoxCategoryInfo;
        private System.Windows.Forms.TextBox textBoxCategoryName;
        private System.Windows.Forms.Label labelCategoryName;
        private System.Windows.Forms.TextBox textBoxCategoryId;
        private System.Windows.Forms.Label labelCategoryId;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private Panel panel1;
        private Button buttonManageOrders;
        private PictureBox pictureBoxLogo;
        private Button buttonManageProducts;
        private Button buttonManageInventory;
        private Button buttonManageCategories;
        private Button buttonReports;
        private Button buttonLogout;
        private Button buttonAdminCSKH;
        private Button buttonAdminHome;
    }
}
