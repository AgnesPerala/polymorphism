using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorfoism
{
    internal class Geometry // base class 
    {
        // virtual method so it can overide to other classes
        public virtual double Area()
        {
            return 0; // default vaule 
        }
    }
}
