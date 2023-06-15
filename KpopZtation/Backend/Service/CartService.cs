using KpopZtation.Backend.Controller;
using KpopZtation.Backend.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Backend.Service
{
    public class CartService
    {
        public static string WSAddToCart(int CustomerId, string AlbumId, string Quantity)
        {
            return Json.Encode(CartController.CreateCart(CustomerId, AlbumId, Quantity));
        }

        public static string WSGetCartsByCustomerId(int CustomerId)
        {
            return Json.Encode(CartController.GetCartsByCustomerId(CustomerId));
        }

        public static string WSRemoveCart(int CustomerID, string AlbumID)
        {
            return Json.Encode(CartController.RemoveCart(CustomerID, AlbumID));
        }

        public static string WSCheckoutCart(int CustomerID)
        {
            return Json.Encode(CartController.Checkout(CustomerID));
        }
    }
}