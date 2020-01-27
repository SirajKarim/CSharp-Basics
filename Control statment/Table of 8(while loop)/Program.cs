using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table_of_8_while_loop_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, res, num1;
            i = 1;
            num1 = int.Parse(Console.ReadLine());
            while (i<=10)
            {
                res = num1 * i;
                Console.WriteLine("{0}*{1}={2}",num1,i,res);
                i++;
            }
            Console.ReadLine();
        }
    }
}
