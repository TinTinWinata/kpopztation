using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KpopZtation.Backend.Controller;
using KpopZtation.Backend.Facade;
using KpopZtation.Frontend.Facade;

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

            Data<Customer> BackendData = AuthController.Login(Email, Password);


            AuthSession.SetUser(Session, BackendData.Object);
            //Session[]
        }
    }
}