using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Begning_practice
{
    class Program
    {
        //simple method function program
        static void write()
        {
            int a = 0;
            while (a<=20)
            {
                Console.WriteLine(a);
                a = a + 2;
            }
            
        }
        static void Main(string[] args)
        {
            write();
        }
    }
}
