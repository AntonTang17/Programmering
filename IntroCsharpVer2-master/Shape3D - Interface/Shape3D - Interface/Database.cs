using System;
using System.Collections.Generic;
using System.Text;

namespace Shape3D___Interface
{
    class Database
    {
        private List<Shape3D> shapes;
        public Database()
        {
            shapes = new List<Shape3D>();

            shapes.Add(new Cube(3));
            shapes.Add(new Cylinder(4, 6));
            shapes.Add(new Sphere(4));

        }

        public void Run()
        {
            foreach(Shape3D form in shapes)
            {
                form.SkrivUt();
                Console.WriteLine();
            }
        }
    }
}
