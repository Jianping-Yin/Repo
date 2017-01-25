using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseDue0125_4
{
    class Dog : Animal
    {
        public Dog() : base()
        {
        }

        public override void Bark()
        {

        }

        //E4: 
        //训练Inheritance  Write an abstract class Animal 
        //and at least 3 child classes inherited from Animal: Dog, Cat, Bird, … 
        //    Each child class should override Bark() method in abstract class Animal. 
        //本题训练如何继承父类, 并且override 父类里面的abstract or virtual methods.
    }
}
