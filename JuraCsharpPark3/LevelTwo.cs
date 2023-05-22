using JuraCsharpPark3;
using src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraCsharpPark3
{
    public class LevelTwo 
    {
        public string Name { get; } = "Level Two - Fences are never high enough!";
        public int ScoreNeeded { get; } = 100;

        public void FinisLevel()
        {
            Console.WriteLine("You got past " + Name);
            Console.WriteLine("Richard Attenborough would be proud");
        }

        // Game Story
        public void StartLevel(Character myguy)
        {
            Console.WriteLine("");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("========== ======================_===================================_==== ==============================");
            // Starting chat
            Console.WriteLine("");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("Well the dinosaurs got out, and learned to drive.");
            System.Threading.Thread.Sleep(300);
            Console.WriteLine("You had best head to the coast and try and find a boat out of here.");

            // Create friendly dino
            Stegosaurus steggy = new Stegosaurus();
            steggy.AppearMysteriously();
            Console.WriteLine("");
            Console.WriteLine("Using a classic trick your grandpa taught you. You tame a wild Stegosaurus!");
            System.Threading.Thread.Sleep(300);
            Console.WriteLine("");

            // Riding dino Scene
            steggy.RideDinosaur();
            // Start dino run scene
            DinoRunScene dinoRun = new DinoRunScene();


            // End level
            FinisLevel();
        }

    }
}
