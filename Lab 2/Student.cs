using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Lab_2;

//Write a program with following specifications:
//Class Name: Student
//Data Members: Enrollment_No, Student_Name, Semester, CPI and SPI
//Get Students Details using constructor and DisplayStudentDetails() using
//member function.

namespace Lab_2
{
    internal class Student
    {
        public int Enrollment_No;
        public string Student_Name;
        public int Semester;
        public double CPI;
        public double SPI;

        public Student(int enrollment_No, string student_Name, int semester, double cPI, double sPI)
        {
            Enrollment_No = enrollment_No;
            Student_Name = student_Name;
            Semester = semester;
            CPI = cPI;
            SPI = sPI;
        }
        public void DisplayStudentDetails()
        {
            Console.WriteLine("Student Enrollment number = " + Enrollment_No);
            Console.WriteLine("Student Name = " + Student_Name);
            Console.WriteLine("Student Semester = " + Semester);
            Console.WriteLine("Student CPI = " + CPI);
            Console.WriteLine("Student SPI = " + SPI);
        }
    }
}
