using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;

namespace Lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------1----------------------

            //ArrayList studentNames = new ArrayList();

            //studentNames.Add("Disha");
            //studentNames.Add("Drashti");
            //studentNames.Add("Rajvi");
            //studentNames.Add("Vritti");
            //studentNames.Add("Dharashvi");
            //studentNames.Add("Rajvi");
            //studentNames.Add("Vritti");
            //studentNames.Add("Dharashvi");

            //studentNames.RemoveAt(3);
            //Console.WriteLine("StudentNamde after removing");
            //foreach (var student in studentNames)
            //{
            //    Console.WriteLine(student);
            //}
            //studentNames.RemoveRange(2,3);
            //Console.WriteLine("StudentNamde after removRange");

            //foreach (var student in studentNames)
            //{
            //    Console.WriteLine(student);
            //}
            //studentNames.Clear();
            //Console.WriteLine("StudentNamde after Clear");

            //foreach (var student in studentNames)
            //{
            //    Console.WriteLine(student);
            //}


            //-------------------------2-------------------------



            //List<String> StudentName = new List<String>();

            //StudentName.Add("Disha");
            //StudentName.Add("Drashti");
            //StudentName.Add("Rajvi");
            //StudentName.Add("Vritti");
            //StudentName.Add("Dharashvi");
            //StudentName.Add("Darsh");
            //StudentName.Add("Vivek");
            //StudentName.Add("Shruti");

            //StudentName.Remove("Darsh");

            //Console.WriteLine("Student After Remove");
            //foreach (String s in StudentName)
            //{
            //    Console.WriteLine(s);
            //}

            //StudentName.RemoveRange(0, 1);

            //Console.WriteLine("Student After RemoveRange");
            //foreach (String s in StudentName)
            //{
            //    Console.WriteLine(s);
            //}

            //StudentName.Clear();

            //Console.WriteLine("Student After Clear");
            //foreach (String s in StudentName)
            //{
            //    Console.WriteLine(s);
            //}

            //-------------------3--------------------

            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);
            //stack.Push(6);

            //Console.WriteLine("Show All Element");

            //foreach (int i in stack)
            //{
            //    Console.WriteLine(i);
            //}

            //int popItm = stack.Pop();
            //Console.WriteLine("Pop index is = "+popItm);
            //stack.Push(7);
            //Console.WriteLine("Show All Element after pop");

            //foreach (int i in stack)
            //{
            //    Console.WriteLine(i);
            //}


            //stack.Peek();
            //Console.WriteLine("Show All Element after Peek");

            //foreach (int i in stack)
            //{
            //    Console.WriteLine(i);
            //}

            //stack.Contains(1);
            //Console.WriteLine("Show All Element after Contains");

            //foreach (int i in stack)
            //{
            //    Console.WriteLine(i);
            //}
            //stack.Clear();
            //Console.WriteLine("Show All Element after Clear");

            //foreach (int i in stack)
            //{
            //    Console.WriteLine(i);
            //}

            //---------------4-----------------
            //Queue<int> q = new Queue<int>();

            //q.Enqueue(1);
            //q.Enqueue(2);
            //q.Enqueue(3);
            //q.Enqueue(4);
            //q.Enqueue(5);
            //q.Enqueue(6);
            //q.Enqueue(7);

            //Console.WriteLine("Show All Element");

            //foreach (int i in q)
            //{
            //    Console.WriteLine(i);
            //}

            //int popItm = q.Dequeue();
            //Console.WriteLine("Pop index is = " + popItm);
            //Console.WriteLine("Show All Element after pop");

            //foreach (int i in q)
            //{
            //    Console.WriteLine(i);
            //}


            //q.Peek();
            //Console.WriteLine("Show All Element after Peek");

            //foreach (int i in q)
            //{
            //    Console.WriteLine(i);
            //}

            //q.Contains(1);
            //Console.WriteLine("Show All Element after Contains");

            //foreach (int i in q)
            //{
            //    Console.WriteLine(i);
            //}
            //q.Clear();
            //Console.WriteLine("Show All Element after Clear");

            //foreach (int i in q)
            //{
            //    Console.WriteLine(i);
            //}

            //----------------------------------5--------------------------

            //Dictionary<int, String> dic = new Dictionary<int, String>();

            //dic.Add(1, "Disha");
            //dic.Add(2, "Darsh");
            //dic.Add(3, "Darshti");
            //dic.Add(4, "Shruti");
            //dic.Add(5, "Vritti");
            //dic.Add(6, "Rajvi");

            //Console.WriteLine("Dictionary all is ");
            //foreach (var item in dic)
            //{
            //    Console.WriteLine("Dictonary  = " + item);
            //}

            //dic.Remove(1);
            //Console.WriteLine("Dictionary after remove is ");
            //foreach (var item in dic)
            //{
            //    Console.WriteLine("Dictonary  = " + item);
            //}

            //dic.ContainsKey(3);
            //Console.WriteLine("Dictionary Index is ");
            //foreach (var item in dic)
            //{
            //    Console.WriteLine("Dictonary index = " + item);
            //}

            //dic.ContainsValue("Disha");
            //dic.Clear();

            //---------------------6-----------------------

            Hashtable ht = new Hashtable();
            ICollection keys = ht.Keys;
            ht.Add(1, "Disha");
            ht.Add(2, "Darsh");
            ht.Add(3, "Dharashvi");
            ht.Add(4, "Drashti");


            ht.Remove(1);
            Console.WriteLine("Dictionary after remove is ");
            foreach (var item in keys)
            {
                Console.WriteLine("Dictonary  = " + ht[item]);
            }

            bool containKey = ht.ContainsKey(3);
            Console.WriteLine("Dictionary Index is " + containKey);


            bool containValue = ht.ContainsValue("Disha");
            ht.Clear();

            Console.ReadLine();
        }
    }
}
