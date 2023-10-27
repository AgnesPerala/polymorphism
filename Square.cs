using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorfoism
{
    internal class Square : Geometry // inherit to square class
    {
        // property 
        public double Length { get; set; }

        // constructor that sets the value of the property
        public Square()
        {
            Length = 7;
        }

        // method that calculate and retruns the answer
        public override double Area()
        {
            return Length * Length;
        }
    }
}
