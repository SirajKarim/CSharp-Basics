using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_and_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input%2==0)
            {
                Console.WriteLine("No is Even");
            }
            else if(input%2==1)
            {
                Console.WriteLine("No is odd");
            }
        }
    }
}
