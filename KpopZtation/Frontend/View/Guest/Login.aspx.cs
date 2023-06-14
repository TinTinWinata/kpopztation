using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KpopZtation.Frontend.Facade;
using KpopZtation.Backend.Service;

namespace KpopZtation.Frontend.View.Guest
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (AuthSession.GetUser(Session) != null || Cookie.GetCookie(Request) != null) Redirect.REDIRECT_HOME(Response);
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            string Email = emailInput.Text;
            string Password = passwordInput.Text;
            bool rememberMeValue = RememberMeCheckbox.Checked;

            string Result = Service.WSLogin(Email, Password);
            Data<Customer> BackendData = Json.Decode<Data<Customer>>(Result);

            if (BackendData.Succeed)
            {
                // Set auth session
                AuthSession.SetUser(Session, BackendData.Object);
                if (rememberMeValue) Cookie.SetCookie(Response, BackendData.Object.CustomerID); // set cookie
                else if (!rememberMeValue && Cookie.GetCookie(Request) != null) Cookie.DeleteCookie(Request, Response);

                // Redirect to Home
                Redirect.REDIRECT_HOME(Response);
            }
            else
            {
                ErrorLabel.Text = BackendData.Message;
            }
        }
    }
}