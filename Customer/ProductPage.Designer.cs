namespace Customer
{
    partial class ProductPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductPage));
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panelSidebar = new Panel();
            pictureBoxLogo = new PictureBox();
            buttonHome = new Button();
            buttonProducts = new Button();
            buttonCart = new Button();
            buttonOrders = new Button();
            pictureBoxMain = new PictureBox();
            flowLayoutPanelProducts = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMain).BeginInit();
            flowLayoutPanelProducts.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(237, 224, 207);
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(360, 105);
            label4.Name = "label4";
            label4.Size = new Size(151, 28);
            label4.TabIndex = 22;
            label4.Text = "Thiều Quốc Huy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(237, 224, 207);
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(236, 105);
            label3.Name = "label3";
            label3.Size = new Size(118, 28);
            label3.TabIndex = 21;
            label3.Text = "Khách hàng:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(237, 224, 207);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(236, 59);
            label2.Name = "label2";
            label2.Size = new Size(463, 28);
            label2.TabIndex = 20;
            label2.Text = "Chào mừng bạn đã đến với cửa hàng của chúng tôi!";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(237, 224, 207);
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(199, 45);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(963, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(237, 224, 207);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(236, 9);
            label1.Name = "label1";
            label1.Size = new Size(270, 28);
            label1.TabIndex = 18;
            label1.Text = "Cửa hàng HeartSteelComestic";
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(77, 58, 41);
            panelSidebar.Controls.Add(pictureBoxLogo);
            panelSidebar.Controls.Add(buttonHome);
            panelSidebar.Controls.Add(buttonProducts);
            panelSidebar.Controls.Add(buttonCart);
            panelSidebar.Controls.Add(buttonOrders);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(200, 600);
            panelSidebar.TabIndex = 16;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
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
            buttonHome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
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
            buttonProducts.BackColor = Color.FromArgb(138, 80, 20);
            buttonProducts.FlatAppearance.BorderSize = 0;
            buttonProducts.FlatStyle = FlatStyle.Flat;
            buttonProducts.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonProducts.ForeColor = Color.White;
            buttonProducts.Location = new Point(0, 230);
            buttonProducts.Name = "buttonProducts";
            buttonProducts.Padding = new Padding(30, 0, 0, 0);
            buttonProducts.Size = new Size(200, 50);
            buttonProducts.TabIndex = 2;
            buttonProducts.Text = "Sản phẩm";
            buttonProducts.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonCart
            // 
            buttonCart.BackColor = Color.FromArgb(77, 58, 41);
            buttonCart.FlatAppearance.BorderSize = 0;
            buttonCart.FlatStyle = FlatStyle.Flat;
            buttonCart.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonCart.ForeColor = Color.White;
            buttonCart.Location = new Point(0, 280);
            buttonCart.Name = "buttonCart";
            buttonCart.Padding = new Padding(30, 0, 0, 0);
            buttonCart.Size = new Size(200, 50);
            buttonCart.TabIndex = 3;
            buttonCart.Text = "Giỏ hàng";
            buttonCart.TextAlign = ContentAlignment.MiddleLeft;
            buttonCart.Click += buttonCart_Click;
            // 
            // buttonOrders
            // 
            buttonOrders.BackColor = Color.FromArgb(77, 58, 41);
            buttonOrders.FlatAppearance.BorderSize = 0;
            buttonOrders.FlatStyle = FlatStyle.Flat;
            buttonOrders.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonOrders.ForeColor = Color.White;
            buttonOrders.Location = new Point(0, 330);
            buttonOrders.Name = "buttonOrders";
            buttonOrders.Padding = new Padding(30, 0, 0, 0);
            buttonOrders.Size = new Size(200, 50);
            buttonOrders.TabIndex = 4;
            buttonOrders.Text = "Đơn mua";
            buttonOrders.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBoxMain
            // 
            pictureBoxMain.BackColor = Color.FromArgb(237, 224, 207);
            pictureBoxMain.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxMain.Location = new Point(199, 0);
            pictureBoxMain.Margin = new Padding(0);
            pictureBoxMain.Name = "pictureBoxMain";
            pictureBoxMain.Size = new Size(963, 46);
            pictureBoxMain.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMain.TabIndex = 17;
            pictureBoxMain.TabStop = false;
            // 
            // flowLayoutPanelProducts
            // 
            flowLayoutPanelProducts.AutoScroll = true;
            flowLayoutPanelProducts.BackColor = Color.FromArgb(255, 255, 255);
            flowLayoutPanelProducts.Location = new Point(229, 173);
            flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            flowLayoutPanelProducts.Size = new Size(931, 427);
            flowLayoutPanelProducts.TabIndex = 23;
            // 
            // ProductPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1160, 600);
            Controls.Add(flowLayoutPanelProducts);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panelSidebar);
            Controls.Add(pictureBoxMain);
            Name = "ProductPage";
            Text = "Sản phẩm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMain).EndInit();
            flowLayoutPanelProducts.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panelSidebar;
        private PictureBox pictureBoxLogo;
        private Button buttonHome;
        private Button buttonProducts;
        private Button buttonCart;
        private Button buttonOrders;
        private PictureBox pictureBoxMain;
        private FlowLayoutPanel flowLayoutPanelProducts;
    }
}


