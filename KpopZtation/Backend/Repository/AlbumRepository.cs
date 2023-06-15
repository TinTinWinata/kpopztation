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

        public static Album Update(int AlbumId, string Name, string Description, string Price, string Stock, string ImagePath)
        {
            Album Object = db.Albums.Find(AlbumId);
            Object.AlbumName = Name;
            Object.AlbumDescription = Description;
            Object.AlbumPrice = int.Parse(Price);
            Object.AlbumStock = int.Parse(Stock);
            Object.AlbumImage = ImagePath;
            db.SaveChanges();
            return Object;
        }

        public static Album UpdateStock(int AlbumId, int Quantity)
        {
            Album Object = db.Albums.Find(AlbumId);
            Object.AlbumStock -= Quantity;
            db.SaveChanges();
            return Object;
        }

        public static Album FindById(int id)
        {
            return (from albums in db.Albums where albums.AlbumID == id select albums).FirstOrDefault();
        }

        public static List<Album> GetAlbumsByArtistId(int id)
        {
            return (from albums in db.Albums where albums.ArtistID == id select albums).ToList();
        }

        public static Album Remove(int ID)
        {
            Album Object = db.Albums.Find(ID);
            db.Albums.Remove(Object);
            db.SaveChanges();
            return Object;
        }

        //public static Album DeleteByArtistID(int ID)
        //{

        //}

        public static Album Create(int ArtistId, string Name, string Description, string Price, string Stock, string ImagePath)
        {
            return AlbumFactory.Create(ArtistId, Name, Description, Price, Stock, ImagePath);
        }

    }
}