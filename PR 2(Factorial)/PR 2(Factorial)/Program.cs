using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_2_Factorial_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number For finding factorial");
            int inputno = int.Parse(Console.ReadLine());
            int fact = inputno;
            for (int i = 0; i < inputno; i++)
            {
                fact = inputno * i;
            }
            Console.WriteLine("Factorial of your no is:"+fact);
        }
    }
}
