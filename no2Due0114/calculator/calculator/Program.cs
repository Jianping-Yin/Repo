using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int l, m, n, k;
            double d;
            Calculator Cal = new Calculator();
            Console.WriteLine("Please input 2 or 3 integer OR one integer and one float type to test calculator.");
            Console.Write("integer l=");
            l = int.Parse(Console.ReadLine());
            Console.Write("integer m=");
            m = int.Parse(Console.ReadLine());
            Console.Write("integer n=");
            n = int.Parse(Console.ReadLine());
            Console.Write("integer k=");
            k = int.Parse(Console.ReadLine());
            Console.Write("double d=");
            d =double.Parse(Console.ReadLine());

            Console.WriteLine("Add(l,m)=" + Cal.Add(l, m));
            Console.WriteLine("Add(l,m,n)=" + Cal.Add(l, m, n));
            Console.WriteLine("Add(k,d)=" + Cal.Add(k, d));

            Console.WriteLine("Subtract(l,m)=" + Cal.Subtract(l, m));
            Console.WriteLine("Subtract(l,m,n)=" + Cal.Subtract(l, m, n));
            Console.WriteLine("Subtract(k,d)=" + Cal.Subtract(k, d));

            Console.WriteLine("Multiply(l,m)=" + Cal.Multiply(l, m));
            Console.WriteLine("Multiply(l,m,n)=" + Cal.Multiply(l, m, n));
            Console.WriteLine("Multiply(k,d)=" + Cal.Multiply(k, d));

            Console.WriteLine("Divide(l,m)=" + Cal.Divide(l, m));
            Console.WriteLine("Divide(l,m,n)=" + Cal.Divide(l, m, n));
            Console.WriteLine("Divide(k,d)=" + Cal.Divide(k, d));


        }
    }
}
