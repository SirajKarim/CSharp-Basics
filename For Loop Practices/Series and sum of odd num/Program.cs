using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series_and_sum_of_odd_num
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program in C# Sharp to display the n terms of odd natural number and their sum 
            int i, n, sum = 0;
            Console.Write("\n\n");
            Console.Write("Display the sum of n odd natural number:\n");
            Console.Write("------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe odd numbers are :");
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", 2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.Write("\nThe Sum of odd Natural Number upto {0} terms : {1} \n", n, sum);
        }
    }
}
