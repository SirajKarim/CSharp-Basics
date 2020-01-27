using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Each_loop_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //here i am declare a array
            string[] arr=new string[6];         //here [6] is lenght of array
            arr[0] = "Siraj";
            arr[1] = "Talha";
            arr[2] = "Mohsin";
            arr[3] = "Abbas";
            arr[4] = "Bilal";
            arr[5] = "Ali Asim";
            foreach (string name in arr)
            {
                Console.WriteLine("Hello    ...."+name);
            }
            Console.ReadLine();
        }
    }
}
