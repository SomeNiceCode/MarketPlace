using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketPlace.Users;

namespace MarketPlace.UsersLists
{
    public static class SellersList      // класс для хранения списка продавцов
    {
        private static List<Seller> sellers = new List<Seller>();
        public static void RegisterSeller(Seller seller)
        {
            sellers.Add(seller);
        }

        public static List<Seller> GetSellers()
        {
            return sellers;
        }
    }
}
