using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_and_prnt_rvrs_arry
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length of array");
            int arrlength = int.Parse(Console.ReadLine());
            int[] arr = new int[arrlength];
            for (int i = 0; i <arrlength; i++)
            {
                int arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = arrlength; i >= 0; i++)
            {
                Console.WriteLine(arr[i]);   
            }

            
                //Array.Reverse(arr);
                //Console.WriteLine(arr);
            
                ////foreach (var value in arr)
                ////{
                ////    Console.WriteLine(value); 
                ////}
                
            
            
        }
    }
}
