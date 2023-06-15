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
    public partial class TransactionHistoryPage : System.Web.UI.Page
    {
        public List<TransactionHeader> TransactionHistoryLists;
        protected void Page_Load(object sender, EventArgs e)
        {
            FetchTransactionHistory();
        }

        private void FetchTransactionHistory()
        {
            int CustomerID = AuthSession.GetUser(Session).CustomerID;
            string Result = TransactionService.WSGetTransactionByCustomerId(CustomerID);
            TransactionHistoryLists = Json.Decode<List<TransactionHeader>>(Result);
            /*TransactionHistoryRepeater.DataSource = TransactionHistoryLists;
            TransactionHistoryRepeater.DataBind();*/
        }
    }
}