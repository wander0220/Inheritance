using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Cat
    {
        public int Age { get; set; }
        public string Color { get; set; }


        public Cat() { this.Age = 0; }
        public void Eat() { Console.WriteLine("더 맛있는거 가져와라 닝겐"); }
        public void Sleep() { Console.WriteLine("하암졸령"); }
        public void Meow() { Console.WriteLine("고양이 소리내봐 시러 니나내세요"); }

    }
}
