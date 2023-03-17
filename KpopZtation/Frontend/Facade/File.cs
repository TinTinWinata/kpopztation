using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace KpopZtation.Frontend.Facade
{
    public class File
    {
        public static void SaveFile(FileUpload File)
        {

            string ImagePath = Redirect.ASSET_PATH + FileImage.FileName;
            FileImage.SaveAs(Server.MapPath(ImagePath));
        }
    }
}