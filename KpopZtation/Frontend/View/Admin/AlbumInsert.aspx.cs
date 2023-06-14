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
    public partial class AlbumInsert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SubmitButton_Click(object sender, EventArgs e)
        {

            // get artist id from url
            int artisId = Int32.Parse(Request.QueryString["id"]);

            // Get Data
            string albumName = AlbumNameInput.Text;
            string albumDescription = AlbumDescriptionInput.Text;
            string albumPrice = AlbumPriceInput.Text;
            string albumStock = AlbumStockInput.Text;
            FileUpload albumImage = AlbumImageInput;

            // Create Album
            string Result = AlbumService.WSCreateAlbum(artisId, albumName, albumDescription, albumPrice, albumStock, albumImage, Server);
            Data<Album> BackendData = Json.Decode<Data<Album>>(Result);

            if (BackendData.Succeed)
            {
                Redirect.REDIRECT_HOME(Response);
            }
            else
            {
                ErrorLabel.Text = BackendData.Message;
            }
        }

    }
}