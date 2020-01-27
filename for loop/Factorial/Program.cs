using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //factorial
            Console.WriteLine("Input No");
            int inputno = int.Parse(Console.ReadLine());
            int fact = inputno;
            for (int i = 0; i < 10; i++)
            {
                fact = inputno * i;
            }
            Console.WriteLine(fact);
        }
    }
}
