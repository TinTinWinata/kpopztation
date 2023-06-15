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




        public static Data<Customer> Register(string Name, string Email, string Gender, string Address, string Password)
        {
            string Error = CustomerController.IsInputValid(Name, Email, Gender, Address, Password, "");

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