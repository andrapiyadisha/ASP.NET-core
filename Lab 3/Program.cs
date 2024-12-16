using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //        --------------1------------------
            Console.WriteLine("Enter a number 1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number 2");
            int b = int.Parse(Console.ReadLine());
            try
            {
                int ans = a / b;
                Console.WriteLine("Answer is : " + ans);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            //--------------2------------------
            int[] array = new int[5];
            try
            {
                foreach (int i in array)
                {
                    Console.WriteLine("enter" + i + " number ");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("exception was handled");
            }

            //---------3--------------

            Calculate calc = new Calculate();

            Console.WriteLine("Sum of 5 and 10: " + calc.SumOfTwo(5, 10));
            Console.WriteLine("Sum of 3, 6, and 9: " + calc.SumOfThree(3, 6, 9));

            //---------------4------------------ -
            Result r = new Result();

            Console.WriteLine("addtion is " + r.Addition(1, 2));
            Console.WriteLine("substraction is " + r.Subtraction(1, 2));

            //----------------5------AND-------6-------------------
            //string a = "Disha";
            //string b = "Andrapiya";

            //Console.WriteLine("Lower case " + a.ToLower());
            //Console.WriteLine("upper case " + a.ToUpper());
            //Console.WriteLine("concat of to sting is " + (a + b));
            //Console.WriteLine("substring is " + a.Substring(1));
            //Console.WriteLine("index of string is " + a.IndexOf('s'));
            //Console.WriteLine("string is equals or not : " + a.Equals(b));

            //------------7----------------------
            displayShape s = new displayShape();
            Console.WriteLine("circle area is " + s.circle(1));
            Console.WriteLine("square area is " + s.square(2));
            Console.WriteLine("triangle area is " + s.triangle(3, 4));

            //----------8-------------
            try
            {
                Console.Write("enter integer number : ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n % 2 != 0)
                {
                    throw new Exception("enter number is not even");
                }
                Console.WriteLine("enter number is even");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            //-----------10----------------
            Console.Write("Enter a character: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (char.IsLetter(c))
            {
                if (char.IsUpper(c))
                {
                    char lower = char.ToLower(c);
                    Console.WriteLine($"The lowercase of '{c}' is '{lower}'.");
                }
                else
                {
                    char upper = char.ToUpper(c);
                    Console.WriteLine("The uppercase of " + c + " is " + upper);
                }
            }
            else
            {
                Console.WriteLine("The entered character is not a letter.");
            }

            //------------------9----------------------

            Console.WriteLine("Enter a string:");
            string sentence = Console.ReadLine();

            string longestWord = "";
            foreach (string word in sentence.Split(' '))
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }

            Console.WriteLine("The longest word is: " + longestWord);

        }
    }
}
