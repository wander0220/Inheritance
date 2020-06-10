using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Dog : Animal
    {
        public string Color { get; set; }

        public Dog() { Color = "흰색"; }
        public void Bart() { Console.WriteLine("왈왈왕ㅇ왕ㅇ오아ㅗㅇ알"); }
    }
}
