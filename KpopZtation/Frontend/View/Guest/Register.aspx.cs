using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KpopZtation.Backend.Controller;
using KpopZtation.Backend.Facade;

namespace KpopZtation.Frontend.View.Guest
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            string Gender = GenderInput.Text;
            string Address = AddressInput.Text;
            string Password = PasswordInput.Text;
            string Name = NameInput.Text;
            string Email = EmailInput.Text;

            Data<Customer> BackendData = AuthController.Register(Name, Email, Gender, Address, Password);
            if (BackendData.Succeed)
            {
                // !Redirect to home
            }
            else
            {
                ErrorLabel.Text = BackendData.Message;
            }
        }
    }
}