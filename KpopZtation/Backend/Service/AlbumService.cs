using KpopZtation.Backend.Controller;
using KpopZtation.Backend.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace KpopZtation.Backend.Service
{
    public class AlbumService
    {
        public static string WSCreateAlbum(int ArtistId, string Name, string Description, string Price, string Stock, FileUpload FileImage, HttpServerUtility Server)
        {
            return Json.Encode(AlbumController.CreateAlbum(ArtistId, Name, Description, Price, Stock, FileImage, Server));
        }

        public static string WSUpdateAlbum(int AlbumId, string Name, string Description, string Price, string Stock, FileUpload FileImage, HttpServerUtility Server)
        {
            return Json.Encode(AlbumController.UpdateAlbum(AlbumId, Name, Description, Price, Stock, FileImage, Server));
        }

        public static string WSGetAlbums()
        {
            return Json.Encode(AlbumController.GetAlbums());
        }

        public static string WSGetAlbumsById(string id)
        {
            return Json.Encode(AlbumController.FindById(id));
        }

        public static string WSGetAlbumsByArtistsId(string id)
        {
            return Json.Encode(AlbumController.GetAlbumsByArtistId(id));
        }
        public static string WSRemoveAlbum(string ID)
        {
            return Json.Encode(AlbumController.RemoveArtist(ID));
        }
    }
}