using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=int.Parse(Console.ReadLine());
            int[,]array=new int [a,a];
            for (int r = 0; r < a; r++)
            {
                for (int c = 0; c < a; c++)
                {
                    array[r, c] = int.Parse(Console.ReadLine());
                }
                
            }
            for (int r = 0; r < a; r++)
            {
                Console.WriteLine();
                for (int c = 0; c < a; c++)
                {
                    Console.Write("   "+array[r,c]);
                }
                Console.WriteLine();
            }

            int b = int.Parse(Console.ReadLine());
            int[,] array1 = new int[b, b];
            for (int r = 0; r < b; r++)
            {
                for (int c = 0; c < a; c++)
                {
                    array[r, c] = int.Parse(Console.ReadLine());
                }

            }
            for (int r = 0; r < b; r++)
            {
                Console.WriteLine();
                for (int c = 0; c < b; c++)
                {
                    Console.Write("   " + array1[r, c]);
                }
                Console.WriteLine();
            }
            int[,]arrray2=new int[a];
        }
    }
}