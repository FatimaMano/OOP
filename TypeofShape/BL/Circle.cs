using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeofShape.BL
{
    class Circle : Shape
    {
        private double radius;
        public Circle(string type, double radius) : base(type)
        {
            this.radius = radius;
        }
    }
}
