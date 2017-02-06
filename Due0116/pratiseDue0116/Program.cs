using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratiseDue0116
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sum=0;
            Console.Write("Please input a integer number:");
            num=int.Parse(Console.ReadLine());
            for (int i = 1; i < num+1; i++)

            {
                sum = sum + i;

            }
            Console.WriteLine(num+"!="+sum);
          
        }
    }
}
