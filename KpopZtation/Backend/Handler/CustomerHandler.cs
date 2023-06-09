﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KpopZtation.Backend.Repository;

namespace KpopZtation.Backend.Handler
{
    public class CustomerHandler
    {
        public static Customer CreateCustomer(string Name, string Email, string Password, string Gender, string Address)
        {
            return CustomerRepository.CreateCustomer(Name, Email, Password, Gender, Address);
        }

        public static Customer UpdateCustomer(string ID, string Name, string Email, string Password, string Gender, string Address)
        {
            return CustomerRepository.UpdateCustomer(ID, Name, Email, Password, Gender, Address);
        }
        public static Customer CreateAdmin(string Name, string Email, string Password, string Gender, string Address)
        {
            return CustomerRepository.CreateAdmin(Name, Email, Password, Gender, Address);
        }
        public static Customer FindByEmail(string Email)
        {
            return CustomerRepository.FindByEmail(Email);
        }

        public static Customer DeleteCustomer(int ID)
        {
            return CustomerRepository.DeleteCustomer(ID);
        }

        public static List<Customer> GetAllCustomer()
        {
            return CustomerRepository.GetCustomers();
        }

        public static Customer FindById(int id)
        {
            return CustomerRepository.FindById(id);
        }
    }
}