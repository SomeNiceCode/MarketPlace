using MarketPlace;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MarketPlace
{
    public class Seller : Person
    {
        string StoreName { get; set; }
        public Seller(string name, string email, string phone, UserRole role, string login, string password, string storeName) : base(name, email, phone, role, login, password)
        {
            StoreName = storeName;
        }

    }
}