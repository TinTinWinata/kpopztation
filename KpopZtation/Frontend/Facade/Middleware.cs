using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace KpopZtation.Frontend.Facade
{
    public class Middleware
    {
        public static void CheckWeb(string Path, HttpResponse Response, HttpSessionState Session)
        {
            Customer User = AuthSession.GetUser(Session);
            if (User == null && (Path.Contains("Admin") || Path.Contains("Client")))
            {
                Redirect.REDIRECT_HOME(Response);
            }
            else if (Path.Contains("Admin") && User.CustomerRole != "Admin")
            {
                Redirect.REDIRECT_HOME(Response);
            }
        }

        public static void CheckPath(HttpSessionState Session, HttpResponse Response)
        {
            HttpContext context = HttpContext.Current;
            if (context != null)
            {
                string Path = context.Request.Path;
                CheckWeb(Path, Response, Session);
            }
        }
    }
}