﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volume_Of_Cylinder.BL
{
    class Cylinder : Circle
    {
        private double height;
        public Cylinder()
        {
            height = 1.0;
        }
        public Cylinder(double radius) : base(radius)
        {
        }
        public Cylinder(double radius, double height) : base(radius)
        {
            this.height = height;
        }
        public Cylinder(double radius, double height,string color) : base(radius,color)
        {
            this.height = height;
        }
        public double getHeight()
        {
            return height;
        }
        public void setHeight(double height)
        {
            this.height = height;
        }
        public double getVolume()
        {
            return getArea() * height;
        }


    }
}
