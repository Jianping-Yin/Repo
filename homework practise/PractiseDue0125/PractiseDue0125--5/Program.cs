using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseDue0125__5
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Please enter file path:");
            string filePath = Console.ReadLine();
            Console.Write("Please enter the file name:");
            string fileName = Console.ReadLine();

            FilerOpener opener = new FilerOpener();
            opener.FileName = fileName;
            opener.FilePath = filePath;
            opener.OpenFile();


        }
    }
}
