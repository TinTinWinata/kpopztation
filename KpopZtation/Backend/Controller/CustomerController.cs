using KpopZtation.Backend.Facade;
using KpopZtation.Backend.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Backend.Controller
{
    public class CustomerController
    {

        public static bool IsExistEmail(string Email, string UpdateID)
        {
            Customer customer = CustomerHandler.FindByEmail(Email);
            if (customer == null || customer.CustomerEmail != UpdateID)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static Data<List<Customer>> GetAllCustomer()
        {
            try
            {
                return new Data<List<Customer>>("Getted Customer", CustomerHandler.GetAllCustomer(), true);
            }catch(Exception err)
            {
                return new Data<List<Customer>>(err.Message, null, false);
            }
        }

        public static Data<Customer> DeleteCustomer(string ID)
        {
            try
            {
                int IntegerID = int.Parse(ID);
                return new Data<Customer>("Success", CustomerHandler.DeleteCustomer(IntegerID), true);
            }catch(Exception error)
            {
                return new Data<Customer>(error.Message, null, false);
            }
        }

        public static Data<Customer> Update(string ID, string Name, string Email, string Gender, string Address, string Password)
        {
            string Error = CustomerController.IsInputValid(Name, Email, Gender, Address, Password, ID);

            if (Error != string.Empty)
            {
                return new Data<Customer>(Error, null, false);
            }

            Customer Object = CustomerHandler.UpdateCustomer(ID, Name, Email, Password, Gender, Address);

            if (Object == null)
            {
                return new Data<Customer>("Customer failed to create!", null, false);
            }

            return new Data<Customer>("Succesfully register New User!", Object, true);
        }

        public static string IsInputValid(string Name, string Email, string Gender, string Address, string Password, string ID)
        {
            string Error = string.Empty;
            if (string.IsNullOrEmpty(Name))
            {
                Error = "Name is empty!";
            }
            else if (string.IsNullOrEmpty(Email))
            {
                Error = "Email is empty!";
            }
            else if (string.IsNullOrEmpty(Gender))
            {
                Error = "Gender is empty!";
            }
            else if (string.IsNullOrEmpty(Address))
            {
                Error = "Address is empty!";
            }
            else if (string.IsNullOrEmpty(Password))
            {
                Error = "Password is empty!";
            }
            else if (Name.Length < 5 || Name.Length > 50)
            {
                Error = "Name must be between 5 - 50 characters";
            }
            else if (IsExistEmail(Email, ID))
            {
                Error = "Email already used by someone";
            }
            else if (!Address.EndsWith("Street"))
            {
                Error = "Address must ends with street";
            }
            else if (!Facade.Facade.CheckAlphanumeric(Password))
            {
                Error = "Password must be alphanumeric!";
            }
            return Error;
        }

        public static Customer GetCustomerById(int id)
        {
            return CustomerHandler.FindById(id);
        }
    }
}