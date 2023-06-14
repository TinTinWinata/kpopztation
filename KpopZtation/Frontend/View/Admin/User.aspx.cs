using KpopZtation.Backend.Service;
using KpopZtation.Frontend.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.Frontend.View.Admin
{
    public partial class User : System.Web.UI.Page
    {
        public List<Customer> UserList;

        private void FetchCustomer()
        {
            string Result = CustomerService.WSGetCustomers();
            Data<List<Customer>> BackendData = Json.Decode<Data<List<Customer>>>(Result);
            if (BackendData.Succeed)
            {
                UserList = BackendData.Object;
                UserRepeater.DataSource = UserList;
                UserRepeater.DataBind();
            }
        }

        public void HandleDeleteBtn(object sender, EventArgs e)
        {
            string ID = ((LinkButton)sender).CommandArgument.ToString();
            string Result = CustomerService.WsDeleteCustomer(ID);
            Data<Customer> BackendData = Json.Decode<Data<Customer>>(Result);
            if (BackendData.Succeed)
            {
                FetchCustomer();
            }
            else
            {
                ErrorLabel.Text = BackendData.Message;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Middleware.CheckPath(Session, Response);
            if (Page.IsPostBack == false)
            {
                FetchCustomer();
            }
        }
    }
}