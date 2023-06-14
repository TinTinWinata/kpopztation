using KpopZtation.Backend.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Backend.Repository
{
    public class AlbumRepository
    {
        private static Entities db = Database.GetInstance();
        public static List<Album> GetAlbums()
        {
            return (from albums in db.Albums select albums).ToList<Album>();
        }

        public static Album FindById(int id)
        {
            return (from albums in db.Albums where albums.ArtistID == id select albums).FirstOrDefault();
        }

        public static Album Create(int ArtistId, string Name, string Description, string Price, string Stock, string ImagePath)
        {
            return AlbumFactory.Create(ArtistId, Name, Description, Price, Stock, ImagePath);
        }
    }
}