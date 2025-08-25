namespace Customer.Admin
{
    partial class InventoryManagementForm
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
            panelStats = new Panel();
            panelStat4 = new Panel();
            labelOutOfStock = new Label();
            label8 = new Label();
            panelStat3 = new Panel();
            labelLowStock = new Label();
            label6 = new Label();
            panelStat2 = new Panel();
            labelTotalValue = new Label();
            label4 = new Label();
            panelStat1 = new Panel();
            labelTotalProducts = new Label();
            label2 = new Label();
            panelMain = new Panel();
            groupBoxLowStock = new GroupBox();
            dataGridViewLowStock = new DataGridView();
            panelLowStockButtons = new Panel();
            buttonRefresh = new Button();
            buttonRestock = new Button();
            panelTop.SuspendLayout();
            panelStats.SuspendLayout();
            panelStat4.SuspendLayout();
            panelStat3.SuspendLayout();
            panelStat2.SuspendLayout();
            panelStat1.SuspendLayout();
            panelMain.SuspendLayout();
            groupBoxLowStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLowStock).BeginInit();
            panelLowStockButtons.SuspendLayout();
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
            labelTitle.Size = new Size(244, 46);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Quản lý kho hàng";
            // 
            // panelStats
            // 
            panelStats.BackColor = Color.FromArgb(236, 240, 241);
            panelStats.Controls.Add(panelStat4);
            panelStats.Controls.Add(panelStat3);
            panelStats.Controls.Add(panelStat2);
            panelStats.Controls.Add(panelStat1);
            panelStats.Dock = DockStyle.Top;
            panelStats.Location = new Point(0, 80);
            panelStats.Name = "panelStats";
            panelStats.Padding = new Padding(20);
            panelStats.Size = new Size(1200, 140);
            panelStats.TabIndex = 1;
            // 
            // panelStat4
            // 
            panelStat4.BackColor = Color.FromArgb(155, 89, 182);
            panelStat4.Controls.Add(labelOutOfStock);
            panelStat4.Controls.Add(label8);
            panelStat4.Location = new Point(920, 20);
            panelStat4.Name = "panelStat4";
            panelStat4.Size = new Size(260, 100);
            panelStat4.TabIndex = 3;
            // 
            // labelOutOfStock
            // 
            labelOutOfStock.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            labelOutOfStock.ForeColor = Color.White;
            labelOutOfStock.Location = new Point(20, 15);
            labelOutOfStock.Name = "labelOutOfStock";
            labelOutOfStock.Size = new Size(220, 40);
            labelOutOfStock.TabIndex = 0;
            labelOutOfStock.Text = "0";
            labelOutOfStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(20, 55);
            label8.Name = "label8";
            label8.Size = new Size(220, 25);
            label8.TabIndex = 1;
            label8.Text = "Hết hàng";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelStat3
            // 
            panelStat3.BackColor = Color.FromArgb(231, 76, 60);
            panelStat3.Controls.Add(labelLowStock);
            panelStat3.Controls.Add(label6);
            panelStat3.Location = new Point(620, 20);
            panelStat3.Name = "panelStat3";
            panelStat3.Size = new Size(280, 100);
            panelStat3.TabIndex = 2;
            // 
            // labelLowStock
            // 
            labelLowStock.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            labelLowStock.ForeColor = Color.White;
            labelLowStock.Location = new Point(20, 15);
            labelLowStock.Name = "labelLowStock";
            labelLowStock.Size = new Size(240, 40);
            labelLowStock.TabIndex = 0;
            labelLowStock.Text = "0";
            labelLowStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(20, 55);
            label6.Name = "label6";
            label6.Size = new Size(240, 25);
            label6.TabIndex = 1;
            label6.Text = "Sắp hết hàng";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelStat2
            // 
            panelStat2.BackColor = Color.FromArgb(52, 152, 219);
            panelStat2.Controls.Add(labelTotalValue);
            panelStat2.Controls.Add(label4);
            panelStat2.Location = new Point(320, 20);
            panelStat2.Name = "panelStat2";
            panelStat2.Size = new Size(280, 100);
            panelStat2.TabIndex = 1;
            // 
            // labelTotalValue
            // 
            labelTotalValue.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold);
            labelTotalValue.ForeColor = Color.White;
            labelTotalValue.Location = new Point(20, 15);
            labelTotalValue.Name = "labelTotalValue";
            labelTotalValue.Size = new Size(240, 40);
            labelTotalValue.TabIndex = 0;
            labelTotalValue.Text = "0 ₫";
            labelTotalValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(20, 55);
            label4.Name = "label4";
            label4.Size = new Size(240, 25);
            label4.TabIndex = 1;
            label4.Text = "Giá trị tồn kho";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelStat1
            // 
            panelStat1.BackColor = Color.FromArgb(46, 204, 113);
            panelStat1.Controls.Add(labelTotalProducts);
            panelStat1.Controls.Add(label2);
            panelStat1.Location = new Point(20, 20);
            panelStat1.Name = "panelStat1";
            panelStat1.Size = new Size(280, 100);
            panelStat1.TabIndex = 0;
            // 
            // labelTotalProducts
            // 
            labelTotalProducts.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold);
            labelTotalProducts.ForeColor = Color.White;
            labelTotalProducts.Location = new Point(20, 15);
            labelTotalProducts.Name = "labelTotalProducts";
            labelTotalProducts.Size = new Size(240, 40);
            labelTotalProducts.TabIndex = 0;
            labelTotalProducts.Text = "0";
            labelTotalProducts.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(20, 55);
            label2.Name = "label2";
            label2.Size = new Size(240, 25);
            label2.TabIndex = 1;
            label2.Text = "Tổng sản phẩm";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(236, 240, 241);
            panelMain.Controls.Add(groupBoxLowStock);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 220);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(20);
            panelMain.Size = new Size(1200, 460);
            panelMain.TabIndex = 2;
            // 
            // groupBoxLowStock
            // 
            groupBoxLowStock.Controls.Add(dataGridViewLowStock);
            groupBoxLowStock.Controls.Add(panelLowStockButtons);
            groupBoxLowStock.Dock = DockStyle.Fill;
            groupBoxLowStock.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            groupBoxLowStock.ForeColor = Color.FromArgb(44, 62, 80);
            groupBoxLowStock.Location = new Point(20, 20);
            groupBoxLowStock.Name = "groupBoxLowStock";
            groupBoxLowStock.Size = new Size(1160, 420);
            groupBoxLowStock.TabIndex = 0;
            groupBoxLowStock.TabStop = false;
            groupBoxLowStock.Text = "Sản phẩm sắp hết hàng (≤ 10 sản phẩm)";
            // 
            // dataGridViewLowStock
            // 
            dataGridViewLowStock.AllowUserToAddRows = false;
            dataGridViewLowStock.AllowUserToDeleteRows = false;
            dataGridViewLowStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewLowStock.BackgroundColor = Color.White;
            dataGridViewLowStock.BorderStyle = BorderStyle.None;
            dataGridViewLowStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLowStock.Dock = DockStyle.Fill;
            dataGridViewLowStock.Location = new Point(3, 30);
            dataGridViewLowStock.MultiSelect = false;
            dataGridViewLowStock.Name = "dataGridViewLowStock";
            dataGridViewLowStock.ReadOnly = true;
            dataGridViewLowStock.RowHeadersWidth = 51;
            dataGridViewLowStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewLowStock.Size = new Size(1154, 327);
            dataGridViewLowStock.TabIndex = 0;
            dataGridViewLowStock.CellDoubleClick += dataGridViewLowStock_CellDoubleClick;
            // 
            // panelLowStockButtons
            // 
            panelLowStockButtons.Controls.Add(buttonRefresh);
            panelLowStockButtons.Controls.Add(buttonRestock);
            panelLowStockButtons.Dock = DockStyle.Bottom;
            panelLowStockButtons.Location = new Point(3, 357);
            panelLowStockButtons.Name = "panelLowStockButtons";
            panelLowStockButtons.Size = new Size(1154, 60);
            panelLowStockButtons.TabIndex = 1;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.FromArgb(52, 152, 219);
            buttonRefresh.FlatAppearance.BorderSize = 0;
            buttonRefresh.FlatStyle = FlatStyle.Flat;
            buttonRefresh.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            buttonRefresh.ForeColor = Color.White;
            buttonRefresh.Location = new Point(150, 10);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(140, 40);
            buttonRefresh.TabIndex = 1;
            buttonRefresh.Text = "🔄 Làm mới";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonRestock
            // 
            buttonRestock.BackColor = Color.FromArgb(46, 204, 113);
            buttonRestock.FlatAppearance.BorderSize = 0;
            buttonRestock.FlatStyle = FlatStyle.Flat;
            buttonRestock.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            buttonRestock.ForeColor = Color.White;
            buttonRestock.Location = new Point(10, 10);
            buttonRestock.Name = "buttonRestock";
            buttonRestock.Size = new Size(130, 40);
            buttonRestock.TabIndex = 0;
            buttonRestock.Text = "📦 Nhập hàng";
            buttonRestock.UseVisualStyleBackColor = false;
            buttonRestock.Click += buttonRestock_Click;
            // 
            // InventoryManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 680);
            Controls.Add(panelMain);
            Controls.Add(panelStats);
            Controls.Add(panelTop);
            Name = "InventoryManagementForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý kho hàng - HeartSteel Cosmetic";
            Load += InventoryManagementForm_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelStats.ResumeLayout(false);
            panelStat4.ResumeLayout(false);
            panelStat3.ResumeLayout(false);
            panelStat2.ResumeLayout(false);
            panelStat1.ResumeLayout(false);
            panelMain.ResumeLayout(false);
            groupBoxLowStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLowStock).EndInit();
            panelLowStockButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label labelTitle;
        private Panel panelStats;
        private Panel panelStat1;
        private Label labelTotalProducts;
        private Label label2;
        private Panel panelStat2;
        private Label labelTotalValue;
        private Label label4;
        private Panel panelStat3;
        private Label labelLowStock;
        private Label label6;
        private Panel panelStat4;
        private Label labelOutOfStock;
        private Label label8;
        private Panel panelMain;
        private GroupBox groupBoxLowStock;
        private DataGridView dataGridViewLowStock;
        private Panel panelLowStockButtons;
        private Button buttonRestock;
        private Button buttonRefresh;
    }
}