using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName, lastName, ageInput;
            int age;
            char gender;
            string title = "";
            Console.WriteLine("Please input your first name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Please input your last name:");
            lastName = Console.ReadLine();
            do {
                Console.WriteLine("Please input your age:");
                ageInput = Console.ReadLine();
                age = Convert.ToInt16(ageInput);
            } while (age<=0||age > 100);
            do
            {
                Console.WriteLine("Please input your gender(M or F):");
                gender = Convert.ToChar(Console.ReadLine());
                switch (gender)
                {
                    case ('m'):
                    case ('M'):
                        title = "Mr.";
                        break;
                    case ('f'):
                    case ('F'):
                        title = "Mrs.";
                        break;
                    default:
                        break;
                }
            } while (title == "");  
            DateTime now = DateTime.Now;
            System.DateTime currentTime = new System.DateTime();
            int hour = currentTime.Hour;
            if (hour >= 18 || hour < 6)
                Console.WriteLine("Good Evening, "+ title + " " + lastName + ", Age " + ageInput);
            else
                Console.WriteLine("Good Day, " + title + " " + lastName + ", Age " + ageInput);
            Console.ReadLine();
        }
    }
}
