Console.WriteLine("Please enter your name:");

string name = Console.ReadLine();
DateTime date = DateTime.UtcNow;

if (string.IsNullOrEmpty(name))
    name = "Anonymous";

Console.WriteLine("------------------------------------------");
Console.WriteLine($"Hello {name}. It's {date.DayOfWeek}.");
Console.WriteLine("Welcome to your math game.");
Console.WriteLine(@"Please choose a game from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program
");
Console.WriteLine("------------------------------------------");

var gameSelected = Console.ReadLine().Trim().ToLower();

if (gameSelected == "a")
{
    Console.WriteLine("Addition game selected.");
}
else if (gameSelected == "s")
{
    Console.WriteLine("Subtraction game selected.");
}
else if (gameSelected == "m")
{
    Console.WriteLine("Multiplication game selected.");
}
else if (gameSelected == "d")
{
    Console.WriteLine("Division game selected.");
}
else
{
    Console.WriteLine("Invalid input detected. Goodbye!");
}
