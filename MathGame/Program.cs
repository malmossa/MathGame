using System.Threading.Channels;
using static System.Formats.Asn1.AsnWriter;

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
    Console.WriteLine("\n");

    bool isGameOn = true;

    do
    {
        Console.Clear();
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
                AdditionGame("Addition game ");
                break;
            case "s":
                SubtractionGame("Subtraction game is ");
                break;
            case "m":
                Multiplication("Multiplication game is ");
                break;
            case "d":
                Division("Division game is ");
                break;
            case "q":
                Console.WriteLine("Goodbye!");
                isGameOn = false;
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid Input");
                Environment.Exit(0);
                break;
        }

    } while (isGameOn);

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
            Console.WriteLine("Your answer was correct! Type any key for next question.");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect. Type any key for next question.");
            score++; Console.ReadLine();
        }

        if (i == 4)
        {
            Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
            Console.ReadLine();
        }
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
            Console.WriteLine("Your answer was correct! Type any key for next question.");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect. Type any key for next question.");
            score++; Console.ReadLine();
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
            Console.WriteLine("Your answer was correct! Type any key for next question.");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect. Type any key for next question.");
            score++; Console.ReadLine();
        }

        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
    }
}

void Division(string message)
{
    Console.Clear();
    Console.WriteLine(message);
    int score = 0;
    for (int i = 0; i < 5; i++)
    {
        int[] divisionNumber = GetDivisionNumbers();
        int firstNumber = divisionNumber[0];
        int secondNumber = divisionNumber[1];

        Console.WriteLine($"{firstNumber} / {secondNumber}");
        string result = Console.ReadLine();

        if (int.Parse(result) == firstNumber / secondNumber)
        {
            Console.WriteLine("Your answer was correct! Type any key for next question.");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect. Type any key for next question.");
            score++; Console.ReadLine();
        }

        if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
    }
}


int[] GetDivisionNumbers() 
{

    Random random = new Random();
    int firstNumber = random.Next(0, 99);
    int secontNumber = random.Next(0, 99);

    int[] result = new int[2];

    while(firstNumber % secontNumber != 0)
    {
        firstNumber = random.Next(1, 99);
        secontNumber = random.Next(1, 99);
    }

    result[0] = firstNumber;
    result[1] = secontNumber;


    return result;
}

Console.ReadLine();
