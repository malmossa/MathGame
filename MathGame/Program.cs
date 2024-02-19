using System.Diagnostics;

Console.Title = "The Math Game";

Header();
Console.Write("First, let's get to know you. What is your name? ");
string name = Console.ReadLine().ToUpper();

List<string> gamesHistory = new List<string>();

GreetingMessage(name);

bool playAgain = true;
while (playAgain)
{
    MenuOptions();
    Game(name);
    Console.WriteLine();

    Console.Write("Do you want to play agin or go back to main menu? N/Y: ");
    string input = Console.ReadLine().Trim().ToUpper();

    if(input == "Y") { playAgain = true; }
    if(input == "N") 
    { 
        playAgain = false;
        Console.WriteLine($"GOOD BY.. {name}");
        Environment.Exit(0);
    }
}

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
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("*******************************************************\n");
    Console.ResetColor();
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

void MenuOptions()
{
    Console.WriteLine(@"
'V' View Games History.
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
            ViewHistory();
            break;
        case "A":
            Add();
            break;
        case "S":
            Subtract();
            break;
        case "M":
            Multiply();
            break;
        case "D":
            Division();
            break;
        case "R":
            Random();
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
    Stopwatch timer = new Stopwatch();
    Random random = new Random();
    int randomNumber_1 = 0;
    int randomNumber_2 = 0;
    int numberOfQuestionsAsked = 0;

    int correctAnswer = 0;
    int wrongAnswer = 0;

    Console.Write("How many questions do you want your game to be? ");
    int userQuestionsChoice = Convert.ToInt32(Console.ReadLine());

    Console.Write("What is the numbers range? 'E' for easy (1 to 10). 'M' for medium (1 to 50). 'D' for difficult (1 to 100). Your choise: " );
    string userChoice = Console.ReadLine().Trim().ToUpper();

    switch(userChoice)
    {
        case "E":

            while(numberOfQuestionsAsked != userQuestionsChoice)
            {
                timer.Start();
                randomNumber_1 = random.Next(1, 11);
                randomNumber_2 = random.Next(1, 11);
                Console.Write($"What is {randomNumber_1} + {randomNumber_2} = ");
                int userAnswer = Convert.ToInt32(Console.ReadLine());

                if ((randomNumber_1 + randomNumber_2) == userAnswer)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("CORRECT!");
                    Console.ResetColor();
                   
                    correctAnswer++;
                    numberOfQuestionsAsked++;
                } else
                {
                    Console.ForegroundColor = ConsoleColor.Red; 
                    Console.WriteLine($"Sorry wrong!");
                    Console.ResetColor();
                 
                    wrongAnswer++;
                    numberOfQuestionsAsked++;
                }
                timer.Stop();              
            }
            

            Console.WriteLine();
            Console.WriteLine("GAME OVER..\n");
            Console.WriteLine("Game Result: ");
            Console.WriteLine("------------------");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Correct: {correctAnswer}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Wrong: {wrongAnswer}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Time: {timer.Elapsed.ToString("mm\\:ss")}");
            Console.ResetColor();

            AddToHistory("Additions easy", userQuestionsChoice, correctAnswer, wrongAnswer);

            break;
        case "M":
            while (numberOfQuestionsAsked != userQuestionsChoice)
            {
                timer.Start();
                randomNumber_1 = random.Next(1, 51);
                randomNumber_2 = random.Next(1, 51);
                Console.Write($"What is {randomNumber_1} + {randomNumber_2} = ");
                int userAnswer = Convert.ToInt32(Console.ReadLine());

                if ((randomNumber_1 + randomNumber_2) == userAnswer)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("CORRECT!");
                    Console.ResetColor();

                    correctAnswer++;
                    numberOfQuestionsAsked++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Sorry wrong!");
                    Console.ResetColor();

                    wrongAnswer++;
                    numberOfQuestionsAsked++;
                }
                timer.Stop();
             
            }

            Console.WriteLine();
            Console.WriteLine("GAME OVER..\n");
            Console.WriteLine("Game Result: ");
            Console.WriteLine("------------------");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Correct: {correctAnswer}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Wrong: {wrongAnswer}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Time: {timer.Elapsed.ToString("mm\\:ss")}");
            Console.ResetColor();

            AddToHistory("Additions medium", userQuestionsChoice, correctAnswer, wrongAnswer);

            break;
        case "D":
            while (numberOfQuestionsAsked != userQuestionsChoice)
            {
                timer.Start();
                randomNumber_1 = random.Next(1, 101);
                randomNumber_2 = random.Next(1, 101);
                Console.Write($"What is {randomNumber_1} + {randomNumber_2} = ");
                int userAnswer = Convert.ToInt32(Console.ReadLine());

                if ((randomNumber_1 + randomNumber_2) == userAnswer)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("CORRECT!");
                    Console.ResetColor();

                    correctAnswer++;
                    numberOfQuestionsAsked++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Sorry wrong!");
                    Console.ResetColor();

                    wrongAnswer++;
                    numberOfQuestionsAsked++;
                }
                timer.Stop();
            }

            Console.WriteLine();
            Console.WriteLine("GAME OVER..\n");
            Console.WriteLine("Game Result: ");
            Console.WriteLine("------------------");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Correct: {correctAnswer}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Wrong: {wrongAnswer}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Time: {timer.Elapsed.ToString("mm\\:ss")}");
            Console.ResetColor();

            AddToHistory("Additions difficult", userQuestionsChoice, correctAnswer, wrongAnswer);

            break;
    }
      
}

