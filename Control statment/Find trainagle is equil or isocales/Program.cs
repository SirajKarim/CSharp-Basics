using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_trainagle_is_equil_or_isocales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Length2");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Length3");
            int c = int.Parse(Console.ReadLine());
            if (a == b && a == c )
            {
                Console.WriteLine("Equilatoral");
            }
            else if (a != b && a == c || a != c&&a==b)
            {
                Console.WriteLine("Isocales");
            }
        }
    }
}
