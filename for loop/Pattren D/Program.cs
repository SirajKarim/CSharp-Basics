using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattren_D
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display the pattern like 'D' with an asterisk:
            for (int r = 1; r <=1; r++)
            {
                for (int c = 1; c <=5; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= 2; c++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int r = 1; r <= 1; r++)
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
