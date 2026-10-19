using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class program
    {
        static void Main(string[] args)
        {
            //creating object of Dog class
            Dog dog = new Dog("Dog");
            dog.MakeSound();

            //creating object of Animal class
            Animal animal = new Animal("Animal");
            animal.MakeSound();

            Console.ReadLine();
        }
    }
}