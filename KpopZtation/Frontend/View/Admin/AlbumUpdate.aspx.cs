using KpopZtation.Frontend.Facade;
using KpopZtation.Backend.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.Frontend.View.Admin
{
    public partial class AlbumUpdate : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                FetchAlbum();
            }
        }

        public void FetchAlbum()
        {
            string ID = Request.QueryString["id"];
            string Result = AlbumService.WSGetAlbumsById(ID);
            Data<Album> BackendData = Json.Decode<Data<Album>>(Result);
            if (BackendData.Succeed)
            {
                AlbumNameUpdate.Text = BackendData.Object.AlbumName;
                AlbumDescriptionUpdate.Text = BackendData.Object.AlbumDescription;
                AlbumPriceUpdate.Text = BackendData.Object.AlbumPrice.ToString();
                AlbumStockUpdate.Text = BackendData.Object.AlbumStock.ToString();
            }
            else
            {
                Redirect.REDIRECT_HOME(Response);
            }
        }
        public void UpdateAlbum_Click(object sender, EventArgs e)
        {

            // get album id from url
            int albumId = Int32.Parse(Request.QueryString["id"]);

            // Get Data
            string albumName = AlbumNameUpdate.Text;
            string albumDescription = AlbumDescriptionUpdate.Text;
            string albumPrice = AlbumPriceUpdate.Text;
            string albumStock = AlbumStockUpdate.Text;
            FileUpload albumImage = AlbumImageUpdate;

            // Create Album
            string Result = AlbumService.WSUpdateAlbum(albumId, albumName, albumDescription, albumPrice, albumStock, albumImage, Server);
            Data<Album> BackendData = Json.Decode<Data<Album>>(Result);

            if (BackendData.Succeed)
            {
                Redirect.REDIRECT_ARTIST_DETAIL(Response, BackendData.Object.ArtistID.ToString());
            }
            else
            {
                AlbumUpdateErrorLabel.Text = BackendData.Message;
            }
        }
    }
}