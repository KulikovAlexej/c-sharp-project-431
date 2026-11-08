class Engine
{
    private const int winStreakLength = 3;

    public static void StartGameLoop(IGame game)
    {
        string name = Cli.Greeting();
        int count = 0;

        Console.WriteLine(game.GetGameRules());

        while (count < winStreakLength)
        {
            bool isSuccess = game.AskQuestion();
            if (isSuccess)
            {
                count++;
            } else
            {
                Console.WriteLine($"Let's try again, {name}!");
                return;
            }
        }

        Console.WriteLine($"Congratulations, {name}!");
    }
}