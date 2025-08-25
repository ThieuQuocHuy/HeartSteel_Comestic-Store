namespace Customer.Admin
{
    partial class ProductAddEditForm
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
            panelTop = new Panel();
            labelTitle = new Label();
            panelMain = new Panel();
            checkBoxActive = new CheckBox();
            buttonBrowseImage = new Button();
            textBoxImagePath = new TextBox();
            label7 = new Label();
            comboBoxCategory = new ComboBox();
            label6 = new Label();
            numericUpDownStock = new NumericUpDown();
            label5 = new Label();
            numericUpDownPrice = new NumericUpDown();
            label4 = new Label();
            textBoxDescription = new TextBox();
            label3 = new Label();
            textBoxName = new TextBox();
            label2 = new Label();
            panelBottom = new Panel();
            buttonCancel = new Button();
            buttonSave = new Button();
            panelTop.SuspendLayout();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(44, 62, 80);
            panelTop.Controls.Add(labelTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(600, 80);
            panelTop.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(20, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(258, 41);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Thêm sản phẩm mới";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(236, 240, 241);
            panelMain.Controls.Add(checkBoxActive);
            panelMain.Controls.Add(buttonBrowseImage);
            panelMain.Controls.Add(textBoxImagePath);
            panelMain.Controls.Add(label7);
            panelMain.Controls.Add(comboBoxCategory);
            panelMain.Controls.Add(label6);
            panelMain.Controls.Add(numericUpDownStock);
            panelMain.Controls.Add(label5);
            panelMain.Controls.Add(numericUpDownPrice);
            panelMain.Controls.Add(label4);
            panelMain.Controls.Add(textBoxDescription);
            panelMain.Controls.Add(label3);
            panelMain.Controls.Add(textBoxName);
            panelMain.Controls.Add(label2);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 80);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(30);
            panelMain.Size = new Size(600, 520);
            panelMain.TabIndex = 1;
            // 
            // checkBoxActive
            // 
            checkBoxActive.AutoSize = true;
            checkBoxActive.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            checkBoxActive.ForeColor = Color.FromArgb(44, 62, 80);
            checkBoxActive.Location = new Point(30, 450);
            checkBoxActive.Name = "checkBoxActive";
            checkBoxActive.Size = new Size(197, 32);
            checkBoxActive.TabIndex = 13;
            checkBoxActive.Text = "Sản phẩm hiệu lực";
            checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // buttonBrowseImage
            // 
            buttonBrowseImage.BackColor = Color.FromArgb(52, 152, 219);
            buttonBrowseImage.FlatAppearance.BorderSize = 0;
            buttonBrowseImage.FlatStyle = FlatStyle.Flat;
            buttonBrowseImage.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            buttonBrowseImage.ForeColor = Color.White;
            buttonBrowseImage.Location = new Point(480, 400);
            buttonBrowseImage.Name = "buttonBrowseImage";
            buttonBrowseImage.Size = new Size(90, 35);
            buttonBrowseImage.TabIndex = 12;
            buttonBrowseImage.Text = "Chọn...";
            buttonBrowseImage.UseVisualStyleBackColor = false;
            buttonBrowseImage.Click += buttonBrowseImage_Click;
            // 
            // textBoxImagePath
            // 
            textBoxImagePath.Font = new Font("Microsoft Sans Serif", 12F);
            textBoxImagePath.Location = new Point(30, 400);
            textBoxImagePath.Name = "textBoxImagePath";
            textBoxImagePath.PlaceholderText = "Đường dẫn hình ảnh (tùy chọn)";
            textBoxImagePath.Size = new Size(440, 34);
            textBoxImagePath.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(44, 62, 80);
            label7.Location = new Point(30, 370);
            label7.Name = "label7";
            label7.Size = new Size(108, 28);
            label7.TabIndex = 10;
            label7.Text = "Hình ảnh:";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Font = new Font("Microsoft Sans Serif", 12F);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(320, 320);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(250, 36);
            comboBoxCategory.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(44, 62, 80);
            label6.Location = new Point(320, 290);
            label6.Name = "label6";
            label6.Size = new Size(111, 28);
            label6.TabIndex = 8;
            label6.Text = "Danh mục:";
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.Font = new Font("Microsoft Sans Serif", 12F);
            numericUpDownStock.Location = new Point(30, 320);
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(250, 34);
            numericUpDownStock.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(44, 62, 80);
            label5.Location = new Point(30, 290);
            label5.Name = "label5";
            label5.Size = new Size(99, 28);
            label5.TabIndex = 6;
            label5.Text = "Số lượng:";
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Font = new Font("Microsoft Sans Serif", 12F);
            numericUpDownPrice.Location = new Point(30, 240);
            numericUpDownPrice.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(540, 34);
            numericUpDownPrice.TabIndex = 5;
            numericUpDownPrice.ThousandsSeparator = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(44, 62, 80);
            label4.Location = new Point(30, 210);
            label4.Name = "label4";
            label4.Size = new Size(101, 28);
            label4.TabIndex = 4;
            label4.Text = "Giá bán *:";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Font = new Font("Microsoft Sans Serif", 12F);
            textBoxDescription.Location = new Point(30, 120);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.PlaceholderText = "Mô tả chi tiết về sản phẩm...";
            textBoxDescription.ScrollBars = ScrollBars.Vertical;
            textBoxDescription.Size = new Size(540, 80);
            textBoxDescription.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(44, 62, 80);
            label3.Location = new Point(30, 90);
            label3.Name = "label3";
            label3.Size = new Size(74, 28);
            label3.TabIndex = 2;
            label3.Text = "Mô tả:";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Microsoft Sans Serif", 12F);
            textBoxName.Location = new Point(30, 40);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Nhập tên sản phẩm";
            textBoxName.Size = new Size(540, 34);
            textBoxName.TabIndex = 1;
            textBoxName.KeyPress += textBoxName_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(44, 62, 80);
            label2.Location = new Point(30, 10);
            label2.Name = "label2";
            label2.Size = new Size(159, 28);
            label2.TabIndex = 0;
            label2.Text = "Tên sản phẩm *:";
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.FromArgb(236, 240, 241);
            panelBottom.Controls.Add(buttonCancel);
            panelBottom.Controls.Add(buttonSave);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 520);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(30);
            panelBottom.Size = new Size(600, 80);
            panelBottom.TabIndex = 2;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(149, 165, 166);
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(450, 20);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(120, 40);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Hủy";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(46, 204, 113);
            buttonSave.FlatAppearance.BorderSize = 0;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(320, 20);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(120, 40);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Lưu";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // ProductAddEditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 600);
            Controls.Add(panelBottom);
            Controls.Add(panelMain);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductAddEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý sản phẩm";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label labelTitle;
        private Panel panelMain;
        private Panel panelBottom;
        private Label label2;
        private TextBox textBoxName;
        private TextBox textBoxDescription;
        private Label label3;
        private NumericUpDown numericUpDownPrice;
        private Label label4;
        private NumericUpDown numericUpDownStock;
        private Label label5;
        private ComboBox comboBoxCategory;
        private Label label6;
        private TextBox textBoxImagePath;
        private Label label7;
        private Button buttonBrowseImage;
        private CheckBox checkBoxActive;
        private Button buttonSave;
        private Button buttonCancel;
    }
}