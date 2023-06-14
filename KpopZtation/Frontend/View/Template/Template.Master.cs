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

        protected void HideAllNav()
        {
            ProfileButton.Visible = false;
            UserButton.Visible = false;
            TransactionButton.Visible = false;
            LoginButton.Visible = false;
            RegisterButton.Visible = false;
        }

        protected void CheckUser()
        {
            if (AuthSession.IsLoggedIn(Session))
            {
                Customer User = AuthSession.GetUser(Session);
                UsernameLabel.Text = User.CustomerName;
                if (User.CustomerRole == "Admin")
                {
                    ProfileButton.Visible = true;
                    UserButton.Visible = true;
                    TransactionButton.Visible = true;
                }
                else if (User.CustomerRole == "Customer")
                {
                    ProfileButton.Visible = true;
                }

            }
            else
            {
                LoginButton.Visible = true;
                RegisterButton.Visible = true;
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
            HideAllNav();
            CheckCookie();
            CheckUser();
            Middleware.CheckPath(Session, Response);
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

        protected void Profile_Click(object sender, EventArgs e)
        {
            Redirect.REDIRECT_PROFILE(Response);
        }

        protected void User_Click(object sender, EventArgs e)
        {
            Redirect.REDIRECT_USER(Response);
        }

        protected void TransactionBtn_Click(object sender, EventArgs e)
        {
            Redirect.REDIRECT_TRANSACTION_REPORT(Response);
        }
    }
}