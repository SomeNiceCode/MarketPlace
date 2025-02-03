using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MarketPlace;
using MarketPlace.AbstractClasses;
using MarketPlace.Categories;

namespace MarketPlace.Users
{
    public class Seller : Person
    {
        private string shopName;
        private List<Electronics> electronics;
        private List<Clothing> clothing;
        private List<Book> books;

        public string ShopName
        {
            get { return shopName; }
            set { shopName = value; }
        }

        public List<Electronics> Electronics
        {
            get { return electronics; }
        }

        public List<Clothing> Clothing
        {
            get { return clothing; }
        }

        public List<Book> Books
        {
            get { return books; }
        }

        public Seller(string name, UserRole role, string login, string password, string shopName) // у каждого экземпляра продавца будут свои коллекции товаров разных категорий, чтобы один продавец не смог работать с товарами другого продавца
            : base(name, role, login, password)
        {
            this.shopName = shopName;
            this.electronics = new List<Electronics>();
            this.clothing = new List<Clothing>();
            this.books = new List<Book>();
        }

    }
}