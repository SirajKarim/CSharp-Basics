using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_practice
{
    class Program
    {
        // return type and paramaeter example
        static void Main()
        {
            int max = Findmax(10,20);
            Console.WriteLine("Max no is {0}",max);
        }
        static int Findmax(int num1,int num2)
        {
            
            int result;
            if (num1>num2)
            {
                result = num1;
            }
            else
            {
                result = num2;
            }
            return result;
           
        }
    }
}
