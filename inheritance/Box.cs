using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    public class Box : Rectangule
    {
        private double height;

        public Box(double length, double width, double height) : base(length, width)
        {
            this.height = height;
        }

        public double GetVolume()
        {
            return Math.Round(GetArea() * height, 2);
        }     
    }
}