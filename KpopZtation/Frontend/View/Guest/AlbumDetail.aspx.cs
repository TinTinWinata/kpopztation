using KpopZtation.Backend.Service;
using KpopZtation.Frontend.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.Frontend.View.Guest
{
    public partial class AlbumDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FetchAlbum();
                CheckRole();
            }
        }

        public void CheckRole()
        {
            if (AuthSession.IsLoggedIn(Session))
            {
                string role = AuthSession.GetUser(Session).CustomerRole;
                if (role == "Customer")
                {
                    AlbumQuantityLabel.Visible = true;
                    AlbumQuantityDetail.Visible = true;
                    AddToCart.Visible = true;
                }
            }

        }

        public void FetchAlbum()
        {
            string ID = Request.QueryString["id"];
            string Result = AlbumService.WSGetAlbumsById(ID);
            Data<Album> BackendData = Json.Decode<Data<Album>>(Result);
            if (BackendData.Succeed)
            {
                AlbumNameDetail.Text = BackendData.Object.AlbumName;
                AlbumDescriptionDetail.Text = BackendData.Object.AlbumDescription;
                AlbumPriceDetail.Text = BackendData.Object.AlbumPrice.ToString();
                AlbumStockDetail.Text = BackendData.Object.AlbumStock.ToString();
            }
            else
            {
                Redirect.REDIRECT_HOME(Response);
            }
        }

        public void AddToCart_Click(object sender, EventArgs e)
        {
            // get album id from url
            string albumId = Request.QueryString["id"];

            // Get Data
            string quantity = AlbumQuantityDetail.Text;
            int customerId = AuthSession.GetUser(Session).CustomerID;

            // Create Album
            string Result = CartService.WSAddToCart(customerId, albumId, quantity);
            Data<Album> BackendData = Json.Decode<Data<Album>>(Result);

            if (BackendData.Succeed)
            {
                Redirect.REDIRECT_ARTIST_DETAIL(Response, BackendData.Object.ArtistID.ToString());
            }
            else
            {
                AlbumDetailErrorLabel.Text = BackendData.Message;
            }
        }
    }
}