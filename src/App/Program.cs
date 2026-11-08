class App
{
    public static void Main()
    {
        Console.WriteLine("Please enter the game number and press Enter.");

        Console.WriteLine("1 - Greet");
        Console.WriteLine("2 - Even");
        Console.WriteLine("3 - Calculator");
        Console.WriteLine("0 - Exit");
        Console.Write("Your choice: ");
        string input = Console.ReadLine() ?? "";

        switch (input)
        {
            case "0":
                return;

            case "1":
                Cli.Greeting();
                break;

            case "2":
                EvenGame evenGame = new EvenGame();
                Engine.StartGameLoop(evenGame);
                break;

            case "3":
                CalculatorGame calculatorGame = new CalculatorGame();
                Engine.StartGameLoop(calculatorGame);
                break;

            default:
                Console.WriteLine("Unknown command!");
                break;
        }

    }
}
