using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_E
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display the pattern like 'E' with an asterisk:
            for (int r = 0; r < 1; r++)
            {
                for (int c = 0; c < 6; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int c = 0; c < 3; c++)
            {
                Console.WriteLine("*");
            }
            for (int r = 0; r < 1; r++)
            {
                for (int c = 0; c < 6; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int c = 0; c < 3; c++)
            {
                Console.WriteLine("*");
            }
            for (int r = 0; r < 1; r++)
            {
                for (int c = 0; c < 6; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
