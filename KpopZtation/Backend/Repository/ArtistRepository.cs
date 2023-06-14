using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtation.Backend.Factory;

namespace KpopZtation.Backend.Repository
{
    public class ArtistRepository
    {
        private static Entities db = Database.GetInstance();
        public static List<Artist> GetArtists()
        {
            return (from artists in db.Artists select artists).ToList<Artist>();
        }

        public static Artist FindById(int id)
        {
            return (from artist in db.Artists where artist.ArtistID == id select artist).FirstOrDefault();
        }

        public static Artist Create(string Username, string ImagePath)
        {
            return ArtistFactory.Create(Username, ImagePath);
        }

    }
}