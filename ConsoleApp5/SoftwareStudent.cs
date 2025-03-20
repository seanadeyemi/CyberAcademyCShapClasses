using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class SoftwareStudent
    {
        public void PrintSoftwareStudent()
        {
            Console.WriteLine("Software Student");
        }

        public void MultiplyNumbers(int number1, int number2)
        {
            int result = number1 * number2;
            Console.WriteLine("The answer is " + result);
        }
        public void MultiplyNumbers(int number1, int number2,int number3)
        {
            int result = number1 * number2 * number3;
            Console.WriteLine("The answer is " + result);
        }


        public int AddNumbers(int number1, int number2)
        {
            SoftwareStudent.WriteTodaysDate();

            int result = number1 + number2;
            return result;
        }

        public static void WriteTodaysDate()
        {


            Console.WriteLine(System.DateTime.Now);
        }
    }
}
