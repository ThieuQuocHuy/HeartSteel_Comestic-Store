namespace Presentation.Pages.Customer
{
    partial class CartPage
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
            pictureBoxLogo = new PictureBox();
            buttonHome = new Button();
            buttonProducts = new Button();
            buttonCart = new Button();
            buttonOrders = new Button();
            buttonLogout = new Button();
            pictureBoxMain = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            flowLayoutPanelCartItems = new FlowLayoutPanel();
            labelCartItemsTitle = new Label();
            panelSummary = new Panel();
            buttonClearCart = new Button();
            buttonCheckout = new Button();
            labelTotalAmount = new Label();
            labelTotalItems = new Label();
            buttonCSKH = new Button();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMain).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelSummary.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(77, 58, 41);
            panelSidebar.Controls.Add(buttonCSKH);
            panelSidebar.Controls.Add(pictureBoxLogo);
            panelSidebar.Controls.Add(buttonHome);
            panelSidebar.Controls.Add(buttonProducts);
            panelSidebar.Controls.Add(buttonCart);
            panelSidebar.Controls.Add(buttonOrders);
            panelSidebar.Controls.Add(buttonLogout);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(200, 553);
            panelSidebar.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Location = new Point(0, 0);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(200, 182);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.FromArgb(77, 58, 41);
            buttonHome.FlatAppearance.BorderSize = 0;
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            buttonHome.ForeColor = Color.White;
            buttonHome.Location = new Point(0, 180);
            buttonHome.Name = "buttonHome";
            buttonHome.Padding = new Padding(30, 0, 0, 0);
            buttonHome.Size = new Size(200, 50);
            buttonHome.TabIndex = 1;
            buttonHome.Text = "Trang chủ";
            buttonHome.TextAlign = ContentAlignment.MiddleLeft;
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonProducts
            // 
            buttonProducts.BackColor = Color.FromArgb(77, 58, 41);
            buttonProducts.FlatAppearance.BorderSize = 0;
            buttonProducts.FlatStyle = FlatStyle.Flat;
            buttonProducts.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            buttonProducts.ForeColor = Color.White;
            buttonProducts.Location = new Point(0, 230);
            buttonProducts.Name = "buttonProducts";
            buttonProducts.Padding = new Padding(30, 0, 0, 0);
            buttonProducts.Size = new Size(200, 50);
            buttonProducts.TabIndex = 2;
            buttonProducts.Text = "Sản phẩm";
            buttonProducts.TextAlign = ContentAlignment.MiddleLeft;
            buttonProducts.UseVisualStyleBackColor = false;
            buttonProducts.Click += buttonProducts_Click;
            // 
            // buttonCart
            // 
            buttonCart.BackColor = Color.FromArgb(221, 207, 182);
            buttonCart.FlatAppearance.BorderSize = 0;
            buttonCart.FlatStyle = FlatStyle.Flat;
            buttonCart.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            buttonCart.ForeColor = Color.White;
            buttonCart.Location = new Point(0, 280);
            buttonCart.Name = "buttonCart";
            buttonCart.Padding = new Padding(30, 0, 0, 0);
            buttonCart.Size = new Size(200, 50);
            buttonCart.TabIndex = 3;
            buttonCart.Text = "Giỏ hàng";
            buttonCart.TextAlign = ContentAlignment.MiddleLeft;
            buttonCart.UseVisualStyleBackColor = false;
            // 
            // buttonOrders
            // 
            buttonOrders.BackColor = Color.FromArgb(77, 58, 41);
            buttonOrders.FlatAppearance.BorderSize = 0;
            buttonOrders.FlatStyle = FlatStyle.Flat;
            buttonOrders.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            buttonOrders.ForeColor = Color.White;
            buttonOrders.Location = new Point(0, 330);
            buttonOrders.Name = "buttonOrders";
            buttonOrders.Padding = new Padding(30, 0, 0, 0);
            buttonOrders.Size = new Size(200, 50);
            buttonOrders.TabIndex = 4;
            buttonOrders.Text = "Đơn mua";
            buttonOrders.TextAlign = ContentAlignment.MiddleLeft;
            buttonOrders.UseVisualStyleBackColor = false;
            buttonOrders.Click += buttonOrders_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.FromArgb(120, 40, 40);
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            buttonLogout.ForeColor = Color.White;
            buttonLogout.Location = new Point(0, 430);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Padding = new Padding(30, 0, 0, 0);
            buttonLogout.Size = new Size(200, 50);
            buttonLogout.TabIndex = 5;
            buttonLogout.Text = "Đăng xuất";
            buttonLogout.TextAlign = ContentAlignment.MiddleLeft;
            buttonLogout.UseVisualStyleBackColor = false;
            // 
            // pictureBoxMain
            // 
            pictureBoxMain.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxMain.Location = new Point(200, 0);
            pictureBoxMain.Margin = new Padding(0);
            pictureBoxMain.Name = "pictureBoxMain";
            pictureBoxMain.Size = new Size(963, 46);
            pictureBoxMain.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMain.TabIndex = 3;
            pictureBoxMain.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 9);
            label1.Name = "label1";
            label1.Size = new Size(277, 25);
            label1.TabIndex = 10;
            label1.Text = "Cửa hàng HeartSteelComestic";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(237, 224, 207);
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(200, 45);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(963, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(237, 59);
            label2.Name = "label2";
            label2.Size = new Size(460, 25);
            label2.TabIndex = 12;
            label2.Text = "Chào mừng bạn đã đến với cửa hàng của chúng tôi!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(237, 105);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 13;
            label3.Text = "Khách hàng:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(377, 105);
            label4.Name = "label4";
            label4.Size = new Size(155, 25);
            label4.TabIndex = 14;
            label4.Text = "Thiều Quốc Huy";
            // 
            // flowLayoutPanelCartItems
            // 
            flowLayoutPanelCartItems.AutoScroll = true;
            flowLayoutPanelCartItems.BackColor = Color.FromArgb(255, 255, 255);
            flowLayoutPanelCartItems.Location = new Point(200, 200);
            flowLayoutPanelCartItems.Name = "flowLayoutPanelCartItems";
            flowLayoutPanelCartItems.Size = new Size(645, 344);
            flowLayoutPanelCartItems.TabIndex = 15;
            // 
            // labelCartItemsTitle
            // 
            labelCartItemsTitle.AutoSize = true;
            labelCartItemsTitle.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCartItemsTitle.ForeColor = Color.FromArgb(77, 58, 41);
            labelCartItemsTitle.Location = new Point(200, 160);
            labelCartItemsTitle.Name = "labelCartItemsTitle";
            labelCartItemsTitle.Size = new Size(247, 29);
            labelCartItemsTitle.TabIndex = 16;
            labelCartItemsTitle.Text = "Sản phẩm trong giỏ:";
            // 
            // panelSummary
            // 
            panelSummary.BackColor = Color.FromArgb(237, 224, 207);
            panelSummary.Controls.Add(buttonClearCart);
            panelSummary.Controls.Add(buttonCheckout);
            panelSummary.Controls.Add(labelTotalAmount);
            panelSummary.Controls.Add(labelTotalItems);
            panelSummary.Location = new Point(862, 200);
            panelSummary.Name = "panelSummary";
            panelSummary.Size = new Size(268, 344);
            panelSummary.TabIndex = 17;
            // 
            // buttonClearCart
            // 
            buttonClearCart.BackColor = Color.FromArgb(220, 53, 69);
            buttonClearCart.FlatAppearance.BorderSize = 0;
            buttonClearCart.FlatStyle = FlatStyle.Flat;
            buttonClearCart.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonClearCart.ForeColor = Color.White;
            buttonClearCart.Location = new Point(20, 220);
            buttonClearCart.Name = "buttonClearCart";
            buttonClearCart.Size = new Size(200, 35);
            buttonClearCart.TabIndex = 3;
            buttonClearCart.Text = "Xóa giỏ hàng";
            buttonClearCart.UseVisualStyleBackColor = false;
            buttonClearCart.Click += buttonClearCart_Click;
            // 
            // buttonCheckout
            // 
            buttonCheckout.BackColor = Color.FromArgb(40, 167, 69);
            buttonCheckout.FlatAppearance.BorderSize = 0;
            buttonCheckout.FlatStyle = FlatStyle.Flat;
            buttonCheckout.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonCheckout.ForeColor = Color.White;
            buttonCheckout.Location = new Point(20, 150);
            buttonCheckout.Name = "buttonCheckout";
            buttonCheckout.Size = new Size(200, 50);
            buttonCheckout.TabIndex = 0;
            buttonCheckout.Text = "Đặt hàng";
            buttonCheckout.UseVisualStyleBackColor = false;
            buttonCheckout.Click += buttonCheckout_Click;
            // 
            // labelTotalAmount
            // 
            labelTotalAmount.AutoSize = true;
            labelTotalAmount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotalAmount.ForeColor = Color.FromArgb(77, 58, 41);
            labelTotalAmount.Location = new Point(11, 80);
            labelTotalAmount.Name = "labelTotalAmount";
            labelTotalAmount.Size = new Size(145, 28);
            labelTotalAmount.TabIndex = 1;
            labelTotalAmount.Text = "Tổng tiền: 0 ₫";
            labelTotalAmount.Click += labelTotalAmount_Click;
            // 
            // labelTotalItems
            // 
            labelTotalItems.AutoSize = true;
            labelTotalItems.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotalItems.ForeColor = Color.FromArgb(77, 58, 41);
            labelTotalItems.Location = new Point(11, 40);
            labelTotalItems.Name = "labelTotalItems";
            labelTotalItems.Size = new Size(166, 28);
            labelTotalItems.TabIndex = 0;
            labelTotalItems.Text = "Tổng sản phẩm: 0";
            // 
            // buttonCSKH
            // 
            buttonCSKH.BackColor = Color.FromArgb(77, 58, 41);
            buttonCSKH.FlatAppearance.BorderSize = 0;
            buttonCSKH.FlatStyle = FlatStyle.Flat;
            buttonCSKH.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            buttonCSKH.ForeColor = Color.White;
            buttonCSKH.Location = new Point(0, 380);
            buttonCSKH.Name = "buttonCSKH";
            buttonCSKH.Padding = new Padding(30, 0, 0, 0);
            buttonCSKH.Size = new Size(200, 50);
            buttonCSKH.TabIndex = 6;
            buttonCSKH.Text = "CSKH";
            buttonCSKH.TextAlign = ContentAlignment.MiddleLeft;
            buttonCSKH.UseVisualStyleBackColor = false;
            // 
            // CartPage
            // 
            BackColor = Color.FromArgb(237, 224, 207);
            ClientSize = new Size(1142, 553);
            Controls.Add(panelSummary);
            Controls.Add(labelCartItemsTitle);
            Controls.Add(flowLayoutPanelCartItems);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(pictureBoxMain);
            Controls.Add(panelSidebar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(1160, 600);
            MinimumSize = new Size(1160, 600);
            Name = "CartPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giỏ hàng - HeartSteel Cosmetic";
            panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMain).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelSummary.ResumeLayout(false);
            panelSummary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSidebar;
        private PictureBox pictureBoxLogo;
        private Button buttonHome;
        private Button buttonProducts;
        private Button buttonCart;
        private Button buttonOrders;
        private Button buttonLogout;
        private PictureBox pictureBoxMain;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private FlowLayoutPanel flowLayoutPanelCartItems;
        private Label labelCartItemsTitle;
        private Panel panelSummary;
        private Label labelTotalAmount;
        private Label labelTotalItems;
        private Button buttonCheckout;
        private Button buttonClearCart;
        private Button buttonCSKH;
    }
}
