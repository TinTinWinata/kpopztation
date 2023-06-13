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
    }
}