using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        public static void welcome(string name)
        {
            Console.WriteLine("Welcome friend " + name + " !");
        }
        public static void HaveAnice()
        {
            Console.WriteLine("Have a nice day!");
        }
        public static void Main(string[] args)
        {
            Console.Write("\n\nSee, how to create an user define function with parameters :\n");
            Console.Write("----------------------------------------------------------------\n");
            string str1;

            Console.Write("Please input a name : ");
            str1 = Console.ReadLine();
            welcome(str1);
            HaveAnice();
        }
    }
}
