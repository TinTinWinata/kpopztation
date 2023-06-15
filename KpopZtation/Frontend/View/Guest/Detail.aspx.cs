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
        List<Album> AlbumList;

        protected void Page_Load(object sender, EventArgs e)
        {
            FetchArtist();
            FetchAlbums();
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

        private void FetchAlbums()
        {
            string ID = Request.QueryString["id"];
            string Result = AlbumService.WSGetAlbumsByArtistsId(ID);
            AlbumList = Json.Decode<List<Album>>(Result);
            AlbumRepeater.DataSource = AlbumList;
            AlbumRepeater.DataBind();
        }

        public void InsertAlbumButton_Click(object sender, EventArgs e)
        {
            string ID = Request.QueryString["id"];
            Redirect.REDIRECT_INSERT_ALBUM(Response, ID);
        }

        public void DeleteAlbumButton_Click(object sender, EventArgs e)
        {
            string ID = ((LinkButton)sender).CommandArgument.ToString();
            string Result = AlbumService.WSRemoveAlbum(ID);
            Data<Artist> BackendData = Json.Decode<Data<Artist>>(Result);
            if (BackendData.Succeed)
            {
                FetchAlbums();
            }
        }
    }
}