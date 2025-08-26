using DAL.Models;

namespace Presentation.Auth
{
    public static class UserSession
    {
        public static int? CurrentUserId { get; private set; }
        public static User? CurrentUser { get; private set; }

        public static void SetUser(User user)
        {
            CurrentUser = user;
            CurrentUserId = user.UserId;
        }

        public static void Clear()
        {
            CurrentUser = null;
            CurrentUserId = null;
        }
    }
}


