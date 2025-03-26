namespace ConsoleAppNET9
{
    internal class Menu
    {
        GameEngine gameEngine = new();
        internal void ShowMenu(string name, DateTime date)
        {
            var valor = true;
            do
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math's game. That's great that you're working on improving yourself\n");
                Console.WriteLine(@$"What game would you like to play today? Choose from the options below: 
                            V - View Previous Games
                            A - Addition
                            S - Subtraction
                            M - Multiplication
                            D - Division
                            Q - Quit the program"); // @$  - Para escribir en varias líneas
                Console.WriteLine("-------------------------------------------");

                var gameSelected = Console.ReadLine();


                switch (gameSelected.Trim().ToLower())
                {
                    case "v":
                        Helpers.GetGames();
                        break;
                    case "a":
                        gameEngine.AdditionGame("Addition game ");
                        break;
                    case "s":
                        gameEngine.SubstractionGame("Substraction game ");
                        break;
                    case "m":
                        gameEngine.MultiplicationGame("Multiplication game ");
                        break;
                    case "d":
                        gameEngine.DivisionGame("Division game ");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        valor = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida, pulsa cualquier tecla para continuar ");
                        Console.ReadLine();
                        break;

                }
            }
            while (valor == true);


        }
    }
}
