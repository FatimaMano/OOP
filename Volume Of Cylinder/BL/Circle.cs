using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volume_Of_Cylinder.BL
{
    class Circle
    {
        protected double radius;
        protected string color;
        public Circle()
        {
            radius = 1.0;
            color = "red";
        }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }
        public double getRadius()
        {
            return radius;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }
        public String getColor()
        {
            return color;
        }
        public void setColor(string color)
        {
            this.color = color;
        }
        public double getArea()
        {
            return 3.14 * radius * radius;
        }
        public string toString()
        {
            return "Circle[radius = " + radius + ", color = " + color;
        }
    }
}