void AddToHistory(string type, int questions,int correct, int wrong)
{
    gamesHistory.Add($"Game Played: {type}, Numbers of Questions: {questions}, Correct Answers: {correct}, Wrong Answers: {wrong}");
}

void ViewHistory()
{
    foreach(string game in gamesHistory)
    {
        Console.WriteLine(game);
    }
}

void Subtract()
{
    Stopwatch timer = new Stopwatch();
    Random random = new Random();
    int randomNumber_1 = 0;
    int randomNumber_2 = 0;
    int numberOfQuestionsAsked = 0;

    int correctAnswer = 0;
    int wrongAnswer = 0;

    Console.Write("How many questions do you want your game to be? ");
    int userQuestionsChoice = Convert.ToInt32(Console.ReadLine());

    Console.Write("What is the numbers range? 'E' for easy (1 to 10). 'M' for medium (1 to 50). 'D' for difficult (1 to 100). Your choise: ");
    string userChoice = Console.ReadLine().Trim().ToUpper();

    switch (userChoice)
    {
        case "E":

            while (numberOfQuestionsAsked != userQuestionsChoice)
            {
                timer.Start();
                randomNumber_1 = random.Next(1, 10);
                randomNumber_2 = random.Next(1, 10);
                Console.Write($"What is {randomNumber_1} - {randomNumber_2} = ");
                int userAnswer = Convert.ToInt32(Console.ReadLine());

                if ((randomNumber_1 - randomNumber_2) == userAnswer)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("CORRECT!");
                    Console.ResetColor();

                    correctAnswer++;
                    numberOfQuestionsAsked++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Sorry wrong!");
                    Console.ResetColor();

                    wrongAnswer++;
                    numberOfQuestionsAsked++;
                }
                timer.Stop();
            }

            Console.WriteLine();
            Console.WriteLine("GAME OVER..\n");
            Console.WriteLine("Game Result: ");
            Console.WriteLine("------------------");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Correct: {correctAnswer}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Wrong: {wrongAnswer}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Time: {timer.Elapsed.ToString("mm\\:ss")}");
            Console.ResetColor();

            AddToHistory("Subtraction easy", userQuestionsChoice, correctAnswer, wrongAnswer);

            break;
        case "M":
            while (numberOfQuestionsAsked != userQuestionsChoice)
            {
                timer.Start();
                randomNumber_1 = random.Next(1, 50);
                randomNumber_2 = random.Next(1, 50);
                Console.Write($"What is {randomNumber_1} - {randomNumber_2} = ");
                int userAnswer = Convert.ToInt32(Console.ReadLine());

                if ((randomNumber_1 - randomNumber_2) == userAnswer)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("CORRECT!");
                    Console.ResetColor();

                    correctAnswer++;
                    numberOfQuestionsAsked++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Sorry wrong!");
                    Console.ResetColor();

                    wrongAnswer++;
                    numberOfQuestionsAsked++;
                }
                timer.Stop();
            }

            Console.WriteLine();
            Console.WriteLine("GAME OVER..\n");
            Console.WriteLine("Game Result: ");
            Console.WriteLine("------------------");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Correct: {correctAnswer}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Wrong: {wrongAnswer}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Time: {timer.Elapsed.ToString("mm\\:ss")}");
            Console.ResetColor();

            AddToHistory("Subtraction medium", userQuestionsChoice, correctAnswer, wrongAnswer);

            break;
        case "D":
            while (numberOfQuestionsAsked != userQuestionsChoice)
            {
                timer.Start();
                randomNumber_1 = random.Next(1, 100);
                randomNumber_2 = random.Next(1, 100);
                Console.Write($"What is {randomNumber_1} - {randomNumber_2} = ");
                int userAnswer = Convert.ToInt32(Console.ReadLine());

                if ((randomNumber_1 - randomNumber_2) == userAnswer)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("CORRECT!");
                    Console.ResetColor();

                    correctAnswer++;
                    numberOfQuestionsAsked++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Sorry wrong!");
                    Console.ResetColor();

                    wrongAnswer++;
                    numberOfQuestionsAsked++;
                }
                timer.Stop();
            }

            Console.WriteLine();
            Console.WriteLine("GAME OVER..\n");
            Console.WriteLine("Game Result: ");
            Console.WriteLine("------------------");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Correct: {correctAnswer}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Wrong: {wrongAnswer}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Time: {timer.Elapsed.ToString("mm\\:ss")}");
            Console.ResetColor();

            AddToHistory("Subtraction difficult", userQuestionsChoice, correctAnswer, wrongAnswer);

            break;
    }

}

