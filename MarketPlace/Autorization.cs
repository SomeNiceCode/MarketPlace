using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace
{
    public class Autorization
    {
        public static bool LoginPass(string login, string password) 
        { 
            Console.WriteLine("Проверка среди покупателей...");
            foreach (var customer in CustomersList.GetCustomers()) 
            {
                Console.WriteLine($"Проверка покупателя: {customer.Login}");
                if (customer.Login == login && customer.Password == password) 
                { 
                    Console.WriteLine("Успешный вход в учетную запись покупателя.");
                    return true; 
                } 
            } 
            Console.WriteLine("Проверка среди продавцов...");
            foreach (var seller in SellersList.GetSellers()) 
            { 
                Console.WriteLine($"Проверка продавца: {seller.Login}");
                if (seller.Login == login && seller.Password == password) 
                { Console.WriteLine("Успешный вход в учетную запись продавца."); 
                    return true; 
                } 
            } Console.WriteLine("Проверка среди модераторов...");
            foreach (var moderator in ModeratorsList.GetModerators()) 
            { 
                Console.WriteLine($"Проверка модератора: {moderator.Login}");
                if (moderator.Login == login && moderator.Password == password) 
                {
                    Console.WriteLine("Введите контрольный код:");
                    string securityCode = Console.ReadLine();
                    if (moderator.SecurityCode == securityCode) 
                    { 
                        Console.WriteLine("Успешный вход в учетную запись модератора.");
                        return true;
                    } 
                    else 
                    { 
                        Console.WriteLine("Неверный контрольный код.");
                        return false; 
                    }
                } 
            } 
            Console.WriteLine("Неверный логин или пароль."); 
            return false; 
        }
    }
}

