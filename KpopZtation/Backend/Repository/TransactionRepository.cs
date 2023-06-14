using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Backend.Repository
{
    public class TransactionRepository
    {
        private static Entities db = Database.GetInstance();
        public static List<TransactionHeader> GetAllTransaction()
        {
            return (from transactions in db.TransactionHeaders select transactions).ToList<TransactionHeader>();  
        }
    }
}