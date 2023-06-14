using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace KpopZtation.Backend.Facade
{
    public class Facade
    {
        public static bool CheckAlphanumeric(string Text)
        {
            bool checkDigit = false;
            bool checkLetter = false;

            foreach (char c in Text)
            {
                if (c >= '0' && c <= '9') checkDigit = true;
                else if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z')) checkLetter = true;
                
                if (checkLetter && checkDigit) return true;
            }
            return false;
        }

        public static bool CheckFileExtention(FileUpload fileUpload)
        {
            string fileExtension = Path.GetExtension(fileUpload.FileName).ToLower();
            string[] allowedExtensions = { ".png", ".jpg", ".jpeg", ".jfif" };

            if (!allowedExtensions.Contains(fileExtension)) return false;
            else return true;
            
        }

        public static bool CheckFileSize(FileUpload fileUpload)
        {
            if (fileUpload.PostedFile.ContentLength >= 2 * 1024 * 1024) return false;
            else return true;
        }

        public static bool CheckValidNumber(string s)
        {
            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] < '0' || s[i] > '9') return false;
            }

            return true;
        }
    }
}