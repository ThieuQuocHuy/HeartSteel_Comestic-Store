namespace Presentation.Pages.Admin
{
    partial class ResponseDialogForm
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
            groupBoxInfo = new System.Windows.Forms.GroupBox();
            textBoxUserId = new System.Windows.Forms.TextBox();
            labelUserId = new System.Windows.Forms.Label();
            textBoxStatus = new System.Windows.Forms.TextBox();
            labelStatus = new System.Windows.Forms.Label();
            dateTimePickerRequestDate = new System.Windows.Forms.DateTimePicker();
            labelRequestDate = new System.Windows.Forms.Label();
            textBoxCustomerName = new System.Windows.Forms.TextBox();
            labelCustomerName = new System.Windows.Forms.Label();
            labelContent = new System.Windows.Forms.Label();
            textBoxContent = new System.Windows.Forms.TextBox();
            textBoxResponse = new System.Windows.Forms.TextBox();
            buttonSend = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInfo
            // 
            groupBoxInfo.Controls.Add(textBoxUserId);
            groupBoxInfo.Controls.Add(labelUserId);
            groupBoxInfo.Controls.Add(textBoxStatus);
            groupBoxInfo.Controls.Add(labelStatus);
            groupBoxInfo.Controls.Add(dateTimePickerRequestDate);
            groupBoxInfo.Controls.Add(labelRequestDate);
            groupBoxInfo.Controls.Add(textBoxCustomerName);
            groupBoxInfo.Controls.Add(labelCustomerName);
            groupBoxInfo.Controls.Add(labelContent);
            groupBoxInfo.Controls.Add(textBoxContent);
            groupBoxInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            groupBoxInfo.Location = new System.Drawing.Point(12, 12);
            groupBoxInfo.Name = "groupBoxInfo";
            groupBoxInfo.Size = new System.Drawing.Size(660, 340);
            groupBoxInfo.TabIndex = 0;
            groupBoxInfo.TabStop = false;
            groupBoxInfo.Text = "Thông tin yêu cầu";
            // 
            // textBoxUserId
            // 
            textBoxUserId.Location = new System.Drawing.Point(430, 45);
            textBoxUserId.Name = "textBoxUserId";
            textBoxUserId.ReadOnly = true;
            textBoxUserId.Size = new System.Drawing.Size(210, 27);
            textBoxUserId.TabIndex = 15;
            // 
            // labelUserId
            // 
            labelUserId.AutoSize = true;
            labelUserId.Location = new System.Drawing.Point(350, 49);
            labelUserId.Name = "labelUserId";
            labelUserId.Size = new System.Drawing.Size(59, 20);
            labelUserId.TabIndex = 14;
            labelUserId.Text = "User ID:";
            // 
            // textBoxStatus
            // 
            textBoxStatus.Location = new System.Drawing.Point(430, 100);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.ReadOnly = true;
            textBoxStatus.Size = new System.Drawing.Size(210, 27);
            textBoxStatus.TabIndex = 13;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new System.Drawing.Point(350, 104);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new System.Drawing.Size(78, 20);
            labelStatus.TabIndex = 12;
            labelStatus.Text = "Trạng thái:";
            // 
            // dateTimePickerRequestDate
            // 
            dateTimePickerRequestDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePickerRequestDate.Enabled = false;
            dateTimePickerRequestDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePickerRequestDate.Location = new System.Drawing.Point(140, 100);
            dateTimePickerRequestDate.Name = "dateTimePickerRequestDate";
            dateTimePickerRequestDate.Size = new System.Drawing.Size(190, 27);
            dateTimePickerRequestDate.TabIndex = 11;
            // 
            // labelRequestDate
            // 
            labelRequestDate.AutoSize = true;
            labelRequestDate.Location = new System.Drawing.Point(16, 104);
            labelRequestDate.Name = "labelRequestDate";
            labelRequestDate.Size = new System.Drawing.Size(91, 20);
            labelRequestDate.TabIndex = 10;
            labelRequestDate.Text = "Ngày yêu cầu:";
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.Location = new System.Drawing.Point(140, 45);
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.ReadOnly = true;
            textBoxCustomerName.Size = new System.Drawing.Size(190, 27);
            textBoxCustomerName.TabIndex = 9;
            // 
            // labelCustomerName
            // 
            labelCustomerName.AutoSize = true;
            labelCustomerName.Location = new System.Drawing.Point(16, 49);
            labelCustomerName.Name = "labelCustomerName";
            labelCustomerName.Size = new System.Drawing.Size(114, 20);
            labelCustomerName.TabIndex = 8;
            labelCustomerName.Text = "Tên khách hàng:";
            // 
            // labelContent
            // 
            labelContent.AutoSize = true;
            labelContent.Location = new System.Drawing.Point(16, 150);
            labelContent.Name = "labelContent";
            labelContent.Size = new System.Drawing.Size(121, 20);
            labelContent.TabIndex = 7;
            labelContent.Text = "Nội dung yêu cầu:";
            // 
            // textBoxContent
            // 
            textBoxContent.Location = new System.Drawing.Point(16, 173);
            textBoxContent.Multiline = true;
            textBoxContent.Name = "textBoxContent";
            textBoxContent.ReadOnly = true;
            textBoxContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBoxContent.Size = new System.Drawing.Size(624, 150);
            textBoxContent.TabIndex = 6;
            // 
            // textBoxResponse
            // 
            textBoxResponse.Location = new System.Drawing.Point(12, 362);
            textBoxResponse.Multiline = true;
            textBoxResponse.Name = "textBoxResponse";
            textBoxResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            textBoxResponse.Size = new System.Drawing.Size(660, 70);
            textBoxResponse.TabIndex = 1;
            // 
            // buttonSend
            // 
            buttonSend.Location = new System.Drawing.Point(486, 438);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new System.Drawing.Size(90, 30);
            buttonSend.TabIndex = 2;
            buttonSend.Text = "Gửi phản";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new System.Drawing.Point(582, 438);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(90, 30);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Hủy";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // ResponseDialogForm
            // 
            this.AcceptButton = this.buttonSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 480);
            this.Controls.Add(buttonCancel);
            this.Controls.Add(buttonSend);
            this.Controls.Add(textBoxResponse);
            this.Controls.Add(groupBoxInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResponseDialogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhập phản hồi";
            groupBoxInfo.ResumeLayout(false);
            groupBoxInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.Label labelUserId;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.DateTimePicker dateTimePickerRequestDate;
        private System.Windows.Forms.Label labelRequestDate;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelContent;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.TextBox textBoxResponse;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonCancel;
    }
}


