using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builtan_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {25,23,21,24,22};
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            
        }
    }
}
