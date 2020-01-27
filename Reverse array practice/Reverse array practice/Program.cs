using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_array_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new[] { 10, 20, 30, 40, 50 };
            Array.Reverse(arr);
            Console.WriteLine(arr);
        }
    }
}
