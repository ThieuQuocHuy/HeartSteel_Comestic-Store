using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Repositories;
using DAL.Models;

namespace Presentation.Pages.Customer
{
    public partial class RegisterForm : Form
    {
        private readonly IUserRepository _userRepository;

        public RegisterForm()
        {
            InitializeComponent();
            _userRepository = new UserRepository();
        }

        private async void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(textBoxUsername.Text) ||
                    string.IsNullOrWhiteSpace(textBoxPassword.Text) ||
                    string.IsNullOrWhiteSpace(textBoxConfirmPassword.Text) ||
                    string.IsNullOrWhiteSpace(textBoxFullName.Text) ||
                    string.IsNullOrWhiteSpace(textBoxEmail.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (textBoxPassword.Text != textBoxConfirmPassword.Text)
                {
                    MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxConfirmPassword.Focus();
                    return;
                }

                if (textBoxPassword.Text.Length < 6)
                {
                    MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBoxPassword.Focus();
                    return;
                }

                buttonRegister.Enabled = false;
                buttonRegister.Text = "Đang đăng ký...";

                // Tạo user mới
                var newUser = new User
                {
                    Username = textBoxUsername.Text.Trim(),
                    PasswordHash = textBoxPassword.Text, // Sẽ được hash trong repository
                    Fullname = textBoxFullName.Text.Trim(),
                    Email = textBoxEmail.Text.Trim(),
                    Phone = textBoxPhone.Text.Trim(),
                    Address = textBoxAddress.Text.Trim(),
                    RoleId = 2 // Giả sử role ID 2 là Customer
                };

                var success = await _userRepository.CreateUserAsync(newUser);

                if (success)
                {
                    MessageBox.Show("Đăng ký tài khoản thành công! Bạn có thể đăng nhập ngay bây giờ.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại! Có thể tên đăng nhập đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi đăng ký: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                buttonRegister.Enabled = true;
                buttonRegister.Text = "Đăng ký";
            }
        }

        private void buttonBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBoxPassword.Focus();
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBoxConfirmPassword.Focus();
            }
        }

        private void textBoxConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBoxFullName.Focus();
            }
        }

        private void textBoxFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBoxEmail.Focus();
            }
        }

        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBoxPhone.Focus();
            }
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBoxAddress.Focus();
            }
        }

        private void textBoxAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonRegister_Click(sender, e);
            }
        }
    }
}
