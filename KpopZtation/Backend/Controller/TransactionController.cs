using KpopZtation.Backend.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Backend.Controller
{
    public class TransactionController
    {
        public static List<TransactionHeader> GetTransactionByCustomerId(int CustomerID)
        {
            return TransactionHandler.GetTransactionHeaderByCustomerId(CustomerID);
        }
    }
}