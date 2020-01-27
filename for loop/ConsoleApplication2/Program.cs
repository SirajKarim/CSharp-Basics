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
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your father name");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter Your Phone No");
            int phn = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Address");
            string add = Console.ReadLine();
            Console.WriteLine("==============");
            Console.WriteLine("Your Complete Address:");
            Console.WriteLine("============\n");

            Console.WriteLine("Name = {0}", name);
            Console.WriteLine("City = {0}", fname);
            Console.WriteLine("Age = {0}", phn);
            Console.WriteLine("Pin = {0}", add);
            Console.WriteLine("===============");

            Console.ReadLine();
        }
    }
}
