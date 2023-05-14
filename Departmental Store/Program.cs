using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using Departmental_Store.BL;
using System.Security.Cryptography;

namespace DepartmentalStore
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Product> products = new List <Product> ();
            products.Add (new Product ());
            products[0].AddProduct(products[0]);
        }
        


    }
}