using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Animal
    {
        //property
        public string AnimalType { get; set; }

        public Animal(string animaltype)
        {
            AnimalType = animaltype;
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }
}