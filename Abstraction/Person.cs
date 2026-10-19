using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Person
    {
        public string Name { get; set; }
        public abstract int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        //abstract method
        public abstract void DoSomething();
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}