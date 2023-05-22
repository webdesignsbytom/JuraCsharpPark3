namespace JuraCsharpPark3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create new instance of game state
            GameState newGame = new GameState();
            newGame.StartGame();


            // Hold end of program
            Console.ReadLine();
        }
    }
}