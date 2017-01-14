using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Sharp sharp = new Sharp();
            Console.WriteLine("Please input rectangle size.");
            Console.Write("Length=");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width=");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Please input Circle radius.");
            Console.Write("Radius=");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Rectangle Area=" + sharp.GetRectangleArea(width, length));
            Console.WriteLine("Circle Area=" + sharp.GetCircleArea(radius));
        }


    }
    } 
