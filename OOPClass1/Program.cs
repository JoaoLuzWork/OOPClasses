using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClass1
{
   class Program
    {
        static void Main(string[] args)
        {
            Studant student1 = new Studant("Alice", 20, "A");
            Studant student2 = new Studant("Bob", 22, "B");

            student1.DisplayInfo();
            student2.DisplayInfo();

            Console.ReadLine();
        }
    }
}