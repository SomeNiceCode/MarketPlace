using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace
{
    public class Customer : Person
    {
        string Address { get; set; }
        string Phone { get; set; }

        public Customer(string name, string email, string phone, UserRole role, string login, string password, string address) : base(name, email, phone, role, login, password)
        {
            Address = address;
        }
    }
}
