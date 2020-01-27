using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simleReverse_program
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]rev ={10,20,30,40,50,60};
            Array.Reverse(rev);
            for (int i = 0; i < rev.Length; i++)
            {
                Console.WriteLine(rev[i]);
            }
            Console.ReadKey();
        }
    }
}
