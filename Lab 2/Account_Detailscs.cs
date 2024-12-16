using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

//Write a program for implementing single inheritance which creates one
//class Account_Details for getting account information and another class
//Interest for calculating and displaying total interest from the data inserted
//                                                       from account details.
namespace Lab_2
{
    internal class Account_Detailscs
    {
        public int Account_Number;
        public string Account_Name;
        public double Balance;

     }
    class  Interest : Account_Detailscs
    {
        public void GetDataInterest()
        {
            Console.WriteLine("Enter a Account Number : ");
            Account_Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Account Name : ");
            Account_Name = Console.ReadLine();
            Console.WriteLine("Enter Balance");
            Balance = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayInterest()
        {
            Console.WriteLine("Total Interest = "+ Balance);        
        }
    }
}
