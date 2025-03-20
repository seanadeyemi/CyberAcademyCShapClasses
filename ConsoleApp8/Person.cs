using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Person
    {
        protected string Name;

        public Person(string name)
        {
            Name = name;
        }

        public void ShowName()
        {
            Console.WriteLine("My name is " + Name);
        }
    }
}
