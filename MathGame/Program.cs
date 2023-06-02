Console.WriteLine("Please type your name");

string name = Console.ReadLine();
DateTime date = DateTime.Now;

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

if(gameSelected.Trim().ToLower() == "a")
{
    AdditionGame("Addition game selected");
} if(gameSelected.Trim().ToLower() == "s")
{
    SubtractionGame("Subtraction game is selected");
} if (gameSelected.Trim().ToLower() == "m")
{
    Multiplication("Multiplication game is selected");
} if(gameSelected.Trim().ToLower() == "d")
{
    Division("Division game is selected");
} if(gameSelected.Trim().ToLower() == "q")
{
    Console.WriteLine("Goodbye!");
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


