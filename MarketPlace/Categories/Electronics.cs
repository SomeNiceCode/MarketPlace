using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MarketPlace.AbstractClasses;

namespace MarketPlace.Categories
{
    public class Electronics : Product
    {
        private string brand;
        private string model;
        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                brand = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public Electronics(string name, decimal price, string brand, string model) : base(name, price)
        {
            this.brand = brand;
            this.model = model;
        }
    }
}
