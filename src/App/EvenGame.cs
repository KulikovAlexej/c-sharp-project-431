class EvenGame
{
    private const int winStreakLength = 3;

    private Random generator = new Random();

    private int GetRandomNumber()
    {
        return this.generator.Next(1, 21);
    }

    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public void Start()
    {
        string name = Cli.Greeting();
        int count = 0;

        Console.WriteLine("Answer 'yes' if the number is even, otherwise answer 'no'.");

        while (count < winStreakLength)
        {
            bool isSuccess = this.AskQuestion();
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

    private bool AskQuestion()
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
}