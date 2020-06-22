using System;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter height:");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter radius:");
            double radius = double.Parse(Console.ReadLine());

            Sphere sphere = new Sphere();
            Cone cone = new Cone();
            Console.WriteLine("The Area of the Sphere is " + Math.Round(sphere.Area(radius),2)+
                " and The Volume is "+Math.Round(sphere.Volume(radius),2));
            Console.WriteLine("The Area of the Cone is " + Math.Round(cone.Area(height, radius),2) +
                " and The Volume is "+Math.Round(cone.Volume(height, radius)),2);
      
            Console.ReadKey();
        }
    }
}
