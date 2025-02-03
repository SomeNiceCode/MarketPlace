using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketPlace.UsersLists;

namespace MarketPlace.ProcessManager
{
    public static class Autorization
    {
        public static string CurrentUserLogin { get; private set; }
        public static UserRole CurrentUserRole { get; private set; }

        public static void LoginPass(string login, string password)
        {
            var seller = SellersList.GetSellers().FirstOrDefault(s => s.Login == login && s.Password == password);
            if (seller != null)
            {
                CurrentUserLogin = login;
                CurrentUserRole = UserRole.Seller;
                Console.WriteLine("Вход выполнен как продавец.");
                return;
            }

            var moderator = ModeratorsList.GetModerators().FirstOrDefault(m => m.Login == login && m.Password == password);
            if (moderator != null)
            {
                CurrentUserLogin = login;
                CurrentUserRole = UserRole.Moderator;
                Console.WriteLine("Вход выполнен как модератор.");
                return;
            }

            var buyer = CustomersList.GetCustomers().FirstOrDefault(b => b.Login == login && b.Password == password);
            if (buyer != null)
            {
                CurrentUserLogin = login;
                CurrentUserRole = UserRole.Customer;
                Console.WriteLine("Вход выполнен как покупатель.");
                return;
            }

            Console.WriteLine("Неверный логин или пароль.");
        }
    }
}


