using AppCalcConsole.Models;

namespace ConsoleAppNET9
{
    internal class Helpers
    {
        internal static List<Game> games = new();  // Definimos una lista de clase Game
        internal static string GetName()
        {
            Console.WriteLine("Please type your name: ");
            string? name = Console.ReadLine();
            return name ?? "";  // si el valor de la izquierda es null, usa el de la derecha(se puede poner tambien string.Empty)
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
            int firstRandom = random.Next(1, 99);
            int secondRandom = random.Next(1, 99);

            var result = new int[2];

            while (firstRandom % secondRandom != 0)
            {
                firstRandom = random.Next(1, 99);
                secondRandom = random.Next(1, 99);
            }

            result[0] = firstRandom;
            result[1] = secondRandom;

            return result;

        }


        internal static void GetGames()
        {
            Console.Clear();
            Console.WriteLine("Games History");
            Console.WriteLine("---------------------------------------");
            foreach (Game game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type} : {game.Score} pts");

            }
            Console.WriteLine("---------------------------------------\n");
            Console.WriteLine("Press any key to return to Main Menu");
            Console.ReadLine();
        }
    }
}
