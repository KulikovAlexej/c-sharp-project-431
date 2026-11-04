class Cli
{
    public static void Greeting()
    {
        Console.WriteLine("Как тебя зовут?");
        var input = Console.ReadLine();
        Console.WriteLine("Добро пожаловать " + input + "!");      
    }
}