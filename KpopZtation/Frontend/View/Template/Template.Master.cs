using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KpopZtation.Backend.Service;
using KpopZtation.Frontend.Facade;

namespace KpopZtation.Frontend.View.Template
{
    public partial class Template : System.Web.UI.MasterPage
    {

        protected void CheckUser()
        {
            if (AuthSession.IsLoggedIn(Session))
            {
                UsernameLabel.Text = AuthSession.GetUser(Session).CustomerName;
            }
        }

        protected void CheckCookie()
        {
            if (Cookie.GetCookie(Request) != null)
            {
                // Refresh session if there is a cookie data
                string customer = CustomerService.WSGetCustomerById(Cookie.GetCookieValue(Request));
                Customer CustomerData = Json.Decode<Customer>(customer);
                AuthSession.SetUser(Session, CustomerData);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            CheckCookie();
            CheckUser();
        }

        protected void HomeBtn_Click(object sender, EventArgs e)
        {
            Redirect.REDIRECT_HOME(Response);
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            Redirect.REDIRECT_REGISTER(Response);
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            Redirect.REDIRECT_LOGIN(Response); 
        }

        protected void LogoutBtn_Click(Object sender, EventArgs e)
        {
            AuthSession.DeleteSession(Session);
            Cookie.DeleteCookie(Request, Response);

            Redirect.REDIRECT_LOGIN(Response);
        }
    }
}