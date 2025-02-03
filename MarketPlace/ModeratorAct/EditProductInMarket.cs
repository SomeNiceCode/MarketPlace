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
    public static class EditProductInMarket
    {
        public static void EditProduct()
        {
            Console.WriteLine("Введите название товара для редактирования:");
            string oldProductName = Console.ReadLine();

            Product oldProduct = null;
            Seller productSeller = null;

            foreach (var seller in SellersList.GetSellers())
            {
                foreach (var electronics in seller.Electronics)
                {
                    if (electronics.Name == oldProductName)
                    {
                        oldProduct = electronics;
                        productSeller = seller;
                        break;
                    }
                }

                if (oldProduct == null)
                {
                    foreach (var clothing in seller.Clothing)
                    {
                        if (clothing.Name == oldProductName)
                        {
                            oldProduct = clothing;
                            productSeller = seller;
                            break;
                        }
                    }
                }

                if (oldProduct == null)
                {
                    foreach (var book in seller.Books)
                    {
                        if (book.Name == oldProductName)
                        {
                            oldProduct = book;
                            productSeller = seller;
                            break;
                        }
                    }
                }

                if (oldProduct != null)
                {
                    break;
                }
            }

            if (oldProduct != null && productSeller != null)
            {
                Console.WriteLine("Введите новое название товара:");
                string newProductName = Console.ReadLine();

                Console.WriteLine("Введите новую цену товара:");
                decimal newProductPrice = decimal.Parse(Console.ReadLine());

                if (oldProduct is Electronics)
                {
                    Console.WriteLine("Введите новый бренд товара:");
                    string newBrand = Console.ReadLine();

                    Console.WriteLine("Введите новую модель товара:");
                    string newModel = Console.ReadLine();

                    var newProduct = new Electronics(newProductName, newProductPrice, newBrand, newModel);
                    int index = productSeller.Electronics.IndexOf((Electronics)oldProduct);
                    if (index != -1)
                    {
                        productSeller.Electronics[index] = newProduct;
                        Console.WriteLine("Товар успешно отредактирован в маркетплейсе!");
                    }
                }
                else if (oldProduct is Clothing)
                {
                    Console.WriteLine("Введите новый размер товара:");
                    string newSize = Console.ReadLine();

                    Console.WriteLine("Введите новый цвет товара:");
                    string newColor = Console.ReadLine();

                    var newProduct = new Clothing(newProductName, newProductPrice, newSize, newColor);
                    int index = productSeller.Clothing.IndexOf((Clothing)oldProduct);
                    if (index != -1)
                    {
                        productSeller.Clothing[index] = newProduct;
                        Console.WriteLine("Товар успешно отредактирован в маркетплейсе!");
                    }
                }
                else if (oldProduct is Book)
                {
                    Console.WriteLine("Введите нового автора книги:");
                    string newAuthor = Console.ReadLine();

                    Console.WriteLine("Введите новое количество страниц:");
                    int newPages = int.Parse(Console.ReadLine());

                    var newProduct = new Book(newProductName, newProductPrice, newAuthor, newPages);
                    int index = productSeller.Books.IndexOf((Book)oldProduct);
                    if (index != -1)
                    {
                        productSeller.Books[index] = newProduct;
                        Console.WriteLine("Товар успешно отредактирован в маркетплейсе!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Товар не найден.");
            }
        }
    }
}
