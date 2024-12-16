using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to Define a class Salary which will contain member
//variable Basic, TA, DA, HRA. Write a program using Constructor with default
//values for DA and HRA and calculate the salary of employee.
namespace Lab_2
{
    internal class Salary
    {
        public double Basic;
        public double TA;
        public double DA;
        public double HRA;

        public Salary(double basic, double tA, double dA = 3000, double hRA = 3000)
        {
            Basic = basic;
            TA = tA;
            DA = dA;
            HRA = hRA;
        }
        public double CalculateSalary()
        {
            return Basic+TA+DA+HRA;
        }

        public void GetSalaryDetails()
        {
            Console.WriteLine("Basic salary"+Basic);
            Console.WriteLine("TA salary" + TA);
            Console.WriteLine("DA salary" + DA);
            Console.WriteLine("Basic salary" + Basic);
        }
    }
}
