using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace table
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program in C# Sharp to display the multiplication table of a given integer.
            int mult = 0;
            Console.WriteLine("Enter No of Table");
            int tableNo = int.Parse(Console.ReadLine());
            for (int i = 1; i <=10; i++)
            {
                mult = tableNo * i;
                Console.WriteLine(tableNo+"* "+i+"="+mult);
            }
            Console.ReadKey();
        }
    }
}
