namespace Presentation.Pages.Customer
{
    partial class OrderListPage
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
            flowLayoutPanelOrders = new FlowLayoutPanel();
            panelHeader.SuspendLayout();
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
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(300, 25);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(200, 32);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "ĐƠN MUA";
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
            // flowLayoutPanelOrders
            // 
            flowLayoutPanelOrders.AutoScroll = true;
            flowLayoutPanelOrders.BackColor = Color.FromArgb(255, 255, 255);
            flowLayoutPanelOrders.Location = new Point(20, 100);
            flowLayoutPanelOrders.Name = "flowLayoutPanelOrders";
            flowLayoutPanelOrders.Size = new Size(760, 480);
            flowLayoutPanelOrders.TabIndex = 1;
            // 
            // OrderListPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 255);
            ClientSize = new Size(800, 600);
            Controls.Add(flowLayoutPanelOrders);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "OrderListPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đơn mua - HeartSteel Cosmetic";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelHeader;
        private Label labelTitle;
        private Button buttonBack;
        private FlowLayoutPanel flowLayoutPanelOrders;
    }
}
