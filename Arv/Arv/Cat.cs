using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    class Cat
    {
        private int age;


        public Cat(int a)
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
            Console.WriteLine("mjau, mjau, mjau");
        }
    }

}
