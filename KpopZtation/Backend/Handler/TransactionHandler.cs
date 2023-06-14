using KpopZtation.Backend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Backend.Handler
{
    public class TransactionHandler
    {
        public static List<TransactionHeader> GetAllTransaction()
        {
            return TransactionRepository.GetAllTransaction();
        }
    }
}