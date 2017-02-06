using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_assign0115SUN
{
    class Triangle:Shape 
    {
        private double edge1;
        private double edge2;
        private double edge3;

        public Triangle (double edge1,double edge2,double edge3,string color):base (color )
        {
            this.edge1 = edge1;
            this.edge2 = edge2;
            this.edge3 = edge3;
        }

        public double Edge1
        {
            get
            {
                return edge1;
            }

            set
            {
                edge1 = value;
            }
        }

        public double Edge2
        {
            get
            {
                return edge2;
            }

            set
            {
                edge2 = value;
            }
        }

        public double Edge3
        {
            get
            {
                return edge3;
            }

            set
            {
                edge3 = value;
            }
        }

        public new double GetArea()
        {
            double s = (edge1 + edge2 + edge3) / 2;
            return Math .Sqrt (s*(s-edge1)*(s-edge2)*(s-edge3));
        }

        public new double GetCircumference()
        {
            return edge1+edge2+edge3;
        }
    }
}
