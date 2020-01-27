using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5_q1_
{
    class Program
    {
        static void Main(string[] args)
        {
            //without user input
            for (int i = 0; i < 5; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                    Console.Write("#");   
                }
                Console.WriteLine();
            }

            //with user input
            Console.WriteLine("Enter no of rows");
            int norows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no hashs do yo want");
            int hashno = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < norows; i++)
            {
                for (int j = 0; j < hashno; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
