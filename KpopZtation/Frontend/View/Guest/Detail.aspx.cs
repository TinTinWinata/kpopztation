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
    public partial class Detail : System.Web.UI.Page
    {

        Artist Artist;

        protected void Page_Load(object sender, EventArgs e)
        {
            FetchArtist();
        }

        private void FetchArtist()
        {
            string id = Request.QueryString["id"];
            string Result = Service.WSGetArtistByID(id);
            Artist = Json.Decode<Artist>(Result);
        }
    }
}