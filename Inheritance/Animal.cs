using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Animal() { this.Age = 0; }
        public void Eat() { Console.WriteLine("념념념쫍쫍"); }
        public void Sleep() { Console.WriteLine("쿨쿨쓰"); }
    }
}
