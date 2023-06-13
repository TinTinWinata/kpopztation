using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
    }
}