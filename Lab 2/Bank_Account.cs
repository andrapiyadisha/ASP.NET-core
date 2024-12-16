using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_2
{
    internal class Bank_Account
    {
        public int Account_No;
        public String Email;
        public String User_Name;
        public String Account_Type;
        public Double Account_Balance;

        public void GetAccountDetails()
        {
            Console.WriteLine("Enter a Account Number : ");
            Account_No = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Email : ");
            Email = Console.ReadLine();
            Console.WriteLine("Enter a User Name : ");
            User_Name = Console.ReadLine();
            Console.WriteLine("Enter a Account Type : ");
            Account_Type = Console.ReadLine();
            Console.WriteLine("Enter a Account Balance : ");
            Account_Balance = Convert.ToDouble(Console.ReadLine());

        }
        public void DisplayAccountDetails()
        {
            Console.WriteLine("Account Number is " + Account_No);
            Console.WriteLine("Email is " + Email);
            Console.WriteLine("User Name is " + User_Name);
            Console.WriteLine("Account Type is " + Account_Type);
            Console.WriteLine("Account Balance is " + Account_Balance);
        }
    }
}
