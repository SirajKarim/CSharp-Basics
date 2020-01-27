using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swictch_Case__Corresponding_days_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your option for days: 1 for Monday:");
            int inputNo = Convert.ToInt32(Console.ReadLine());
            switch (inputNo)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again\n");
                    break;
            }
         
        }
    }
}
