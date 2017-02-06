using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise0117_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int @Position;
            int dotPosition;
            string userName;
            string domain;
            string inPutstring = Console.ReadLine();
            @Position = inPutstring.IndexOf("@");
            userName = inPutstring.Substring(0, @Position);
            inPutstring = inPutstring.Substring(@Position + 1);
            dotPosition = inPutstring.IndexOf(".");
            domain = inPutstring.Substring(0, dotPosition );
            Console.WriteLine("username=" + userName);
            Console.WriteLine("domain=" + domain);
              
            
        }
    }
}
