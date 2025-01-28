using System.Net;

namespace MarketPlace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit) 
            { 
                Console.WriteLine("Выберите действие (1 - Регистрация, 2 - Вход, 3 - Выход):");
                int action = int.Parse(Console.ReadLine());
                switch (action) 
                { 
                    case 1: Console.WriteLine("Выберите тип пользователя для регистрации (1 - Покупатель, 2 - Продавец):");
                        int userType = int.Parse(Console.ReadLine());
                        if (userType == 1) 
                        { 
                            Registration.RegisterCustomer(); 
                        } 
                        else if (userType == 2) 
                        { 
                            Registration.RegisterSeller(); 
                        } 
                        else
                        {
                            Console.WriteLine("Неверный выбор."); 
                        } 
                        break; 
                    case 2:
                        Console.WriteLine("Введите логин:");
                        string login = Console.ReadLine();
                        Console.WriteLine("Введите пароль:");
                        string password = Console.ReadLine();
                        Autorization.LoginPass(login, password);
                        break;
                    case 3:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор.");
                        break; 
                } 
            }
        }   
    }
}