using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Circle circle1 = new Circle(2);
        Circle circle2 = new Circle(4.5);
        Console.WriteLine("Area: " + circle1.GetArea());
        Console.WriteLine("Area: " + circle2.GetArea());
    }
}