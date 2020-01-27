using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Function to calculate sum of two numbers");
            Console.WriteLine("Enter first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("The sum of two number is {0}",Sum(a,b));
        }
        static int Sum(int a,int b)
        {
            int sum = 0;
            sum = a + b;
            return sum;
        }
    }
}
