using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MarketPlace.AbstractClasses;

namespace MarketPlace.Users
{
    public class Seller : Person
    {
        private string shopName;
        private List<string> products;
        public string ShopName
        {
            get
            {
                return shopName;
            }
            set
            {
                shopName = value;
            }
        }
        public List<string> Products
        {
            get
            {
                return products;
            }
            set
            {
                products = value;
            }
        }
        public Seller(string name, UserRole role, string login, string password, string shopName) : base(name, role, login, password)
        {
            this.shopName = shopName;
        }


    }
}