using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    abstract class Calculate1
    {
        public abstract int Addition(int a, int b);
        public abstract int Subtraction(int a, int b);
    }

    class Result : Calculate1
    {
        public override int Addition(int a, int b)
        {
            return a + b;
        }

        public override int Subtraction(int a, int b)
        {
            return a - b;
        }
    }
}
