using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program to accept two integers and check whether they are equal or not.
            Console.WriteLine("Enter No");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter No");
            int b = int.Parse(Console.ReadLine());
            if (a==b)
            {
                Console.WriteLine("Both values are equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
            Console.ReadKey();
        }
    }
}
