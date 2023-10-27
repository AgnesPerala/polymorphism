using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorfoism
{
    internal class Rectangle : Geometry
    {
        public double Length { get; set; }
        public double Width { get; set; }

        // constructor that sets the value of the property
        public Rectangle()
        {
            Length = 5.2;
            Width = 2;
        }
        // method that calculate and retruns the answer
        public override double Area()
        {
            return Length * Width;
        }
    }
}
