using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_c
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display the pattern like 'C' with an asterisk:
            for (int r = 1; r <=2; r++)
            {
                for (int c = 1; c <=5; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int c = 1; c <= 5; c++)
            {
                Console.WriteLine("*");
            }
            for (int r = 1; r <= 2; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
