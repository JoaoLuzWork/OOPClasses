using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Teacher : Person
    {
        public string Subject { get; set; }
        public string Title { get; set; }

        public override int Age { get; set; }

        public Teacher(string name, int age, string subject, string title):base(name,age)
        {
            Subject = subject;
            Title = title;
        }

        public override void DoSomething()
        {
            Console.WriteLine($"\n\n======= Pofessor ======= \nName:{Name}\nAge:{Age}\nSubject:{Subject}\nTitle:{Title}\n========================");
        }
    }
}