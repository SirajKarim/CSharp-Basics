using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_practice5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program in C# Sharp to print the Floyd's Triangle
            for (int i = 0; i <=6; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("0");
                    }
                    else
                    {
                        Console.Write("1");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
