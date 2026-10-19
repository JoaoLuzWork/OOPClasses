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

            Overloading overloading = new Overloading();
            Console.WriteLine("Addition of two numbers: " + overloading.Add(10, 20));
            Console.WriteLine("Addition of three numbers: " + overloading.Add(10, 20, 30));
            Console.WriteLine("Addition of two double numbers: " + overloading.Add(10.1, 20.5));
        }
    }
}