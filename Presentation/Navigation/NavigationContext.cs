using System;
using System.Windows.Forms;

namespace Presentation.Navigation
{
    public sealed class NavigationContext : ApplicationContext
    {
        private Form? _currentForm;
        private readonly FormClosedEventHandler _exitOnCloseHandler;

        public NavigationContext()
        {
            _exitOnCloseHandler = (_, __) => ExitThread();
        }

        public void ShowNext(Form nextForm)
        {
            // Ensure previous form won't exit the app when it is closed programmatically
            if (_currentForm != null)
            {
                _currentForm.FormClosed -= _exitOnCloseHandler;
            }

            // When the currently visible form is closed via X, exit the app entirely
            nextForm.FormClosed += _exitOnCloseHandler;

            Form? previousForm = _currentForm;
            _currentForm = nextForm;

            nextForm.Show();

            if (previousForm != null && !previousForm.IsDisposed)
            {
                try
                {
                    previousForm.Close();
                }
                catch
                {
                    // Ignore close errors
                }
            }
        }
    }
}


