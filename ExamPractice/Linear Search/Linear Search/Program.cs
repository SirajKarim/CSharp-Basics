using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------             LINEAR  SEARCH              ------");
            Console.WriteLine("Input Array Length");
            int a = Convert.ToInt32(Console.ReadLine());
            int[]arr=new int[a];
            Console.WriteLine("Enter Values in Array");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter Value Do You Want To Search");
            int search = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
            if (arr[i]==search)
            {
                Console.WriteLine("Searh Successful");
            }
            else
            {
                Console.WriteLine("Search Invalid");
            }
            
                }
        }
        
    }
}
