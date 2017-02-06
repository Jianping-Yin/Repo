using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputStringArray;
            string[] outputStringArray;
            int num;

            Console.WriteLine("How many strings do you want to input?");
            num = Convert.ToInt32(Console.ReadLine());
            inputStringArray = new string[num];
            outputStringArray = new string[num];
            Console.WriteLine("Please input these strings-input ENTER after each string.");
            for (int i = 0; i < num; i++)
            {
                inputStringArray[i] = Console.ReadLine();
                outputStringArray[num-i-1] = inputStringArray[i];

            }


            Console.Write("Input String Array:[");
            for (int i = 0; i < num; i++)
            {
                Console.Write(inputStringArray[i]);
                Console.Write(',');
            }
            Console.Write("\b]\n");

            Console.Write("Output String Array:[");
            for (int i = 0; i < num; i++)
            {
                Console.Write(outputStringArray[i]);
                Console.Write(',');
            }
            Console.Write("\b]\n");
        }
      

    }
}
            
