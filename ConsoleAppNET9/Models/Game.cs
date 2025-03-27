namespace AppCalcConsole.Models
{
    internal class Game
    {
        public int Score { get; set; }  // Las propiedades siempre enmpiezan por mayúscula
        public DateTime Date { get; set; }
        public GameType Type { get; set; }

    }

    internal enum GameType
    {
        Addition,
        Substraction,
        Multiplication,
        Division

    }
}
