using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Frontend.Facade
{
    public class Redirect
    {
        public static string BASE_PATH = "/Frontend/View";
        public static string ASSET_PATH = "~/Assets/";

        public static string VALIDATE_URL(string URL)
        {
            string Prefix = URL.Substring(URL.Length - 4);
            if (Prefix != ".aspx")
                return URL + ".aspx";
            else
                return URL;
        }
        public static void REDIRECT(HttpResponse Response, string URL)
        {
            string ValidatedURL = VALIDATE_URL(URL);
            Response.Redirect(BASE_PATH + ValidatedURL);
        }

        public static void REDIRECT_HOME(HttpResponse Response)
        {
            REDIRECT(Response, "/Guest/Home");
        }

        public static void REDIRECT_LOGIN(HttpResponse Response)
        {
            REDIRECT(Response, "/Guest/Login");
        }

        public static void REDIRECT_REGISTER(HttpResponse Response)
        {
            REDIRECT(Response, "/Guest/Register");
        }
    }
}