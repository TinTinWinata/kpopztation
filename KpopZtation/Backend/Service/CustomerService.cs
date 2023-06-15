using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtation.Backend.Controller;
using KpopZtation.Backend.Facade;

namespace KpopZtation.Backend.Service
{
    public class CustomerService
    {
        public static string WSGetCustomerById(int id)
        {
            return Json.Encode(CustomerController.GetCustomerById(id));
        }

        public static string WSUpdateCustomer(string ID, string Name, string Email, string Gender, string Address, string Password)
        {
            return Json.Encode(CustomerController.Update(ID, Name, Email, Gender, Address, Password));
        }

        public static string WSGetCustomers()
        {
            return Json.Encode(CustomerController.GetAllCustomer());
        }

        public static string WsDeleteCustomer(string ID)
        {
            return Json.Encode(CustomerController.DeleteCustomer(ID));
        }
    }
}