using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuItemProject.BL;

namespace CoffeeShopProject.BL
{
    class CoffeeShop
    {
        public string name;
        static List<string> orders = new List<string>();
        static List<MenuItem> menu = new List<MenuItem>();

        public CoffeeShop(string name) 
        { 
            this.name = name;
        }
        public static void Addorder(string name)
        {
            MenuItem menuItem = new MenuItem();

            if (ItemInMenuPresent(name, menuItem) == "Available";
            {
                orders.Add(menuItem);
            }


        }
        public static string ItemInMenuPresent(string name, MenuItem menuItem)
        {
            
            foreach (MenuItem menuItem in menu)
            {
                if(menuItem.Name = name)
                {
                    return "Available";
                }
                else
                {
                    return "This item is currently unavailable";
                }
            }

        }
        public static string fulfillOrder()
        {
            if (orders.Count > 0)
            {
                string item = orders[0];
                orders.RemoveAt(0);
                return "The " + item + " is ready!";
            }
            else
            {
                return "All orders have been fulfilled!";
            }
        }

        public static List<string> listOrders()
        {
            if (orders.Count > 0)
            {
                return orders;
            }
            else
            {
                return null;
            }
        }
        public static float dueAmount()
        {
            double sum = 0;
            foreach(MenuItem item in orders)
            {
                sum += item.price;
            }
            return sum;
        }
        public static string CheapestItem()
        {
            MenuItem cheapestItem = null;
            int cheapestPrice = int.MaxValue;

            foreach (MenuItem item in menu)
            {
                if (item.Price < cheapestPrice)
                {
                    cheapestItem = item;
                    cheapestPrice = item.Price;
                }
            }

            if (cheapestItem != null)
            {
                return cheapestItem.Name;
            }
            else
            {
                return "No items found in the menu.";
            }
        }
        public static List<string> drinksOnly()
        {
            List<string> drinks = menu.Where(item => item.Type == "Drink").Select(item => item.Name).ToList();
            return drinks;
        }

        public static List<string> foodOnly()
        {
            List<string> food = menu.Where(item => item.Type == "Food").Select(item => item.Name).ToList();
            return food;
        }

        public static int IntegerValidation()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
            {
                Console.WriteLine("Enter integer: ");
            }
            return number;
        }
    }
}
