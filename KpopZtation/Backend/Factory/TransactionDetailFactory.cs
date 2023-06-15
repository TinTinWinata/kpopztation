using KpopZtation.Backend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Backend.Factory
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail Create(int TransactionID, int AlbumID, int Quantity)
        {
            Entities db = Database.GetInstance();

            TransactionDetail Object = new TransactionDetail();

            Object.TransactionID = TransactionID;
            Object.AlbumID = AlbumID;
            Object.Qty = Quantity;
            db.TransactionDetails.Add(Object);

            Database.SecureSave();
            return Object;
        }
    }
}