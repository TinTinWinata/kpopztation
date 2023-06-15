using KpopZtation.Backend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Backend.Factory
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader Create(DateTime TransactionDate, int CustomerID)
        {
            Entities db = Database.GetInstance();

            TransactionHeader Object = new TransactionHeader();
            Object.TransactionDate = TransactionDate;
            Object.CustomerID = CustomerID;
            db.TransactionHeaders.Add(Object);

            Database.SecureSave();
            return Object;
        }
    }
}