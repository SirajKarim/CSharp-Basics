using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabonaci_series
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fabonaci Series
            int a = 0;
            int b = int.Parse(Console.ReadLine());
            int c = 0;
            for (int i = 0; i < 10; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
            ////Fabonaci Series using while loop
            //int d = 0;
            //int a = 0;
            //int b = int.Parse(Console.ReadLine());
            //int c = 0;
            //while (d < 10)
            //{
            //    c = a + b;
            //    Console.WriteLine(c);
            //    a = b;
            //    b = c;
            //    d++;
            //}
        }
    }
}
