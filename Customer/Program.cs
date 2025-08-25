using Customer.Admin;

namespace Customer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            // Vòng lặp để cho phép quay lại StartupForm khi đóng các form chính
            bool continueRunning = true;
            while (continueRunning)
            {
                // Hiển thị form lựa chọn
                var startupForm = new StartupForm();
                if (startupForm.ShowDialog() == DialogResult.OK)
                {
                    if (startupForm.IsAdminMode)
                    {
                        // Chạy AdminHomePage và chờ đóng
                        using (var adminForm = new AdminHomePage())
                        {
                            adminForm.ShowDialog();
                        }
                        // Sau khi đóng AdminHomePage, quay lại StartupForm
                    }
                    else
                    {
                        // Chạy HomePage cho customer và thoát
                        Application.Run(new HomePage());
                        continueRunning = false; // Thoát vòng lặp khi đóng HomePage
                    }
                }
                else
                {
                    // Người dùng đóng StartupForm, thoát ứng dụng
                    continueRunning = false;
                }
            }
        }
    }
}