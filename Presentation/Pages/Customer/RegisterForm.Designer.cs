namespace Presentation.Pages.Customer
{
    partial class RegisterForm
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
            panelRegister = new Panel();
            labelTitle = new Label();
            labelUsername = new Label();
            textBoxUsername = new TextBox();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            labelConfirmPassword = new Label();
            textBoxConfirmPassword = new TextBox();
            labelFullName = new Label();
            textBoxFullName = new TextBox();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            labelPhone = new Label();
            textBoxPhone = new TextBox();
            labelAddress = new Label();
            textBoxAddress = new TextBox();
            buttonRegister = new Button();
            buttonBackToLogin = new Button();
            labelSubtitle = new Label();
            panelRegister.SuspendLayout();
            SuspendLayout();
            // 
            // panelRegister
            // 
            panelRegister.BackColor = Color.FromArgb(237, 224, 207);
            panelRegister.Controls.Add(labelSubtitle);
            panelRegister.Controls.Add(buttonBackToLogin);
            panelRegister.Controls.Add(buttonRegister);
            panelRegister.Controls.Add(textBoxAddress);
            panelRegister.Controls.Add(labelAddress);
            panelRegister.Controls.Add(textBoxPhone);
            panelRegister.Controls.Add(labelPhone);
            panelRegister.Controls.Add(textBoxEmail);
            panelRegister.Controls.Add(labelEmail);
            panelRegister.Controls.Add(textBoxFullName);
            panelRegister.Controls.Add(labelFullName);
            panelRegister.Controls.Add(textBoxConfirmPassword);
            panelRegister.Controls.Add(labelConfirmPassword);
            panelRegister.Controls.Add(textBoxPassword);
            panelRegister.Controls.Add(labelPassword);
            panelRegister.Controls.Add(textBoxUsername);
            panelRegister.Controls.Add(labelUsername);
            panelRegister.Controls.Add(labelTitle);
            panelRegister.Location = new Point(100, 20);
            panelRegister.Name = "panelRegister";
            panelRegister.Size = new Size(600, 700);
            panelRegister.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.FromArgb(77, 58, 41);
            labelTitle.Location = new Point(200, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(200, 41);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "ĐĂNG KÝ";
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsername.ForeColor = Color.FromArgb(77, 58, 41);
            labelUsername.Location = new Point(50, 100);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(120, 28);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Tài khoản:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxUsername.Location = new Point(50, 130);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(500, 34);
            textBoxUsername.TabIndex = 2;
            textBoxUsername.KeyPress += textBoxUsername_KeyPress;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassword.ForeColor = Color.FromArgb(77, 58, 41);
            labelPassword.Location = new Point(50, 180);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(100, 28);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Mật khẩu:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPassword.Location = new Point(50, 210);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '●';
            textBoxPassword.Size = new Size(500, 34);
            textBoxPassword.TabIndex = 4;
            textBoxPassword.KeyPress += textBoxPassword_KeyPress;
            // 
            // labelConfirmPassword
            // 
            labelConfirmPassword.AutoSize = true;
            labelConfirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelConfirmPassword.ForeColor = Color.FromArgb(77, 58, 41);
            labelConfirmPassword.Location = new Point(50, 260);
            labelConfirmPassword.Name = "labelConfirmPassword";
            labelConfirmPassword.Size = new Size(180, 28);
            labelConfirmPassword.TabIndex = 5;
            labelConfirmPassword.Text = "Xác nhận mật khẩu:";
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxConfirmPassword.Location = new Point(50, 290);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.PasswordChar = '●';
            textBoxConfirmPassword.Size = new Size(500, 34);
            textBoxConfirmPassword.TabIndex = 6;
            textBoxConfirmPassword.KeyPress += textBoxConfirmPassword_KeyPress;
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFullName.ForeColor = Color.FromArgb(77, 58, 41);
            labelFullName.Location = new Point(50, 340);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(100, 28);
            labelFullName.TabIndex = 7;
            labelFullName.Text = "Họ và tên:";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFullName.Location = new Point(50, 370);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(500, 34);
            textBoxFullName.TabIndex = 8;
            textBoxFullName.KeyPress += textBoxFullName_KeyPress;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.ForeColor = Color.FromArgb(77, 58, 41);
            labelEmail.Location = new Point(50, 420);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(60, 28);
            labelEmail.TabIndex = 9;
            labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxEmail.Location = new Point(50, 450);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(500, 34);
            textBoxEmail.TabIndex = 10;
            textBoxEmail.KeyPress += textBoxEmail_KeyPress;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPhone.ForeColor = Color.FromArgb(77, 58, 41);
            labelPhone.Location = new Point(50, 500);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(80, 28);
            labelPhone.TabIndex = 11;
            labelPhone.Text = "Số điện thoại:";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPhone.Location = new Point(50, 530);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(500, 34);
            textBoxPhone.TabIndex = 12;
            textBoxPhone.KeyPress += textBoxPhone_KeyPress;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAddress.ForeColor = Color.FromArgb(77, 58, 41);
            labelAddress.Location = new Point(50, 580);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(80, 28);
            labelAddress.TabIndex = 13;
            labelAddress.Text = "Địa chỉ:";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxAddress.Location = new Point(50, 610);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(500, 34);
            textBoxAddress.TabIndex = 14;
            textBoxAddress.KeyPress += textBoxAddress_KeyPress;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.FromArgb(77, 58, 41);
            buttonRegister.FlatAppearance.BorderSize = 0;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegister.ForeColor = Color.White;
            buttonRegister.Location = new Point(200, 660);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(200, 45);
            buttonRegister.TabIndex = 15;
            buttonRegister.Text = "Đăng ký";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // buttonBackToLogin
            // 
            buttonBackToLogin.BackColor = Color.FromArgb(138, 80, 20);
            buttonBackToLogin.FlatAppearance.BorderSize = 0;
            buttonBackToLogin.FlatStyle = FlatStyle.Flat;
            buttonBackToLogin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBackToLogin.ForeColor = Color.White;
            buttonBackToLogin.Location = new Point(50, 20);
            buttonBackToLogin.Name = "buttonBackToLogin";
            buttonBackToLogin.Size = new Size(100, 30);
            buttonBackToLogin.TabIndex = 16;
            buttonBackToLogin.Text = "← Quay lại";
            buttonBackToLogin.UseVisualStyleBackColor = false;
            buttonBackToLogin.Click += buttonBackToLogin_Click;
            // 
            // labelSubtitle
            // 
            labelSubtitle.AutoSize = true;
            labelSubtitle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSubtitle.ForeColor = Color.FromArgb(77, 58, 41);
            labelSubtitle.Location = new Point(200, 60);
            labelSubtitle.Name = "labelSubtitle";
            labelSubtitle.Size = new Size(200, 23);
            labelSubtitle.TabIndex = 17;
            labelSubtitle.Text = "HeartSteel Cosmetic Store";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 255);
            ClientSize = new Size(800, 750);
            Controls.Add(panelRegister);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký - HeartSteel Cosmetic";
            panelRegister.ResumeLayout(false);
            panelRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelRegister;
        private Label labelTitle;
        private Label labelUsername;
        private TextBox textBoxUsername;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private Label labelConfirmPassword;
        private TextBox textBoxConfirmPassword;
        private Label labelFullName;
        private TextBox textBoxFullName;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label labelPhone;
        private TextBox textBoxPhone;
        private Label labelAddress;
        private TextBox textBoxAddress;
        private Button buttonRegister;
        private Button buttonBackToLogin;
        private Label labelSubtitle;
    }
}
