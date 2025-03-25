string name = GetName();

var date = DateTime.UtcNow;

Menu(name);

string GetName()
{
    Console.WriteLine("Please type your name: ");
    var name = Console.ReadLine();
    return name;
}

void DivisionGame(string message)
{
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

        Console.WriteLine($"Your final score is {score}");


    }
}

void MultiplicationGame(string message)
{
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

        Console.WriteLine($"Your final score is {score}");


    }
}

void SubstractionGame(string message)
{
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

        Console.WriteLine($"Your final score is {score}");


    }
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

    Console.WriteLine($"Your final score is {score}");

    
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
    Console.WriteLine("------------------------------------------");
    Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math's game. That's great that you're working on improving yourself\n");
    Console.WriteLine(@$"What game would you like to play today? Choose from the options below: 
A - Addition
S - Subtraction
M - Multiplication
D - Division
Q - Quit the program"); // @$  - Para escribir en varias líneas
    Console.WriteLine("-------------------------------------------");

    var gameSelected = Console.ReadLine();


    switch (gameSelected.Trim().ToLower())
    {
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
            Environment.Exit(1);
            break;
        default:
            Console.WriteLine("Opción no válida");
            Environment.Exit(1);
            break;

    }
}

