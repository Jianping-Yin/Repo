using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_assign0115SUN
{
    abstract class Shape
    {
        private string color;
        private string name;

        public  Shape (string color)
        {
            this.color = color;
        }

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public double GetArea()
        {
            return 0;
        }
        public double GetCircumference()
        {
            return 0;
        }


        //        Homework:

        //Shape: Abstract
        //    Color

        //    GetArea()

        //    GetCircum()


        //Triangle, Rectangle, Square


        //in main:
        //Create a triangle object(2,3,4,blue), a rectangle object(4,3,green), a square(5, red) object

        // Console Out:
        //The max Area, color, name(ex.triangle).

        //The max Circum, color, name(ex.triangle).
    }
}
