namespace ConsoleAppExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int laptopCount = 34;



            /***
             Here is the special code for sending a message to the console
             ***/

            //data types: int, string, double, float, decimal, bool, byte, char
            int laptopCount;
            laptopCount = 35;

            string laptopModel = "Dell Latitude 5480";
            double laptopTotal = 1234.56;
            float laptopWidth = 12.34f;
            decimal laptopHeight = 12.34m;
            bool laptopVisible = false;
            byte laptopColor = 255;
            char laptopLetter = 'A';


            //laptopCount++;

            //String name;
            //Double y;
            //Single z;
            //Double j;
            //Decimal k;
            //Boolean l;
            //Byte m;
            //Char n;


            //operators: +, -, *, /, %, ++, --
            //comparison: ==, !=, >, <, >=, <=
            //logical: &&, ||, !
            //bitwise: &, |, ^, ~, <<, >>

            if (laptopCount == 0 && laptopCount == 35) 
            {
                Console.WriteLine("Laptops are available");
            }

            //if(laptopCount < 0)
            //{
            //    Console.WriteLine("Laptops are not available");
            //}

            //if(laptopCount == 34)
            //{
            //    Console.WriteLine("34 Laptops are available");
            //}

            //if(laptopCount != 34)
            //{
            //    Console.WriteLine("34 Laptops are not available");
            //}


            //This code will write Hello World to the screen
            //Console.WriteLine("Hello, World!");

            //Console.WriteLine(laptopCount);

            //Console.WriteLine(laptopModel);

            Console.ReadKey();
        }
    }
}
