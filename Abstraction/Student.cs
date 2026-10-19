using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Student : Person
    {
        public int Id { get; set; }
        public override int Age { get; set; }

        public Student(int id,string name, int age) : base(name,age)
        {
            this.Id = id;
        }

        public override void DoSomething()
        {
            Console.WriteLine("Now I do something");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Student ID: {Id}, Name: {Name}, Age: {Age}");
        }
    }
}