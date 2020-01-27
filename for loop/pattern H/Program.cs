using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_H
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print Pattern of H
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("*    ");
                }
                Console.WriteLine();
            }
            for (int i = 1; i < 7; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("*    ");
                }
                Console.WriteLine();
            }
        }
    }
}
