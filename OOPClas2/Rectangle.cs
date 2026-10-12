using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClas2
{
    class Rectangle
    {
        private double length;
        private double width;
        public Rectangle()
        {
            length = length;
            width = width;
        }
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double GetArea()
        {
            return Math.Round(length * width, 2);
        }
    }
}
