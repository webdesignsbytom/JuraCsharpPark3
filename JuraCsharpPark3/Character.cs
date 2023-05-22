using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraCsharpPark3
{
    public class Character
    {
        // Generate random attack damage
        Random random = new Random();
        public string Username { get; set; } = "";
        public int Age { get; set; }
        public int Health { get; set; } = 100;
        public int Damage { get; set; } = 10;
        public int Score { get; set; } = 0;

        public Backpack backPack = new Backpack();

        public void CreateCharacter(string username, int age)
        {
            Username = username;
            Age = age;
            Console.WriteLine("Greetings " + Username + "! You are " + Age + " years old. " + "Your starting health is " + Health);
        }

        public void CurrentScore()
        {
            Console.WriteLine("Current Score = " + Score);
        }        

        public void CurrentHealth()
        {
            Console.WriteLine("Current Health = " + Health);
        }

        public void CurrentDamage()
        {
            Console.WriteLine("Current Attack Damage = " + Damage);
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine("The enemies attack does " + damage);
        }

        public void AddHealth(int health)
        {
            Health += health;
            Console.WriteLine("Your New Health is " + Health);
        }

        public int Attack()
        {
            int attack = Damage;
            return attack;
        }

        public void UseItemFromPack(string searchTerm)
        {
            if (searchTerm == "Potion")
            {
                AddHealth(20);
            }
            backPack.RemoveItem(searchTerm);
        }

        // Print all objects in backpack - connects to Backpack class
        public void PrintBackpackContents()
        {
            backPack.LoopThroughBackpack();
        }

    }
}
