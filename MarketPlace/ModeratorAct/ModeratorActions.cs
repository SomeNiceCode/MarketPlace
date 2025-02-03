using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.ModeratorAct
{
    public static class ModeratorActions
    {
        public static void ModeratorAction()
        {
            bool moderatorExit = false;
            while (!moderatorExit)
            {
                Console.WriteLine("Выберите действие (1 - Просмотреть все товары, 2 - Редактировать товар, 3 - Удалить товар, 4 - Выход):");
                int moderatorAction = int.Parse(Console.ReadLine());

                switch (moderatorAction)
                {
                    case 1:
                        ViewAllProducts.ViewAll();
                        break;

                    case 2:
                        EditProductInMarket.EditProduct();
                        break;

                    case 3:
                        DeleteProductFromMarket.RemoveProduct();
                        break;

                    case 4:
                        moderatorExit = true;
                        break;

                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }
            }
        }
    }
}
