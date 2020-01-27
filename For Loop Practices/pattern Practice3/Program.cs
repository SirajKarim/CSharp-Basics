using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_Practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int s = 4; s < i; s--)
                {
                    Console.Write(" ");
                }
                for (int c = 1; c <=i*2-1; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
    }
}
