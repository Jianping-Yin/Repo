using Due0119Assign0117.NewFolder1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Due0119Assign0117
{
    class Program
    {

        static void Main(string[] args)
        {
            double num;
            List<double> numbers = new List<double>();
            Console.WriteLine("Please input a series of numbers with ENTER for each number. Input N and ENTER when finishing input.");
            Process1 process = new Process1(numbers);
            string input = Console.ReadLine();
            while (input != "N")
            {
                num = double.Parse(input);
                numbers.Add(num);
                input = Console.ReadLine();
            }

            Console.WriteLine ("sum = "+process.GetSum());
            Console.WriteLine("mean = " + process.GetMean());
            Console.WriteLine("median = " + process.GetMedian());
            Console.WriteLine("max = " + process.GetMax());
            Console.WriteLine("min = " + process.GetMin());


        }
    }
}
