namespace Presentation.Pages.Customer
{
    partial class OrderDetailPage
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
            panelOrderInfo = new Panel();
            labelOrderId = new Label();
            labelOrderDate = new Label();
            labelTotalAmount = new Label();
            labelShippingAddress = new Label();
            labelStatus = new Label();
            panelOrderItems = new Panel();
            labelOrderItems = new Label();
            flowLayoutPanelOrderItems = new FlowLayoutPanel();
            panelStatusHistory = new Panel();
            labelStatusHistory = new Label();
            flowLayoutPanelStatusHistory = new FlowLayoutPanel();
            panelHeader.SuspendLayout();
            panelOrderInfo.SuspendLayout();
            panelOrderItems.SuspendLayout();
            panelStatusHistory.SuspendLayout();
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
            panelHeader.Size = new Size(900, 80);
            panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(350, 25);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(200, 32);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "CHI TIẾT ĐƠN HÀNG";
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.FromArgb(108, 117, 125);
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonBack.ForeColor = Color.White;
            buttonBack.Location = new Point(20, 25);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(80, 30);
            buttonBack.TabIndex = 1;
            buttonBack.Text = "← Quay";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // panelOrderInfo
            // 
            panelOrderInfo.BackColor = Color.FromArgb(255, 255, 255);
            panelOrderInfo.Controls.Add(labelStatus);
            panelOrderInfo.Controls.Add(labelShippingAddress);
            panelOrderInfo.Controls.Add(labelTotalAmount);
            panelOrderInfo.Controls.Add(labelOrderDate);
            panelOrderInfo.Controls.Add(labelOrderId);
            panelOrderInfo.Location = new Point(20, 100);
            panelOrderInfo.Name = "panelOrderInfo";
            panelOrderInfo.Size = new Size(860, 120);
            panelOrderInfo.TabIndex = 1;
            // 
            // labelOrderId
            // 
            labelOrderId.AutoSize = true;
            labelOrderId.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            labelOrderId.ForeColor = Color.FromArgb(77, 58, 41);
            labelOrderId.Location = new Point(15, 15);
            labelOrderId.Name = "labelOrderId";
            labelOrderId.Size = new Size(200, 30);
            labelOrderId.TabIndex = 0;
            labelOrderId.Text = "Đơn hàng #0";
            // 
            // labelOrderDate
            // 
            labelOrderDate.AutoSize = true;
            labelOrderDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            labelOrderDate.ForeColor = Color.FromArgb(77, 58, 41);
            labelOrderDate.Location = new Point(15, 55);
            labelOrderDate.Name = "labelOrderDate";
            labelOrderDate.Size = new Size(200, 21);
            labelOrderDate.TabIndex = 1;
            labelOrderDate.Text = "Ngày đặt: 01/01/2024";
            // 
            // labelTotalAmount
            // 
            labelTotalAmount.AutoSize = true;
            labelTotalAmount.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTotalAmount.ForeColor = Color.FromArgb(77, 58, 41);
            labelTotalAmount.Location = new Point(450, 15);
            labelTotalAmount.Name = "labelTotalAmount";
            labelTotalAmount.Size = new Size(200, 25);
            labelTotalAmount.TabIndex = 2;
            labelTotalAmount.Text = "Tổng tiền: 0 ₫";
            // 
            // labelShippingAddress
            // 
            labelShippingAddress.AutoSize = true;
            labelShippingAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            labelShippingAddress.ForeColor = Color.FromArgb(77, 58, 41);
            labelShippingAddress.Location = new Point(450, 55);
            labelShippingAddress.Name = "labelShippingAddress";
            labelShippingAddress.Size = new Size(200, 21);
            labelShippingAddress.TabIndex = 3;
            labelShippingAddress.Text = "Địa chỉ giao hàng: ";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelStatus.ForeColor = Color.Orange;
            labelStatus.Location = new Point(450, 85);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(200, 21);
            labelStatus.TabIndex = 4;
            labelStatus.Text = "Trạng thái: Chờ xử lý";
            // 
            // panelOrderItems
            // 
            panelOrderItems.BackColor = Color.FromArgb(255, 255, 255);
            panelOrderItems.Controls.Add(flowLayoutPanelOrderItems);
            panelOrderItems.Controls.Add(labelOrderItems);
            panelOrderItems.Location = new Point(20, 240);
            panelOrderItems.Name = "panelOrderItems";
            panelOrderItems.Size = new Size(540, 400);
            panelOrderItems.TabIndex = 2;
            // 
            // labelOrderItems
            // 
            labelOrderItems.AutoSize = true;
            labelOrderItems.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelOrderItems.ForeColor = Color.FromArgb(77, 58, 41);
            labelOrderItems.Location = new Point(15, 15);
            labelOrderItems.Name = "labelOrderItems";
            labelOrderItems.Size = new Size(200, 25);
            labelOrderItems.TabIndex = 0;
            labelOrderItems.Text = "Sản phẩm trong đơn:";
            // 
            // flowLayoutPanelOrderItems
            // 
            flowLayoutPanelOrderItems.AutoScroll = true;
            flowLayoutPanelOrderItems.Location = new Point(15, 50);
            flowLayoutPanelOrderItems.Name = "flowLayoutPanelOrderItems";
            flowLayoutPanelOrderItems.Size = new Size(510, 330);
            flowLayoutPanelOrderItems.TabIndex = 1;
            // 
            // panelStatusHistory
            // 
            panelStatusHistory.Visible = false;
            // 
            // labelStatusHistory
            // 
            labelStatusHistory.AutoSize = true;
            labelStatusHistory.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelStatusHistory.ForeColor = Color.FromArgb(77, 58, 41);
            labelStatusHistory.Location = new Point(15, 15);
            labelStatusHistory.Name = "labelStatusHistory";
            labelStatusHistory.Size = new Size(200, 25);
            labelStatusHistory.TabIndex = 0;
            labelStatusHistory.Text = "Lịch sử trạng thái:";
            // 
            // flowLayoutPanelStatusHistory
            // 
            flowLayoutPanelStatusHistory.AutoScroll = true;
            flowLayoutPanelStatusHistory.Location = new Point(15, 50);
            flowLayoutPanelStatusHistory.Name = "flowLayoutPanelStatusHistory";
            flowLayoutPanelStatusHistory.Size = new Size(270, 330);
            flowLayoutPanelStatusHistory.TabIndex = 1;
            // 
            // OrderDetailPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 255);
            ClientSize = new Size(900, 660);
            // status history removed when not used
            Controls.Add(panelOrderItems);
            Controls.Add(panelOrderInfo);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "OrderDetailPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chi tiết đơn hàng - HeartSteel Cosmetic";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelOrderInfo.ResumeLayout(false);
            panelOrderInfo.PerformLayout();
            panelOrderItems.ResumeLayout(false);
            panelOrderItems.PerformLayout();
            panelStatusHistory.ResumeLayout(false);
            panelStatusHistory.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelHeader;
        private Label labelTitle;
        private Button buttonBack;
        private Panel panelOrderInfo;
        private Label labelOrderId;
        private Label labelOrderDate;
        private Label labelTotalAmount;
        private Label labelShippingAddress;
        private Label labelStatus;
        private Panel panelOrderItems;
        private Label labelOrderItems;
        private FlowLayoutPanel flowLayoutPanelOrderItems;
        private Panel panelStatusHistory;
        private Label labelStatusHistory;
        private FlowLayoutPanel flowLayoutPanelStatusHistory;
    }
}
