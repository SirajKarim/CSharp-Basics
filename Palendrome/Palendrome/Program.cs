using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palendrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your words");
            string a = Console.ReadLine();
            string b = new string(a.Reverse().ToArray());
            if (a==b)
            {
                Console.WriteLine("Pallendrome");
            }
            else
            {
                Console.WriteLine("No Pallendrome");
                Console.WriteLine(b);
            }
        }
    }
}
