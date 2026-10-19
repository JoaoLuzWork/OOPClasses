using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Rectangule
    {
        private double length;
        private double width;

        public Rectangule(double length, double width)
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