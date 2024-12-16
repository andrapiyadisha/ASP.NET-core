using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Distance
    {
        public double dist1;
        public double dist2;
        public double dist3;

        public Distance(double dist1, double dist2)
        {
            this.dist1 = dist1;
            this.dist2 = dist2;
        }

        public void CalculateDist()
        {
            dist3 = dist1 + dist2;
        }

        public void GetDistance()
        {
            Console.WriteLine("Distance 1: " + dist1);
            Console.WriteLine("Distance 2: " + dist2);
            Console.WriteLine("Sum of Distances: " + dist3);
        }
    }
}
