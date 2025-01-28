using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketPlace.AbstractClasses;

namespace MarketPlace.Categories
{
    public class Book : Product
    {
        private string author;
        private int pages;
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        public int Pages
        {
            get
            {
                return pages;
            }
            set
            {
                pages = value;
            }
        }
        public Book(string name, decimal price, string author, int pages) : base(name, price)
        {
            this.author = author;
            this.pages = pages;
        }
    }
}