void Multiply()
{
    Stopwatch timer = new Stopwatch();
    Random random = new Random();
    int randomNumber_1 = 0;
    int randomNumber_2 = 0;
    int numberOfQuestionsAsked = 0;

    int correctAnswer = 0;
    int wrongAnswer = 0;

    Console.Write("How many questions do you want your game to be? ");
    int userQuestionsChoice = Convert.ToInt32(Console.ReadLine());

    Console.Write("What is the numbers range? 'E' for easy (1 to 10). 'M' for medium (1 to 50). 'D' for difficult (1 to 100). Your choise: ");
    string userChoice = Console.ReadLine().Trim().ToUpper();

    switch (userChoice)
    {
        case "E":

            while (numberOfQuestionsAsked != userQuestionsChoice)
            {
                timer.Start();
                randomNumber_1 = random.Next(1, 10);
                randomNumber_2 = random.Next(1, 10);
                Console.Write($"What is {randomNumber_1} x {randomNumber_2} = ");
                int userAnswer = Convert.ToInt32(Console.ReadLine());

                if ((randomNumber_1 * randomNumber_2) == userAnswer)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("CORRECT!");
                    Console.ResetColor();

                    correctAnswer++;
                    numberOfQuestionsAsked++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Sorry wrong!");
                    Console.ResetColor();

                    wrongAnswer++;
                    numberOfQuestionsAsked++;
                }
                timer.Stop();
            }

            Console.WriteLine();
            Console.WriteLine("GAME OVER..\n");
            Console.WriteLine("Game Result: ");
            Console.WriteLine("------------------");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Correct: {correctAnswer}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Wrong: {wrongAnswer}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Time: {timer.Elapsed.ToString("mm\\:ss")}");
            Console.ResetColor();

            AddToHistory("Multiplication easy", userQuestionsChoice, correctAnswer, wrongAnswer);

            break;
        case "M":
            while (numberOfQuestionsAsked != userQuestionsChoice)
            {
                timer.Start();
                randomNumber_1 = random.Next(1, 50);
                randomNumber_2 = random.Next(1, 50);
                Console.Write($"What is {randomNumber_1} x {randomNumber_2} = ");
                int userAnswer = Convert.ToInt32(Console.ReadLine());

                if ((randomNumber_1 * randomNumber_2) == userAnswer)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("CORRECT!");
                    Console.ResetColor();

                    correctAnswer++;
                    numberOfQuestionsAsked++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Sorry wrong!");
                    Console.ResetColor();

                    wrongAnswer++;
                    numberOfQuestionsAsked++;
                }
                timer.Stop();
            }

            Console.WriteLine();
            Console.WriteLine("GAME OVER..\n");
            Console.WriteLine("Game Result: ");
            Console.WriteLine("------------------");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Correct: {correctAnswer}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Wrong: {wrongAnswer}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Time: {timer.Elapsed.ToString("mm\\:ss")}");
            Console.ResetColor();

            AddToHistory("Multiplication medium", userQuestionsChoice, correctAnswer, wrongAnswer);

            break;
        case "D":
            while (numberOfQuestionsAsked != userQuestionsChoice)
            {
                timer.Start();
                randomNumber_1 = random.Next(1, 100);
                randomNumber_2 = random.Next(1, 100);
                Console.Write($"What is {randomNumber_1} x {randomNumber_2} = ");
                int userAnswer = Convert.ToInt32(Console.ReadLine());

                if ((randomNumber_1 * randomNumber_2) == userAnswer)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("CORRECT!");
                    Console.ResetColor();

                    correctAnswer++;
                    numberOfQuestionsAsked++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Sorry wrong!");
                    Console.ResetColor();

                    wrongAnswer++;
                    numberOfQuestionsAsked++;
                }
                timer.Stop();
            }

            Console.WriteLine();
            Console.WriteLine("GAME OVER..\n");
            Console.WriteLine("Game Result: ");
            Console.WriteLine("------------------");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Correct: {correctAnswer}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Wrong: {wrongAnswer}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Time: {timer.Elapsed.ToString("mm\\:ss")}");
            Console.ResetColor();

            AddToHistory("Multiplication difficult", userQuestionsChoice, correctAnswer, wrongAnswer);


            break;
    }

}

