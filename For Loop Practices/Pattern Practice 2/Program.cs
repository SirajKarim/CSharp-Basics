using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program in C# Sharp to make such a pattern like right angle triangle with a number which will repeat a number in a row.
            Console.WriteLine("Enter No ofRows do you want");
            int rows = int.Parse(Console.ReadLine());
            for (int r = 1; r <= rows; r++)
            {
                for (int c = 1; c <=r; c++)
                {
                    Console.Write(r);
                }
                Console.WriteLine();
            }
        }
    }
}
