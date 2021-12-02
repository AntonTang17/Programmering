using System;
using System.Collections.Generic;
using System.Text;

namespace Shape3D___Interface
{
    class Cylinder : Shape3D
    {
        public Cylinder(double radius, double height)
        {
            r = radius;
            radius = 4.0;

            h = height;
            height = 6.0;
        }

        private double r;

        private double h;

        public double GetArea()
        {
            return 2 * Math.PI * r * r + 2 * Math.PI * r * h;
        }

        public double GetVolume()
        {
            return Math.PI * r * r * h;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void SkrivUt()
        {
            Console.WriteLine("Cylinder");
            Console.WriteLine("Height: " + h);
            Console.WriteLine("Radius: " + r);
            Console.WriteLine("Area: " + GetArea());
            Console.WriteLine("Volume: " + GetVolume());
        }
    }
}
