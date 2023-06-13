using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KpopZtation.Backend.Controller;
using KpopZtation.Backend.Service;
using KpopZtation.Frontend.Facade;

namespace KpopZtation.Frontend.View.Guest
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (AuthSession.GetUser(Session) != null || Cookie.GetCookie(Request) != null) Redirect.REDIRECT_HOME(Response);
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            string Gender = GenderInputRadioButtonList.SelectedValue;
            string Address = AddressInput.Text;
            string Password = PasswordInput.Text;
            string Name = NameInput.Text;
            string Email = EmailInput.Text;

            String Result = Service.WSRegister(Name, Email, Gender, Address, Password);
            Data<Customer> BackendData = Json.Decode<Data<Customer>>(Result);

            if (BackendData.Succeed)
            {
                // !Redirect to home
                Redirect.REDIRECT_LOGIN(Response);
            }
            else
            {
                ErrorLabel.Text = BackendData.Message;
            }
        }
    }
}