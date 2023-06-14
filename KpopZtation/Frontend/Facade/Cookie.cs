using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Frontend.Facade
{
    public class Cookie
    {
        public static readonly string CookieKey = "RememberMe";
        public static HttpCookie GetCookie(HttpRequest request)
        {
            HttpCookie rememberMeCookie = request.Cookies[CookieKey];

            return rememberMeCookie;
        }

        public static int GetCookieValue(HttpRequest request)
        {
            return Int32.Parse(GetCookie(request).Value);
        }

        public static void SetCookie(HttpResponse response, int userId)
        {
            HttpCookie rememberMeCookie = new HttpCookie(CookieKey, userId.ToString())
            {
                Expires = DateTime.Now.AddHours(1)
            };

            response.Cookies.Add(rememberMeCookie);
        }

        public static void DeleteCookie(HttpRequest request, HttpResponse response)
        {
            HttpCookie rememberMeCookie = GetCookie(request);
            if (rememberMeCookie != null)
            {
                rememberMeCookie.Expires = DateTime.Now.AddDays(-1);
                response.Cookies.Add(rememberMeCookie);
            }
        }
    }
}