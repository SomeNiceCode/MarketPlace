using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MarketPlace.AbstractClasses
{
    public abstract class Product
    {
        private string name;
        private decimal price;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        protected Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
