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

        public static void REDIRECT(HttpResponse Response, string URL, string ID)
        {
            string ValidatedURL = VALIDATE_URL(URL);
            if(ID != "")
            {
                ValidatedURL += "?id=" + ID;
            }
            Response.Redirect(BASE_PATH + ValidatedURL);
        }

        public static void REDIRECT_INSERT_ARTIST(HttpResponse Response)
        {
            REDIRECT(Response, "/Admin/ArtistInsert", "");
        }

        public static void REDIRECT_HOME(HttpResponse Response)
        {
            REDIRECT(Response, "/Guest/Home", "");
        }

        public static void REDIRECT_LOGIN(HttpResponse Response)
        {
            REDIRECT(Response, "/Guest/Login", "");
        }

        public static void REDIRECT_REGISTER(HttpResponse Response)
        {
            REDIRECT(Response, "/Guest/Register", "");
        }

        public static void REDIRECT_ARTIST_DETAIL(HttpResponse Response, string ID)
        {
            REDIRECT(Response, "/Guest/Detail", ID);
        }

        public static void REDIRECT_INSERT_ALBUM(HttpResponse Response, string ID)
        {
            REDIRECT(Response, "/Admin/AlbumInsert", ID);
        }
        public static void REDIRECT_CART(HttpResponse Response)
        {
            REDIRECT(Response, "/Client/CartView", "");
        }

        public static void REDIRECT_TRANSACTION_HISTORY(HttpResponse Response)
        {
            REDIRECT(Response, "/Client/TransactionHistory", "");
        }
    }
}