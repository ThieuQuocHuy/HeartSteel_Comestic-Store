namespace Customer
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
            panelHeader = new Panel();
            labelTitle = new Label();
            buttonBack = new Button();
            panelCartItems = new Panel();
            flowLayoutPanelCartItems = new FlowLayoutPanel();
            labelCartItemsTitle = new Label();
            panelSummary = new Panel();
            labelTotalAmount = new Label();
            labelTotalItems = new Label();
            buttonCheckout = new Button();
            buttonClearCart = new Button();
            panelHeader.SuspendLayout();
            panelCartItems.SuspendLayout();
            panelSummary.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(77, 58, 41);
            panelHeader.Controls.Add(buttonBack);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 80);
            panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(300, 25);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(200, 41);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "GIỎ HÀNG";
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.FromArgb(138, 80, 20);
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBack.ForeColor = Color.White;
            buttonBack.Location = new Point(20, 25);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(80, 30);
            buttonBack.TabIndex = 1;
            buttonBack.Text = "← Quay lại";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // panelCartItems
            // 
            panelCartItems.BackColor = Color.FromArgb(255, 255, 255);
            panelCartItems.Controls.Add(flowLayoutPanelCartItems);
            panelCartItems.Controls.Add(labelCartItemsTitle);
            panelCartItems.Dock = DockStyle.Fill;
            panelCartItems.Location = new Point(0, 80);
            panelCartItems.Name = "panelCartItems";
            panelCartItems.Size = new Size(800, 520);
            panelCartItems.TabIndex = 1;
            // 
            // flowLayoutPanelCartItems
            // 
            flowLayoutPanelCartItems.AutoScroll = true;
            flowLayoutPanelCartItems.BackColor = Color.FromArgb(255, 255, 255);
            flowLayoutPanelCartItems.Location = new Point(20, 50);
            flowLayoutPanelCartItems.Name = "flowLayoutPanelCartItems";
            flowLayoutPanelCartItems.Size = new Size(580, 460);
            flowLayoutPanelCartItems.TabIndex = 1;
            // 
            // labelCartItemsTitle
            // 
            labelCartItemsTitle.AutoSize = true;
            labelCartItemsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCartItemsTitle.ForeColor = Color.FromArgb(77, 58, 41);
            labelCartItemsTitle.Location = new Point(20, 15);
            labelCartItemsTitle.Name = "labelCartItemsTitle";
            labelCartItemsTitle.Size = new Size(200, 32);
            labelCartItemsTitle.TabIndex = 0;
            labelCartItemsTitle.Text = "Sản phẩm trong giỏ:";
            // 
            // panelSummary
            // 
            panelSummary.BackColor = Color.FromArgb(237, 224, 207);
            panelSummary.Controls.Add(buttonClearCart);
            panelSummary.Controls.Add(buttonCheckout);
            panelSummary.Controls.Add(labelTotalAmount);
            panelSummary.Controls.Add(labelTotalItems);
            panelSummary.Dock = DockStyle.Right;
            panelSummary.Location = new Point(600, 80);
            panelSummary.Name = "panelSummary";
            panelSummary.Size = new Size(200, 520);
            panelSummary.TabIndex = 2;
            // 
            // labelTotalAmount
            // 
            labelTotalAmount.AutoSize = true;
            labelTotalAmount.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotalAmount.ForeColor = Color.FromArgb(77, 58, 41);
            labelTotalAmount.Location = new Point(20, 80);
            labelTotalAmount.Name = "labelTotalAmount";
            labelTotalAmount.Size = new Size(160, 32);
            labelTotalAmount.TabIndex = 1;
            labelTotalAmount.Text = "Tổng tiền: 0 ₫";
            // 
            // labelTotalItems
            // 
            labelTotalItems.AutoSize = true;
            labelTotalItems.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotalItems.ForeColor = Color.FromArgb(77, 58, 41);
            labelTotalItems.Location = new Point(20, 40);
            labelTotalItems.Name = "labelTotalItems";
            labelTotalItems.Size = new Size(150, 28);
            labelTotalItems.TabIndex = 0;
            labelTotalItems.Text = "Tổng sản phẩm: 0";
            // 
            // buttonCheckout
            // 
            buttonCheckout.BackColor = Color.FromArgb(40, 167, 69);
            buttonCheckout.FlatAppearance.BorderSize = 0;
            buttonCheckout.FlatStyle = FlatStyle.Flat;
            buttonCheckout.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            buttonCheckout.ForeColor = Color.White;
            buttonCheckout.Location = new Point(20, 200);
            buttonCheckout.Name = "buttonCheckout";
            buttonCheckout.Size = new Size(200, 50);
            buttonCheckout.TabIndex = 0;
            buttonCheckout.Text = "Đặt hàng";
            buttonCheckout.UseVisualStyleBackColor = false;
            buttonCheckout.Click += buttonCheckout_Click;
            // 
            // buttonClearCart
            // 
            buttonClearCart.BackColor = Color.FromArgb(220, 53, 69);
            buttonClearCart.FlatAppearance.BorderSize = 0;
            buttonClearCart.FlatStyle = FlatStyle.Flat;
            buttonClearCart.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonClearCart.ForeColor = Color.White;
            buttonClearCart.Location = new Point(20, 210);
            buttonClearCart.Name = "buttonClearCart";
            buttonClearCart.Size = new Size(160, 35);
            buttonClearCart.TabIndex = 3;
            buttonClearCart.Text = "Xóa giỏ hàng";
            buttonClearCart.UseVisualStyleBackColor = false;
            buttonClearCart.Click += buttonClearCart_Click;
            // 
            // CartPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 255);
            ClientSize = new Size(800, 600);
            Controls.Add(panelSummary);
            Controls.Add(panelCartItems);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CartPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giỏ hàng - HeartSteel Cosmetic";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelCartItems.ResumeLayout(false);
            panelCartItems.PerformLayout();
            panelSummary.ResumeLayout(false);
            panelSummary.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label labelTitle;
        private Button buttonBack;
        private Panel panelCartItems;
        private FlowLayoutPanel flowLayoutPanelCartItems;
        private Label labelCartItemsTitle;
        private Panel panelSummary;
        private Label labelTotalAmount;
        private Label labelTotalItems;
        private Button buttonCheckout;
        private Button buttonClearCart;
    }
}
