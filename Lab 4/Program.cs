using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Addition sum = new Addition();
            //Console.WriteLine("Enter First integer");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Second integer");
            //int n2 = Convert.ToInt32(Console.ReadLine());
            //int result = sum.Add(n1,n2);
            //Console.WriteLine("Result is "+result);

            //Console.WriteLine("Enter First Float");
            //float num1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Second Float");
            //float num2 = float.Parse(Console.ReadLine());
            //float result2 = sum.Add(num1, num2);
            //Console.WriteLine("Result is " + result2);

            //Area area = new Area();
            //Console.WriteLine("Enter side of square");
            //int side = Convert.ToInt32(Console.ReadLine());
            //int AreaSquare = area.CalculateArea(side);
            //Console.WriteLine("Area of Square is " + AreaSquare);

            //Console.WriteLine("Enter l of square");
            //int l = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter b of square");
            //int b = Convert.ToInt32(Console.ReadLine());
            //int AreaRectangel = area.CalculateArea(l, b);
            //Console.WriteLine("Area of Square is " + AreaRectangel);

            //HDFC hdfc = new HDFC();
            //SBI sbi = new SBI();
            //ICICI icici = new ICICI();

            //Console.WriteLine("Enter interest");
            //double i = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter rate");
            //double rHDFC = double.Parse(Console.ReadLine());
            //double rSBI = double.Parse(Console.ReadLine());
            //double rICICI = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter time");
            //int t = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Total interest of all banks is : ");
            //hdfc.CalculateInterest(i, rHDFC, t);
            //sbi.CalculateInterest(i, rSBI, t);
            //icici.CalculateInterest(i, rICICI, t);

            //Apollo apollo = new Apollo();
            //Wockhardt wockhardt = new Wockhardt();
            //Gokul_Superspeciality gokul = new Gokul_Superspeciality();

            //apollo.HospitalDetails();
            //wockhardt.HospitalDetails();
            //gokul.HospitalDetails();

            //Areas areas = new Areas();
            //Console.WriteLine("Enter side of square");
            //int side = Convert.ToInt32(Console.ReadLine());
            //int AreaSquare = areas.CalArea(side);
            //Console.WriteLine("Area of Square is " + AreaSquare);

            //Console.WriteLine("Enter l of square");
            //int l = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter b of square");
            //int b = Convert.ToInt32(Console.ReadLine());
            //int AreaRectangel = areas.CalArea(l, b);
            //Console.WriteLine("Area of Square is " + AreaRectangel);

            //Console.WriteLine("Enter radius of Circle");
            //double radius = double.Parse(Console.ReadLine());
            //double AreaCircle = areas.CalArea(radius);
            //Console.WriteLine("Area of Circle is " + AreaCircle);

            BankAccount details = new BankAccount("Disha", 100000.23);

            details.DisplayAccountDetails();

            details.Deposit(5000); 
            details.Deposit("CHK12345", 2000);

            details.Withdraw(3000);
            details.Withdraw("CHK54321", 1000);

            details.DisplayAccountDetails();

        }
    }
}
