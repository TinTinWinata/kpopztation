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
            foreach (char c in Text)
            {
                if (!Char.IsLetterOrDigit(c))
                {
                    System.Diagnostics.Debug.WriteLine("[NOT ALPHANUMERIC] : " + c);
                    return false;
                }
            }
            return true;
        }
    }
}