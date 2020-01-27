using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table_of_2_Using_While_Loop_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Table of 2 Using While loop
            int inputNo,i, res;
            Console.WriteLine("Enter a Number");
            inputNo = Convert.ToInt32(Console.ReadLine());
             i = 1;       //Initializing i
            while (i<=10)
            {
                res=inputNo*i;
                Console.WriteLine("{0}*{1}={2}",inputNo,i,res);
                i++;
            }
            Console.ReadLine();



 
        }
    }
}
