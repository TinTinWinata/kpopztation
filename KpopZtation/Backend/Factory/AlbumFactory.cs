using KpopZtation.Backend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Backend.Factory
{
    public class AlbumFactory
    {
        public static Album Create (int ArtistId, string Name, string Description, string Price, string Stock , string ImagePath)
        {
            Entities db = Database.GetInstance();

            Album Object = new Album();

            Object.ArtistID = ArtistId;
            Object.AlbumName = Name;
            Object.AlbumDescription = Description;
            Object.AlbumPrice = Int32.Parse(Price);
            Object.AlbumStock = Int32.Parse(Stock);
            Object.AlbumImage = ImagePath;
            db.Albums.Add(Object);

            Database.SecureSave();
            return Object;
        }
    }
}