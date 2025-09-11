namespace Presentation.Pages.Customer
{
    partial class SupportDetailForm
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

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.labelStatusValue = new System.Windows.Forms.Label();
            this.labelDateValue = new System.Windows.Forms.Label();
            this.labelUserIdValue = new System.Windows.Forms.Label();
            this.labelCustomerValue = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelUserId = new System.Windows.Forms.Label();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.panelConversation = new System.Windows.Forms.Panel();
            this.textBoxDetail = new System.Windows.Forms.TextBox();
            this.labelConversation = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelConversation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(77, 58, 41);
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(740, 64);
            this.panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(20, 16);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(219, 30);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Chi tiết yêu cầu";
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.Color.White;
            this.panelInfo.Controls.Add(this.labelStatusValue);
            this.panelInfo.Controls.Add(this.labelDateValue);
            this.panelInfo.Controls.Add(this.labelUserIdValue);
            this.panelInfo.Controls.Add(this.labelCustomerValue);
            this.panelInfo.Controls.Add(this.labelStatus);
            this.panelInfo.Controls.Add(this.labelDate);
            this.panelInfo.Controls.Add(this.labelUserId);
            this.panelInfo.Controls.Add(this.labelCustomer);
            this.panelInfo.Location = new System.Drawing.Point(16, 76);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(708, 110);
            this.panelInfo.TabIndex = 1;
            // 
            // labelStatusValue
            // 
            this.labelStatusValue.AutoSize = true;
            this.labelStatusValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelStatusValue.ForeColor = System.Drawing.Color.FromArgb(77, 58, 41);
            this.labelStatusValue.Location = new System.Drawing.Point(434, 68);
            this.labelStatusValue.Name = "labelStatusValue";
            this.labelStatusValue.Size = new System.Drawing.Size(81, 19);
            this.labelStatusValue.TabIndex = 7;
            this.labelStatusValue.Text = "Đang xử lý";
            // 
            // labelDateValue
            // 
            this.labelDateValue.AutoSize = true;
            this.labelDateValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelDateValue.ForeColor = System.Drawing.Color.FromArgb(77, 58, 41);
            this.labelDateValue.Location = new System.Drawing.Point(434, 20);
            this.labelDateValue.Name = "labelDateValue";
            this.labelDateValue.Size = new System.Drawing.Size(142, 19);
            this.labelDateValue.TabIndex = 6;
            this.labelDateValue.Text = "01/01/2025 12:00";
            // 
            // labelUserIdValue
            // 
            this.labelUserIdValue.AutoSize = true;
            this.labelUserIdValue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelUserIdValue.ForeColor = System.Drawing.Color.FromArgb(77, 58, 41);
            this.labelUserIdValue.Location = new System.Drawing.Point(112, 68);
            this.labelUserIdValue.Name = "labelUserIdValue";
            this.labelUserIdValue.Size = new System.Drawing.Size(32, 19);
            this.labelUserIdValue.TabIndex = 5;
            this.labelUserIdValue.Text = "#1";
            // 
            // labelCustomerValue
            // 
            this.labelCustomerValue.AutoSize = true;
            this.labelCustomerValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelCustomerValue.ForeColor = System.Drawing.Color.FromArgb(77, 58, 41);
            this.labelCustomerValue.Location = new System.Drawing.Point(112, 20);
            this.labelCustomerValue.Name = "labelCustomerValue";
            this.labelCustomerValue.Size = new System.Drawing.Size(131, 19);
            this.labelCustomerValue.TabIndex = 4;
            this.labelCustomerValue.Text = "Thiều Quốc Huy";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelStatus.ForeColor = System.Drawing.Color.FromArgb(77, 58, 41);
            this.labelStatus.Location = new System.Drawing.Point(360, 68);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(72, 19);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "Trạng thái:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(77, 58, 41);
            this.labelDate.Location = new System.Drawing.Point(360, 20);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(65, 19);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Thời gian:";
            // 
            // labelUserId
            // 
            this.labelUserId.AutoSize = true;
            this.labelUserId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelUserId.ForeColor = System.Drawing.Color.FromArgb(77, 58, 41);
            this.labelUserId.Location = new System.Drawing.Point(16, 68);
            this.labelUserId.Name = "labelUserId";
            this.labelUserId.Size = new System.Drawing.Size(60, 19);
            this.labelUserId.TabIndex = 1;
            this.labelUserId.Text = "User ID:";
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelCustomer.ForeColor = System.Drawing.Color.FromArgb(77, 58, 41);
            this.labelCustomer.Location = new System.Drawing.Point(16, 20);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(88, 19);
            this.labelCustomer.TabIndex = 0;
            this.labelCustomer.Text = "Khách hàng:";
            // 
            // panelConversation
            // 
            this.panelConversation.BackColor = System.Drawing.Color.White;
            this.panelConversation.Controls.Add(this.textBoxDetail);
            this.panelConversation.Controls.Add(this.labelConversation);
            this.panelConversation.Location = new System.Drawing.Point(16, 200);
            this.panelConversation.Name = "panelConversation";
            this.panelConversation.Padding = new System.Windows.Forms.Padding(10, 36, 10, 10);
            this.panelConversation.Size = new System.Drawing.Size(708, 340);
            this.panelConversation.TabIndex = 2;
            // 
            // textBoxDetail
            // 
            this.textBoxDetail.BackColor = System.Drawing.Color.White;
            this.textBoxDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDetail.Location = new System.Drawing.Point(10, 36);
            this.textBoxDetail.Multiline = true;
            this.textBoxDetail.Name = "textBoxDetail";
            this.textBoxDetail.ReadOnly = true;
            this.textBoxDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDetail.Size = new System.Drawing.Size(688, 294);
            this.textBoxDetail.TabIndex = 1;
            // 
            // labelConversation
            // 
            this.labelConversation.AutoSize = true;
            this.labelConversation.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelConversation.ForeColor = System.Drawing.Color.FromArgb(77, 58, 41);
            this.labelConversation.Location = new System.Drawing.Point(14, 10);
            this.labelConversation.Name = "labelConversation";
            this.labelConversation.Size = new System.Drawing.Size(128, 20);
            this.labelConversation.TabIndex = 0;
            this.labelConversation.Text = "Hội thoại CSKH";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(108, 117, 125);
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(619, 554);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(105, 32);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Đóng";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // SupportDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(237, 224, 207);
            this.ClientSize = new System.Drawing.Size(740, 600);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelConversation);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SupportDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết yêu cầu";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.panelConversation.ResumeLayout(false);
            this.panelConversation.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelCustomerValue;
        private System.Windows.Forms.Label labelUserIdValue;
        private System.Windows.Forms.Label labelDateValue;
        private System.Windows.Forms.Label labelStatusValue;
        private System.Windows.Forms.Panel panelConversation;
        private System.Windows.Forms.Label labelConversation;
        private System.Windows.Forms.TextBox textBoxDetail;
        private System.Windows.Forms.Button buttonClose;
    }
}


