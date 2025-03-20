

Console.WriteLine("Hi there, what is your name?");
string? userName = Console.ReadLine();

Console.WriteLine("Hi " + userName + ", its nice meeting you!");

Console.WriteLine("What year were you born?");
string? birthYear = Console.ReadLine();

int birthYearInt = Convert.ToInt32(birthYear);

int age = 2025 - birthYearInt;

Console.WriteLine("You must be about " + age + " years old");

switch(birthYearInt)
{
    case 1980:
        Console.WriteLine("You are a millenial");
        break;
    case 1990:
        Console.WriteLine("You are unknown");
        break;
    case 2000:
        Console.WriteLine("You are a Gen Z");
        break;
    case 2010:
        Console.WriteLine("You are a generation Alpha");
        break;
    default:
        Console.WriteLine("You are an adult");
        break;
}


Console.ReadKey();


//int year = Convert.ToInt32("1990");

//  1990