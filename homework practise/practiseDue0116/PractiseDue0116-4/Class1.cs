using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseDue0116_4
{
    class Class1
    {
       
        public int Fibonacci(int n)
        {
            if (n == 0) return 0;
            else if (n == 1) return 1;
            else return Fibonacci(n - 1) + Fibonacci(n - 2);
          

        }

    }
}
