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
            List<Animal> animals =
                new List<Animal>
                {
                    new Dog(), new Cat(), new Cat(), new Dog(),
                    new Dog(), new Cat(), new Dog(), new Dog()
                };

            foreach(var item in animals)
            {
                item.Eat();
                item.Sleep();

                var dog = item as Dog;
                if (dog != null) { dog.Bark(); }

                var cat = item as Cat;
                if (cat != null) { cat.Meow(); }

            }


            
        }
    }
}
