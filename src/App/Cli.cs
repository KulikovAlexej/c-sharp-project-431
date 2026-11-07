class Cli
{
    public static string Greeting()
    {
        Console.WriteLine("Welcome to the Brain Games!");
        Console.Write("May I have your name? ");
        string input = Console.ReadLine() ?? "";
        Console.WriteLine("Hello, " + input + "!");
        return input;
    }
}
