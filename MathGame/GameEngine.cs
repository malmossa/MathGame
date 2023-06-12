using MathGame.Models;

namespace MathGame
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
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
                    Console.ReadLine();
                }

                if (i == 4)
                {
                    Console.WriteLine($"Game over. Your final score is {score}. Press any key to go back to the main menu.");
                    Console.ReadLine();
                }
            }

            Helpers.AddToHistory(score, GameType.Addition);
        }


        internal void SubtractionGame(string message)
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
                    Console.ReadLine();
                }

                if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
            }

            Helpers.AddToHistory(score, GameType.Subtraction);
        }

        internal void MultiplicationGame(string message)
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
                    Console.ReadLine();
                }

                if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
            }

            Helpers.AddToHistory(score, GameType.Multiplication);
        }

        internal void DivisionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                int[] divisionNumber = Helpers.GetDivisionNumbers();
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
                    Console.ReadLine();
                }

                if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
            }

            Helpers.AddToHistory(score, GameType.Division);
        }
    }
}
