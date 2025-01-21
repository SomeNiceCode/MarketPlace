using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace
{
    public static class SellersList      // класс для хранения списка продавцов
    { 
        private static List<Seller> sellers = new List<Seller>();
        public static void AddSeller(Seller seller)
        { 
            sellers.Add(seller); 
        } 
        
        public static List<Seller> GetSellers() 
        { 
            return sellers; 
        } 
    }
}
