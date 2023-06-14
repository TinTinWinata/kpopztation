using KpopZtation.Backend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Backend.Handler
{
    public class AlbumHandler
    {
        public static Album Create(int ArtistId, string Name, string Description, string Price, string Stock, string ImagePath)
        {
            return AlbumRepository.Create(ArtistId, Name, Description, Price, Stock, ImagePath);
        }

        public static List<Album> GetAlbums()
        {
            return AlbumRepository.GetAlbums();
        }
    }
}