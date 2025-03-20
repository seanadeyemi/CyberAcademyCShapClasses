using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Employee : Person
    {
        private string CompanyName;

        public Employee(string name, string companyName) : base(name)
        {
            CompanyName = companyName;
        }

        public void ShowEmployeeInfo()
        {
            ShowName();
            Console.WriteLine("I work at " + CompanyName);
        }
    }
}
