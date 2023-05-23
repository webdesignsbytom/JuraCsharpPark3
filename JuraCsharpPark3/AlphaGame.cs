using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraCsharpPark3
{
    public class AlphaGame
    {
        public AlphaGame() 
        {
            for (char c = 'A'; c <= 'Z'; c++)
            {

                ConsoleKeyInfo cki;

                do
                {
                    cki = Console.ReadKey();
                    Console.Write(" --- You pressed ");
                    if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
                    if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
                    if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
                    Console.WriteLine(cki.Key.ToString());

                    // Correct key pressed and move to next character
                    if (cki.Key.ToString() == c.ToString())
                    {
                        Console.WriteLine("Correct key pressed!!");
                        c++;
                    }
                    // Check for last key in series to win the game
                    else if (cki.Key == ConsoleKey.Z)
                    {
                        Console.WriteLine("You did it well done!!");
                        Console.WriteLine("Press Enter To Continue");
                    }
                    else
                    {
                        // Wrong key pressed message
                        Console.WriteLine("You missed the right key!");
                        return;
                    }


                } while (cki.Key != ConsoleKey.Escape);

            }
        }
    }
}
