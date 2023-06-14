using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtation.Backend.Factory;

namespace KpopZtation.Backend.Repository
{
    public class CustomerRepository
    {
        private static Entities db = Database.GetInstance();

        public static List<Customer> GetCustomer()
        {
            return (from customers in db.Customers select customers).ToList<Customer>();
        }

        public static Customer CreateCustomer(string Name, string Email, string Password, string Gender, string Address)
        {
            return CustomerFactory.CreateCustomer(Name, Email, Password, Gender, Address);
        }

        public static Customer UpdateCustomer(string ID, string Name, string Email, string Password, string Gender, string Address)
        {
            Customer Object = FindById(int.Parse(ID));
            Object.CustomerName = Name;
            Object.CustomerEmail = Email;
            Object.CustomerPassword = Password;
            Object.CustomerGender = Gender;
            Object.CustomerAddress = Address;
            db.SaveChanges();
            return Object;
        }

        public static Customer CreateAdmin(string Name, string Email, string Password, string Gender, string Address)
        {
            return CustomerFactory.CreateAdmin(Name, Email, Password, Gender, Address);
        }


        public static Customer FindByEmail(string Email) {
            return (from customers in db.Customers where customers.CustomerEmail == Email select customers).FirstOrDefault();
        }

        public static Customer FindById(int id)
        {
            return (from customers in db.Customers where customers.CustomerID == id select customers).FirstOrDefault();
        }
    }
}