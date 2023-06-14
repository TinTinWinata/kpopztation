using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtation.Backend.Handler;
using KpopZtation.Backend.Facade;
using System.Web.UI.WebControls;

namespace KpopZtation.Backend.Controller
{

    public class ArtistController
    {
        public static List<Artist> GetArtists()
        {
            return ArtistHandler.GetArtists();
        }

        //public static Data<Artist> IsValidInput(string Username, FileUpload FileImage, HttpServerUtility Server)
        //{
            // To Do Make
        //}  

        public static Data<Artist> CreateArtist(string Username, FileUpload FileImage, HttpServerUtility Server)
        {
            string ImagePath = File.SaveFile(FileImage, Server);

            Artist Object = ArtistHandler.Create(Username, ImagePath);

            return new Data<Artist>("Succesfully Create Artist!", Object, true);
        }

        public static Data<Artist> UpdateArtist(string ID, string Username, FileUpload FileImage, HttpServerUtility Server)
        {
            try
            {
                string ImagePath = File.SaveFile(FileImage, Server);
                int IntegerID = int.Parse(ID);
                Artist Object = ArtistHandler.Update(IntegerID, Username, ImagePath);
                return new Data<Artist>("Succesfully Create Artist!", Object, true);
            }
            catch (Exception error)
            {
                return new Data<Artist>(error.Message, null, false);
            }
        }

        public static Data<Artist> FindById(string id)
        {
            try
            {
                int integerId = int.Parse(id);
                Artist Object = ArtistHandler.FindById(integerId);
                return new Data<Artist>("Succesfully Create Artist", Object, true);
            }
            catch (Exception err)
            {
                return new Data<Artist>(err.Message, null, true);
            }
        }
    }
}