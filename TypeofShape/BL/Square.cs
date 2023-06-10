using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeofShape.BL
{
    class Square : Shape
    {
        private double side;
        public Square(string type, double side) : base(type)
        {
            this.side = side;
        }
    }
}
