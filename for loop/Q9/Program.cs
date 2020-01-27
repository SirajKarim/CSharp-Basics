using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9
{
    class Program
    {
        static void Main(string[] args)
        {
           // Write a program in C# Sharp to display the pattern like right angle triangle using an asterisk.
            for (int i = 0; i <6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            ////write a program to calculate sum of n series
            //Console.WriteLine("Enter NO");
            //int a=int.Parse(Console.ReadLine());
            //int sum = 0;
            //for (int i = 1; i <= a; i++)
            //{
            // Console.Write(i);
            // sum = sum + i;

            //}
            //Console.WriteLine("sum of series is"+sum);
            //Console.WriteLine();

        }
    }
}
