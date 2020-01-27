using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_n_series
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter Length of the Series");
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                sum = sum + i;
            }
            for (int i = 1; i <= input; i++)
            {
                Console.Write(i+", ");
            }
            Console.WriteLine();
            Console.WriteLine("The Sum of Series is   " + sum);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
