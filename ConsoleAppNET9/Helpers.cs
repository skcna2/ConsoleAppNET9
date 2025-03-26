namespace ConsoleAppNET9
{
    internal class Helpers
    {
        static List<string> games = new();
        internal static string GetName()
        {
            Console.WriteLine("Please type your name: ");
            var name = Console.ReadLine();
            return name;
        }

        internal static void AddToHistory(int gameScore, string gameType)
        {
            games.Add($"{DateTime.Now} -  {gameType} : {gameScore}");
        }

        internal static int[] GetDivisionNumbers()
        {
            var random = new Random();
            var firstRandom = random.Next(1, 99);
            var secondRandom = random.Next(1, 99);

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
            foreach (string game in games)
            {
                Console.WriteLine(game);

            }
            Console.WriteLine("---------------------------------------\n");
            Console.WriteLine("Press any key to return to Main Menu");
            Console.ReadLine();
        }
    }
}
