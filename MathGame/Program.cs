Console.WriteLine("Please enter your name:");

string name = Console.ReadLine();
DateTime date = DateTime.UtcNow;

Console.WriteLine("------------------------------------------");
Console.WriteLine($"Hello {name}. It's {date}.");
Console.WriteLine("Welcome to your math game.");
Console.WriteLine(@"Please choose a game from the options below:
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program
");
Console.WriteLine("------------------------------------------");

Console.ReadLine();
