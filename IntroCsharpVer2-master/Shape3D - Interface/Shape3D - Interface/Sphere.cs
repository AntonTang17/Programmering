using System;
using System.Collections.Generic;
using System.Text;

namespace Shape3D___Interface
{
    class Sphere : Shape3D
    {
        public Sphere(double radius)
        {
            r = radius;
            radius = 4.0;
        }
        private double r;


        public double GetArea()
        {
            return 4 * Math.PI * r * r;
        }

        public double GetVolume()
        {
            return 4 * Math.PI * r * r * r / 3;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void SkrivUt()
        {
            Console.WriteLine("Sphere");
            Console.WriteLine("Radius: " + r);
            Console.WriteLine("Area: " + GetArea());
            Console.WriteLine("Volume: " + GetVolume());
        }

    }


}
