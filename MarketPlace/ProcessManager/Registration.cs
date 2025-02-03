using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MarketPlace.UsersLists;

namespace MarketPlace.ProcessManager
{
    public class Registration                 // модераторы у нас регистрируются только через код
    {
        public static void RegisterCustomer() // регистрация покупателя 
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

        public static void RegisterSeller()    // регистрация продавца
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

        public static void PersonRegistration()     // процесс регистрации юзера на одну из ролей
        {
            Console.WriteLine("Выберите тип пользователя для регистрации (1 - Покупатель, 2 - Продавец):");
            int userType = int.Parse(Console.ReadLine());

            if (userType == 1)
            {
                RegisterCustomer();
            }
            else if (userType == 2)
            {
                RegisterSeller();
            }
            else
            {
                Console.WriteLine("Неверный выбор.");
            }
        }

        public static void PersonAuth()      // сам процесс авторизации юзера в программе
        {
            Console.WriteLine("Введите логин:");
            string login = Console.ReadLine();

            Console.WriteLine("Введите пароль:");
            string password = Console.ReadLine();

            Autorization.LoginPass(login, password);
        }
    }
}