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

        public Artist Artist;

        protected void Page_Load(object sender, EventArgs e)
        {
            FetchArtist();
        }

        private void FetchArtist()
        {
            string ID = Request.QueryString["id"];
            string Result = Service.WSGetArtistByID(ID);
            Data<Artist> BackendData = Json.Decode<Data<Artist>>(Result);
            if (BackendData.Succeed)
            {
                Artist = BackendData.Object;
            }
            else
            {
                Redirect.REDIRECT_HOME(Response);
            }
        }
    }
}