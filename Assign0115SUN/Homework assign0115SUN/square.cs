using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_assign0115SUN
{
    class Square:Shape 
    {
        private double edge;

        public Square(double edge,string color):base(color)
        {
            this.edge = edge;
            
        }

        public double Edge
        {
            get
            {
                return edge;
            }

            set
            {
                edge = value;
            }
        }

        public new double  GetArea()
        {
            return edge*edge;
        }
        public new double GetCircumference()
        {
            return edge * 4;
        }
    }
}
