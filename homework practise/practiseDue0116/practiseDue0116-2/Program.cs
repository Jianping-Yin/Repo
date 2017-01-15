using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiseDue0116_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string username, password;
            do
            {
                Console.Write("Please input username:");
                username = Console.ReadLine();
                Console.Write("Please input password:");
                password = Console.ReadLine();



            } while (username != "hello" || password != "123");

        }
    }
}
