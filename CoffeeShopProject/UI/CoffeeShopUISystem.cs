using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopProject.BL;
using MenuItemProject.BL;
namespace CoffeShopUISystem
{
    public class CoffeeShopUI
    {
        public static int PrintMenu()
        {
            PrintHeader();
            subMenu("Menu");
            Console.WriteLine("1.Add the Menu item");
            Console.WriteLine("2.View the Cheapest Item in the Menu");
            Console.WriteLine("3. View the Drink's Menu");
            Console.WriteLine("4.View the Food's Menu");
            Console.WriteLine("5.Add Order");
            Console.WriteLine("6.Fulfill the Order");
            Console.WriteLine("6. View the Order's List");
            Console.WriteLine("7.Total Payable Amount");
            Console.WriteLine("Exit");
            int option = CoffeeShop.integerValidation();

        }
        public static void PrintHeader()
        {
            Console.WriteLine("######   #######  ######## ######## ######## ########        ######  ##     ##   #######  ########     ");
            Console.WriteLine("##    ## ##     ## ##       ##       ##       ##            ##    ## ##     ##  ##     ## ##     ##     ");
            Console.WriteLine("##       ##     ## ##       ##       ##       ##            ##       ##     ##  ##     ## ##     ##     ");
            Console.WriteLine("##       ##     ## ######   ######   ######   ######        ######   #########  ##     ## ########      ");
            Console.WriteLine("##       ##     ## ##       ##       ##       ##                ##   ##     ##  ##     ## ##            ");
            Console.WriteLine("##    ## ##     ## ##       ##       ##       ##           ##   ##   ##     ##  ##     ## ##            ");
            Console.WriteLine("######   #######  ##       ##       ######## ########      ######    ##     ##   #######  ##            ");

        }
        public static void subMenuBeforeMainMenu(string submenu)
        {
            string message = submenu + " Menu";
            Console.WriteLine(message);
            Console.WriteLine("------------------------");
            Console.ReadKey();
        }
        public static void subMenu(string submenu)
        {
            string message = "Main Menu >" + submenu;
            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.ReadKey();
        }
        public static void PrintTheStatusOfOrder()
        {
            string Result = CoffeeShop.fulfillOrder();
            Console.WriteLine("{0}", Result);

        }
        public static void ViewOrdersList()
        {
            foreach(MenuItem item in orders)
            {

            }

        }
        public static void ViewTotalPayableAmount ()
        {

        }

    }


}


