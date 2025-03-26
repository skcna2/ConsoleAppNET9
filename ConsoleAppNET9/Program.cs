using ConsoleAppNET9;

string name = Helpers.GetName();

Menu menu = new();

DateTime date = DateTime.UtcNow;

List<string> games = new();  // Creamos una lista para almacenar las jugadas previas

menu.ShowMenu(name, date);

