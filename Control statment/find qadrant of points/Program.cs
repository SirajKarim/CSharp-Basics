using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_qadrant_of_points
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of X Quadrant");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of Y Quadrant");
            int y = int.Parse(Console.ReadLine());
            if (x==0 && y==0)
            {
                Console.WriteLine("Ponits lie on the origin");
            }
            else if (x<0 && y>0)
            {
                Console.WriteLine("Point lie on the First Quadrant");
            }
            else if (x<0 && y<0)
            {
                Console.WriteLine("Point lie on the Second Quadrant");
            }
            else if (x>0 && y<0)
            {
                Console.WriteLine("Point lie on the Third Quadrant");
            }
            else if (x>0 && y>0)
            {
                Console.WriteLine("Point lie on the Fourth  Quadrant");
            }
        }
    }
}
