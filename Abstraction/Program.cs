using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            //cannot create an instance of an abstract class
            //Person person = new Person("John", 30); // This line would cause a compilation error

            // Create an instance of the derived class
            Student student = new Student(1, "Alice", 20);
            student.DisplayInfo();
            student.DoSomething();
        }
    }
}