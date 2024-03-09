using System.Diagnostics;

class Calculator
{
    static List<GameResult> gameResults = new List<GameResult>();

    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("MATH GAME");
            Console.WriteLine("---------");
            Console.WriteLine();
            Console.WriteLine("Here is your Menu:");
            Console.WriteLine("1. Start Game");
            Console.WriteLine("2. View Previous Games");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");

            switch (Console.ReadLine())
            {
                case "1":
                    StartGame();
                    break;
                case "2":
                    ViewPreviousGames();
                    break;
                case "3":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }

    static void StartGame()
    {
        Console.WriteLine();
        Console.WriteLine("Choose difficulty level:");
        Console.WriteLine("1. Easy (Numbers from 0 to 10)");
        Console.WriteLine("2. Medium (Numbers from 0 to 50)");
        Console.WriteLine("3. Hard (Numbers from 0 to 100)");
        Console.Write("Enter your choice: ");

        int levelChoice;
        if (!int.TryParse(Console.ReadLine(), out levelChoice) || levelChoice < 1 || levelChoice > 3)
        {
            Console.WriteLine("Invalid choice. Please enter a valid option.");
            return;
        }

        Console.Write("Enter number of questions: ");
        int numQuestions;
        if (!int.TryParse(Console.ReadLine(), out numQuestions) || numQuestions <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer for the number of questions.");
            return;
        }

        Random random = new Random();
        Stopwatch timer = new Stopwatch();
        timer.Start();

        int correctAnswers = 0;

        for (int i = 0; i < numQuestions; i++)
        {
            int num1 = 0, num2 = 0, result = 0;
            char operation = GetRandomOperation();
            switch (levelChoice)
            {
                case 1:
                    num1 = random.Next(11);
                    num2 = random.Next(11);
                    break;
                case 2:
                    num1 = random.Next(51);
                    num2 = random.Next(51);
                    break;
                case 3:
                    num1 = random.Next(101);
                    num2 = random.Next(101);
                    break;
            }

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        continue;
                    }
                    result = num1 / num2;
                    break;
            }

            Console.Write($"{num1} {operation} {num2} = ");
            int userAnswer;
            if (!int.TryParse(Console.ReadLine(), out userAnswer))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return;
            }

            if (userAnswer == result)
            {
                Console.WriteLine("Correct!");
                correctAnswers++;
            }
            else
            {
                Console.WriteLine($"Incorrect! The correct answer is {result}");
            }
        }

        timer.Stop();
        TimeSpan timeTaken = timer.Elapsed;

        gameResults.Add(new GameResult(numQuestions, correctAnswers, timeTaken));

        Console.WriteLine();
        Console.WriteLine($"Game Over! You answered {correctAnswers} out of {numQuestions} questions correctly.");
        Console.WriteLine($"Time taken: {timeTaken.Minutes} minutes {timeTaken.Seconds} seconds");
        Console.WriteLine();
    }

    static void ViewPreviousGames()
    {
        Console.WriteLine("Previous Games:");
        foreach (var game in gameResults)
        {
            Console.WriteLine($"Questions: {game.NumQuestions}, Correct Answers: {game.CorrectAnswers}, Time Taken: {game.TimeTaken}");
        }
    }

    static char GetRandomOperation()
    {
        Random random = new Random();
        string operations = "+-*/";
        return operations[random.Next(operations.Length)];
    }
}

class GameResult
{
    public int NumQuestions { get; }
    public int CorrectAnswers { get; }
    public TimeSpan TimeTaken { get; }

    public GameResult(int numQuestions, int correctAnswers, TimeSpan timeTaken)
    {
        NumQuestions = numQuestions;
        CorrectAnswers = correctAnswers;
        TimeTaken = timeTaken;
    }
}
