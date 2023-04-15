using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace week1
{
    class Program
    {
        static void Main(string[] args)
        {

            int minOrders = 5;
            double minOrderPrice = 20;
            string eligibleCustomers = GetEligibleCustomers(minOrders, minOrderPrice);
            Console.WriteLine(eligibleCustomers);
        }

        static string GetEligibleCustomers(int minOrders, double minOrderPrice)
        {
            string eligibleCustomers = "";
                string path = "C:\\Users\\HP\\source\\repos\\week1\\week1\\Customers.txt";
                if(File.Exists(path))
                {
                    StreamReader filevariable = new StreamReader(path);
                    string line;
                    while ((line = filevariable.ReadLine()) != null)
                    {
                        string[] customerInfo = line.Trim().Split();
                        string customerName = customerInfo[0];
                        int numOrders = int.Parse(customerInfo[1]);
                        double[] orderPrices = Array.ConvertAll(customerInfo[2].Trim('(', ')').Split(','), double.Parse);

                        if (numOrders >= minOrders && orderPrices.Any(price => price >= minOrderPrice))
                        {
                        eligibleCustomers += customerName;
                        }
                    }
                    
                }


            return " ";
        }
    }


}
