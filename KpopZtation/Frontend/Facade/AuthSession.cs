using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace KpopZtation.Frontend.Facade
{
    public class AuthSession
    {
        public static string USER_KEY = "user";
        public static void SetUser(HttpSessionState Session, Customer Object)
        {
            Session[USER_KEY] = Object;         
        }
        public static Customer GetUser(HttpSessionState Session)
        {
            return (Customer) Session[USER_KEY];
        }
        public static bool IsLoggedIn(HttpSessionState Session)
        {
            return Session[USER_KEY] != null;
        }

        public static void DeleteSession(HttpSessionState Session)
        {
            Session.Clear();
        }
    }
}