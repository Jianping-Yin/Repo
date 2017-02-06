using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_assign0115SUN
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string color;
            string name;

            Triangle triangle = new Triangle(2, 3, 4, "blue");
            triangle.Name = "Traniangle";
            Rectangle rectangle = new Rectangle(4, 3, "green");
            rectangle.Name = "Rectangle";
            Square square = new Square(5, "red");
            square.Name = "Square";

            double maxArea = 0;
            double maxCircumference = 0;

            #region Get maxArea

            color = "";
            name = "";


            if (triangle.GetArea() > maxArea)
            {
                maxArea = triangle.GetArea();
                color = triangle.Color;
                name = triangle.Name;
            }
            if (rectangle.GetArea() > maxArea)
            {
                maxArea = rectangle.GetArea();
                color = rectangle.Color;
                name = rectangle.Name;
            }
            if (square.GetArea() > maxArea)
            {
                maxArea = square.GetArea();
                color = square.Color;
                name = square.Name;
            }
            Console.Write("maxArea=" + maxArea + "  " + "color=" + color + "  " + "name=" + name + "\n\n");

            #endregion

            #region Get maxCircumference

            color = "";
            name = "";

            if (triangle.GetCircumference() > maxCircumference)
            {
                maxCircumference = triangle.GetCircumference();
                color = triangle.Color;
                name = triangle.Name;
            }
            if (rectangle.GetCircumference() > maxCircumference)
            {
                maxCircumference = rectangle.GetCircumference();
                color = rectangle.Color;
                name = rectangle.Name;
            }
            if (square.GetCircumference() > maxCircumference)
            {
                maxCircumference = square.GetCircumference();
                color = square.Color;
                name = square.Name;
            }
            Console.Write("maxCircumference=" + maxCircumference + "  " + "color=" + color + "  " + "name=" + name + "\n\n"); 
            #endregion


        }
    }
}
