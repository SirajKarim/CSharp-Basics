using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] multi = new int[3, 3];
            multi[0,0]=3;
            multi[0,1]=9;
            multi[0,2]=8;
            multi[1,0]=4;
            multi[1,1]=7;
            multi[1,2]=5;
            multi[2,0]=6;
            multi[2,1]=2;
            multi[2,2]=1;
            for (int i = 0; i < multi.Length; i++)
            {
                Console.WriteLine(multi[0,0]);    
            }
            
        }
    }
}
