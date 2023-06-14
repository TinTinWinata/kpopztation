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

        public void HandleClickItem(object sender, EventArgs e)
        {
            string ArtistID = ((LinkButton)sender).CommandArgument.ToString();
            Redirect.REDIRECT_ARTIST_DETAIL(Response, ArtistID);
        }

        private void FetchArtist()
        {
            string Result = Service.WSGetArtists();
            ArtistList = Json.Decode<List<Artist>>(Result);
            ArtistRepeater.DataSource = ArtistList;
            ArtistRepeater.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                FetchArtist();
            }
        }

        public void InsertButton_Click(object sender, EventArgs e)
        {
            Redirect.REDIRECT_INSERT_ARTIST(Response);
        }
    }
}