using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_begning
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Write a program in C# Sharp to store elements in an array and print it

            //array declaration
            int[]arr=new int[5];

            //taking stored in array through user input
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter Number :   ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            //printing numbers in array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Number in Element {0} is {1}",i,arr[i]);
            }
        }
    }
}
