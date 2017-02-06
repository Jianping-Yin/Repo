using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integer;
            int num, max;

            Console.WriteLine("How many integers do you want to input?");
            num = Convert.ToInt32(Console.ReadLine());
            integer = new int[num];
            Console.WriteLine("Please input these integers-input ENTER after each integer.");
            for (int i = 0; i < num; i++)
            {
                integer[i] = Convert.ToInt32(Console.ReadLine());
            }
            max = integer[0];
            for (int i = 1; i < num; i++)
            {
                if (max < integer[i])
                {
                    max = integer[i];
                }
            }
            Console.WriteLine("Max of these integer is: " + max);

        }
    }
}
