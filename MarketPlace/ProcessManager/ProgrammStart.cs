using MarketPlace.CustomerAct;
using MarketPlace.ModeratorAct;
using MarketPlace.SellerAct;
using MarketPlace.Users;
using MarketPlace.UsersLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.ProcessManager
{
    public static class ProgramStart
    {
        public static void Start()
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Выберите действие (1 - Регистрация, 2 - Вход, 3 - Выход):");
                int action = int.Parse(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        Registration.PersonRegistration();
                        break;

                    case 2:
                        Registration.PersonAuth();

                        if (Autorization.CurrentUserRole == UserRole.Seller)
                        {
                            Seller seller = null;
                            foreach (var s in SellersList.GetSellers())
                            {
                                if (s.Login == Autorization.CurrentUserLogin)
                                {
                                    seller = s;
                                    break;
                                }
                            }
                            if (seller != null)
                            {
                                SellerActions.SellerAction(seller);
                            }
                        }
                        else if (Autorization.CurrentUserRole == UserRole.Customer)
                        {
                            Customer customer = null;
                            foreach (var c in CustomersList.GetCustomers())
                            {
                                if (c.Login == Autorization.CurrentUserLogin)
                                {
                                    customer = c;
                                    break;
                                }
                            }
                            if (customer != null)
                            {
                                CustomerActions.CustomerAction(customer);
                            }
                        }
                        else if (Autorization.CurrentUserRole == UserRole.Moderator)
                        {
                            ModeratorActions.ModeratorAction();
                        }
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
