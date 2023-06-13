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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            string Result = Service.WSCreateArtist(NameInput.Text, FileImage, Server);
            Data<Artist> BackendData = Json.Decode<Data<Artist>>(Result);
            ErrorLabel.Text = BackendData.Message;
        }

    }
}