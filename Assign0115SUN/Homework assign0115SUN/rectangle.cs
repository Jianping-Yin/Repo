using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_assign0115SUN
{
    class Rectangle : Shape
    {
        private double length;
        private double width;


        public Rectangle(double length, double width, string color) : base(color)
        {
            this.length = length;
            this.width = width;
        }

        public double Length
        {
            get
            {
                return length;
            }

            set
            {
                length = value;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }




        public new double GetArea()
        {
            return length * width;
        }
        public new double GetCircumference()
        {
            return (length + width) * 2;
        }
    }
}
