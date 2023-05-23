using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraCsharpPark3
{
    public class GameState
    {
        public bool GameOver { get; private set; }
        public int Score { get; private set; } = 0;
        public int HighScore { get; private set; } = 0;

        // Instance of Character
        Character myguy = new Character();
        public void StartGame()
        {
            Console.WriteLine("Welcome to 'JurraC# Park 3'");

            // Start Level one
            LevelOne levelOne = new LevelOne();
            levelOne.StartLevel(myguy);

            // Check to continue
            Console.WriteLine("Do you want to start Level Two? (y/n)");
            ConsoleKeyInfo key = new ConsoleKeyInfo();

            key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.Y:
                    Console.WriteLine("Yes was selected");
                    LevelTwo levelTwo = new LevelTwo();
                    levelTwo.StartLevel(myguy);
                    break;
                case ConsoleKey.N:
                    Console.WriteLine("No was selected");
                    break;
            }
        }

        public void EndGame()
        {
            Console.WriteLine("GAME OVER!");
            Console.WriteLine("Your scored: " + Score);
            Console.WriteLine("Your high score is: " + HighScore);
        }
    }
}
