using MarketPlace.AbstractClasses;
using MarketPlace.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.CustomerAct
{
    public static class CustomerActions
    {
        public static void CustomerAction(Customer customer)
        {
            Basket basket = new Basket();
            bool customerExit = false;
            while (!customerExit)
            {
                Console.WriteLine("Выберите действие (1 - Просмотреть товары, 2 - Добавить в корзину, 3 - Убрать из корзины, 4 - Подтвердить заказ, 5 - Показать корзину, 6 - Показать покупки, 7 - Выход):");
                int customerAction = int.Parse(Console.ReadLine());

                switch (customerAction)
                {
                    case 1:
                        ViewProducts.ViewAllProducts();
                        break;

                    case 2:
                        BuyProduct.PurchaseProduct(customer, basket);
                        break;

                    case 3:
                        RemoveFromBasket(basket);
                        break;

                    case 4:
                        basket.ConfirmOrder(customer);
                        break;

                    case 5:
                        basket.ShowBasket();
                        break;

                    case 6:
                        ShowPurchases.DisplayPurchases(customer);
                        break;

                    case 7:
                        customerExit = true;
                        break;

                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }
            }
        }

        private static void RemoveFromBasket(Basket basket)
        {
            Console.WriteLine("Введите название товара для удаления из корзины:");
            string productName = Console.ReadLine();

            basket.RemoveFromBasket(productName);
        }
    }
}