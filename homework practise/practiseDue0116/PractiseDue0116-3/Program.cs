using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseDue0116_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int max, inputInteger;
            
            string inputString;
            Console.WriteLine("Help you find the maxmun integer!-Please input integers with a Enter for each integer.the last input should be 'end'");
            inputString = Console.ReadLine();
            if (inputString == "end")
                Console.WriteLine("No Entry");
            else
            {
                max = int.Parse(inputString);
                inputString = Console.ReadLine();
                while (inputString != "end")
                {
                    inputInteger = int.Parse(inputString);
                    if (max < inputInteger) max = inputInteger;
                    inputString = Console.ReadLine();
                }
                Console.WriteLine("Max is: " + max);
             }
            
        }
    }
}
