string name = GetName();

var date = DateTime.UtcNow;
var games = new List<string>();  // Creamos una lista para almacenar las jugadas previas

Menu(name);

string GetName()
{
    Console.WriteLine("Please type your name: ");
    var name = Console.ReadLine();
    return name;
}

void DivisionGame(string message)
{
  
        Console.Clear();
        Console.WriteLine(message);

        var score = 0;
        int firstRandom;
        int secondRandom;

        for (int i = 0; i < 5; i++)
        {
            var divisionNumbers = GetDivisionNumbers();
            firstRandom = divisionNumbers[0];
            secondRandom = divisionNumbers[1];

            Console.WriteLine($"{firstRandom} / {secondRandom}");
            var result = Console.ReadLine();

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
        AddToHistory(score, "Division");
 }

void MultiplicationGame(string message)
{
    
        Console.Clear();
        Console.WriteLine(message);

        var score = 0;
        var random = new Random();
        int firstRandom;
        int secondRandom;

        for (int i = 0; i < 5; i++)
        {
            firstRandom = random.Next(1, 9);
            secondRandom = random.Next(1, 9);

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
        AddToHistory(score, "Multiplication");
 }

void SubstractionGame(string message)
{
  
        Console.Clear();
        Console.WriteLine(message);

        var score = 0;
        var random = new Random();
        int firstRandom;
        int secondRandom;

        for (int i = 0; i < 5; i++)
        {
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
    AddToHistory(score, "Substraction");
}

void AdditionGame(string message)
{
    Console.Clear();
    Console.WriteLine(message);

    var score = 0;
    var random = new Random();
    int firstRandom;
    int secondRandom;

    for(int i=0;i<5; i++)
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
    AddToHistory(score, "Addition");
    

    
}

void AddToHistory(int gameScore, string gameType)
{
    games.Add($"{DateTime.Now} -  {gameType} : {gameScore}");
}

int[] GetDivisionNumbers()
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
void Menu(string name)
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
                GetGames();
                break;
            case "a":
                AdditionGame("Addition game ");
                break;
            case "s":
                SubstractionGame("Substraction game ");
                break;
            case "m":
                MultiplicationGame("Multiplication game ");
                break;
            case "d":
                DivisionGame("Division game ");
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

void GetGames()
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