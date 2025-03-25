using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample
{
    public class Boat : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Boat is being driven");
        }
    }
}
