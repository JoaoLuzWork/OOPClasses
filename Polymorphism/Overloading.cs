using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Overloading
    {
        //regular addition method
        public int Add(int a, int b)
        {
            return a + b;
        }

        //overloaded addition method adding paramenter c
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        //overladed addition method changing the data type
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}