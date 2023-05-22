using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraCsharpPark3
{
    internal class DinoRunScene
    {
        
        public  DinoRunScene()
        {
            Console.WriteLine("");
            Console.WriteLine("========================================================================================================");
            Console.WriteLine("");
            System.Threading.Thread.Sleep(700);
            Console.WriteLine("As you ride throught the jungle you notice the air is becoming toxic!");
            System.Threading.Thread.Sleep(700);
            Console.WriteLine("You had better hurry!!");

            // Set timer to start
            // Create new timer
            // All probably needs renaming and more classes for timer and timed events that has evolved.
            Console.WriteLine("To make your dinosaur run fast enough...");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Enter the Alphabet in order in less than 30 seconds!");
            System.Threading.Thread.Sleep(1000);
            Timer runTime = new Timer();

            

            Console.WriteLine("XXXXX");
            System.Threading.Thread.Sleep(500);

        }
    }
}
