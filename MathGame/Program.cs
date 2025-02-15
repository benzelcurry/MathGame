using MathGame;

Console.WriteLine("Please enter your name:");

string name = Console.ReadLine();
DateTime date = DateTime.UtcNow;

List<string> games = new();

if (string.IsNullOrEmpty(name))
    name = "Anonymous";

Menu.Display(name, date);

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
