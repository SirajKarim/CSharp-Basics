using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No_is_posi_or_nega
{
    class Program
    {
        static void Main(string[] args)
        {
           // Write a C# Sharp program to check whether a given number is positive or negative.
            Console.WriteLine("Enter Numbr");
            int input = int.Parse(Console.ReadLine());
            if (input<0)
            {
                Console.WriteLine("No is Negative");
            }
            else
            {
                Console.WriteLine("No is positive");
            }
            Console.ReadKey();
        }
    }
}
