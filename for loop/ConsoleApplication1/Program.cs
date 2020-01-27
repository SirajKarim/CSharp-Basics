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
            //A Pattren
            for (int r = 1; r <= 1; r++)
            {
                for (int c = 1; c <= 3; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int r = 1; r <= 2; r++)
            {
                for (int c = 1; c <= 2; c++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int r = 1; r <= 1; r++)
            {
                for (int c = 1; c <= 3; c++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (int r = 1; r <= 4; r++)
            {
                for (int c = 1; c <= 2; c++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}