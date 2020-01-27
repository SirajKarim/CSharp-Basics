using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace given_number_is_even_or_odd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a C# Sharp program to check whether a given number is even or odd.
            Console.WriteLine("Enter No");
            int input = int.Parse(Console.ReadLine());
            if (input%2==0)
            {
                Console.WriteLine("No is Even");                            
            }
            else if (input%2==1)
            {
                Console.WriteLine("No is odd");
            }
            Console.ReadKey();
        }
    }
}