void Division()
{
    Stopwatch timer = new Stopwatch();
    Random random = new Random();
    int randomNumber_1 = 0;
    int randomNumber_2 = 0;
    int numberOfQuestionsAsked = 0;

    int correctAnswer = 0;
    int wrongAnswer = 0;

    Console.Write("How many questions do you want your game to be? ");
    int userQuestionsChoice = Convert.ToInt32(Console.ReadLine());

    Console.Write("What is the numbers range? 'E' for easy (1 to 10). 'M' for medium (1 to 50). 'D' for difficult (1 to 100). Your choise: ");
    string userChoice = Console.ReadLine().Trim().ToUpper();

    switch (userChoice)
    {
        case "E":
            while (numberOfQuestionsAsked != userQuestionsChoice)
            {
                bool isInteger = true;

                while(isInteger)
                {
                    timer.Start();
                    randomNumber_1 = random.Next(1, 11);
                    randomNumber_2 = random.Next(1, 11);

                    if(randomNumber_1 % randomNumber_2 == 0)
                    {
                        Console.Write($"What is {randomNumber_1} / {randomNumber_2} = ");
                        int userAnswer = Convert.ToInt32(Console.ReadLine());
           
                        if ((randomNumber_1 / randomNumber_2) == userAnswer)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("CORRECT!");
                            Console.ResetColor();

                            correctAnswer++;
                            numberOfQuestionsAsked++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Sorry wrong!");
                            Console.ResetColor();

                            wrongAnswer++;
                            numberOfQuestionsAsked++;
                        }
                        isInteger = false;
                    } 
                    timer.Stop();

                }
              
            }

            Console.WriteLine();
            Console.WriteLine("GAME OVER..\n");
            Console.WriteLine("Game Result: ");
            Console.WriteLine("------------------");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Correct: {correctAnswer}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Wrong: {wrongAnswer}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Time: {timer.Elapsed.ToString("mm\\:ss")}");
            Console.ResetColor();

            AddToHistory("Division easy", userQuestionsChoice, correctAnswer, wrongAnswer);
            break;
        case "M":
            while (numberOfQuestionsAsked != userQuestionsChoice)
            {
                bool isInteger = true;

                while (isInteger)
                {
                    timer.Start();
                    randomNumber_1 = random.Next(1, 51);
                    randomNumber_2 = random.Next(1, 51);

                    if (randomNumber_1 % randomNumber_2 == 0)
                    {
                        Console.Write($"What is {randomNumber_1} / {randomNumber_2} = ");
                        int userAnswer = Convert.ToInt32(Console.ReadLine());

                        if ((randomNumber_1 / randomNumber_2) == userAnswer)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("CORRECT!");
                            Console.ResetColor();

                            correctAnswer++;
                            numberOfQuestionsAsked++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Sorry wrong!");
                            Console.ResetColor();

                            wrongAnswer++;
                            numberOfQuestionsAsked++;
                        }
                        isInteger = false;
                    }
                    timer.Stop();

                }

            }

            Console.WriteLine();
            Console.WriteLine("GAME OVER..\n");
            Console.WriteLine("Game Result: ");
            Console.WriteLine("------------------");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Correct: {correctAnswer}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Wrong: {wrongAnswer}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Time: {timer.Elapsed.ToString("mm\\:ss")}");
            Console.ResetColor();

            AddToHistory("Division easy", userQuestionsChoice, correctAnswer, wrongAnswer);

            break;
        case "D":
            while (numberOfQuestionsAsked != userQuestionsChoice)
            {
                bool isInteger = true;

                while (isInteger)
                {
                    timer.Start();
                    randomNumber_1 = random.Next(1, 101);
                    randomNumber_2 = random.Next(1, 101);

                    if (randomNumber_1 % randomNumber_2 == 0)
                    {
                        Console.Write($"What is {randomNumber_1} / {randomNumber_2} = ");
                        int userAnswer = Convert.ToInt32(Console.ReadLine());

                        if ((randomNumber_1 / randomNumber_2) == userAnswer)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("CORRECT!");
                            Console.ResetColor();

                            correctAnswer++;
                            numberOfQuestionsAsked++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Sorry wrong!");
                            Console.ResetColor();

                            wrongAnswer++;
                            numberOfQuestionsAsked++;
                        }
                        isInteger = false;
                    }
                    timer.Stop();
                }

            }

            Console.WriteLine();
            Console.WriteLine("GAME OVER..\n");
            Console.WriteLine("Game Result: ");
            Console.WriteLine("------------------");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Correct: {correctAnswer}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Wrong: {wrongAnswer}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Time: {timer.Elapsed.ToString("mm\\:ss")}");
            Console.ResetColor();

            AddToHistory("Division easy", userQuestionsChoice, correctAnswer, wrongAnswer);

            break;
    }
}
void Random()
{
    Stopwatch timer = new Stopwatch();
    Random random = new Random();

    int randomNumber_1 = 0;
    int randomNumber_2 = 0;


    int numberOfQuestionsAsked = 0;

    int correctAnswer = 0;
    int wrongAnswer = 0;

    Console.Write("How many questions do you want your game to be? ");
    int userQuestionsChoice = Convert.ToInt32(Console.ReadLine());

    Console.Write("What is the numbers range? 'E' for easy (1 to 10). 'M' for medium (1 to 50). 'D' for difficult (1 to 100). Your choise: ");
    string userChoice = Console.ReadLine().Trim().ToUpper();

    switch(userChoice)
    {
        case "E":
            while(numberOfQuestionsAsked != userQuestionsChoice)
            {
                timer.Start();
                randomNumber_1 = random.Next(1, 11);
                randomNumber_2 = random.Next(1, 11);

                int randomOperation = random.Next(1, 5);

                string operation = string.Empty;

                switch(randomOperation)
                {
                    case 1:
                        operation = "+";
                        break;
                    case 2:
                        operation = "-";
                        break;
                    case 3:
                        operation = "*";
                        break;
                    case 4:
                        operation = "/";
                        break;
                }

                Console.Write($"What is {randomNumber_1} {operation} {randomNumber_2} = ");
                int userAnswer = Convert.ToInt32(Console.ReadLine());

                if (operation == "+")
                {
                    if ((randomNumber_1 + randomNumber_2) == userAnswer)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("CORRECT!");
                        Console.ResetColor();

                        correctAnswer++;
                        numberOfQuestionsAsked++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Sorry wrong!");
                        Console.ResetColor();

                        wrongAnswer++;
                        numberOfQuestionsAsked++;
                    }
                }

                if (operation == "-")
                {
                    if ((randomNumber_1 - randomNumber_2) == userAnswer)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("CORRECT!");
                        Console.ResetColor();

                        correctAnswer++;
                        numberOfQuestionsAsked++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Sorry wrong!");
                        Console.ResetColor();

                        wrongAnswer++;
                        numberOfQuestionsAsked++;
                    }
                }

                if (operation == "*")
                {
                    if ((randomNumber_1 * randomNumber_2) == userAnswer)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("CORRECT!");
                        Console.ResetColor();

                        correctAnswer++;
                        numberOfQuestionsAsked++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Sorry wrong!");
                        Console.ResetColor();

                        wrongAnswer++;
                        numberOfQuestionsAsked++;
                    }
                }

                if (operation == "/")
                {
                    if ((randomNumber_1 / randomNumber_2) == userAnswer)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("CORRECT!");
                        Console.ResetColor();

                        correctAnswer++;
                        numberOfQuestionsAsked++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Sorry wrong!");
                        Console.ResetColor();

                        wrongAnswer++;
                        numberOfQuestionsAsked++;
                    }
                }

                timer.Stop();
            }

            Console.WriteLine();
            Console.WriteLine("GAME OVER..\n");
            Console.WriteLine("Game Result: ");
            Console.WriteLine("------------------");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Correct: {correctAnswer}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Wrong: {wrongAnswer}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Time: {timer.Elapsed.ToString("mm\\:ss")}");
            Console.ResetColor();

            AddToHistory("Random easy", userQuestionsChoice, correctAnswer, wrongAnswer);
            break;
        case "M":
            while (numberOfQuestionsAsked != userQuestionsChoice)
            {
                timer.Start();
                randomNumber_1 = random.Next(1, 51);
                randomNumber_2 = random.Next(1, 51);

                int randomOperation = random.Next(1, 5);

                string operation = string.Empty;

                switch (randomOperation)
                {
                    case 1:
                        operation = "+";
                        break;
                    case 2:
                        operation = "-";
                        break;
                    case 3:
                        operation = "*";
                        break;
                    case 4:
                        operation = "/";
                        break;
                }

                Console.Write($"What is {randomNumber_1} {operation} {randomNumber_2} = ");
                int userAnswer = Convert.ToInt32(Console.ReadLine());

                if (operation == "+")
                {
                    if ((randomNumber_1 + randomNumber_2) == userAnswer)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("CORRECT!");
                        Console.ResetColor();

                        correctAnswer++;
                        numberOfQuestionsAsked++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Sorry wrong!");
                        Console.ResetColor();

                        wrongAnswer++;
                        numberOfQuestionsAsked++;
                    }
                }

                if (operation == "-")
                {
                    if ((randomNumber_1 - randomNumber_2) == userAnswer)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("CORRECT!");
                        Console.ResetColor();

                        correctAnswer++;
                        numberOfQuestionsAsked++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Sorry wrong!");
                        Console.ResetColor();

                        wrongAnswer++;
                        numberOfQuestionsAsked++;
                    }
                }

                if (operation == "*")
                {
                    if ((randomNumber_1 * randomNumber_2) == userAnswer)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("CORRECT!");
                        Console.ResetColor();

                        correctAnswer++;
                        numberOfQuestionsAsked++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Sorry wrong!");
                        Console.ResetColor();

                        wrongAnswer++;
                        numberOfQuestionsAsked++;
                    }
                }

                if (operation == "/")
                {
                    if ((randomNumber_1 / randomNumber_2) == userAnswer)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("CORRECT!");
                        Console.ResetColor();

                        correctAnswer++;
                        numberOfQuestionsAsked++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Sorry wrong!");
                        Console.ResetColor();

                        wrongAnswer++;
                        numberOfQuestionsAsked++;
                    }
                }

                timer.Stop();
            }

            Console.WriteLine();
            Console.WriteLine("GAME OVER..\n");
            Console.WriteLine("Game Result: ");
            Console.WriteLine("------------------");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Correct: {correctAnswer}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Wrong: {wrongAnswer}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Time: {timer.Elapsed.ToString("mm\\:ss")}");
            Console.ResetColor();

            AddToHistory("Random medium", userQuestionsChoice, correctAnswer, wrongAnswer);
            break;
        case "D":
            while (numberOfQuestionsAsked != userQuestionsChoice)
            {
                timer.Start();
                randomNumber_1 = random.Next(1, 101);
                randomNumber_2 = random.Next(1, 101);

                int randomOperation = random.Next(1, 5);

                string operation = string.Empty;

                switch (randomOperation)
                {
                    case 1:
                        operation = "+";
                        break;
                    case 2:
                        operation = "-";
                        break;
                    case 3:
                        operation = "*";
                        break;
                    case 4:
                        operation = "/";
                        break;
                }

                Console.Write($"What is {randomNumber_1} {operation} {randomNumber_2} = ");
                int userAnswer = Convert.ToInt32(Console.ReadLine());

                if (operation == "+")
                {
                    if ((randomNumber_1 + randomNumber_2) == userAnswer)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("CORRECT!");
                        Console.ResetColor();

                        correctAnswer++;
                        numberOfQuestionsAsked++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Sorry wrong!");
                        Console.ResetColor();

                        wrongAnswer++;
                        numberOfQuestionsAsked++;
                    }
                }

                if (operation == "-")
                {
                    if ((randomNumber_1 - randomNumber_2) == userAnswer)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("CORRECT!");
                        Console.ResetColor();

                        correctAnswer++;
                        numberOfQuestionsAsked++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Sorry wrong!");
                        Console.ResetColor();

                        wrongAnswer++;
                        numberOfQuestionsAsked++;
                    }
                }

                if (operation == "*")
                {
                    if ((randomNumber_1 * randomNumber_2) == userAnswer)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("CORRECT!");
                        Console.ResetColor();

                        correctAnswer++;
                        numberOfQuestionsAsked++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Sorry wrong!");
                        Console.ResetColor();

                        wrongAnswer++;
                        numberOfQuestionsAsked++;
                    }
                }

                if (operation == "/")
                {
                    if ((randomNumber_1 / randomNumber_2) == userAnswer)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("CORRECT!");
                        Console.ResetColor();

                        correctAnswer++;
                        numberOfQuestionsAsked++;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Sorry wrong!");
                        Console.ResetColor();

                        wrongAnswer++;
                        numberOfQuestionsAsked++;
                    }
                }

                timer.Stop();
            }

            Console.WriteLine();
            Console.WriteLine("GAME OVER..\n");
            Console.WriteLine("Game Result: ");
            Console.WriteLine("------------------");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Correct: {correctAnswer}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Wrong: {wrongAnswer}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Time: {timer.Elapsed.ToString("mm\\:ss")}");
            Console.ResetColor();

            AddToHistory("Random difficult", userQuestionsChoice, correctAnswer, wrongAnswer);
            break;
    }
  
}


Console.ReadLine();

