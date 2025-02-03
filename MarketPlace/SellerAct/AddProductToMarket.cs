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
    public class AddProductToMarket
    {
        public static void AddProduct(Seller seller)
        {
            Console.WriteLine("Введите название товара:");
            string productName = Console.ReadLine();

            Console.WriteLine("Введите цену товара:");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Выберите категорию товара (1 - Электроника, 2 - Одежда, 3 - Книга):");
            int category = int.Parse(Console.ReadLine());

            Product product = null;

            switch (category)
            {
                case 1:
                    Console.WriteLine("Введите бренд товара:");
                    string brand = Console.ReadLine();

                    Console.WriteLine("Введите модель товара:");
                    string model = Console.ReadLine();

                    product = new Electronics(productName, productPrice, brand, model);
                    break;

                case 2:
                    Console.WriteLine("Введите размер товара:");
                    string size = Console.ReadLine();

                    Console.WriteLine("Введите цвет товара:");
                    string color = Console.ReadLine();

                    product = new Clothing(productName, productPrice, size, color);
                    break;

                case 3:
                    Console.WriteLine("Введите автора книги:");
                    string author = Console.ReadLine();

                    Console.WriteLine("Введите количество страниц:");
                    int pages = int.Parse(Console.ReadLine());

                    product = new Book(productName, productPrice, author, pages);
                    break;

                default:
                    Console.WriteLine("Неверная категория.");
                    break;
            }

            if (product != null)
            {
                if (product is Electronics)
                {
                    seller.Electronics.Add((Electronics)product);
                }
                else if (product is Clothing)
                {
                    seller.Clothing.Add((Clothing)product);
                }
                else if (product is Book)
                {
                    seller.Books.Add((Book)product);
                }
                Console.WriteLine("Товар успешно добавлен в маркетплейс!");
            }
        }
    }
}
