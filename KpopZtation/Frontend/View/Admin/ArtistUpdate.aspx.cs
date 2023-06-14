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
    public partial class ArtistUpdate : System.Web.UI.Page
    {
        public Artist Artist;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) FetchArtist();
        }

        private void FetchArtist()
        {
            string ID = Request.QueryString["id"];
            string Result = Service.WSGetArtistByID(ID);
            Data<Artist> Object = Json.Decode<Data<Artist>>(Result);
            if (Object.Succeed)
            {
                Artist = Object.Object;
            }
            else
            {
                Redirect.REDIRECT_HOME(Response);
            }
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            string ID = Request.QueryString["id"];
            string Result = Service.WSUpdateArtist(ID, NameInput.Text, FileImage, Server);
            Data<Artist> BackendData = Json.Decode<Data<Artist>>(Result);
            ErrorLabel.Text = BackendData.Message;
        }
    }
}