using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtation.Backend.Repository;

namespace KpopZtation.Backend.Handler
{
    public class ArtistHandler
    {
        public static List<Artist> GetArtists()
        {
            return ArtistRepository.GetArtists();
        }

        public static Artist Create(string Username, string ImagePath)
        {
            return ArtistRepository.Create(Username, ImagePath);
        }

        public static Artist FindById(int id)
        {
            return ArtistRepository.FindById(id);
        }
    }
}