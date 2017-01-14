using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Calculator
    {


        #region Add()
        public int Add(int x, int y)
        {
            return x + y;
        }
        public double Add(int x, double y)
        {
            return x + y;
        }
        public int Add(int x, int y, int z)
        {
            return Add(x, y) + z;
        }
        #endregion

        #region Subtract()
        public int Subtract(int x, int y)
        {
            return x - y;
        }
        public double Subtract(int x, double y)
        {
            return x - y;
        }
        public int Subtract(int x, int y, int z)
        {
            return Subtract(x, y) - z;
        } 
        #endregion

        #region Multiply()
        public int Multiply(int x, int y)
        {
            return x * y;
        }
        public double Multiply(int x, double y)
        {
            return x * y;
        }
        public int Multiply(int x, int y, int z)
        {
            return Multiply(x, y) * z;
        }
        #endregion

        #region Divide()
        public int Divide(int x, int y)
        {
            return x / y;
        }
        public double Divide(int x, double y)
        {
            return x / y;
        }
        public int Divide(int x, int y, int z)
        {
            return Divide(x, y) / z; 
        }
        #endregion

    }
}
