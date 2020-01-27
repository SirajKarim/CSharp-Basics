using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_n_num
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no to find sum of n No");
            int inputSum = Convert.ToInt32(Console.ReadLine());
            int sum = inputSum;
            for (int j = 1; j < inputSum; j++)
            {
                sum = sum + j;
            }
            Console.WriteLine("Sum of no is:"+sum);
            Console.Write("\n");
        }
    }
}
