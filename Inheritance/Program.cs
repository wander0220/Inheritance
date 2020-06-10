using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog> { new Dog(), new Dog(), new Dog() };

            List<Cat> cats = new List<Cat> { new Cat(), new Cat(), new Cat() };


            foreach(Dog dog in dogs)
            {
                dog.Bart();
                dog.Sleep();
                dog.Eat();
            }
            foreach (Cat cat in cats)
            {
                cat.Eat();
                cat.Sleep();
                cat.Meow();
            }
        }
    }
}
