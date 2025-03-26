using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionWithInterfaces
{
    public class Jungle
    {



        public void ForceAnimalsToMakeSound(IAnimal animal)
        {
            animal.MakeSound();
        }
    }
}
