using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtation.Backend.Repository;

namespace KpopZtation.Backend.Factory
{
    public class CustomerFactory
    {
        public static Customer Create(string Name, string Email, string Password, string Gender, string Address, string Role)
        {
            Entities db = Database.GetInstance();

            Customer Customer = new Customer();

            Customer.CustomerName = Name;
            Customer.CustomerEmail = Email;
            Customer.CustomerPassword = Password;
            Customer.CustomerGender = Gender;
            Customer.CustomerAddress = Address;
            Customer.CustomerRole = Role;
            db.Customers.Add(Customer);
            
            Database.SecureSave();
            return Customer;
        }

        public static Customer CreateCustomer(string Name, string Email, string Password, string Gender, string Address)
        {
            return Create(Name, Email, Password, Gender, Address, "Customer");
        }

        public static Customer CreateAdmin(string Name, string Email, string Password, string Gender, string Address)
        {
            return Create(Name, Email, Password, Gender, Address, "Admin");
        }
    }
}