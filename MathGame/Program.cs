using System.Threading.Channels;

DateTime date = DateTime.Now;

string name = GetName();

Menu(name);
static string GetName()
{
    Console.WriteLine("Please type your name");
    string name = Console.ReadLine();
    return name;
}
void Menu(string name)
{
    Console.WriteLine("---------------------------------");
    Console.WriteLine($"Hello {name}. It's {date}. This is your math's game. That's great that you're working on improving yourself\n");
    Console.WriteLine(@$"What game would you like to play today? Choose from the options below:
                   A - Addition.
                   S - Subtraction.
                   M - Multiplication.
                   D - Division.
                   Q - Quit the program.");
    Console.WriteLine("---------------------------------");

    string gameSelected = Console.ReadLine();

    switch (gameSelected.Trim().ToLower())
    {
        case "a":
            AdditionGame("Addition game selected");
            break;
        case "s":
            SubtractionGame("Subtraction game is selected");
            break;
        case "m":
            Multiplication("Multiplication game is selected");
            break;
        case "d":
            Division("Division game is selected");
            break;
        case "q":
            Console.WriteLine("Goodbye!");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid Input");
            Environment.Exit(0);
            break;
    }
}

void AdditionGame(string message)
{
    Console.WriteLine(message);

    Random random = new Random();
    int score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);
        Console.WriteLine($"{firstNumber} + {secondNumber}");
        string result = Console.ReadLine();
        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("Your answer was correct!");
            score++;
        } else 
        {
            Console.WriteLine("Your answer was not correct!");
        }

        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
    }

}

void SubtractionGame(string message)
{
    Console.WriteLine(message);

    Random random = new Random();
    int score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);
        Console.WriteLine($"{firstNumber} - {secondNumber}");
        string result = Console.ReadLine();
        if (int.Parse(result) == firstNumber - secondNumber)
        {
            Console.WriteLine("Your answer was correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was not correct!");
        }

        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
    }
}

void Multiplication(string message)
{
    Console.WriteLine(message);

    Random random = new Random();
    int score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);
        Console.WriteLine($"{firstNumber} * {secondNumber}");
        string result = Console.ReadLine();
        if (int.Parse(result) == firstNumber * secondNumber)
        {
            Console.WriteLine("Your answer was correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was not correct!");
        }

        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
    }
}

void Division(string message)
{
    Console.WriteLine(message);

    Random random = new Random();
    int score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);
        Console.WriteLine($"{firstNumber} / {secondNumber}");
        string result = Console.ReadLine();
        if (int.Parse(result) == firstNumber / secondNumber)
        {
            Console.WriteLine("Your answer was correct!");
            score++;
        }
        else
        {
            Console.WriteLine("Your answer was not correct!");
        }

        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
    }
}



Console.ReadLine();
