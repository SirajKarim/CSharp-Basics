using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_paractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 1;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(k++);
                }
                Console.WriteLine();
            }
        }
    }
}
