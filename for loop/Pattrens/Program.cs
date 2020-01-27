using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattrens
{
    class Program
    {
        static void Main(string[] args)
        {
           // Write a program in C# Sharp to display the pattern like right angle triangle with a number.
            //for (int i = 1; i <= 6; i++)
            //{
            //    for (int j = 1; j <=i; j++)
            //    {
            //        Console.Write(j);
            //    }
            //    Console.WriteLine();
            //}

            //Write a program in C# Sharp to make such a pattern like right angle triangle with a number which will repeat a number in a row.
            //for (int i = 1; i <=5; i++)
            //{
            //    for (int j = 1; j <=i; j++)
            //    {
            //        Console.Write(i);C 
            //    }
            //    Console.WriteLine();
            //}

            // 12. Write a program in C# Sharp to make such a pattern like right angle triangle with number increased by 1.
            //int k = 1;
            //for (int i = 1; i <=4; i++)
            //{
            //    for (int j = 0; j <i; j++)
            //    {
            //        Console.Write(k++);
            //    }
            //    Console.WriteLine();
            //}

            // Write a program to make square with #.
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write("#");
            //    }
            //    Console.WriteLine();
            //}

            //Write a program on C# which make inverse pyramid with user define rows.
            //Console.WriteLine("Enter No of Rows");
            //int input = int.Parse(Console.ReadLine());
            //for (int i = 1; i <=input; i++)
            //{
            //    for (int j = 1; j <=i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = input; k >= i * 2 - 1; k--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            // write a C# program that make Number Diamond over a triangle.
            //for (int i = 1; i <= 3; i++)
            //{
            //    for (int j = 2; j >= i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= i * 2 - 1; k++)
            //    {
            //        Console.Write(k);
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 1; i <= 2; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    int l = 1;
            //    for (int k = 3; k >= i * 2 - 1; k--)
            //    {
            //        Console.Write(l); l++;
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 1; i <=3; i++)
            //{
            //    for (int j =1; j <i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 5; k>=i*2-1 ; k--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Write a program on C# which make aright angle triangle of 1 to 5 numbers inverse.
            //for (int i = 1; i <= 5; i++)
            //{
            //    int a = 5;
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(a); a--;
            //    }
            //    Console.WriteLine();
            //}

            ////Write a program on C# which make a pyramid.
            //for (int i = 0; i < 6; i++)
            //{
            //    for (int j = 5; j >=i ; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <=i ; k++)
            //    {
            //        Console.Write("* ");
            //    }
            //    Console.WriteLine();
            //}
            
            // Write a C# program which make a
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 3; j >=i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <=i*2-1; k++)
                {
                    Console.Write(k+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
