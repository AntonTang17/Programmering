using System;
using System.Collections.Generic;
using System.Text;

namespace Arv
{
    class Zoo
    {
        private List<Cat> cats;
        private List<Dog> dogs;
        public Zoo()
        {
            cats = new List<Cat>();
            
            cats.Add(new Cat(2));
            cats.Add(new Cat(16));
            cats.Add(new Cat(5));

            dogs = new List<Dog>();

            dogs.Add(new Dog(5));
            dogs.Add(new Dog(11));
            dogs.Add(new Dog(7));
            dogs.Add(new Dog(3));


        }

        public void Run()
        {
            foreach (Cat katt in cats)
            {
                katt.Act();
            }

            foreach (Dog hund in dogs)
            {
                hund.Act();
            }
        }
    }
}
