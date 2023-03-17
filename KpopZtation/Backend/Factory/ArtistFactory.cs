using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using KpopZtation.Backend.Repository;

namespace KpopZtation.Backend.Factory
{
    public class ArtistFactory
    {
        public static Artist Create(string Name, string ImagePath)
        {
            Entities db = Database.GetInstance();
            Artist Object = new Artist();
            Object.ArtistName = Name;
            Object.ArtistImage = ImagePath;
            db.Artists.Add(Object);
            Database.SecureSave();

            return Object;
        }
    }
}