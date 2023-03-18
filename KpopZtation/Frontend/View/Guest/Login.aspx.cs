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

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            string Email = emailInput.Text;
            string Password = passwordInput.Text;

            string Result = Service.WSLogin(Email, Password);
            Data<Customer> BackendData = Json.Decode<Data<Customer>>(Result);


            if (BackendData.Succeed)
            {
                AuthSession.SetUser(Session, BackendData.Object);
                Redirect.REDIRECT_HOME(Response);
                // Redirect to Home
            }
            else
            {
                ErrorLabel.Text = BackendData.Message;                
            }
        }
    }
}