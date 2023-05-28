using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPoint.BL
{
    class Point
    {
        public int x;
        public int y;

        // Default constructor
        public Point()
        {
            x = 0;
            y = 0;
        }

        // Parameterized constructor
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // Getter and setter for x
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        // Getter and setter for y
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        // Method to set both x and y
        public void SetXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

}
