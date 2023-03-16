using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KpopZtation.Frontend.Facade;

namespace KpopZtation.Frontend.View.Template
{
    public partial class Template : System.Web.UI.MasterPage
    {


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void homeBtn_Click(object sender, EventArgs e)
        {
            Redirect.REDIRECT_HOME(Response);
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            Redirect.REDIRECT_REGISTER(Response);
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            Redirect.REDIRECT_LOGIN(Response); 
        }
    }
}