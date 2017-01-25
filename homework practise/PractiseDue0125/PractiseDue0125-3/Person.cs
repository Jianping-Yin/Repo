using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseDue0125_3
{
    class Person
    {
        private string firstName;
        private string lastName;
        private string nationality;
        private string gender;
        private string race;
        private string age;

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string Nationality
        {
            get
            {
                return nationality;
            }

            set
            {
                nationality = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public string Race
        {
            get
            {
                return race;
            }

            set
            {
                race = value;
            }
        }

        public string Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void GetAllInfo()
        {
            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
            Console.WriteLine(Nationality);
            Console.WriteLine(Gender);
            Console.WriteLine(Race);
            Console.WriteLine(Age);
        }

        #region practise 3
        //E3: 
        //在E1 和E2 的基础上， 在Person class 加入method : GetAllInfor(); 在这个method 里面打印出所有property 的信息。

        #endregion

    }
        
}
