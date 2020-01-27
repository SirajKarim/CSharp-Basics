using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Right_angle__
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program in C# Sharp to display the pattern like right angle triangle using an asterisk.
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                
            }
        }
    }
}
