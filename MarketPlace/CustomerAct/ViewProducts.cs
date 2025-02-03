using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketPlace.UsersLists;

namespace MarketPlace.CustomerAct
{
    public static class ViewProducts
    {
        public static void ViewAllProducts()
        {
            Console.WriteLine("Просмотр всех доступных товаров:");

            foreach (var seller in SellersList.GetSellers())
            {
                Console.WriteLine($"Продавец: {seller.Name}");

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
}
