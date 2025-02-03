using MarketPlace.AbstractClasses;
using MarketPlace.Categories;
using MarketPlace.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace
{
    public class Basket
    {
        public List<Product> Products { get; private set; }

        public Basket()
        {
            Products = new List<Product>();
        }

        public void AddToBasket(Product product)
        {
            Products.Add(product);
            Console.WriteLine("Товар добавлен в корзину.");
        }

        public void RemoveFromBasket(string productName)
        {
            Product product = Products.FirstOrDefault(p => p.Name == productName);

            if (product != null)
            {
                Products.Remove(product);
                Console.WriteLine("Товар удален из корзины.");
            }
            else
            {
                Console.WriteLine("Товар не найден в корзине.");
            }
        }

        public void ConfirmOrder(Customer customer)
        {
            foreach (var product in Products)
            {
                customer.Purchases.Add(product);
            }
            Products.Clear();
            Console.WriteLine("Заказ подтвержден и товары добавлены в ваши покупки.");
        }
        public void ShowBasket()
        {
            Console.WriteLine("Содержимое корзины:");

            if (Products.Count == 0)
            {
                Console.WriteLine("Корзина пуста.");
            }
            else
            {
                foreach (var product in Products)
                {
                    if (product is Electronics electronics)
                    {
                        Console.WriteLine($"- Название: {electronics.Name}, Цена: {electronics.Price}, Бренд: {electronics.Brand}, Модель: {electronics.Model}");
                    }
                    else if (product is Clothing clothing)
                    {
                        Console.WriteLine($"- Название: {clothing.Name}, Цена: {clothing.Price}, Размер: {clothing.Size}, Цвет: {clothing.Color}");
                    }
                    else if (product is Book book)
                    {
                        Console.WriteLine($"- Название: {book.Name}, Цена: {book.Price}, Автор: {book.Author}, Количество страниц: {book.Pages}");
                    }
                }
            }
        }
    }
}
