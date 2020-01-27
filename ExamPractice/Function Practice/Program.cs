using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Practice
{
    class Program
    {
        static void acceptdetails()
        {
            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Father Name");
            string father = Console.ReadLine();
            Console.WriteLine("Enter your age");
           var age = Console.ReadLine();
            Console.WriteLine("Enter Your City");
            string city = Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            acceptdetails();
        }
    }
}
