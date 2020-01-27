using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rough_ork
{
    class Program
    {
        static void Main(string[] args)
        {
           
    //int[] a= new int[100];
    //int i, n, sum=0;
	
	
    //   Console.Write("\n\nFind sum of all elements of array:\n");
    //   Console.Write("--------------------------------------\n");	

    //   Console.Write("Input the number of elements to be stored in the array :");
    //   n = Convert.ToInt32(Console.ReadLine()); 
   
    //   Console.Write("Input {0} elements in the array :\n",n);
    //   for(i=0;i<n;i++)
    //    {
    //      Console.Write("element - {0} : ",i);
    //      a[i] = Convert.ToInt32(Console.ReadLine()); 
    //    }

    //for(i=0; i<n; i++)
    //{
    //    sum += a[i];
    //}

    //Console.Write("Sum of all elements stored in the array is : {0}\n\n", sum);
            int a = int.Parse(Console.ReadLine());
            int[] arr = new int[a];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
