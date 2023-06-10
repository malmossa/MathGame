namespace MathGame
{
    
    internal class Menu
    {
        GameEngine gameEnging = new GameEngine();
       internal void ShowMenu(string name, DateTime date)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Hello {name}. It's {date}. This is your math's game. That's great that you're working on improving yourself\n");
            Console.WriteLine("\n");

            bool isGameOn = true;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"What game would you like to play today? Choose from the options below:
                V - View Previous Game.
                A - Addition.
                S - Subtraction.
                M - Multiplication.
                D - Division.
                Q - Quit the program.");
                Console.WriteLine("---------------------------------");

                string gameSelected = Console.ReadLine();

                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.GetGames();
                        break;
                    case "a":
                        gameEnging.AdditionGame("Addition game ");
                        break;
                    case "s":
                        gameEnging.SubtractionGame("Subtraction game is ");
                        break;
                    case "m":
                        gameEnging.MultiplicationGame("Multiplication game is ");
                        break;
                    case "d":
                        gameEnging.DivisionGame("Division game is ");
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
    }
}
