using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeofShape.BL
{
    class Rectangle : Shape
    {
        private double height;
        private double width;
        public Rectangle(string type, double height,double width): base(type)
        {
            this.height = height;
            this.width = width;
        }
        public double  getHeight()
        {
            return height;
        }
        public void setHeight(double height)
        {
            this.height = height;
        }
        public double getWidth()
        {
            return width;
        }
        public void setWidth(double width)
        {
            this.width = width;
        }
    }
}
