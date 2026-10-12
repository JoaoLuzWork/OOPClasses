using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClas2
{
class Program
{
    static void Main(string[] args)
    {
        Circle circle1 = new Circle(2);
        Circle circle2 = new Circle(4.5);
        Console.WriteLine("Area: " + circle1.GetArea());
        Console.WriteLine("Area: " + circle2.GetArea());
        
        Rectangle rectangle1 = new Rectangle(2, 3);
        Rectangle rectangle2 = new Rectangle(4.5, 6.7);
        Console.WriteLine("Area: " + rectangle1.GetArea());
        Console.WriteLine("Area: " + rectangle2.GetArea());
    }
}
}