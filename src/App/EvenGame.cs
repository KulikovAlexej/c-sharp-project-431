class EvenGame
{
    private int count = 0;

    private int winStreakLength = 3;

    private Random generator = new Random();

    private int getRandomNumber()
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

        Console.WriteLine("Answer 'yes' if the number is even, otherwise answer 'no'.");

        while (this.count < this.winStreakLength)
        {
            bool isSuccess = this.AskQuestion();
            if (isSuccess)
            {
                this.count++;
            } else
            {
                Console.WriteLine($"Let's try again, {name}!");
                break;
            }
        }

        if (this.count == this.winStreakLength)
        {
            Console.WriteLine($"Congratulations, {name}!");
        }

    }

    private bool AskQuestion()
    {
        int number = this.getRandomNumber();
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