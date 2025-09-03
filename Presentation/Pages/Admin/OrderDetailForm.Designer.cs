namespace Presentation.Pages.Admin
{
    partial class OrderDetailForm
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
            groupBoxOrderInfo = new GroupBox();
            textBoxCustomerId = new TextBox();
            labelCustomerId = new Label();
            textBoxCancelReason = new TextBox();
            labelCancelReason = new Label();
            textBoxShippingAddress = new TextBox();
            labelShippingAddress = new Label();
            textBoxStatus = new TextBox();
            labelStatus = new Label();
            dateTimePickerOrderDate = new DateTimePicker();
            labelOrderDate = new Label();
            textBoxCustomerName = new TextBox();
            labelCustomerName = new Label();
            textBoxOrderId = new TextBox();
            labelOrderId = new Label();
            dataGridViewOrderItems = new DataGridView();
            labelGrandTotal = new Label();
            groupBoxOrderInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderItems).BeginInit();
            SuspendLayout();
            // 
            // groupBoxOrderInfo
            // 
            groupBoxOrderInfo.Controls.Add(textBoxCustomerId);
            groupBoxOrderInfo.Controls.Add(labelCustomerId);
            groupBoxOrderInfo.Controls.Add(textBoxCancelReason);
            groupBoxOrderInfo.Controls.Add(labelCancelReason);
            groupBoxOrderInfo.Controls.Add(textBoxShippingAddress);
            groupBoxOrderInfo.Controls.Add(labelShippingAddress);
            groupBoxOrderInfo.Controls.Add(textBoxStatus);
            groupBoxOrderInfo.Controls.Add(labelStatus);
            groupBoxOrderInfo.Controls.Add(dateTimePickerOrderDate);
            groupBoxOrderInfo.Controls.Add(labelOrderDate);
            groupBoxOrderInfo.Controls.Add(textBoxCustomerName);
            groupBoxOrderInfo.Controls.Add(labelCustomerName);
            groupBoxOrderInfo.Controls.Add(textBoxOrderId);
            groupBoxOrderInfo.Controls.Add(labelOrderId);
            groupBoxOrderInfo.Font = new Font("Segoe UI", 9F);
            groupBoxOrderInfo.Location = new Point(16, 18);
            groupBoxOrderInfo.Margin = new Padding(4, 5, 4, 5);
            groupBoxOrderInfo.Name = "groupBoxOrderInfo";
            groupBoxOrderInfo.Padding = new Padding(4, 5, 4, 5);
            groupBoxOrderInfo.Size = new Size(1035, 350);
            groupBoxOrderInfo.TabIndex = 0;
            groupBoxOrderInfo.TabStop = false;
            groupBoxOrderInfo.Text = "Thông tin đơn hàng";
            // 
            // textBoxCustomerId
            // 
            textBoxCustomerId.Location = new Point(691, 46);
            textBoxCustomerId.Margin = new Padding(4, 5, 4, 5);
            textBoxCustomerId.Name = "textBoxCustomerId";
            textBoxCustomerId.ReadOnly = true;
            textBoxCustomerId.Size = new Size(320, 27);
            textBoxCustomerId.TabIndex = 15;
            // 
            // labelCustomerId
            // 
            labelCustomerId.AutoSize = true;
            labelCustomerId.Location = new Point(558, 54);
            labelCustomerId.Margin = new Padding(4, 0, 4, 0);
            labelCustomerId.Name = "labelCustomerId";
            labelCustomerId.Size = new Size(112, 20);
            labelCustomerId.TabIndex = 14;
            labelCustomerId.Text = "Mã khách hàng:";
            // 
            // textBoxCancelReason
            // 
            textBoxCancelReason.Location = new Point(691, 162);
            textBoxCancelReason.Margin = new Padding(4, 5, 4, 5);
            textBoxCancelReason.Multiline = true;
            textBoxCancelReason.Name = "textBoxCancelReason";
            textBoxCancelReason.ReadOnly = true;
            textBoxCancelReason.Size = new Size(320, 152);
            textBoxCancelReason.TabIndex = 13;
            textBoxCancelReason.Visible = false;
            // 
            // labelCancelReason
            // 
            labelCancelReason.AutoSize = true;
            labelCancelReason.Location = new Point(558, 169);
            labelCancelReason.Margin = new Padding(4, 0, 4, 0);
            labelCancelReason.Name = "labelCancelReason";
            labelCancelReason.Size = new Size(74, 20);
            labelCancelReason.TabIndex = 12;
            labelCancelReason.Text = "Lý do hủy:";
            labelCancelReason.Visible = false;
            // 
            // textBoxShippingAddress
            // 
            textBoxShippingAddress.Location = new Point(160, 218);
            textBoxShippingAddress.Margin = new Padding(4, 5, 4, 5);
            textBoxShippingAddress.Multiline = true;
            textBoxShippingAddress.Name = "textBoxShippingAddress";
            textBoxShippingAddress.ReadOnly = true;
            textBoxShippingAddress.Size = new Size(265, 96);
            textBoxShippingAddress.TabIndex = 11;
            // 
            // labelShippingAddress
            // 
            labelShippingAddress.AutoSize = true;
            labelShippingAddress.Location = new Point(27, 225);
            labelShippingAddress.Margin = new Padding(4, 0, 4, 0);
            labelShippingAddress.Name = "labelShippingAddress";
            labelShippingAddress.Size = new Size(129, 20);
            labelShippingAddress.TabIndex = 10;
            labelShippingAddress.Text = "Địa chỉ giao hàng:";
            // 
            // textBoxStatus
            // 
            textBoxStatus.Location = new Point(691, 108);
            textBoxStatus.Margin = new Padding(4, 5, 4, 5);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.ReadOnly = true;
            textBoxStatus.Size = new Size(320, 27);
            textBoxStatus.TabIndex = 9;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(558, 115);
            labelStatus.Margin = new Padding(4, 0, 4, 0);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(78, 20);
            labelStatus.TabIndex = 8;
            labelStatus.Text = "Trạng thái:";
            // 
            // dateTimePickerOrderDate
            // 
            dateTimePickerOrderDate.CustomFormat = "dd/MM/yyyy";
            dateTimePickerOrderDate.Enabled = false;
            dateTimePickerOrderDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerOrderDate.Location = new Point(160, 162);
            dateTimePickerOrderDate.Margin = new Padding(4, 5, 4, 5);
            dateTimePickerOrderDate.Name = "dateTimePickerOrderDate";
            dateTimePickerOrderDate.Size = new Size(265, 27);
            dateTimePickerOrderDate.TabIndex = 5;
            // 
            // labelOrderDate
            // 
            labelOrderDate.AutoSize = true;
            labelOrderDate.Location = new Point(27, 169);
            labelOrderDate.Margin = new Padding(4, 0, 4, 0);
            labelOrderDate.Name = "labelOrderDate";
            labelOrderDate.Size = new Size(110, 20);
            labelOrderDate.TabIndex = 4;
            labelOrderDate.Text = "Ngày đặt hàng:";
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.Location = new Point(160, 104);
            textBoxCustomerName.Margin = new Padding(4, 5, 4, 5);
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.ReadOnly = true;
            textBoxCustomerName.Size = new Size(265, 27);
            textBoxCustomerName.TabIndex = 3;
            // 
            // labelCustomerName
            // 
            labelCustomerName.AutoSize = true;
            labelCustomerName.Location = new Point(27, 112);
            labelCustomerName.Margin = new Padding(4, 0, 4, 0);
            labelCustomerName.Name = "labelCustomerName";
            labelCustomerName.Size = new Size(114, 20);
            labelCustomerName.TabIndex = 2;
            labelCustomerName.Text = "Tên khách hàng:";
            // 
            // textBoxOrderId
            // 
            textBoxOrderId.Location = new Point(160, 46);
            textBoxOrderId.Margin = new Padding(4, 5, 4, 5);
            textBoxOrderId.Name = "textBoxOrderId";
            textBoxOrderId.ReadOnly = true;
            textBoxOrderId.Size = new Size(265, 27);
            textBoxOrderId.TabIndex = 1;
            // 
            // labelOrderId
            // 
            labelOrderId.AutoSize = true;
            labelOrderId.Location = new Point(27, 54);
            labelOrderId.Margin = new Padding(4, 0, 4, 0);
            labelOrderId.Name = "labelOrderId";
            labelOrderId.Size = new Size(100, 20);
            labelOrderId.TabIndex = 0;
            labelOrderId.Text = "Mã đơn hàng:";
            // 
            // dataGridViewOrderItems
            // 
            dataGridViewOrderItems.AllowUserToAddRows = false;
            dataGridViewOrderItems.AllowUserToDeleteRows = false;
            dataGridViewOrderItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewOrderItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOrderItems.BackgroundColor = Color.White;
            dataGridViewOrderItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrderItems.Location = new Point(16, 378);
            dataGridViewOrderItems.Margin = new Padding(4, 5, 4, 5);
            dataGridViewOrderItems.Name = "dataGridViewOrderItems";
            dataGridViewOrderItems.ReadOnly = true;
            dataGridViewOrderItems.RowHeadersWidth = 51;
            dataGridViewOrderItems.Size = new Size(1035, 140);
            dataGridViewOrderItems.TabIndex = 1;
            // 
            // labelGrandTotal
            // 
            labelGrandTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelGrandTotal.AutoSize = true;
            labelGrandTotal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGrandTotal.Location = new Point(733, 537);
            labelGrandTotal.Margin = new Padding(4, 0, 4, 0);
            labelGrandTotal.Name = "labelGrandTotal";
            labelGrandTotal.Size = new Size(158, 25);
            labelGrandTotal.TabIndex = 2;
            labelGrandTotal.Text = "Tổng tiền: 0.00";
            // 
            // OrderDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 581);
            Controls.Add(labelGrandTotal);
            Controls.Add(dataGridViewOrderItems);
            Controls.Add(groupBoxOrderInfo);
            Margin = new Padding(4, 5, 4, 5);
            Name = "OrderDetailForm";
            Text = "Chi tiết đơn hàng";
            groupBoxOrderInfo.ResumeLayout(false);
            groupBoxOrderInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrderItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOrderInfo;
        private System.Windows.Forms.TextBox textBoxOrderId;
        private System.Windows.Forms.Label labelOrderId;
        private System.Windows.Forms.TextBox textBoxCustomerName;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrderDate;
        private System.Windows.Forms.Label labelOrderDate;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelShippingAddress;
        private System.Windows.Forms.TextBox textBoxShippingAddress;
        private System.Windows.Forms.Label labelCancelReason;
        private System.Windows.Forms.TextBox textBoxCancelReason;
        private System.Windows.Forms.DataGridView dataGridViewOrderItems;
        private System.Windows.Forms.Label labelGrandTotal;
        private System.Windows.Forms.Label labelCustomerId;
        private System.Windows.Forms.TextBox textBoxCustomerId;
    }
}