using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            getCandidateDetails p1 = new getCandidateDetails();
            p1.getCandDetails();
            p1.displayCandidateDetails();

            Staff[] p2 = new Staff[5];
            for (int i = 0; i < p2.Length; i++)
            {
                Console.WriteLine($" Enter Starf member {i + 1} : ");
                p2[i] = new Staff();
                p2[i].getStaffDetails();
            }
            Console.WriteLine("Details of Staffs:");
            foreach (var staff in p2)
            {
                if (staff.Designation.Equals("HOD"))
                {
                    Console.WriteLine($"Name: {staff.name}, Salary: {staff.Salary:C}");
                }
                else
                {
                    staff.displayStaffDetails();
                }
            }

            Bank_Account p3 = new Bank_Account();
            p3.GetAccountDetails();
            p3.DisplayAccountDetails();
            Student p4 = new Student(1234567, "Disha", 4, 9.34, 9.05);
            p4.DisplayStudentDetails();

            Area p5 = new Area(12, 25);
            //p5.getAreaOfRectangel();

            Interest p6 = new Interest();
            p6.GetDataInterest();
            p6.DisplayInterest();

            Console.Write("Enter Basic Salary: ");
            double basic = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter TA : ");
            double ta = Convert.ToDouble(Console.ReadLine());
            Salary p7 = new Salary(basic, ta);
            p7.GetSalaryDetails();
            p7.CalculateSalary();

            Console.WriteLine("Enter Distance 1");
            double dist1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Distance 2");
            double dist2 = double.Parse(Console.ReadLine());

            Distance p8 = new Distance(dist1, dist2);
            p8.CalculateDist();
            p8.GetDistance();

            Console.Write("Enter material of the table: ");
            string material = Console.ReadLine();

            Console.Write("Enter price of the table: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height of the table (in meters): ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter surface area of the table (in square meters): ");
            double surfaceArea = Convert.ToDouble(Console.ReadLine());

            Table table = new Table(material, price, height, surfaceArea);

            Console.WriteLine("Table Details:");
            table.DisplayTableDetails();


            Salary1 salary = new Salary1(hra: 5000, ta: 2000, da: 3000, basicSalary: 20000);

            Employee employee = new Employee("Disha Andrapiya");

            salary.Gross_sal();
            salary.Disp_sal();
            employee.Gross_sal();
        }
    }
}
