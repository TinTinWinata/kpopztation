using KpopZtation.Backend.Controller;
using KpopZtation.Backend.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Backend.Service
{
    public class TransactionService
    {
        public static string WSGetTransactionByCustomerId(int CustomerID)
        {
            return Json.Encode(TransactionController.GetTransactionByCustomerId(CustomerID));
        }
        public static string WSGetAllTransaction()
        {
            return Json.Encode(TransactionController.GetAllTransaction());
        }
    }
}