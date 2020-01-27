using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace My_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int s = 0; s < i; s++)
                {
                    Console.WriteLine("+");
                }
            }
        }
    }
}
