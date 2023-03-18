using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace KpopZtation.Backend.Facade
{
    public class File
    {  

        private static string ASSET_PATH = "~/Assets/";

        public static string SaveFile(FileUpload FileImage, HttpServerUtility Server)
        {
            string ImagePath = ASSET_PATH + FileImage.FileName;
            FileImage.SaveAs(Server.MapPath(ImagePath));

            // Remove Tilda (~) When Saving To The Database
            return ImagePath.Substring(1);
        }
    }
}