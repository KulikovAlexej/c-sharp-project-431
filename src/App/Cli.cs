class Cli
{
    public static void Greeting()
    {
        Console.Write("May I have your name? ");
        var input = Console.ReadLine();
        Console.WriteLine("Hello, " + input + "!");      
    }
}