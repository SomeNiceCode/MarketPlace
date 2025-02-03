using MarketPlace.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.SellerAct
{
    public class ShowAllProducts
    {
        public static void ShowAllSellerProducts(Seller seller)
        {
            Console.WriteLine("Все товары продавца:");

            Console.WriteLine("Электроника:");
            foreach (var electronics in seller.Electronics)
            {
                Console.WriteLine($"- Название: {electronics.Name}, Цена: {electronics.Price}, Бренд: {electronics.Brand}, Модель: {electronics.Model}");
            }

            Console.WriteLine("Одежда:");
            foreach (var clothing in seller.Clothing)
            {
                Console.WriteLine($"- Название: {clothing.Name}, Цена: {clothing.Price}, Размер: {clothing.Size}, Цвет: {clothing.Color}");
            }

            Console.WriteLine("Книги:");
            foreach (var book in seller.Books)
            {
                Console.WriteLine($"- Название: {book.Name}, Цена: {book.Price}, Автор: {book.Author}, Количество страниц: {book.Pages}");
            }
        }
    }
}
