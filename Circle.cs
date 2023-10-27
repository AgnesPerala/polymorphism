using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorfoism
{
    internal class Circle : Geometry
    {
        // privte field cinse it is a namber that should not be changed 
        private float _pi = 3.14f;

        public double Radius { get; set; }

        // constructor that sets the value of the property
        public Circle()
        {
            Radius = 6;
        }

        // method that calculate and retruns the answer
        public override double Area()
        {
            return Radius * Radius * _pi;
        }
    }
}
