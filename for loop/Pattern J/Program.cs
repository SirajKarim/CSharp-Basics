using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_J
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 6; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    Console.Write("     *");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 4; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
