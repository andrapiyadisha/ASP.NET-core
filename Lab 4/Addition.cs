using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program using method overloading by changing datatype of
//arguments to perform addition of two integer numbers and two float
//numbers.
namespace Lab_4
{
    internal class Addition
    {
        public int Add(int n1, int n2)
        {
            return n1 + n2;
        }

        public float Add(float n1, float n2)
        {
            return n1 + n2;
        }
    }
}
