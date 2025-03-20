
Console.WriteLine("Hi there, what is your name?");
string? userName = Console.ReadLine();

Console.WriteLine("Hi "+userName+", its nice meeting you!");

Console.WriteLine("What year were you born?");
string? birthYear = Console.ReadLine();

int birthYearInt = Convert.ToInt32(birthYear);

int age  = 2025 - birthYearInt;

Console.WriteLine("You must be about "+age+" years old");

if(birthYearInt >= 1980 && birthYearInt < 1990)
{
    Console.WriteLine("You are a millenial");
}
else if (birthYearInt >= 1990 && birthYearInt < 2000)
{
    Console.WriteLine("You are unknown");
}
else if(birthYearInt >= 2000 && birthYearInt < 2010)
{
    Console.WriteLine("You are a Gen Z");
}
else if(birthYearInt < 1980)
{
    Console.WriteLine("You are a baby boomer");
}
else if(birthYearInt >= 2010)
{
    Console.WriteLine("You are a generation Alpha");
}
else
{
    Console.WriteLine("You are an adult");
}


Console.ReadKey();


//int year = Convert.ToInt32("1990");

  //  1990