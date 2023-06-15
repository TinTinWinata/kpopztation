using KpopZtation.Backend.Facade;
using KpopZtation.Backend.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace KpopZtation.Backend.Controller
{
    public class AlbumController
    {
        public static List<Album> GetAlbums()
        {
            return AlbumHandler.GetAlbums();
        }

        public static List<Album> GetAlbumsByArtistId(string id)
        {
            int integerId = int.Parse(id);
            return AlbumHandler.GetAlbumsByArtistId(integerId);
        }

        public static Data<Album> RemoveArtist(string ID)
        {
            try
            {
                int IntegerID = int.Parse(ID);
                Album Object = AlbumHandler.Remove(IntegerID);
                return new Data<Album>("Succesfully delete object", null, true);
            }
            catch (Exception error)
            {
                return new Data<Album>(error.Message, null, false);
            }
        }

        public static Data<Album> FindById(string id)
        {
            try
            {
                int integerId = int.Parse(id);
                Album Object = AlbumHandler.FindById(integerId);
                return new Data<Album>("Succesfully Find Albums", Object, true);
            }
            catch (Exception err)
            {
                return new Data<Album>(err.Message, null, true);
            }
        }

        public static Data<Album> CreateAlbum(int ArtistId, string Name, string Description, string Price, string Stock, FileUpload FileImage, HttpServerUtility Server)
        {
            string Error = string.Empty;

            if (string.IsNullOrEmpty(Name))
            {
                Error = "Album Name is empty!";
            } else if (string.IsNullOrEmpty(Description))
            {
                Error = "Album Description is empty!";
            } else if (string.IsNullOrEmpty(Price))
            {
                Error = "Album Price is empty!";
            } else if (Facade.Facade.CheckValidNumber(Price) == false) {
                Error = "Invalid Album Price Input";
            } else if (string.IsNullOrEmpty(Stock))
            {
                Error = "Album Stock is empty!";
            }else if(Facade.Facade.CheckValidNumber(Stock) == false)
            {
                Error = "Invalid Album Stock Input";
            }
            else if (FileImage.HasFile == false)
            {
                Error = "Album File must be choosen";
            } else if (Name.Length >= 50)
            {
                Error = "Album Name must be smaller than 50 characters";
            } else if (Description.Length >= 255)
            {
                Error = "Album Description must be smaller than 255 characters";
            } else if (Int32.Parse(Price) < 100000 || Int32.Parse(Price) > 1000000)
            {
                Error = "Album Price must be between 100000 and 1000000";
            } else if (Int32.Parse(Stock) <= 0)
            {
                Error = "Album Stock must be more than 0";
            } else if (Facade.Facade.CheckFileExtention(FileImage) == false)
            {
                Error = "Album File extension must be .png, .jpg, .jpeg, or .jfif";
            } else if (Facade.Facade.CheckFileSize(FileImage) == false)
            {
                Error = "Album File size must be lower than 2MB";
            }

            if (Error != string.Empty)
            {
                return new Data<Album>(Error, null, false);
            }

            string ImagePath = File.SaveFile(FileImage, Server);

            Album Object = AlbumHandler.Create(ArtistId, Name, Description, Price, Stock, ImagePath);

            if (Object == null)
            {
                return new Data<Album>("Album failed to create!", null, false);
            }

            return new Data<Album>("Succesfully Create Album!", Object, true);
        }

        public static Data<Album> UpdateAlbum(int AlbumId, string Name, string Description, string Price, string Stock, FileUpload FileImage, HttpServerUtility Server)
        {
            string Error = string.Empty;

            if (string.IsNullOrEmpty(Name))
            {
                Error = "Album Name is empty!";
            }
            else if (string.IsNullOrEmpty(Description))
            {
                Error = "Album Description is empty!";
            }
            else if (string.IsNullOrEmpty(Price))
            {
                Error = "Album Price is empty!";
            }
            else if (Facade.Facade.CheckValidNumber(Price) == false)
            {
                Error = "Invalid Album Price Input";
            }
            else if (string.IsNullOrEmpty(Stock))
            {
                Error = "Album Stock is empty!";
            }
            else if (Facade.Facade.CheckValidNumber(Stock) == false)
            {
                Error = "Invalid Album Stock Input";
            }
            else if (FileImage.HasFile == false)
            {
                Error = "Album File must be choosen";
            }
            else if (Name.Length >= 50)
            {
                Error = "Album Name must be smaller than 50 characters";
            }
            else if (Description.Length >= 255)
            {
                Error = "Album Description must be smaller than 255 characters";
            }
            else if (Int32.Parse(Price) < 100000 || Int32.Parse(Price) > 1000000)
            {
                Error = "Album Price must be between 100000 and 1000000";
            }
            else if (Int32.Parse(Stock) <= 0)
            {
                Error = "Album Stock must be more than 0";
            }
            else if (Facade.Facade.CheckFileExtention(FileImage) == false)
            {
                Error = "Album File extension must be .png, .jpg, .jpeg, or .jfif";
            }
            else if (Facade.Facade.CheckFileSize(FileImage) == false)
            {
                Error = "Album File size must be lower than 2MB";
            }

            if (Error != string.Empty)
            {
                return new Data<Album>(Error, null, false);
            }

            string ImagePath = File.SaveFile(FileImage, Server);

            Album Object = AlbumHandler.Update(AlbumId, Name, Description, Price, Stock, ImagePath);

            if (Object == null)
            {
                return new Data<Album>("Album failed to update!", null, false);
            }

            return new Data<Album>("Succesfully Update Album!", Object, true);
        }
    }
}