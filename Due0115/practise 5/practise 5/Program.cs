using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integerArray;
            string[] outputStringArray;
            int num;

            Console.WriteLine("How many integers do you want to input?");
            num = Convert.ToInt32(Console.ReadLine());
            integerArray = new int[num];
            outputStringArray = new string[num];
            Console.WriteLine("Please input these integers-input ENTER after each integer.");
            for (int i = 0; i < num; i++)
            {
                integerArray[i] = Convert.ToInt32(Console.ReadLine());
                outputStringArray[i] = Convert.ToString(integerArray[i]);

            }


            Console.Write("Array:[");
            for (int i = 0; i < num; i++)
            {
                Console.Write(integerArray[i]);
                Console.Write(',');
            }
            Console.Write("\b]\n");

            Console.Write("Output Array:[");
            for (int i = 0; i < num; i++)
            {
                Console.Write(outputStringArray[i]);
                Console.Write(',');
            }
            Console.Write("\b]\n");
        }
    }
}
