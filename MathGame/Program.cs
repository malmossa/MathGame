
Header();
string name = GetUserName();
GreetingMessage(name);
MenuOptions();
Game(name);


static void Header()
{
 Console.WriteLine(@"
                                   _   _     
                                  | | | |    
                   _ __ ___   __ _| |_| |__  
                  | '_ ` _ \ / _` | __| '_ \ 
                  | | | | | | (_| | |_| | | |
  WELCOME TO THE  |_| |_| |_|\__,_|\__|_| |_| GAME
 ");
  Console.WriteLine("*******************************************************\n");
}


static void GreetingMessage(string name)
{
    Console.WriteLine();
    DateTime time = DateTime.Now;
    string currentTime = time.ToString("HH"); // Time in 24 Hours
    int currentTimeInt = Convert.ToInt32(currentTime);

    Console.WriteLine();
    
    if (currentTimeInt >= 1 && currentTimeInt <= 12)
    {
        Console.WriteLine($"Good Morning {name}, Please choose from the menu below..");
    } else if (currentTimeInt > 12 && currentTimeInt <= 17)
    {
        Console.WriteLine($"Good afternoon {name}, Please choose from the menu below..");
    } else
    {
        Console.WriteLine($"Good evening {name}, Please choose from the menu below: ");
    }

}


static string GetUserName()
{
    Console.Write("First, let's get to know you. What is your name? ");
    string name = Console.ReadLine();
    return name;
}

static void MenuOptions()
{
    Console.WriteLine(@"
'V' View previous games.
'A' Add.
'S' Subtract.
'M' Multiply.
'D' Divide.
'R' Random.
'E' Exit.");
}


static void Game(string name)
{
    Console.WriteLine();

    Console.Write("Your choice: ");
    string userChoice = Console.ReadLine().Trim().ToUpper();

    switch(userChoice)
    {
        case "V":
            Console.WriteLine("You chose: V");
            break;
        case "A":
            Console.WriteLine("You chose: A");
            break;
        case "S":
            Console.WriteLine("You chose: S");
            break;
        case "M":
            Console.WriteLine("You chose: M");
            break;
        case "D":
            Console.WriteLine("You chose: D");
            break;
        case "R":
            Console.WriteLine("You chose: R");
            break;
        case "E":
            Console.WriteLine($"GOOD BY.. {name}");
            Environment.Exit(0);
            break;
        default: 
            Console.WriteLine("Invalid input..");
            break;
    }
}





Console.ReadLine();