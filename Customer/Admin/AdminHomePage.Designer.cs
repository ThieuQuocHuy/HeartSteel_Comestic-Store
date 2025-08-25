namespace Customer.Admin
{
    partial class AdminHomePage
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
            pictureBoxLogo = new PictureBox();
            buttonDashboard = new Button();
            buttonProducts = new Button();
            buttonInventory = new Button();
            buttonReports = new Button();
            buttonSettings = new Button();
            panelMain = new Panel();
            labelTitle = new Label();
            panelStats = new Panel();
            panelStat1 = new Panel();
            labelTotalProducts = new Label();
            label2 = new Label();
            panelStat2 = new Panel();
            labelLowStock = new Label();
            label4 = new Label();
            panelStat3 = new Panel();
            labelInventoryValue = new Label();
            label6 = new Label();
            labelWelcome = new Label();
            labelAdminName = new Label();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelMain.SuspendLayout();
            panelStats.SuspendLayout();
            panelStat1.SuspendLayout();
            panelStat2.SuspendLayout();
            panelStat3.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(44, 62, 80);
            panelSidebar.Controls.Add(pictureBoxLogo);
            panelSidebar.Controls.Add(buttonDashboard);
            panelSidebar.Controls.Add(buttonProducts);
            panelSidebar.Controls.Add(buttonInventory);
            panelSidebar.Controls.Add(buttonReports);
            panelSidebar.Controls.Add(buttonSettings);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(250, 700);
            panelSidebar.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.FromArgb(52, 73, 94);
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(250, 120);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            pictureBoxLogo.Click += pictureBoxLogo_Click;
            // 
            // buttonDashboard
            // 
            buttonDashboard.BackColor = Color.FromArgb(52, 152, 219);
            buttonDashboard.FlatAppearance.BorderSize = 0;
            buttonDashboard.FlatStyle = FlatStyle.Flat;
            buttonDashboard.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            buttonDashboard.ForeColor = Color.White;
            buttonDashboard.Location = new Point(0, 120);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Padding = new Padding(20, 0, 0, 0);
            buttonDashboard.Size = new Size(250, 60);
            buttonDashboard.TabIndex = 1;
            buttonDashboard.Text = "🏠 Trang chủ";
            buttonDashboard.TextAlign = ContentAlignment.MiddleLeft;
            buttonDashboard.UseVisualStyleBackColor = false;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // buttonProducts
            // 
            buttonProducts.BackColor = Color.FromArgb(44, 62, 80);
            buttonProducts.FlatAppearance.BorderSize = 0;
            buttonProducts.FlatStyle = FlatStyle.Flat;
            buttonProducts.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            buttonProducts.ForeColor = Color.White;
            buttonProducts.Location = new Point(0, 180);
            buttonProducts.Name = "buttonProducts";
            buttonProducts.Padding = new Padding(20, 0, 0, 0);
            buttonProducts.Size = new Size(250, 60);
            buttonProducts.TabIndex = 2;
            buttonProducts.Text = "📦 Quản lý sản phẩm";
            buttonProducts.TextAlign = ContentAlignment.MiddleLeft;
            buttonProducts.UseVisualStyleBackColor = false;
            buttonProducts.Click += buttonProducts_Click;
            // 
            // buttonInventory
            // 
            buttonInventory.BackColor = Color.FromArgb(44, 62, 80);
            buttonInventory.FlatAppearance.BorderSize = 0;
            buttonInventory.FlatStyle = FlatStyle.Flat;
            buttonInventory.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            buttonInventory.ForeColor = Color.White;
            buttonInventory.Location = new Point(0, 240);
            buttonInventory.Name = "buttonInventory";
            buttonInventory.Padding = new Padding(20, 0, 0, 0);
            buttonInventory.Size = new Size(250, 60);
            buttonInventory.TabIndex = 3;
            buttonInventory.Text = "📊 Quản lý kho hàng";
            buttonInventory.TextAlign = ContentAlignment.MiddleLeft;
            buttonInventory.UseVisualStyleBackColor = false;
            buttonInventory.Click += buttonInventory_Click;
            // 
            // buttonReports
            // 
            buttonReports.BackColor = Color.FromArgb(44, 62, 80);
            buttonReports.FlatAppearance.BorderSize = 0;
            buttonReports.FlatStyle = FlatStyle.Flat;
            buttonReports.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            buttonReports.ForeColor = Color.White;
            buttonReports.Location = new Point(0, 300);
            buttonReports.Name = "buttonReports";
            buttonReports.Padding = new Padding(20, 0, 0, 0);
            buttonReports.Size = new Size(250, 60);
            buttonReports.TabIndex = 4;
            buttonReports.Text = "📈 Báo cáo";
            buttonReports.TextAlign = ContentAlignment.MiddleLeft;
            buttonReports.UseVisualStyleBackColor = false;
            buttonReports.Click += buttonReports_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.BackColor = Color.FromArgb(44, 62, 80);
            buttonSettings.FlatAppearance.BorderSize = 0;
            buttonSettings.FlatStyle = FlatStyle.Flat;
            buttonSettings.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            buttonSettings.ForeColor = Color.White;
            buttonSettings.Location = new Point(0, 360);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Padding = new Padding(20, 0, 0, 0);
            buttonSettings.Size = new Size(250, 60);
            buttonSettings.TabIndex = 5;
            buttonSettings.Text = "⚙️ Cài đặt";
            buttonSettings.TextAlign = ContentAlignment.MiddleLeft;
            buttonSettings.UseVisualStyleBackColor = false;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(236, 240, 241);
            panelMain.Controls.Add(labelTitle);
            panelMain.Controls.Add(panelStats);
            panelMain.Controls.Add(labelWelcome);
            panelMain.Controls.Add(labelAdminName);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(250, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(30);
            panelMain.Size = new Size(950, 700);
            panelMain.TabIndex = 1;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(44, 62, 80);
            labelTitle.Location = new Point(30, 30);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(341, 54);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Admin Dashboard";
            // 
            // panelStats
            // 
            panelStats.Controls.Add(panelStat1);
            panelStats.Controls.Add(panelStat2);
            panelStats.Controls.Add(panelStat3);
            panelStats.Location = new Point(30, 180);
            panelStats.Name = "panelStats";
            panelStats.Size = new Size(890, 150);
            panelStats.TabIndex = 3;
            // 
            // panelStat1
            // 
            panelStat1.BackColor = Color.FromArgb(46, 204, 113);
            panelStat1.Controls.Add(labelTotalProducts);
            panelStat1.Controls.Add(label2);
            panelStat1.Location = new Point(0, 0);
            panelStat1.Name = "panelStat1";
            panelStat1.Size = new Size(280, 120);
            panelStat1.TabIndex = 0;
            // 
            // labelTotalProducts
            // 
            labelTotalProducts.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Bold);
            labelTotalProducts.ForeColor = Color.White;
            labelTotalProducts.Location = new Point(20, 20);
            labelTotalProducts.Name = "labelTotalProducts";
            labelTotalProducts.Size = new Size(240, 50);
            labelTotalProducts.TabIndex = 0;
            labelTotalProducts.Text = "0";
            labelTotalProducts.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 70);
            label2.Name = "label2";
            label2.Size = new Size(240, 30);
            label2.TabIndex = 1;
            label2.Text = "Tổng sản phẩm";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelStat2
            // 
            panelStat2.BackColor = Color.FromArgb(231, 76, 60);
            panelStat2.Controls.Add(labelLowStock);
            panelStat2.Controls.Add(label4);
            panelStat2.Location = new Point(305, 0);
            panelStat2.Name = "panelStat2";
            panelStat2.Size = new Size(280, 120);
            panelStat2.TabIndex = 1;
            // 
            // labelLowStock
            // 
            labelLowStock.Font = new Font("Microsoft Sans Serif", 28F, FontStyle.Bold);
            labelLowStock.ForeColor = Color.White;
            labelLowStock.Location = new Point(20, 20);
            labelLowStock.Name = "labelLowStock";
            labelLowStock.Size = new Size(240, 50);
            labelLowStock.TabIndex = 0;
            labelLowStock.Text = "0";
            labelLowStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(20, 70);
            label4.Name = "label4";
            label4.Size = new Size(240, 30);
            label4.TabIndex = 1;
            label4.Text = "Sản phẩm sắp hết";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelStat3
            // 
            panelStat3.BackColor = Color.FromArgb(52, 152, 219);
            panelStat3.Controls.Add(labelInventoryValue);
            panelStat3.Controls.Add(label6);
            panelStat3.Location = new Point(610, 0);
            panelStat3.Name = "panelStat3";
            panelStat3.Size = new Size(280, 120);
            panelStat3.TabIndex = 2;
            // 
            // labelInventoryValue
            // 
            labelInventoryValue.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            labelInventoryValue.ForeColor = Color.White;
            labelInventoryValue.Location = new Point(20, 20);
            labelInventoryValue.Name = "labelInventoryValue";
            labelInventoryValue.Size = new Size(240, 50);
            labelInventoryValue.TabIndex = 0;
            labelInventoryValue.Text = "0 ₫";
            labelInventoryValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(20, 70);
            label6.Name = "label6";
            label6.Size = new Size(240, 30);
            label6.TabIndex = 1;
            label6.Text = "Giá trị tồn kho";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Microsoft Sans Serif", 14F);
            labelWelcome.ForeColor = Color.FromArgb(127, 140, 141);
            labelWelcome.Location = new Point(30, 100);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(391, 32);
            labelWelcome.TabIndex = 1;
            labelWelcome.Text = "Chào mừng bạn đến trang quản trị";
            // 
            // labelAdminName
            // 
            labelAdminName.AutoSize = true;
            labelAdminName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            labelAdminName.ForeColor = Color.FromArgb(44, 62, 80);
            labelAdminName.Location = new Point(30, 140);
            labelAdminName.Name = "labelAdminName";
            labelAdminName.Size = new Size(175, 37);
            labelAdminName.TabIndex = 2;
            labelAdminName.Text = "Admin System";
            // 
            // AdminHomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            Name = "AdminHomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HeartSteel Cosmetic - Admin Panel";
            panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            panelStats.ResumeLayout(false);
            panelStat1.ResumeLayout(false);
            panelStat2.ResumeLayout(false);
            panelStat3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private PictureBox pictureBoxLogo;
        private Button buttonDashboard;
        private Button buttonProducts;
        private Button buttonInventory;
        private Button buttonReports;
        private Button buttonSettings;
        private Panel panelMain;
        private Label labelTitle;
        private Label labelWelcome;
        private Label labelAdminName;
        private Panel panelStats;
        private Panel panelStat1;
        private Label labelTotalProducts;
        private Label label2;
        private Panel panelStat2;
        private Label labelLowStock;
        private Label label4;
        private Panel panelStat3;
        private Label labelInventoryValue;
        private Label label6;
    }
}