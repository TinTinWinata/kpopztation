using KpopZtation.Backend.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Backend.Controller
{
    public class CustomerController
    {
        public static void CreateCustomer(){
               
        }

        public static Customer GetCustomerById(int id)
        {
            return CustomerHandler.FindById(id);
        }
    }
}