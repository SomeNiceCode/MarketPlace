using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketPlace.AbstractClasses;

namespace MarketPlace.Categories
{
    public class Clothing : Product
    {
        private string size;
        private string color;
        public string Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public Clothing(string name, decimal price, string size, string color) : base(name, price)
        {
            this.size = size; this.color = color;
        }
    }
}
