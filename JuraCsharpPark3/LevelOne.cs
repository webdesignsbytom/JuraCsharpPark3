using JuraCsharpPark3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraCsharpPark3
{
    public class LevelOne 
    {
        public string Name { get; } = "Level One - Island Of Roars!";
        public int ScoreNeeded { get; } = 100;

        public void FinisLevel()
        {
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("You got past " + Name);
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Richard Attenborough would be proud");
            System.Threading.Thread.Sleep(300);
            Console.WriteLine("");
        }

        // Game Story
        public void StartLevel(Character myguy)
        {
            // Starting chat
            Console.WriteLine("");
            Console.WriteLine(Name);
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("You have been invited on a wonderous journey to test the fences and check for teeth in things.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("My Name is Professor Hootington, what is your name?...");
            System.Threading.Thread.Sleep(1000);

            // Get user data
            Console.WriteLine("Enter your username");
            string username = Console.ReadLine();

            Console.WriteLine("And your age?");
            int age = int.Parse(Console.ReadLine());

            // I know i dont need this constructor if i just fiddle around how the user gets asked for its data. But meh
            myguy.CreateCharacter(username, age);

            Console.WriteLine("Thank you and Nice to meet you");
            System.Threading.Thread.Sleep(300);
            Console.WriteLine("");
            Console.WriteLine("Press Enter to start your journey!");
            Console.ReadLine();

            Console.WriteLine("Take a trip around the park!");

            Console.WriteLine("=================================_==============================================================================");
            Console.WriteLine("");
            System.Threading.Thread.Sleep(300);
            Console.WriteLine("You take a walk around the perimiter of the fences, after a while you start to forget which side of the fence is the good side to be on?");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("You hear a egg cracking sound up ahead...");
            System.Threading.Thread.Sleep(300);
            Console.WriteLine("");

            // Create enemy from, Enemy class
            Trex skippy = new Trex();
            skippy.Create();

            Console.WriteLine("Press Enter to continue!");
            Console.WriteLine("");
            Console.ReadLine();

            // Fight with enemy until its dead is while loop
            Battle fight = new Battle(skippy, myguy);

            // Find some items for you backpack
            // They already exist in your backpack as you have starting items asigned
            Console.WriteLine("");
            Console.WriteLine("Hmmm whats that up ahead");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("");
            Console.WriteLine("You run around the bend a find a backpack of holding!!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Like a greedy sausage you peek inside...");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("");
            myguy.PrintBackpackContents();

            Console.WriteLine("");

            // Use Health pack
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Do you want to use a Potion? (y/n)");
            ConsoleKeyInfo key = new ConsoleKeyInfo();

            key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.Y:
                    System.Threading.Thread.Sleep(300);
                    Console.WriteLine("Yes was selected");
                    myguy.UseItemFromPack("Potion");
                    break;
                case ConsoleKey.N:
                    System.Threading.Thread.Sleep(300);
                    Console.WriteLine("No was selected");
                    break;
            }

            
            Console.WriteLine("");

            FinisLevel();
        }

    }
}
