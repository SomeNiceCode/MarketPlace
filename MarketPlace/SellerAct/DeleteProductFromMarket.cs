using MarketPlace.AbstractClasses;
using MarketPlace.Categories;
using MarketPlace.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.SellerAct
{
    public class DeleteProductFromMarket
    {
        public static void RemoveProduct(Seller seller)
        {
            Console.WriteLine("Введите название товара для удаления:");
            string productName = Console.ReadLine();

            Product product = null;

            foreach (var electronics in seller.Electronics)
            {
                if (electronics.Name == productName)
                {
                    product = electronics;
                    break;
                }
            }

            if (product == null)
            {
                foreach (var clothing in seller.Clothing)
                {
                    if (clothing.Name == productName)
                    {
                        product = clothing;
                        break;
                    }
                }
            }

            if (product == null)
            {
                foreach (var book in seller.Books)
                {
                    if (book.Name == productName)
                    {
                        product = book;
                        break;
                    }
                }
            }

            if (product != null)
            {
                if (product is Electronics)
                {
                    seller.Electronics.Remove((Electronics)product);
                }
                else if (product is Clothing)
                {
                    seller.Clothing.Remove((Clothing)product);
                }
                else if (product is Book)
                {
                    seller.Books.Remove((Book)product);
                }
                Console.WriteLine("Товар успешно удален из маркетплейса!");
            }
            else
            {
                Console.WriteLine("Товар не найден.");
            }
        }
    }
}
