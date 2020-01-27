using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_vowel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
        }
        static void newmethod(string name)
        {
           
            int count = 0;
            if (name=="a"||name=="e"||name=="i"||name=="o"||name=="u")
            {
                count++;

            }
        }
    }
}
