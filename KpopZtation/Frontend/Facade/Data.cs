using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Frontend.Facade
{
    public class Data<T>
    {
        public T Object;
        public string Message;
        public bool Succeed;
        public Data(string Message, T Object, bool Succeed)
        {
            this.Object = Object;
            this.Message = Message;
            this.Succeed = Succeed;
        }

    }
}