using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClass1
{
    public class Studant
    {
        
        private string name;
        private int age;
        private string grade;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Grade { get => grade; set => grade = value; }

        public Studant(string name, int age, string grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Grade: {Grade}");
        }
    }
}