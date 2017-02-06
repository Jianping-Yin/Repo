using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise0117_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string inString = Console.ReadLine();
            int length = inString.Length;
            string respectiveString = "";
            string charOfString = "";
            for (int i = 0; i < length; i++)
            {
                charOfString = inString.Substring(i, 1);
                switch (charOfString)
                {
                    case "0":
                        respectiveString = respectiveString + "zero";
                        break;
                    case "1":
                        respectiveString = respectiveString + "one";
                        break;
                    case "2":
                        respectiveString = respectiveString + "two";
                        break;
                    case "3":
                        respectiveString = respectiveString + "three";
                        break;
                    case "4":
                        respectiveString = respectiveString + "four";
                        break;
                    case "5":
                        respectiveString = respectiveString + "five";
                        break;
                    case "6":
                        respectiveString = respectiveString + "six";
                        break;
                    case "7":
                        respectiveString = respectiveString + "seven";
                        break;
                    case "8":
                        respectiveString = respectiveString + "eight";
                        break;
                    case "9":
                        respectiveString = respectiveString + "nine";
                        break;
                    default:
                        respectiveString = respectiveString + charOfString ;
                        break;
                }

            }

            Console.WriteLine(respectiveString );

        }
    }
}
