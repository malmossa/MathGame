using MathGame.Models;
using System;
namespace MathGame
{
    internal class Helpers
    {
        internal static List<Game> games = new List<Game>();
        internal static void PrintGames()
        {
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("-------------------");
            foreach (Game game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type} : {game.Score} pts");
            }
            Console.WriteLine("-------------------\n");
            Console.WriteLine("Press any key to retirn to Main Menu");
            Console.ReadLine();
        }
        internal static void AddToHistory(int gameScore, string gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Score = gameScore,
                Type = gameType
            });
        }
        internal static int[] GetDivisionNumbers()
        {

            Random random = new Random();
            int firstNumber = random.Next(0, 99);
            int secontNumber = random.Next(0, 99);

            int[] result = new int[2];

            while (firstNumber % secontNumber != 0)
            {
                firstNumber = random.Next(1, 99);
                secontNumber = random.Next(1, 99);
            }

            result[0] = firstNumber;
            result[1] = secontNumber;


            return result;
        }
    }
}
