using MathGame.Models;
using System;
namespace MathGame
{
    internal class Helpers
    {
        internal static List<Game> games = new List<Game>
        {
            new Game { Date = DateTime.Now.AddDays(1), Type = GameType.Addition, Score = 5 },
            new Game { Date = DateTime.Now.AddDays(2), Type = GameType.Multiplication, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(3), Type = GameType.Division, Score = 4 },
            new Game { Date = DateTime.Now.AddDays(4), Type = GameType.Subtraction, Score = 3 },
            new Game { Date = DateTime.Now.AddDays(5), Type = GameType.Addition, Score = 1 },
            new Game { Date = DateTime.Now.AddDays(6), Type = GameType.Multiplication, Score = 2 },
            new Game { Date = DateTime.Now.AddDays(7), Type = GameType.Division, Score = 3 },
            new Game { Date = DateTime.Now.AddDays(8), Type = GameType.Subtraction, Score = 4 },
        };
        internal static void PrintGames()
        {
            var gamesTpPrint = games.Where(x => x.Date > new DateTime(2023, 05, 09)).OrderByDescending(x => x.Score);

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
        internal static void AddToHistory(int gameScore, GameType gameType)
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
