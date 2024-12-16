using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to calculate area of a Rectangle using constructor.
namespace Lab_2
{
    internal class Area
    {
        public double l;
        public double b;
        public double area;

        public Area(double l, double b)
        {
            this.l = l;
            this.b = b;
        }

        public void GetAreaOfRectangel()
        {
            area = l * b;
            Console.WriteLine("Area of rectangel = " + area);
        }
    }
}
