using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattren_practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program in C# Sharp to display the pattern like right angle triangle with a number
            Console.WriteLine("Enter No of Rows Do You Want to Know");
            int rows = int.Parse(Console.ReadLine());
            for (int r = 1; r <= rows; r++)
            {
                for (int c = 1; c <= r; c++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
            
        }
    }
}
