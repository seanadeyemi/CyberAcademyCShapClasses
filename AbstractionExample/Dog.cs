using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExample
{
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("This dog is barking");
        }
    }
}
