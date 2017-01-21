using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseDue0125_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Johny", 46, "male");
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.Gender);
            Person person1 = new Person("rocky", 121, "Male");
            Console.WriteLine(person1.Name);
            Console.WriteLine(person1.Age);
            Console.WriteLine(person1.Gender);
            person1.Name = "Rocky";
            person1.Age = 122;
            person1.Gender = "Female";
            Console.WriteLine(person1.Name);
            Console.WriteLine(person1.Age);
            Console.WriteLine(person1.Gender);



        }
    }
}
