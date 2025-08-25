namespace Customer.Admin
{
    partial class RestockForm
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
            textBoxNote = new TextBox();
            label3 = new Label();
            numericUpDownQuantity = new NumericUpDown();
            label2 = new Label();
            labelProductName = new Label();
            panelBottom = new Panel();
            buttonCancel = new Button();
            buttonRestock = new Button();
            panelTop.SuspendLayout();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
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
            panelTop.Size = new Size(500, 80);
            panelTop.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            labelTitle.ForeColor = Color.White;
            labelTitle.Location = new Point(20, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(158, 41);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Nhập hàng";
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(236, 240, 241);
            panelMain.Controls.Add(textBoxNote);
            panelMain.Controls.Add(label3);
            panelMain.Controls.Add(numericUpDownQuantity);
            panelMain.Controls.Add(label2);
            panelMain.Controls.Add(labelProductName);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 80);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(30);
            panelMain.Size = new Size(500, 270);
            panelMain.TabIndex = 1;
            // 
            // textBoxNote
            // 
            textBoxNote.Font = new Font("Microsoft Sans Serif", 12F);
            textBoxNote.Location = new Point(30, 160);
            textBoxNote.Multiline = true;
            textBoxNote.Name = "textBoxNote";
            textBoxNote.PlaceholderText = "Ghi chú (tùy chọn)...";
            textBoxNote.ScrollBars = ScrollBars.Vertical;
            textBoxNote.Size = new Size(440, 80);
            textBoxNote.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(44, 62, 80);
            label3.Location = new Point(30, 130);
            label3.Name = "label3";
            label3.Size = new Size(84, 28);
            label3.TabIndex = 3;
            label3.Text = "Ghi chú:";
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Font = new Font("Microsoft Sans Serif", 14F);
            numericUpDownQuantity.Location = new Point(30, 80);
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(440, 39);
            numericUpDownQuantity.TabIndex = 2;
            numericUpDownQuantity.TextAlign = HorizontalAlignment.Center;
            numericUpDownQuantity.ThousandsSeparator = true;
            numericUpDownQuantity.KeyPress += numericUpDownQuantity_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(44, 62, 80);
            label2.Location = new Point(30, 50);
            label2.Name = "label2";
            label2.Size = new Size(150, 28);
            label2.TabIndex = 1;
            label2.Text = "Số lượng nhập:";
            // 
            // labelProductName
            // 
            labelProductName.AutoSize = true;
            labelProductName.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            labelProductName.ForeColor = Color.FromArgb(44, 62, 80);
            labelProductName.Location = new Point(30, 10);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(194, 32);
            labelProductName.TabIndex = 0;
            labelProductName.Text = "Sản phẩm: [Tên]";
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.FromArgb(236, 240, 241);
            panelBottom.Controls.Add(buttonCancel);
            panelBottom.Controls.Add(buttonRestock);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 270);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(30);
            panelBottom.Size = new Size(500, 80);
            panelBottom.TabIndex = 2;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(149, 165, 166);
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(350, 20);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(120, 40);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Hủy";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonRestock
            // 
            buttonRestock.BackColor = Color.FromArgb(46, 204, 113);
            buttonRestock.FlatAppearance.BorderSize = 0;
            buttonRestock.FlatStyle = FlatStyle.Flat;
            buttonRestock.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            buttonRestock.ForeColor = Color.White;
            buttonRestock.Location = new Point(220, 20);
            buttonRestock.Name = "buttonRestock";
            buttonRestock.Size = new Size(120, 40);
            buttonRestock.TabIndex = 0;
            buttonRestock.Text = "📦 Nhập hàng";
            buttonRestock.UseVisualStyleBackColor = false;
            buttonRestock.Click += buttonRestock_Click;
            // 
            // RestockForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 350);
            Controls.Add(panelBottom);
            Controls.Add(panelMain);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RestockForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nhập hàng - HeartSteel Cosmetic";
            Load += RestockForm_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label labelTitle;
        private Panel panelMain;
        private Label labelProductName;
        private NumericUpDown numericUpDownQuantity;
        private Label label2;
        private TextBox textBoxNote;
        private Label label3;
        private Panel panelBottom;
        private Button buttonRestock;
        private Button buttonCancel;
    }
}