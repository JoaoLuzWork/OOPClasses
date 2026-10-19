using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Dog : Animal
    {
        //parameterized constructor
        public Dog(string animaltype):base(animaltype)
        {
        }

        //polymorphism method
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks");
        }
    }
}