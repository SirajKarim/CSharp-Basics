using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_K
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int r = 0; r < 6; r++)
            {
                for (int s = 5; s < r; s--)
                {
                    Console.Write("*"); 
                }
                Console.WriteLine();
            }
        }
    }
}
