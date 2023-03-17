using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using KpopZtation.Backend.Service;
using KpopZtation.Frontend.Facade;

namespace KpopZtation.Frontend.View.Guest
{
    public partial class Home : System.Web.UI.Page
    {
        public List<Artist> ArtistList = new List<Artist>();

        private void FetchArtist()
        {
            string Result = Service.WSGetArtists();
            ArtistList =  Json.Decode<List<Artist>>(Result);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            FetchArtist();
        }
    }
}