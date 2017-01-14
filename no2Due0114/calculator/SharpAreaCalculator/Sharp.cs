using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpAreaCalculator
{
    class Sharp
    {

        // 对圆形或者长方形分别写constructor
        //public Shape(double width, double height)
        //{
              
        //  }

        //public Shape(double radius)
        //{
            
        //   }

        /// 接下来写 Shape class 里面的 properties 
        //  以下是一个example, 你可以按自己方式定义property 
        private double _width;


        /// <summary>
        /// 宽
        /// </summary>
        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }

        private double _height;

        /// <summary>
        /// 高
        /// </summary>
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        private double _radius;
        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        /// <summary>
        /// 计算指定图形的面积
        /// </summary>
        /// <returns></returns>
        public double GetRectangleArea(double _width, double _height)
        {
            return _width * _height;
       
        }
        public double GetCircleArea(double _radius)
        {
            return 3.14 * _radius*_radius ;
        }

    }

}
