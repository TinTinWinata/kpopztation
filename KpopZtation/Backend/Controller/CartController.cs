using KpopZtation.Backend.Facade;
using KpopZtation.Backend.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Backend.Controller
{
    public class CartController
    {
        public static List<Cart> GetCartsByCustomerId(int CustomerId)
        {
            return CartHandler.GetCartsByCustomerId(CustomerId);

        }
        public static Data<Cart> RemoveCart(int CustomerID, string AlbumID)
        {
            try
            {
                int IntegerAlbumID = int.Parse(AlbumID);
                Cart Object = CartHandler.Remove(CustomerID, IntegerAlbumID);
                return new Data<Cart>("Succesfully delete object", null, true);
            }
            catch (Exception error)
            {
                return new Data<Cart>(error.Message, null, false);
            }
        }

        public static Data<Cart> CreateCart(int CustomerId, string AlbumId, string Quantity)
        {
            string Error = string.Empty;

            if (string.IsNullOrEmpty(Quantity))
            {
                Error = "Quantity Name is empty!";
            }
            else if (Facade.Facade.CheckValidNumber(Quantity) == false)
            {
                Error = "Invalid Quantity Input";
            }
            else
            {
                int AlbumIdInt = int.Parse(AlbumId);
                int QuantityInt = int.Parse(Quantity);
                Album album = AlbumHandler.FindById(AlbumIdInt);

                if (QuantityInt > album.AlbumStock)
                {
                    Error = "Quantity value must be less than or equal to the stock album";
                }else if(QuantityInt == 0)
                {
                    Error = "Quantity value must be more than 0";
                }

                if (Error != string.Empty)
                {
                    return new Data<Cart>(Error, null, false);
                }

                // find if there is already a cart data
                Cart cart = CartHandler.GetCartsByCustomerIdAndAlbumId(CustomerId, AlbumIdInt);
                Cart Object;
                if(cart != null)
                {
                    // update cart quantity
                    Object = CartHandler.Update(CustomerId, AlbumIdInt, QuantityInt);
                }
                else
                {
                    // create a cart
                    Object = CartHandler.Create(CustomerId, AlbumIdInt, QuantityInt);
                }

                if (Object == null)
                {
                    return new Data<Cart>("Cart failed to create / update", null, false);
                }

                // Decrease stock of albums
                AlbumHandler.UpdateStock(AlbumIdInt, QuantityInt);

                return new Data<Cart>("Succesfully Create Cart / update", Object, true);
            }

            return new Data<Cart>(Error, null, false);
        }
    }
}