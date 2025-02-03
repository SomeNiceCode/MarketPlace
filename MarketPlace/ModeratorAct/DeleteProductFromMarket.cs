using MarketPlace.AbstractClasses;
using MarketPlace.Categories;
using MarketPlace.Users;
using MarketPlace.UsersLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.ModeratorAct
{
    public static class DeleteProductFromMarket
    {
        public static void RemoveProduct()
        {
            Console.WriteLine("Введите название товара для удаления:");
            string productName = Console.ReadLine();

            Product product = null;
            Seller productSeller = null;

            foreach (var seller in SellersList.GetSellers())
            {
                foreach (var electronics in seller.Electronics)
                {
                    if (electronics.Name == productName)
                    {
                        product = electronics;
                        productSeller = seller;
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
                            productSeller = seller;
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
                            productSeller = seller;
                            break;
                        }
                    }
                }

                if (product != null)
                {
                    break;
                }
            }

            if (product != null && productSeller != null)
            {
                if (product is Electronics)
                {
                    productSeller.Electronics.Remove((Electronics)product);
                }
                else if (product is Clothing)
                {
                    productSeller.Clothing.Remove((Clothing)product);
                }
                else if (product is Book)
                {
                    productSeller.Books.Remove((Book)product);
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
