namespace MathGame
{
    internal class Game
    {
        public List<int> History { get; set; } = [];

        public void Play()
        {
            Console.WriteLine("Please enter your name:");

            string name = Console.ReadLine() ?? "Anonymous";
            DateTime date = DateTime.UtcNow;

            List<string> games = new();

            Menu.Display(name, date);

            string gameSelected = Console.ReadLine()?.Trim().ToLower() ?? "";

            switch (gameSelected)
            {
                case "a":
                    History.Add(GameEngine.AdditionGame());
                    break;
                case "s":
                    History.Add(GameEngine.SubtractionGame());
                    break;
                case "m":
                    History.Add(GameEngine.MultiplicationGame());
                    break;
                case "d":
                    History.Add(GameEngine.DivisionGame());
                    break;
                default:
                    Console.WriteLine("Invalid input detected. Application closing.");
                    break;
            }

            Console.WriteLine("Would you like to play again? (Yes / No)");

            string playAgain = Console.ReadLine()?.Trim().ToLower() ?? "";

            while (playAgain != "yes" || playAgain != "no")
            {
                Console.WriteLine("Sorry, I don't understand that. Please input 'Yes' or 'No'");
                playAgain = Console.ReadLine()?.Trim().ToLower() ?? "";
            }

            return playAgain;
        }
    }
}
