using System;
using System.Collections.Generic;
using System.Text;

namespace Shape3D___Interface
{
    class Cube : Shape3D      
    {
        public Cube(double lenght)
        {
            l = lenght;
            lenght = 3.0;
        }

        private double l;

        public double GetArea()
        {
            return l * l * 6;
        }

        public double GetVolume()
        {
            return l * l * l;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void SkrivUt()
        {
            Console.WriteLine("Cube");
            Console.WriteLine("Lenght: "+ l);
            Console.WriteLine("Area: "+ GetArea());
            Console.WriteLine("Volume: "+ GetVolume());
        }
    }
}
