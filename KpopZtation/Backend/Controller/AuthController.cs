using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using KpopZtation.Backend.Handler;
using KpopZtation.Backend.Facade;

namespace KpopZtation.Backend.Controller
{
    public class AuthController
    {
        public static Data<Customer> Login(string Email, string Password) {
            Customer Object = CustomerHandler.FindByEmail(Email);
            if(Object != null && Object.CustomerPassword == Password)
            {
                return new Data<Customer>("Succesfully Login!", Object, true);
            }
            return new Data<Customer>("Wrong credentials or User not found!", Object, false);
        }

        public static bool IsExistEmail(string Email)
        {
            Customer customer = CustomerHandler.FindByEmail(Email);
            if(customer == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static Data<Customer> Register(string Name, string Email, string Gender, string Address, string Password)
        {
            string Error = string.Empty;

            if(string.IsNullOrEmpty(Name))
            {
                Error = "Name is empty!";
            }else if (string.IsNullOrEmpty(Email))
            {
                Error = "Email is empty!";
            }else if (string.IsNullOrEmpty(Gender))
            {
                Error = "Gender is empty!";
            }
            else if (string.IsNullOrEmpty(Address))
            {
                Error = "Address is empty!";
            }else if (string.IsNullOrEmpty(Password))
            {
                Error = "Password is empty!";
            }
            else if(Name.Length < 5 || Name.Length > 50)
            {
                Error = "Name must be between 5 - 50 characters";
            }else if (IsExistEmail(Email))
            {
                Error = "Email already used by someone";
            }else if(!Address.EndsWith("Street"))
            {
                Error = "Address must ends with street";
            }else if (!Facade.Facade.CheckAlphanumeric(Password))
            {
                Error = "Password must be alphanumeric!";
            }




            if (Error != string.Empty)
            {
                return new Data<Customer>(Error, null, false);
            }

            Customer Object = CustomerHandler.CreateCustomer(Name, Email, Password, Gender, Address);

            if (Object == null)
            {
                return new Data<Customer>("Customer failed to create!", null, false);
            }

            return new Data<Customer>("Succesfully register New User!", Object, true);
        }
    }
}