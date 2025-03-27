using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionWithInterfaces
{
    public class Jungle
    {
        private IAnimal _animal;
        public Jungle(IAnimal animal)
        {
            _animal = animal;
        }


        public void ForceAnimalsToMakeSound(IAnimal animal)
        {
            animal.MakeSound();
        }

        public void MakeAnimalMakeSound()
        { 
            _animal.MakeSound(); 
        }



    }
}
