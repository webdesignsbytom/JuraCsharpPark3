using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraCsharpPark3
{
    internal class KeyPressListener
    {
        public KeyPressListener() {
            ConsoleKeyInfo key = new ConsoleKeyInfo();

            key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.Y:
                    Console.WriteLine("Y was selected");
                    
                    break;
                case ConsoleKey.N:
                    Console.WriteLine("N was selected");
                    break;
            }
        }
    }
}
