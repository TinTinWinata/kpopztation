using KpopZtation.Backend.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Backend.Repository
{
    public class CartRepository
    {
        private static Entities db = Database.GetInstance();

        public static Cart Create(int CustomerId, int AlbumId, int quantity)
        {
            return CartFactory.Create(CustomerId, AlbumId, quantity);
        }

        public static List<Cart> GetCartsByCustomerId(int CustomerId)
        {
            return (from carts in db.Carts where carts.CustomerID == CustomerId select carts).ToList<Cart>();
        }

        public static Cart GetCartsByCustomerIdAndAlbumId(int CustomerID, int AlbumID)
        {
            return (from carts in db.Carts where carts.CustomerID == CustomerID && carts.AlbumID == AlbumID select carts).FirstOrDefault();
        }

        public static Cart Update(int CustomerID, int AlbumID, int Quantity)
        {
            Cart Object = GetCartsByCustomerIdAndAlbumId(CustomerID, AlbumID);
            Object.Qty += Quantity;
            db.SaveChanges();
            return Object;
        }

        public static List<Cart> Checkout(int CustomerID)
        {
            List<Cart> CartsByCustomerId = GetCartsByCustomerId(CustomerID);

            for(int i = 0; i < CartsByCustomerId.Count; i++)
            {
                Cart CurrentCart = CartsByCustomerId[i];

                // insert into transaction header
                TransactionRepository.CreateTransactionHeader(DateTime.Now, CurrentCart.CustomerID);

                // get last transaction id
                int LastTransactionID = TransactionRepository.GetLastTransaction().TransactionID;

                // insert into transaction detail
                TransactionRepository.CreateTransactionDetail(LastTransactionID, CurrentCart.AlbumID, (int) CurrentCart.Qty);

                // decrease album stock
                AlbumRepository.UpdateStock(CurrentCart.AlbumID, (int) CurrentCart.Qty);

                // delete from cart
                Remove(CurrentCart.CustomerID, CurrentCart.AlbumID);
            }

            return CartsByCustomerId;
        }
            
        public static Cart Remove(int CustomerID, int AlbumID)
        {
            Cart Object = db.Carts.FirstOrDefault(c => c.CustomerID == CustomerID && c.AlbumID == AlbumID);
            db.Carts.Remove(Object);
            db.SaveChanges();
            return Object;
        }
    }
}