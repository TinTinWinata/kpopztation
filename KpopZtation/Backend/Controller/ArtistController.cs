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

        public static Data<Artist> RemoveArtist(string ID)
        {
            try
            {
                int IntegerID = int.Parse(ID);
                Artist Object = ArtistHandler.Remove(IntegerID);
                return new Data<Artist>("Succesfully delete object", null, true);
            } catch(Exception error)
            {
                return new Data<Artist>(error.Message, null, false);
            }
        }

        public static Data<Artist> IsInputValid(string Username, FileUpload FileImage, string UpdateID)
        {
            string Error = "";

            Artist Object = ArtistHandler.FindByName(Username);

            if(Object != null && UpdateID != Object.ArtistID.ToString())
            {
                Error = "You must have unique username!";
            }else if (!Facade.Facade.CheckFileExtention(FileImage))
            {
                Error = "File extension is invalid!";
            }else if (!Facade.Facade.CheckFileSize(FileImage))
            {
                Error = "File size is invalid!";
            }

            if(Error == "")
            {
                return new Data<Artist>("Input Valid", null, true);
            }else
            {
                return new Data<Artist>(Error, null, false);
            }
        }

        public static Data<Artist> CreateArtist(string Username, FileUpload FileImage, HttpServerUtility Server)
        {
            Data<Artist> IsValid= IsInputValid(Username, FileImage, "");
            if (!IsValid.Succeed)
            {
                return IsValid;
            }

            string ImagePath = File.SaveFile(FileImage, Server);

            Artist Object = ArtistHandler.Create(Username, ImagePath);

            return new Data<Artist>("Succesfully Create Artist!", Object, true);
        }

        public static Data<Artist> UpdateArtist(string ID, string Username, FileUpload FileImage, HttpServerUtility Server)
        {
            try
            {
                Data<Artist> IsValid = IsInputValid(Username, FileImage, ID);
                if (!IsValid.Succeed)
                {
                    return IsValid;
                }

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