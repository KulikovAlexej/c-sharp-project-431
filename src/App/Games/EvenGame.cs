class EvenGame:IGame
{
    private Random generator = new Random();

    private int GetRandomNumber()
    {
        return this.generator.Next(1, 21);
    }

    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public bool AskQuestion()
    {
        int number = this.GetRandomNumber();
        bool isEven = IsEven(number);
        string rightAnswer = isEven ? "yes" : "no";

        Console.WriteLine("Question: " + number);
        Console.Write("Your answer: ");
        string answer = Console.ReadLine() ?? "";

        if (answer == rightAnswer)
        {
            Console.WriteLine("Correct!");
            return true;
        } else
        {
            Console.WriteLine($"'{answer}' is wrong answer ;(. Correct answer was '{rightAnswer}'.");
            return false;
        }

    }

    public string GetGameRules()
    {
        return "Answer 'yes' if the number is even, otherwise answer 'no'.";
    }
}