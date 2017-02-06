using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseDue0117_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string inString = Console.ReadLine();
            int length = inString.Length;
            string reverseString = "";
            for (int i = 0; i < length; i++)
            {
                reverseString = reverseString + inString.Substring(length - 1 - i, 1);
            }
            Console.WriteLine(reverseString);

        }

    }
}
