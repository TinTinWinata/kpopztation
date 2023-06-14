using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Backend.Facade
{
    public class Json
    {
        public static string Encode(object Data)
        {
            return JsonConvert.SerializeObject(Data, Formatting.None, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
        }

        public static T Decode<T>(string String)
        {
            return JsonConvert.DeserializeObject<T>(String);
        }
    }
}