using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorfoism
{
    internal class Parallellogram : Geometry
    {
        public double Base { get; set; }
        public double Height { get; set; }

        // constructor that sets the value of the property
        public Parallellogram()
        {
            Base = 2.4;
            Height = 3;
        }

        // method that calculate and retruns the answer
        public override double Area()
        {
            return Base * Height;
        }

    }
}
