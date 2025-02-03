using MarketPlace.AbstractClasses;
using MarketPlace.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.SellerAct
{
    public class SellerActions
    {
        public static void SellerAction(Seller seller)
        {
            bool sellerExit = false;
            while (!sellerExit)
            {
                Console.WriteLine("Выберите действие (1 - Добавить товар, 2 - Удалить товар, 3 - Редактировать товар, 4 - Выход, 5 - Показать все мои товары):");
                int sellerAction = int.Parse(Console.ReadLine());

                switch (sellerAction)
                {
                    case 1:
                        AddProductToMarket.AddProduct(seller);
                        break;

                    case 2:
                        DeleteProductFromMarket.RemoveProduct(seller);
                        break;

                    case 3:
                        EditProductInMarket.EditProduct(seller);
                        break;

                    case 4:
                        sellerExit = true;
                        break;
                    case 5:
                        ShowAllProducts.ShowAllSellerProducts(seller);
                        break;

                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                }
            }
        }

    }
}
