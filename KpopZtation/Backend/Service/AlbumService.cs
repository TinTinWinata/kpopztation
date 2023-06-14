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

        public static string WSGetAlbums()
        {
            return Json.Encode(AlbumController.GetAlbums());
        }
    }
}