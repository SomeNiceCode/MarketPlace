using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace
{
    public class Registration
    {
        public static void RegisterCustomer()
        {
            Console.WriteLine("Введите имя покупателя:");
            string customerName = Console.ReadLine();
            Console.WriteLine("Введите логин покупателя:");
            string login = Console.ReadLine();
            Console.WriteLine("Введите пароль покупателя:");
            string password = Console.ReadLine();
            Console.WriteLine("Введите номер телефона покупателя:");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Введите email покупателя:");
            string email = Console.ReadLine();
            var customer = new Users.Customer(customerName, UserRole.Customer, login, password, phoneNumber, email);
            CustomersList.RegisterCustomer(customer);
            Console.WriteLine("Покупатель успешно зарегистрирован!");
        }

        public static void RegisterSeller() 
        { 
            Console.WriteLine("Введите имя продавца:");
            string sellerName = Console.ReadLine();
            Console.WriteLine("Введите логин продавца:");
            string login = Console.ReadLine();
            Console.WriteLine("Введите пароль продавца:");
            string password = Console.ReadLine();
            Console.WriteLine("Введите название магазина:");
            string shopName = Console.ReadLine(); 
            var seller = new Users.Seller(sellerName, UserRole.Seller, login, password, shopName);
            SellersList.RegisterSeller(seller); 
            Console.WriteLine("Продавец успешно зарегистрирован!"); 
        }
    }
}