using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExample
{
    internal class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("This cat is purring");
        }
    }
}
