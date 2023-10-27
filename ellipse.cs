using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorfoism
{
    internal class ellipse : Geometry
    {
        // privte field cinse it is a namber that should not be changed 
        private float _pi = 3.14f;


        public double Lenght1 { get; set; }
        public double Lenght2 { get; set; }

        // constructor that sets the value of the property
        public ellipse()
        {
            Lenght1 = 5.4;
            Lenght2 = 7.9;
        }

        // method that calculate and retruns the answer
        public override double Area()
        {
            return _pi * Lenght1 * Lenght2;
        }

    }
}
