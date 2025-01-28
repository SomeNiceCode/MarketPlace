using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketPlace.Users;

namespace MarketPlace
{
    public static class CustomersList                          // этот класс для списка покупателей
    { 
        private static List<Customer> customers = new List<Customer>();
        public static void RegisterCustomer(Customer customer) 
        { 
            customers.Add(customer); 
        }
        public static List<Customer> GetCustomers() 
        { 
            return customers; 
        } 
    }
}
