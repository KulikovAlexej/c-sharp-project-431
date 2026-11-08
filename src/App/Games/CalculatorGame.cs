class CalculatorGame:IGame
{
    private Random random = new Random();

    public bool AskQuestion()
    {
        int firstOperand = this.GetRandomNumber();
        int secondOperand = this.GetRandomNumber();
        string action = this.GetRandomAction();
        int rightAnswer = this.getRightAnswer(firstOperand, secondOperand, action);

        Console.WriteLine("Question: " + firstOperand + " " + action + " " + secondOperand);
        Console.Write("Your answer: ");
        string answer = Console.ReadLine() ?? "";

        if (answer == rightAnswer.ToString())
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
        return "What is the result of the expression?";
    }

    private int GetRandomNumber()
    {
        return this.random.Next(1, 21);
    }

    private string GetRandomAction()
    {
        string[] actions = ["+", "-", "*"];
        int index = this.random.Next(0, actions.Length);
        return actions[index];
    }

    private int getRightAnswer(int firstOperand, int secondOperand, string action)
    {
        switch(action)
        {
            case "+":
                return firstOperand + secondOperand;
            case "-":
                return firstOperand - secondOperand;
            case "*":
                return firstOperand * secondOperand;
            default:
                throw new ArgumentException("Непредусмотренная математическая операция!");
        }
    }
}