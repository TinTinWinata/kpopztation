using KpopZtation.Backend.Service;
using KpopZtation.Frontend.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.Frontend.View.Client
{
    public partial class Profile : System.Web.UI.Page
    {

        public Customer Customer;

        private void FetchCustomer()
        {
            Customer = AuthSession.GetUser(Session);
            System.Diagnostics.Debug.WriteLine("\nCustomer : ", Customer.CustomerID.ToString());

            AddressInput.Text = Customer.CustomerAddress;
            PasswordInput.Text = Customer.CustomerPassword;
            ProfileEmailInput.Text = Customer.CustomerEmail;
            ProfileNameInput.Text = Customer.CustomerName;
            if (Customer.CustomerGender == "Female")
            {
                FemaleListItem.Selected = true;
            }
            else
            {
                MaleListItem.Selected = true;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) FetchCustomer();
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            Customer = AuthSession.GetUser(Session);
            string ID = Customer.CustomerID.ToString();
            string Result = CustomerService.WSUpdateCustomer(ID, ProfileNameInput.Text, ProfileEmailInput.Text, GenderInputRadioButtonList.SelectedValue, AddressInput.Text, PasswordInput.Text);
            Data<Customer> BackendData = Json.Decode<Data<Customer>>(Result);
            ErrorLabel.Text = BackendData.Message;
        }
    }
}