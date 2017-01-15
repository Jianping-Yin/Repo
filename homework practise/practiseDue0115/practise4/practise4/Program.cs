using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] IntegerArray,outputIntegerArray;
            int num;

            Console.WriteLine("How many integers do you want to input?");
            num = Convert.ToInt32(Console.ReadLine());
            IntegerArray = new int[num];
            outputIntegerArray = new int[num];
            Console.WriteLine("Please input these integers-input ENTER after each integer.");
            for (int i = 0; i < num; i++)
            {
                IntegerArray[i] = Convert.ToInt32(Console.ReadLine());
                if (IntegerArray[i] > 0)
                    outputIntegerArray[i] = IntegerArray[i] + 1;
                else if (IntegerArray[i] < 0)
                    outputIntegerArray[i] = IntegerArray[i] - 1;
            }

            
            Console.Write("Array:[");
            for (int i = 0; i < num; i++)
            {
                Console.Write(IntegerArray[i]);
                Console.Write(',');
            }
            Console.Write("\b]\n");

            Console.Write("Output Array:[");
            for (int i = 0; i < num; i++)
            {
                Console.Write(outputIntegerArray[i]);
                Console.Write(',');
            }
            Console.Write("\b]\n");


        }
    }
}
