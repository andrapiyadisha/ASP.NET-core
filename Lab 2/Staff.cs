using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    //Write a program to create a class Staff having data members as Name,
    //Department, Designation, Experience & Salary.Accept this data for 5
    //different staffs and display only names & salary of those staff who are
    //HOD.

    internal class Staff
    {
        public String name;
        public String Department;
        public String Designation;
        public String Experience;
        public String Salary;

        public void getStaffDetails()
        {
            Console.WriteLine("Enter a staff Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter a staff Department : ");
            Department = Console.ReadLine();
            Console.WriteLine("Enter a staff Designation : ");
            Designation = Console.ReadLine();
            Console.WriteLine("Enter a staff Experience : ");
            Experience = Console.ReadLine();
            Console.WriteLine("Enter a staff Salary : ");
            Salary = Console.ReadLine();

        }
        public void displayStaffDetails()
        {
            Console.WriteLine("staff ID Name " + name);
            Console.WriteLine("staff Department is " + Department);
            Console.WriteLine("staff Designation is " + Designation);
            Console.WriteLine("staff Experience is " + Experience);
            Console.WriteLine("staff Salary is " + Salary);
        }
    }
}
