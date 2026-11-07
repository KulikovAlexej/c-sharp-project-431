class App
{
    public static void Main()
    {
        Console.WriteLine("Please enter the game number and press Enter.");

        Console.WriteLine("1 - Greet");
        Console.WriteLine("2 - Even");
        Console.WriteLine("0 - Exit");
        Console.Write("Your choice: ");
        string input = Console.ReadLine() ?? "";

        switch (input)
        {
            case "0":
                break;

            case "1":
                Cli.Greeting();
                break;

            case "2":
                Console.WriteLine("Even Game");
                EvenGame game = new EvenGame();
                game.Start();
                break;

            default:
                Console.WriteLine("Unknown command!");
                break;
        }

    }
}
