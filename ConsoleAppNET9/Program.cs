using System.ComponentModel;

Console.WriteLine("Please type your name: ");

var name = Console.ReadLine();
var date = DateTime.UtcNow;

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
        Console.WriteLine("Addition game selected");
        break;
    case "s":
        Console.WriteLine("Substraction game selected");
        break;
    case "m":
        Console.WriteLine("Multiplication game selected");
        break;
    case "d":
        Console.WriteLine("Dicision game selected");
        break;
    case "q":
        Console.WriteLine("Goodbye");
        break;
    default:
        Console.WriteLine("Opción no válida");
        break;

}

