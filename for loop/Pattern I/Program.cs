using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_I
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int j = 0; j < 6; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.Write("  *");
                }
                Console.WriteLine();
            }
            for (int j = 0; j < 6; j++)
            {
                Console.Write("*");
            } Console.WriteLine();
        }
    }
}
