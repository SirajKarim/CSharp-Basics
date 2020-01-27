using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace table_using_do_while_loop_
{
    class Program
    {
        static void Main(string[] args)
        {
            //write table of 12 using do while loop
            int table, i, res;
            i = 1;          //initializing i
            table = 12;     //initialize table of no
            do
            {
                res = table * i;
                Console.WriteLine("{0}*{1}={2}",table,i,res);
                i++;
            } 
            while (i<=10);
            Console.ReadLine();
        }
    }
}
