using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionExample
{
    public abstract class Animal
    {
        public abstract void MakeSound();

        public void Jump()
        {

            Console.WriteLine("Jumping");
        }
    }
}
