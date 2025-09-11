namespace Presentation.Pages.Customer
{
    partial class OrderPage
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
            buttonCancel = new Button();
            labelTitle = new Label();
            panelOrderSummary = new Panel();
            flowLayoutPanelOrderItems = new FlowLayoutPanel();
            labelOrderSummary = new Label();
            panelOrderForm = new Panel();
            buttonPlaceOrder = new Button();
            labelTotalAmount = new Label();
            textBoxShippingAddress = new TextBox();
            labelShippingAddress = new Label();
            panelHeader.SuspendLayout();
            panelOrderSummary.SuspendLayout();
            panelOrderForm.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(77, 58, 41);
            panelHeader.Controls.Add(buttonCancel);
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1025, 80);
            panelHeader.TabIndex = 0;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(108, 117, 125);
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(20, 25);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(80, 30);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "← Quay";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(300, 25);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(176, 41);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "ĐẶT HÀNG";
            // 
            // panelOrderSummary
            // 
            panelOrderSummary.BackColor = Color.FromArgb(255, 255, 255);
            panelOrderSummary.Controls.Add(flowLayoutPanelOrderItems);
            panelOrderSummary.Controls.Add(labelOrderSummary);
            panelOrderSummary.Location = new Point(20, 100);
            panelOrderSummary.Name = "panelOrderSummary";
            panelOrderSummary.Size = new Size(632, 400);
            panelOrderSummary.TabIndex = 1;
            // 
            // flowLayoutPanelOrderItems
            // 
            flowLayoutPanelOrderItems.AutoScroll = true;
            flowLayoutPanelOrderItems.Location = new Point(15, 50);
            flowLayoutPanelOrderItems.Name = "flowLayoutPanelOrderItems";
            flowLayoutPanelOrderItems.Size = new Size(591, 330);
            flowLayoutPanelOrderItems.TabIndex = 1;
            // 
            // labelOrderSummary
            // 
            labelOrderSummary.AutoSize = true;
            labelOrderSummary.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelOrderSummary.ForeColor = Color.FromArgb(77, 58, 41);
            labelOrderSummary.Location = new Point(15, 15);
            labelOrderSummary.Name = "labelOrderSummary";
            labelOrderSummary.Size = new Size(224, 32);
            labelOrderSummary.TabIndex = 0;
            labelOrderSummary.Text = "Tóm tắt đơn hàng:";
            // 
            // panelOrderForm
            // 
            panelOrderForm.BackColor = Color.FromArgb(255, 255, 255);
            panelOrderForm.Controls.Add(buttonPlaceOrder);
            panelOrderForm.Controls.Add(labelTotalAmount);
            panelOrderForm.Controls.Add(textBoxShippingAddress);
            panelOrderForm.Controls.Add(labelShippingAddress);
            panelOrderForm.Location = new Point(690, 100);
            panelOrderForm.Name = "panelOrderForm";
            panelOrderForm.Size = new Size(290, 400);
            panelOrderForm.TabIndex = 2;
            // 
            // buttonPlaceOrder
            // 
            buttonPlaceOrder.BackColor = Color.FromArgb(40, 167, 69);
            buttonPlaceOrder.FlatAppearance.BorderSize = 0;
            buttonPlaceOrder.FlatStyle = FlatStyle.Flat;
            buttonPlaceOrder.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            buttonPlaceOrder.ForeColor = Color.White;
            buttonPlaceOrder.Location = new Point(15, 230);
            buttonPlaceOrder.Name = "buttonPlaceOrder";
            buttonPlaceOrder.Size = new Size(260, 50);
            buttonPlaceOrder.TabIndex = 5;
            buttonPlaceOrder.Text = "Đặt hàng";
            buttonPlaceOrder.UseVisualStyleBackColor = false;
            buttonPlaceOrder.Click += buttonPlaceOrder_Click;
            // 
            // labelTotalAmount
            // 
            labelTotalAmount.AutoSize = true;
            labelTotalAmount.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelTotalAmount.ForeColor = Color.FromArgb(77, 58, 41);
            labelTotalAmount.Location = new Point(15, 180);
            labelTotalAmount.Name = "labelTotalAmount";
            labelTotalAmount.Size = new Size(194, 37);
            labelTotalAmount.TabIndex = 4;
            labelTotalAmount.Text = "Tổng tiền: 0 ₫";
            // 
            // textBoxShippingAddress
            // 
            textBoxShippingAddress.Font = new Font("Segoe UI", 10F);
            textBoxShippingAddress.Location = new Point(15, 45);
            textBoxShippingAddress.Multiline = true;
            textBoxShippingAddress.Name = "textBoxShippingAddress";
            textBoxShippingAddress.Size = new Size(260, 120);
            textBoxShippingAddress.TabIndex = 1;
            // 
            // labelShippingAddress
            // 
            labelShippingAddress.AutoSize = true;
            labelShippingAddress.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelShippingAddress.ForeColor = Color.FromArgb(77, 58, 41);
            labelShippingAddress.Location = new Point(15, 15);
            labelShippingAddress.Name = "labelShippingAddress";
            labelShippingAddress.Size = new Size(183, 28);
            labelShippingAddress.TabIndex = 0;
            labelShippingAddress.Text = "Địa chỉ giao hàng:";
            // 
            // OrderPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 255);
            ClientSize = new Size(1025, 553);
            Controls.Add(panelOrderForm);
            Controls.Add(panelOrderSummary);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "OrderPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đặt hàng - HeartSteel Cosmetic";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelOrderSummary.ResumeLayout(false);
            panelOrderSummary.PerformLayout();
            panelOrderForm.ResumeLayout(false);
            panelOrderForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelHeader;
        private Label labelTitle;
        private Button buttonCancel;
        private Panel panelOrderSummary;
        private Label labelOrderSummary;
        private FlowLayoutPanel flowLayoutPanelOrderItems;
        private Panel panelOrderForm;
        private Label labelShippingAddress;
        private TextBox textBoxShippingAddress;
        private Label labelTotalAmount;
        private Button buttonPlaceOrder;
    }
}
