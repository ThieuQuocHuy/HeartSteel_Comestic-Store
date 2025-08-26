using Presentation.Pages.Customer;
using Presentation.Navigation;

namespace Presentation
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
            // Thiết lập ghi log ra file để debug
            var logFile = System.IO.Path.Combine(AppContext.BaseDirectory, "app.log");
            System.Diagnostics.Trace.Listeners.Add(new System.Diagnostics.TextWriterTraceListener(logFile));
            System.Diagnostics.Trace.AutoFlush = true;
            System.Diagnostics.Trace.WriteLine("[BOOT] app started");
            // Chạy app qua Navigator để kiểm soát vòng đời form
            Navigator.Run(new LoginForm());
        }
    }
}