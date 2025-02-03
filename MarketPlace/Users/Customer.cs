using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketPlace.AbstractClasses;

namespace MarketPlace.Users
{
    public class Customer : Person
    {
        private string phoneNumber;
        private string email;
        public List<Product> Purchases { get; set; }

        public string PhoneNumber

        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public Customer(string name, UserRole role, string login, string password, string phoneNumber, string email) : base(name, role, login, password)
        {
            this.phoneNumber = phoneNumber;
            this.email = email;
            Purchases = new List<Product>();
        }


    }
}
