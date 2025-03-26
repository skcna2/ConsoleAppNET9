using ConsoleAppNET9;

string name = Helpers.GetName();

Menu menu = new();

var date = DateTime.UtcNow;

var games = new List<string>();  // Creamos una lista para almacenar las jugadas previas

menu.ShowMenu(name, date);

