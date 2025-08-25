
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
            ApplicationConfiguration.Initialize();
            
            // Mở LoginForm khi chạy app
            Application.Run(new LoginForm());
        }
    }
}