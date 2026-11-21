using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTest
{
    class Dog : IAnimal , IStudent
    {
        public void MakeSound()
        {
            Console.WriteLine("Woof!");
        }

        public void Study()
        {
            Console.WriteLine("Dog is studying.");
        }
    }
}