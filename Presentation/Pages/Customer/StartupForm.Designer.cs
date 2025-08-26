namespace Presentation.Pages.Customer
{
    partial class StartupForm
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
            panelMain = new Panel();
            buttonCustomer = new Button();
            buttonAdmin = new Button();
            labelSubtitle = new Label();
            labelTitle = new Label();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(236, 240, 241);
            panelMain.Controls.Add(buttonCustomer);
            panelMain.Controls.Add(buttonAdmin);
            panelMain.Controls.Add(labelSubtitle);
            panelMain.Controls.Add(labelTitle);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(50);
            panelMain.Size = new Size(500, 350);
            panelMain.TabIndex = 0;
            // 
            // buttonCustomer
            // 
            buttonCustomer.BackColor = Color.FromArgb(77, 58, 41);
            buttonCustomer.FlatAppearance.BorderSize = 0;
            buttonCustomer.FlatStyle = FlatStyle.Flat;
            buttonCustomer.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            buttonCustomer.ForeColor = Color.White;
            buttonCustomer.Location = new Point(50, 230);
            buttonCustomer.Name = "buttonCustomer";
            buttonCustomer.Size = new Size(400, 60);
            buttonCustomer.TabIndex = 3;
            buttonCustomer.Text = "🛍️ Khách hàng - Mua sắm";
            buttonCustomer.UseVisualStyleBackColor = false;
            buttonCustomer.Click += buttonCustomer_Click;
            // 
            // buttonAdmin
            // 
            buttonAdmin.BackColor = Color.FromArgb(44, 62, 80);
            buttonAdmin.FlatAppearance.BorderSize = 0;
            buttonAdmin.FlatStyle = FlatStyle.Flat;
            buttonAdmin.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            buttonAdmin.ForeColor = Color.White;
            buttonAdmin.Location = new Point(50, 150);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(400, 60);
            buttonAdmin.TabIndex = 2;
            buttonAdmin.Text = "⚙️ Quản trị - Quản lý cửa hàng";
            buttonAdmin.UseVisualStyleBackColor = false;
            buttonAdmin.Click += buttonAdmin_Click;
            // 
            // labelSubtitle
            // 
            labelSubtitle.AutoSize = true;
            labelSubtitle.Font = new Font("Microsoft Sans Serif", 12F);
            labelSubtitle.ForeColor = Color.FromArgb(127, 140, 141);
            labelSubtitle.Location = new Point(50, 100);
            labelSubtitle.Name = "labelSubtitle";
            labelSubtitle.Size = new Size(290, 28);
            labelSubtitle.TabIndex = 1;
            labelSubtitle.Text = "Vui lòng chọn chế độ sử dụng:";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(44, 62, 80);
            labelTitle.Location = new Point(50, 50);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(360, 46);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "HeartSteel Cosmetic";
            // 
            // StartupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 350);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "StartupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HeartSteel Cosmetic - Chọn chế độ";
            Load += StartupForm_Load;
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Label labelTitle;
        private Label labelSubtitle;
        private Button buttonAdmin;
        private Button buttonCustomer;
    }
}