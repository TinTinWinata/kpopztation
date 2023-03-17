using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Frontend.Facade
{
    public class Json
    {
        public static string Encode(object Data)
        {
            return JsonConvert.SerializeObject(Data);
        }

        public static T Decode<T>(string String)
        {
            return JsonConvert.DeserializeObject<T>(String);
        }
    }
}