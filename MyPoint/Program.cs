using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.IO;
using BoundaryProject.BL;
using GameObjectProject.BL;
using MyPoint.BL;
using System.Diagnostics;

namespace MyPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] triangle = new char[,]
{
    { '*', ' ', ' ', ' ', ' ' },
    { '*', '*', ' ', ' ', ' ' },
    { '*', '*', '*', ' ', ' ' },
    { '*', '*', '*', '*', ' ' },
    { '*', '*', '*', '*', '*' }
};
            char[,] triangle = new char[,]
            {
    { ' ', ' ', ' ', ' ', '*' },
    { ' ', ' ', ' ', '*', '*' },
    { ' ', ' ', '*', '*', '*' },
    { ' ', '*', '*', '*', '*' },
    { '*', '*', '*', '*', '*' }
            };
            Boundary b = new Boundary(new Point(0, 0), new Point(0, 90), new Point(90, 0), new Point(90, 90));
            
        }
    }
}