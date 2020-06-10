using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Dog
    {
        public int Age { get; set; }
        public string Color { get; set; }


        public Dog() { this.Age = 0; }
        public void Eat() { Console.WriteLine("념념념쫍쫍"); }
        public void Sleep() { Console.WriteLine("쿨쿨쓰"); }
        public void Bart() { Console.WriteLine("왈왈왕ㅇ왕ㅇ오아ㅗㅇ알"); }
    }
}
