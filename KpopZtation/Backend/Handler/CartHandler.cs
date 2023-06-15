using KpopZtation.Backend.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Backend.Handler
{
    public class CartHandler
    {
        public static Cart Create(int CustomerId, int AlbumId, int quantity)
        {
            return CartRepository.Create(CustomerId, AlbumId, quantity);
        }

        public static Cart Update(int CustomerId, int AlbumId, int quantity)
        {
            return CartRepository.Update(CustomerId, AlbumId, quantity);
        }

        public static List<Cart> GetCartsByCustomerId(int CustomerId)
        {
            return CartRepository.GetCartsByCustomerId(CustomerId);
        }

        public static Cart GetCartsByCustomerIdAndAlbumId(int CustomerID, int AlbumID)
        {
            return CartRepository.GetCartsByCustomerIdAndAlbumId(CustomerID, AlbumID);
        }

        public static Cart Checkout(int CustomerID, int AlbumID, int Quantity)
        {
            return CartRepository.Checkout(CustomerID, AlbumID, Quantity);
        }

        public static Cart Remove(int CustomerID, int AlbumID)
        {
            return CartRepository.Remove(CustomerID, AlbumID);
        }
    }
}