using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionWithInterfaces
{
    public class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Barking!!!");
        }

        public void Run()
        {
            Console.WriteLine("Running on four legs");
        }
    }
}
