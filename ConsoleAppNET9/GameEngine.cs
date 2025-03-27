using AppCalcConsole.Models;

namespace ConsoleAppNET9
{
    internal class GameEngine
    {
        internal void DivisionGame(string message)
        {

            Console.Clear();
            Console.WriteLine(message);

            var score = 0;
            int firstRandom;
            int secondRandom;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                int[] divisionNumbers = Helpers.GetDivisionNumbers();
                firstRandom = divisionNumbers[0];
                secondRandom = divisionNumbers[1];

                Console.WriteLine($"{firstRandom} / {secondRandom}");
                string? result = Console.ReadLine();

                if (int.Parse(result) == firstRandom / secondRandom)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question. ");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question. ");
                    Console.ReadLine();
                }

            }

            Console.WriteLine($"Your final score is {score}. Press any key to go back to the main menu");
            Console.ReadLine();
            Helpers.AddToHistory(score, GameType.Division);
        }

        internal void MultiplicationGame(string message)
        {

            Console.Clear();
            Console.WriteLine(message);

            var score = 0;
            var random = new Random();
            

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                int firstRandom = random.Next(1, 9);
                int secondRandom = random.Next(1, 9);

                Console.WriteLine($"{firstRandom} * {secondRandom}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstRandom * secondRandom)
                {
                    Console.WriteLine("Your answer was correct!  Type any key for the next question. ");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question. ");
                    Console.ReadLine();
                }

            }

            Console.WriteLine($"Your final score is {score}. Press any key to go back to the main menu");
            Console.ReadLine();
            Helpers.AddToHistory(score, GameType.Multiplication);
        }

        internal void SubstractionGame(string message)
        {

            Console.Clear();
            Console.WriteLine(message);

            var score = 0;
            var random = new Random();
            int firstRandom;
            int secondRandom;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                firstRandom = random.Next(1, 9);
                secondRandom = random.Next(1, 9);

                Console.WriteLine($"{firstRandom} - {secondRandom}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstRandom - secondRandom)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question. ");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question. ");
                    Console.ReadLine();
                }

            }



            Console.WriteLine($"Your final score is {score}. Press any key to go back to the main menu");
            Console.ReadLine();
            Helpers.AddToHistory(score, GameType.Substraction);
        }

        internal void AdditionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            var score = 0;
            var random = new Random();
            int firstRandom;
            int secondRandom;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                firstRandom = random.Next(1, 9);
                secondRandom = random.Next(1, 9);

                Console.WriteLine($"{firstRandom} + {secondRandom}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstRandom + secondRandom)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question. ");
                    Console.ReadLine();
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect. Type any key for the next question. ");
                    Console.ReadLine();
                }

            }

            Console.WriteLine($"Your final score is {score}. Press any key to go back to the main menu");
            Console.ReadLine();
            Helpers.AddToHistory(score, GameType.Addition);



        }
    }
}
