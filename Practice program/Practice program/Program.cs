using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input No");
            int[] arr = new int[10];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                for (int j = 2; j < 20; j++)
                {
                    Console.WriteLine(arr[i]+j);
                }
            }
        }
    }
}
