using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box(2, 3, 4);
            Box box2 = new Box(4.5, 6.7, 8.9);
            Console.WriteLine("Volume: " + box1.GetVolume());
            Console.WriteLine("Volume: " + box2.GetVolume());
        }
    }
}