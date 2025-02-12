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

var gameSelected = Console.ReadLine()?.Trim().ToLower() ?? "";

switch (gameSelected)
{
    case "a":
        AdditionGame();
        break;
    case "s":
        SubtractionGame();
        break;
    case "m":
        MultiplicationGame();
        break;
    case "d":
        DivisionGame();
        break;
    default:
        Console.WriteLine("Invalid input detected. Application closing.");
        break;
}

void AdditionGame()
{
    Console.WriteLine("Addition game selected.");
}

void SubtractionGame()
{
    Console.WriteLine("Subtraction game selected.");
}

void MultiplicationGame()
{
    Console.WriteLine("Multiplication game selected.");
}

void DivisionGame()
{
    Console.WriteLine("Division game selected.");
}
