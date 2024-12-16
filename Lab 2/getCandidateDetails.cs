using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    internal class getCandidateDetails
    {
        //1. Write a program to create a class named Candidate with ID, Name, Age,
        //Weight and Height as data members & also create a member functions like
        //GetCandidateDetails() and DisplayCandidateDetails(). 
        int id;
        string name;
        int age;
        double weight;
        double height;

        public void getCandDetails()
        {
            Console.WriteLine("Enter a candidate Id : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a candidate Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter a candidate age : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a candidate weight : ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a candidate height : ");
            height = Convert.ToDouble(Console.ReadLine());

        }
        public void displayCandidateDetails()
        {
            Console.WriteLine("Candidate ID is " + id);
            Console.WriteLine("Candidate NAME is " + name);
            Console.WriteLine("Candidate AGE is " + age);
            Console.WriteLine("Candidate WEIGHT is " + weight);
            Console.WriteLine("Candidate HEIGHT is " + height);
        }
    }
}
