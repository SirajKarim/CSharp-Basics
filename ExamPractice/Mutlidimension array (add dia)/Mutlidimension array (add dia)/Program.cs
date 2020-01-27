using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutlidimension_array__add_dia_
{
    class Program
    {
        static void Main(string[] args)
        {
             int[,] num= {
                {22,50,11, 2, 49},
                {92,63,12,64,37},
                {75,23,64,12,99},
                {21,25,71,69,39},
                {19,39,58,28,83}};
 
                //Getting Row and Column Length
                int rowlength = num.GetLength(0);
                int columnlength = num.GetLength(1);
                int total=0;
                Console.Write("Diagonals are : ");
                for(int row=0; row<rowlength; row++)
                {
                    for(int column=0; column<columnlength; column++)
                    {
                        if(row==column)
                        {
                            Console.Write(num[row,column] + " ");
                            total += num[row,column];
                        }
                    }
                }
                Console.WriteLine(": Sum : " + total);
        }
    }
}
