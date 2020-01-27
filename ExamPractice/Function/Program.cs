using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function
{
    class Program
    {
        static int Sum()
        {
            Console.WriteLine("Input No1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input No2");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            return c;
        }
        static void Main(string[] args)
        {
            int d = Sum();
            Console.WriteLine(d);
        }
    }
}
