using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departmental_Store.BL
{
    class Product
    {
        public Product()
        {
            name = "Apple";
            Category = "Fresh Fruits";
            Price = 30F;
            Stock_Quantity = 30;
            Min_Stock_Quantity = 10;

        }
        public string name;
        public string Category;
        public float Price;
        public int Stock_Quantity;
        public int Min_Stock_Quantity;
        public float salesTax;
        public void AddProduct(Product product)
        {
            product.name = Console.ReadLine();
            product.Category = Console.ReadLine();
            product.Price = float.Parse(Console.ReadLine());
            product.Min_Stock_Quantity = int.Parse(Console.ReadLine());
            product.Stock_Quantity = int.Parse(Console.ReadLine());
        }
        public void ViewProducts()
        {

        }




    }
}
