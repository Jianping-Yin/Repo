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
            Shape shapeRectangle = new Shape(1.0,2.0);
            Shape shapeCircle = new Shape(1);
            
            shapeRectangle.Width = 2;
            shapeCircle.Radius  = 2;
            Console.WriteLine("Rectangle Area=" + shapeRectangle.GetRectangleArea());
            Console.WriteLine("Circle Area=" + shapeCircle.GetCircleArea());
        }


    }
    } 
