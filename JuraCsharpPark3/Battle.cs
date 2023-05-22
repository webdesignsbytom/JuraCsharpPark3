using JuraCsharpPark3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraCsharpPark3
{
    public class Battle
    {
        // I must be able to feed in the Enemy class here instead of trex?
        public Battle(Trex skippy, Character myguy)
        {
            while (skippy.Health > 0)
            {
                System.Threading.Thread.Sleep(300);
                // Get attacked
                int dam2 = skippy.Attack();
                myguy.TakeDamage(dam2);

                // Return new Health of character
                myguy.CurrentHealth();

                Console.WriteLine("");
                Console.WriteLine("You Attack The Trex");
                System.Threading.Thread.Sleep(500);
                // Attack the dinosaur
                // Dinosuar takes damage
                skippy.TakeDamage(myguy.Attack());

                // return new health of dinosaur
                skippy.CurrentHealth();
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("Press Enter to continue!");
                Console.WriteLine("");
                Console.ReadLine();
            }

            // Death state
            skippy.Die();
            return;
        }
    }
}
