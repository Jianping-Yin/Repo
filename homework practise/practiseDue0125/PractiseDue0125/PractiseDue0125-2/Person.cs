using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseDue0125_2
{
    class Person
    {
        private string _name;
        private int _age;
        private string _gender;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = "John";

            }
        }

        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                while (value < 0 || value > 120)

                {
                    Console.Write("Age shoule between 0-120. Please input age again. Age=");
                    value = int.Parse(Console.ReadLine());
                };
                _age = value;
            }

        }
        
        public string Gender
        {
            get
            {
                return _gender;
            }

            set
            {
                while (value != "female" && value != "male")
                {
                    Console.Write("Gender should be female or male.Please input gender again. Gender=");
                    value = Console.ReadLine();
                };
                _gender = value;
            }
        }

        public Person(string name, int age, string gender)
        {
            _name = name;
            _age = age;
            _gender = gender;
        }

        
        #region Practise 2
        //E2: 
        //write a Person class. In Person class, you should have _name field ,_age field, and _gender field 
        //and respective properties.
        //    You need to write property to make the _name of Person can only be “John”. 
        //    As for the _age field, you keep to keep _age of Person is between[0, 120]. 
        //    _gender can only be female or male.
        //本题训练如何用property 保护字段 
        #endregion
               
    }
}
