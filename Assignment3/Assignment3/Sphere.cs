using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Sphere : Circle
    {
        // public double Height { get; set; }
        //public double Radius { get; set; }

        public Sphere()
        {
        }
        public double Volume(double rad) { 
        return (4 * Math.PI * Math.Pow(rad, 3))/ 3;
    }
        public new double Area(double rad) {
            return 4 * Math.PI * Math.Pow(rad, 2);
        }
    }
}
