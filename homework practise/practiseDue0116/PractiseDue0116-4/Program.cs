using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseDue0116_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("please input a natural number to calulate Fibonacci Function:");
            n = int.Parse(Console.ReadLine());
            
            Class1 fibo = new Class1();
            Console.WriteLine("Fibonacci("+n+"):"+ fibo.Fibonacci(n));
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Fibonacci(" + i + "):" + fibo.Fibonacci(i));

            }


        }
        
    }
}
