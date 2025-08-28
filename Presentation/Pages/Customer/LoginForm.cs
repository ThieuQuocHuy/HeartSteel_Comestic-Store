using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Services;

namespace Presentation.Pages.Customer
{
    public partial class LoginForm : Form
    {
        private readonly IAuthService _authService;

        public LoginForm()
        {
            InitializeComponent();
            var userRepository = new DAL.Repositories.UserRepository();
            _authService = new AuthService(userRepository);
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                buttonLogin.Enabled = false;
                buttonLogin.Text = "Đang đăng nhập...";

                var username = textBoxUsername.Text.Trim();
                var password = textBoxPassword.Text;

                var (success, user, message) = await _authService.LoginAsync(username, password);

                if (success && user != null)
                {
                    // Kiểm tra role và chuyển hướng
                    var isAdmin = await _authService.IsAdminAsync(user.UserId);

                    if (isAdmin)
                    {
                        MessageBox.Show("Chào mừng Admin! Chức năng Admin sẽ được phát triển sau.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // TODO: Mở AdminHomePage khi có
                        this.Close();
                    }
                    else
                    {
                        // Lưu session người dùng và điều hướng qua Navigator
                        System.Diagnostics.Trace.WriteLine($"[LOGIN] userId={user.UserId}, name={user.Fullname}");
                        Presentation.Auth.UserSession.SetUser(user);
                        Presentation.Navigation.Navigator.Navigate(new HomePage());
                    }
                }
                else
                {
                    MessageBox.Show(message, "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                buttonLogin.Enabled = true;
                buttonLogin.Text = "Đăng nhập";
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.ShowDialog(this);
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonLogin_Click(sender, e);
            }
        }

        private void textBoxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBoxPassword.Focus();
            }
        }
    }
}
