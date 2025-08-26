namespace Presentation.Pages.Customer
{
    partial class ProductDetailPage
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
            pictureBox = new System.Windows.Forms.PictureBox();
            labelName = new System.Windows.Forms.Label();
            labelCategoryTitle = new System.Windows.Forms.Label();
            labelCategory = new System.Windows.Forms.Label();
            labelStatusTitle = new System.Windows.Forms.Label();
            labelStatus = new System.Windows.Forms.Label();
            labelPrice = new System.Windows.Forms.Label();
            labelMarketPrice = new System.Windows.Forms.Label();
            labelStock = new System.Windows.Forms.Label();
            labelSold = new System.Windows.Forms.Label();
            labelStockInDate = new System.Windows.Forms.Label();
            textDescription = new System.Windows.Forms.TextBox();
            panelCard = new System.Windows.Forms.Panel();
            buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new System.Drawing.Point(15, 60);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new System.Drawing.Size(300, 260);
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // labelName
            // 
            labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            labelName.Location = new System.Drawing.Point(330, 15);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(430, 40);
            labelName.TabIndex = 1;
            labelName.Text = "Tên sản phẩm";
            labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCategoryTitle
            // 
            labelCategoryTitle.AutoSize = true;
            labelCategoryTitle.Location = new System.Drawing.Point(330, 70);
            labelCategoryTitle.Name = "labelCategoryTitle";
            labelCategoryTitle.Size = new System.Drawing.Size(88, 20);
            labelCategoryTitle.TabIndex = 2;
            labelCategoryTitle.Text = "Danh mục:";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new System.Drawing.Point(430, 70);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new System.Drawing.Size(12, 20);
            labelCategory.TabIndex = 3;
            labelCategory.Text = "-";
            // 
            // labelStatusTitle
            // 
            labelStatusTitle.AutoSize = true;
            labelStatusTitle.Location = new System.Drawing.Point(330, 100);
            labelStatusTitle.Name = "labelStatusTitle";
            labelStatusTitle.Size = new System.Drawing.Size(73, 20);
            labelStatusTitle.TabIndex = 4;
            labelStatusTitle.Text = "Trạng thái:";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new System.Drawing.Point(430, 100);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new System.Drawing.Size(12, 20);
            labelStatus.TabIndex = 5;
            labelStatus.Text = "-";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            labelPrice.ForeColor = System.Drawing.Color.Red;
            labelPrice.Location = new System.Drawing.Point(330, 140);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new System.Drawing.Size(85, 29);
            labelPrice.TabIndex = 6;
            labelPrice.Text = "Giá bán:";
            // 
            // labelMarketPrice
            // 
            labelMarketPrice.AutoSize = true;
            labelMarketPrice.Location = new System.Drawing.Point(330, 180);
            labelMarketPrice.Name = "labelMarketPrice";
            labelMarketPrice.Size = new System.Drawing.Size(107, 20);
            labelMarketPrice.TabIndex = 7;
            labelMarketPrice.Text = "Giá thị trường:";
            // 
            // labelStock
            // 
            labelStock.AutoSize = true;
            labelStock.Location = new System.Drawing.Point(330, 210);
            labelStock.Name = "labelStock";
            labelStock.Size = new System.Drawing.Size(67, 20);
            labelStock.TabIndex = 8;
            labelStock.Text = "Tồn kho:";
            // 
            // labelSold
            // 
            labelSold.AutoSize = true;
            labelSold.Location = new System.Drawing.Point(330, 240);
            labelSold.Name = "labelSold";
            labelSold.Size = new System.Drawing.Size(61, 20);
            labelSold.TabIndex = 9;
            labelSold.Text = "Đã bán:";
            // 
            // labelStockInDate
            // 
            labelStockInDate.AutoSize = true;
            labelStockInDate.Location = new System.Drawing.Point(330, 270);
            labelStockInDate.Name = "labelStockInDate";
            labelStockInDate.Size = new System.Drawing.Size(80, 20);
            labelStockInDate.TabIndex = 10;
            labelStockInDate.Text = "Ngày nhập:";
            // 
            // textDescription
            // 
            textDescription.Location = new System.Drawing.Point(15, 330);
            textDescription.Multiline = true;
            textDescription.Name = "textDescription";
            textDescription.ReadOnly = true;
            textDescription.Size = new System.Drawing.Size(708, 80);
            textDescription.TabIndex = 11;
            // 
            // panelCard
            // 
            panelCard.BackColor = System.Drawing.SystemColors.ControlLightLight;
            panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelCard.Location = new System.Drawing.Point(12, 12);
            panelCard.Name = "panelCard";
            panelCard.Size = new System.Drawing.Size(748, 428);
            panelCard.TabIndex = 12;
            panelCard.Controls.Add(buttonBack);
            panelCard.Controls.Add(pictureBox);
            panelCard.Controls.Add(labelName);
            panelCard.Controls.Add(labelCategoryTitle);
            panelCard.Controls.Add(labelCategory);
            panelCard.Controls.Add(labelStatusTitle);
            panelCard.Controls.Add(labelStatus);
            panelCard.Controls.Add(labelPrice);
            panelCard.Controls.Add(labelMarketPrice);
            panelCard.Controls.Add(labelStock);
            panelCard.Controls.Add(labelSold);
            panelCard.Controls.Add(labelStockInDate);
            panelCard.Controls.Add(textDescription);
            // 
            // buttonBack
            // 
            buttonBack.BackColor = System.Drawing.Color.LightGray;
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
            buttonBack.ForeColor = System.Drawing.Color.Black;
            buttonBack.Location = new System.Drawing.Point(15, 15);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new System.Drawing.Size(90, 35);
            buttonBack.TabIndex = 13;
            buttonBack.Text = "Trở về";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            
            // 
            // ProductDetailPage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(237, 224, 207);
            ClientSize = new System.Drawing.Size(772, 492);
            Controls.Add(panelCard);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductDetailPage";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Chi tiết sản phẩm";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCategoryTitle;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelStatusTitle;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelMarketPrice;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelSold;
        private System.Windows.Forms.Label labelStockInDate;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Button buttonBack;
    }
}


