Console.WriteLine("Please type your name");

string name = Console.ReadLine();
DateTime date = DateTime.Now;

Menu(name, date);
void Menu(string name, DateTime date)
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
}

void SubtractionGame(string message)
{
    Console.WriteLine(message);
}

void Multiplication(string message)
{
    Console.WriteLine(message);
}

void Division(string message)
{
    Console.WriteLine(message);
}



Console.ReadLine();
