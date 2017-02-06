using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseDue0117_2
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int lastPosition;
            string inString = " "+Console.ReadLine();
            int length = inString.Length;
            string reverseString = "";
            do
            {
                lastPosition = inString.LastIndexOf(" ");
                reverseString = reverseString + inString.Substring(lastPosition);
                inString = inString.Substring(0, lastPosition);
            } while (inString != "");
            reverseString = reverseString.Substring(1);
            Console.WriteLine(reverseString);
        }
    }
}
