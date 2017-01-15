using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num;
            int sum=0;
            


            Console.WriteLine("How many integers do you want to input?");
            num = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Please input these integers-input ENTER after each integer.");
            for (int i = 0; i < num; i++)
            {
                sum =sum+ Convert.ToInt32(Console.ReadLine());
            }
                       
            Console.WriteLine("Sum of these integers is: " + sum);

        }
    }
}
