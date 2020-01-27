using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraysort
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;
            int[] array ={50,20,30,10,40};
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length-1; j++)
                {
                    if (array[j]>array[j+1])
                    {
                        sum = array[j + 1];
                        array[j+1]=array[j];
                        array[j] = sum;
                    }
                }
                Console.WriteLine(array[j]); 
            }
        }
    }
}
