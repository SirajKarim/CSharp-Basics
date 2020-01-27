using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mthod
{
    class Program
    {
        static void Main()
        {
            Evennumbers(30);
            int sum = Add(40,40);
            Console.WriteLine(sum);
        }
        static int Add(int Fn,int Sn)
        {
            return Fn + Sn;
        }
        static void Evennumbers(int target)
        {
            int start = 0;
            while (start<=target)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
        }
    }
}
