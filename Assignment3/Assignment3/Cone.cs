using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    class Cone: Circle
    {
        //public double height;
        public Cone()
        {
           
        }
        public double Volume(double h, double rad)
        {
            return (Math.PI * Math.Pow(rad,2) * h) / 3;
        }

        public new double Area( double h,double rad) {

              double area = Math.PI * rad * (rad + Math.Sqrt(h * h + rad * rad));
            //return Math.PI * rad * h + Math.PI * rad * rad;
            return area;

        }
    }
}
