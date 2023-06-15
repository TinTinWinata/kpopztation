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

        public static Album Update(int AlbumId, string Name, string Description, string Price, string Stock, string ImagePath)
        {
            return AlbumRepository.Update(AlbumId, Name, Description, Price, Stock, ImagePath);
        }

        public static Album UpdateStock(int AlbumId, int Quantity)
        {
            return AlbumRepository.UpdateStock(AlbumId, Quantity);
        }

        public static List<Album> GetAlbums()
        {
            return AlbumRepository.GetAlbums();
        }

        public static Album Remove(int ID)
        {
            return AlbumRepository.Remove(ID);
        }


        public static Album FindById(int id)
        {
            return AlbumRepository.FindById(id);
        }

        public static List<Album> GetAlbumsByArtistId(int id)
        {
            return AlbumRepository.GetAlbumsByArtistId(id);
        }
    }
}