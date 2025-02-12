using static System.Formats.Asn1.AsnWriter;

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

    int score = 0;
    var random = new Random();

    for (int i = 0; i < 5; i++)
    {
        int firstNumber = random.Next(1, 9);
        int secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. :(");
        }
    }

    Console.WriteLine($"Game over. Final score: {score}");
}

void SubtractionGame()
{
    Console.WriteLine("Subtraction game selected.");

    int score = 0;
    var random = new Random();

    for (int i = 0; i < 5; i++)
    {
        int firstNumber = random.Next(1, 9);
        int secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} - {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber - secondNumber)
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. :(");
        }
    }

    Console.WriteLine($"Game over. Final score: {score}");
}

void MultiplicationGame()
{
    Console.WriteLine("Multiplication game selected.");

    int score = 0;
    var random = new Random();

    for (int i = 0; i < 5; i++)
    {
        int firstNumber = random.Next(1, 9);
        int secondNumber = random.Next(1, 9);

        Console.WriteLine($"{firstNumber} * {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber * secondNumber)
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. :(");
        }
    }

    Console.WriteLine($"Game over. Final score: {score}");
}

void DivisionGame()
{
    Console.WriteLine("Division game selected.");

    int score = 0;
    var random = new Random();

    for (int i = 0; i < 5; i++)
    {
        int firstNumber = random.Next(0, 101);
        int secondNumber = random.Next(1, 11);

        while (firstNumber % secondNumber != 0)
        {
            firstNumber = random.Next(0, 101);
            secondNumber = random.Next(1, 11);
        }

        Console.WriteLine($"{firstNumber} / {secondNumber}");
        var result = Console.ReadLine();


        if (int.Parse(result) == firstNumber / secondNumber)
        {
            Console.WriteLine("Correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Incorrect. :(");
        }
    }
}
