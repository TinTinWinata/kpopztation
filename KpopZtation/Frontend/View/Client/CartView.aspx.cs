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
    public partial class CartView : System.Web.UI.Page
    {
        List<Cart> CartList;
        protected void Page_Load(object sender, EventArgs e)
        {
            FetchCart();
        }
        private void FetchCart()
        {
            int ID = AuthSession.GetUser(Session).CustomerID;
            string Result = CartService.WSGetCartsByCustomerId(ID);
            CartList = Json.Decode<List<Cart>>(Result);
            CartRepeater.DataSource = CartList;
            CartRepeater.DataBind();
        }

        public void DeleteCartButton_Click(object sender, EventArgs e)
        {
            int CustomerID = AuthSession.GetUser(Session).CustomerID;
            string AlbumID = ((LinkButton)sender).CommandArgument.ToString();
            string Result = CartService.WSRemoveCart(CustomerID, AlbumID);
            Data<Cart> BackendData = Json.Decode<Data<Cart>>(Result);
            if (BackendData.Succeed)
            {
                FetchCart();
            }
        }
    }
}