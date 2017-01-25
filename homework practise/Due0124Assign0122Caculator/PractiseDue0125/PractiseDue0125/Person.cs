using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseDue0125
{
    class Person
    {
        private string firstName;
        private string lastName;
        private string nationality;
        private string gender;
        private string race;

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

        public Person (string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }


        #region practise1
        //        E1: write a Person class. 
        //Each Person object can have different nationality, different gender, different race.You need to write constructor 
        //and use “this” keyword.
        //本题训练constructor 和 “this” 关键字 
        #endregion

        
    }
}
