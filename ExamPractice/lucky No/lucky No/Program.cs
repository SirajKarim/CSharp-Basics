using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lucky_No
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Length");
            int arrLength = int.Parse(Console.ReadLine());
            int[]arr1=new int[arrLength];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(arr1);
            if (arr1[2]==7)
            {
                Console.WriteLine("Number is Lucky");
            }
            else
            {
                Console.WriteLine("Number is Not Lucky");
            }
            //int[] arr = {12,60,8,58,60 };
            //Array.Reverse(arr);
            //if (arr[2]==7)
            //{
            //    Console.WriteLine(" Lucky");
            //}
            //else
            //{
            //    Console.WriteLine("not LukY");   
            //}
        }
    }
}
