using System.Windows.Forms;

namespace Presentation.Navigation
{
    public static class Navigator
    {
        private static readonly NavigationContext AppContext = new NavigationContext();

        public static void Navigate(Form nextForm)
        {
            AppContext.ShowNext(nextForm);
        }

        public static void Run(Form firstForm)
        {
            AppContext.ShowNext(firstForm);
            Application.Run(AppContext);
        }
    }
}


