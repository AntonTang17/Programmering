using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    class Dog
    {
        private int age;


        public Dog(int a)
        {
            age = a;

        }

        public int Age
        {
            get
            {
                return age;
            }
        }

        public void Act()
        {
            Console.WriteLine("vov, vov, vov");
        }
    }
}
