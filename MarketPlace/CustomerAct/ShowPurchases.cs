using MarketPlace.Categories;
using MarketPlace.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.CustomerAct
{
    public static class ShowPurchases
    {
        public static void DisplayPurchases(Customer customer)
        {
            Console.WriteLine("Ваши покупки:");

            foreach (var purchase in customer.Purchases)
            {
                if (purchase is Electronics electronics)
                {
                    Console.WriteLine($"- Название: {electronics.Name}, Цена: {electronics.Price}, Бренд: {electronics.Brand}, Модель: {electronics.Model}");
                }
                else if (purchase is Clothing clothing)
                {
                    Console.WriteLine($"- Название: {clothing.Name}, Цена: {clothing.Price}, Размер: {clothing.Size}, Цвет: {clothing.Color}");
                }
                else if (purchase is Book book)
                {
                    Console.WriteLine($"- Название: {book.Name}, Цена: {book.Price}, Автор: {book.Author}, Количество страниц: {book.Pages}");
                }
            }
        }
    }
}
