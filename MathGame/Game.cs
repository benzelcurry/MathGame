namespace MathGame
{
    internal class Game
    {
        public List<int> History { get; set; } = new List<int>();

        public void Play()
        {
            Console.WriteLine("Please enter your name:");

            string name = Console.ReadLine() ?? "Anonymous";
            DateTime date = DateTime.UtcNow;

            List<string> games = new();

            Menu.Display(name, date);

            var gameSelected = Console.ReadLine()?.Trim().ToLower() ?? "";

            switch (gameSelected)
            {
                case "a":
                    GameEngine.AdditionGame();
                    break;
                case "s":
                    GameEngine.SubtractionGame();
                    break;
                case "m":
                    GameEngine.MultiplicationGame();
                    break;
                case "d":
                    GameEngine.DivisionGame();
                    break;
                default:
                    Console.WriteLine("Invalid input detected. Application closing.");
                    break;
            }
        }
    }
}
