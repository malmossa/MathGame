
Header();
string name = GetUserName();
GreetingMessage(name);
MenuOptions();
Game(name);



void Header()
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


void GreetingMessage(string name)
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


string GetUserName()
{
    Console.Write("First, let's get to know you. What is your name? ");
    string name = Console.ReadLine().ToUpper();
    return name;
}

void MenuOptions()
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


void Game(string name)
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
            Add();
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


void Add()
{
    Random random = new Random();
    int randomNumber_1 = 0;
    int randomNumber_2 = 0;
    int numberOfQuestionsAsked = 0;

    Console.Write("How many questions do you want your game to be? ");
    int userQuestionsChoice = Convert.ToInt32(Console.ReadLine());

    Console.Write("What is the numbers range? 'A' 1 to 10. 'B' 1 to 50. 'C' 1 to 100. Your choise: " );
    string userChoice = Console.ReadLine().Trim().ToUpper();

    switch(userChoice)
    {
        case "A":
            while(numberOfQuestionsAsked != userQuestionsChoice)
            {
                randomNumber_1 = random.Next(1, 10);
                randomNumber_2 = random.Next(1, 10);
                Console.Write($"What is {randomNumber_1} + {randomNumber_2} = ");
                int userAnswer = Convert.ToInt32(Console.ReadLine());

                if ((randomNumber_1 + randomNumber_2) == userAnswer)
                {
                    Console.WriteLine($"That is currect, Great job.");
                    numberOfQuestionsAsked++;
                } else
                {
                    Console.WriteLine($"That is NOT currect, That is stupid");
                    numberOfQuestionsAsked++;
                }
            }
            Console.WriteLine("Do you want to play again? ");
            break;
        case "B":
            randomNumber_1 = random.Next(1, 50);
            randomNumber_2 = random.Next(1, 50);
            break;
        case "C":
            randomNumber_1 = random.Next(1, 100);
            randomNumber_2 = random.Next(1, 100);
            break;
    }

   
        
}




Console.ReadLine();