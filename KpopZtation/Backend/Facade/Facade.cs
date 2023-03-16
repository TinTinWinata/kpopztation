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
            return Text.All(char.IsLetterOrDigit);
        }
    }
}