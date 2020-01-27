using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace begning_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Qu2: Write a program to display student information. Accept Student’s name, Roll no, Age, class, and university name and display it on console.
            Console.WriteLine("Student Information");
            Console.WriteLine("Enter your Name");
            string sname = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Class");
            int cl = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your University Name");
            string uni = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("===============");
            Console.WriteLine("Name={0}", sname);
            Console.WriteLine("Age={0}", age);
            Console.WriteLine("Class={0}",cl);
            Console.WriteLine("Uni={0}", uni);
            Console.WriteLine("===============");
        }
    }
}
