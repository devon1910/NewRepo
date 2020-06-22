using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Circle
    {
        public double radius;
        public Circle()
        {
            radius = 0.0;
        }

        public double Area => radius * radius * Math.PI;

        public double Perimeter => (radius * 2) * Math.PI;
        
    }
}

