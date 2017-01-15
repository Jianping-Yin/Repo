using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise_3
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] stringArray;
            string outputString;
            int num;

            Console.WriteLine("How many strings do you want to input?");
            num = Convert.ToInt32(Console.ReadLine());
            stringArray = new string[num];

            Console.WriteLine("Please input these strings-input ENTER after each string.");
            for (int i = 0; i < num; i++)
            {
                stringArray[i] = Console.ReadLine();

            }

            outputString = stringArray[0];
            for (int i = 1 ; i < num; i++)
            {
                outputString = outputString + '-' + stringArray[i];
            }
       
            Console.Write("Array:[");
            for (int i = 0; i < num; i++)
            {
                Console.Write(stringArray[i]);
                Console.Write(',');
            }
            Console.Write("\b]\n");

            Console.Write("Output String:" + outputString);
            Console.WriteLine();


            
        }
    }
}
