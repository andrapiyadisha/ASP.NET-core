using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Write a program to print your name, address, contact number & city.
            //Console.WriteLine("Disha");
            //Console.WriteLine("150 feet rode Goverthan circal, SukhSagar Society");
            //Console.WriteLine("9972473423");
            //Console.WriteLine("Rajkot");


            //2.Write a program to get two numbers from user and print those two numbers.
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("A is " + a);
            //Console.WriteLine("B is " + b);

            //3.Write program to prompt a user to input his/ her name and country name and then output will be shown as 
            //    given: Hello<yourname> from country <countryname>
            //Console.WriteLine("Enter Your name");
            //String Name = Console.ReadLine();
            //Console.WriteLine("Enter your Country name");
            //String country = Console.ReadLine();
            //Console.WriteLine("Hello" +" "+ Name +" "+ "from country" +" "+ country);

            //4.Write a program to calculate the size of the area in square - feet based on
            //  Specified length and width.
            //Console.WriteLine("Enter a feet");
            //int feet1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter a feet");
            //int feet2 = Convert.ToInt32(Console.ReadLine());
            //int answer = feet1 * feet2;
            //Console.WriteLine("Area is " + answer + " square feet");

            ////5.Write a program to calculate area of Square, Rectangle and Circle
            //Console.WriteLine("Area of Rectangle");
            //Console.WriteLine("Enter a length");
            //int length = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter a width");
            //int width = Convert.ToInt32(Console.ReadLine());
            //int area = length * width;
            //Console.WriteLine("Area is " + area);
            //Console.WriteLine("Area of Circle");
            //Console.WriteLine("Enter a width");
            //int r = Convert.ToInt32(Console.ReadLine());
            //double area1 = 3.14 *r*r;
            //Console.WriteLine("Area is " + area1);
            //Console.WriteLine("Area of Square");
            //Console.WriteLine("Area of Square");
            //Console.WriteLine("Enter a ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //double area2 = a * a;
            //Console.WriteLine("Area is " + area2);

            //6.Write a program to calculate Celsius to Fahrenheit and vice - versa using
            //  function.
            //Console.WriteLine("Enter a f");
            //double f = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter a c");
            //double c = Convert.ToInt32(Console.ReadLine());
            //f = (c * 1.8) + 32;
            //c = (f-32)/1.8;
            //Console.WriteLine("Fahrenheit is " + f);
            //Console.WriteLine("Fahrenheit is " + c);

            //7. Write a program to find out Simple Interest using function. (I = PRN/100)
            //int p = Convert.ToInt32(Console.ReadLine());
            //double r = Convert.ToDouble(Console.ReadLine());
            //double n = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Simple Interest is " + (p * r * n) / 100);

            //8. Write a program to create a Simple Calculator for two numbers (Addition,
            //Multiplication, Subtraction, Division) [Also using if…else & Switch Case]
            //Console.WriteLine("Enter two number ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Operation which you want to perform");
            //String op = Console.ReadLine();
            //if (op == "+")
            //{
            //    Console.WriteLine(a + b);
            //} else if (op == "-")
            //{
            //    Console.WriteLine(a - b);
            //} else if (op == "*")
            //{
            //    Console.WriteLine(a * b);
            //} else if (op == "/")
            //{
            //    Console.WriteLine(a/b);
            //}
            //9. Write a program to Swapping without using third variable.
            Console.WriteLine("Enter two number ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swapping ");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("After Swapping");
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            //10.Write a program to find maximum numbers from given 3 numbers using
            //ternary operator.
            int n1 = 5, n2 = 10, max;

            max = (n1 > n2) ? n1 : n2;

            Console.WriteLine("Largest number between " +
                             n1 + " and " + n2 + " is " +
                                            max + ". ");


        }
    }
}
