using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_arr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of Matrix");
            int n = int.Parse(Console.ReadLine());
            int[,] arr1 = new int[n, n];
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    arr1[r, c] = int.Parse(Console.ReadLine());
                }
            }
            for (int r = 0; r < n; r++)
            {
                Console.WriteLine();
                for (int c = 0; c < n; c++)
                {
                    Console.Write("  " + arr1[r, c]);
                }

            }
            Console.WriteLine();
            int[,] arr2 = new int[n, n];
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    arr2[r, c] = int.Parse(Console.ReadLine());
                }
            }
            for (int r = 0; r < n; r++)
            {
                Console.WriteLine();
                for (int c = 0; c < n; c++)
                {
                    Console.Write("  " + arr2[r, c]);
                }

            }
            Console.WriteLine();
            int[,] arr3 = new int[n, n];
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    arr3[r, c] = arr1[r, c] + arr2[r, c];
                }
            }
            for (int r = 0; r < n; r++)
            {
                Console.WriteLine();
                for (int c = 0; c < n; c++)
                {
                    Console.Write("  " + arr3[r, c]);
                }



            }
        }
    }
}