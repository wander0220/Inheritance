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
                if ( item is Dog)
                {
                    //클래스 자료형변환 방법 두가지
                    ((Dog)item).Bark();
                    //as ~로써
                    (item as Dog).Bark();
                }
                else
                {
                    ((Cat)item).Meow();
                }

            }


            
        }
    }
}
