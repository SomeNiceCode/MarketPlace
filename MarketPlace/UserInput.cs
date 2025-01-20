using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace
{
    public class UserInput
    {
        public void Input()
        {
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите email:");
            string email = Console.ReadLine();
            Console.WriteLine("Введите телефон:");
            string phone = Console.ReadLine();
            Console.WriteLine("Введите логин:");
            string username = Console.ReadLine();
            Console.WriteLine("Введите пароль:");
            string password = Console.ReadLine();
            Console.WriteLine("Введите роль (Customer, Seller, Moderator):");
            UserRole role = (UserRole)Enum.Parse(typeof(UserRole), Console.ReadLine(), true);
            string additionalInfo = null;
            if (role == UserRole.Seller)
            {
                Console.WriteLine("Введите название магазина:");
                additionalInfo = Console.ReadLine();
            }
            else if (role == UserRole.Customer)
            {
                Console.WriteLine("Введите адрес:");
                additionalInfo = Console.ReadLine();
            }
            
            Registration registration = new Registration(); 
            registration.RegisterUser(name, email, phone, username, password, role, additionalInfo);
        }
    }
}
