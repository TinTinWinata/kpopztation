using KpopZtation.Backend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Backend.Factory
{
    public class CartFactory
    {
        public static Cart Create(int CustomerId, int AlbumId, int quantity)
        {
            Entities db = Database.GetInstance();
            Cart Object = new Cart();
            Object.CustomerID = CustomerId;
            Object.AlbumID = AlbumId;
            Object.Qty = quantity;
            db.Carts.Add(Object);
            Database.SecureSave();

            return Object;
        }
    }
}