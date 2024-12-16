using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    interface Gross
    {
        void Gross_sal();
    }
    class Salary1 : Gross
    {
        public double HRA;
        public double TA;
        public double DA;
        public double BasicSalary;
        public Salary1(double hra, double ta, double da, double basicSalary)
        {
            HRA = hra;
            TA = ta;
            DA = da;
            BasicSalary = basicSalary;
        }

        public void Gross_sal()
        {
            double totalSalary = BasicSalary + HRA + TA + DA;
            Console.WriteLine("Gross Salary: " + totalSalary);
        }

        public void Disp_sal()
        {
            Console.WriteLine($"Basic Salary: {BasicSalary}");
            Console.WriteLine($"HRA: {HRA}");
            Console.WriteLine($"TA: {TA}");
            Console.WriteLine($"DA: {DA}");
        }
    }
    class Employee : Gross
    {
        public string Name;

        public Employee(string name)
        {
            Name = name;
        }

        public void Gross_sal()
        {
            Console.WriteLine($"Employee Name: {Name}");
            
        }
    }


}
