using KpopZtation.Backend.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Backend.Repository
{
    public class TransactionRepository
    {
        private static Entities db = Database.GetInstance();

        public static List<TransactionHeader> GetTransactionHeader()
        {
            return (from TransactionHeader in db.TransactionHeaders select TransactionHeader).ToList<TransactionHeader>();
        }

        public static List<TransactionHeader> GetTransactionHeaderByCustomerId(int CustomerID)
        {
            return (from TransactionHeader in db.TransactionHeaders where TransactionHeader.CustomerID == CustomerID select TransactionHeader).ToList<TransactionHeader>();
        }

        public static List<TransactionDetail> GetTransactionDetail()
        {
            return (from TransactionDetail in db.TransactionDetails select TransactionDetail).ToList<TransactionDetail>();
        }

        public static TransactionHeader GetLastTransaction()
        {
            return db.TransactionHeaders.OrderByDescending(th => th.TransactionID).FirstOrDefault();
        }

        public static TransactionHeader CreateTransactionHeader(DateTime TransactionDate, int CustomerID)
        {
            return TransactionHeaderFactory.Create(TransactionDate, CustomerID);
        }

        public static TransactionDetail CreateTransactionDetail(int TransactionID, int AlbumID, int Quantity)
        {
            return TransactionDetailFactory.Create(TransactionID, AlbumID, Quantity);
        }
        public static List<TransactionHeader> GetAllTransaction()
        {
            return (from transactions in db.TransactionHeaders select transactions).ToList<TransactionHeader>();  
        }
    }
}