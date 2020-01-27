using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax_calculation__using_if_else_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("     Enter you Depoist Money");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input==10000)
            {
                int tax = (input*5)/100;
                Console.WriteLine("Your tax is:"+input+"Rs");
            }
            else if (input>10000||input<100000)
            {
                int tax = (input * 8) / 100;
                Console.WriteLine("Your tax is:" + input + "Rs");

            }
            else if (input > 100000)
            {
                Double tax = (input*8.5)/100;
                Console.WriteLine("Your tax is:" + input + "Rs");
            }
            Console.ReadLine();
        }
    }
}
