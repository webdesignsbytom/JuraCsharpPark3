using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraCsharpPark3
{
    public class Backpack
    {
        Dictionary<int, Item> myBackpack = new Dictionary<int, Item>();
        public int Capacity { get; set; } = 50;
        public int OccupiedSpaces { get; set; } = 3;

        public Backpack()
        {
            // Starting items for character are added to the bag.
            myBackpack.Add(1, new Item() { Name = "Cheese", Description = "Food to eat", Effect = 10 });
            myBackpack.Add(2, new Item() { Name = "Potion", Description = "Heals +20", Effect = 20 });
            myBackpack.Add(3, new Item() { Name = "Pistol", Description = "Shoots a short range", Effect = 25 });
        
        }
        public void AddItem()
        {
            Console.WriteLine("Adding item to bag: ");
            myBackpack.Add(4, new Item() { Name = "Potion", Description = "Heals +10", Effect = 10 });
            OccupiedSpaces++;
        }

        public void RemoveItem(string searchTerm) 
        {
            // Console.WriteLine(string.Join(Environment.NewLine, myBackpack.ContainsValue("Cheese");
            foreach (Item item in myBackpack.Values)
            {
                if (item.Name.Contains(searchTerm))
                {
                    Console.WriteLine($"Found {searchTerm} in bag");
                    var found = item;
                    myBackpack.Remove(2);
                    
                }
            }

            Console.WriteLine($"You used a {searchTerm}");
            Console.WriteLine("");
            Console.WriteLine("Remaining items:  ");
            Console.WriteLine("");
            LoopThroughBackpack(); 
        }

        public void LoopThroughBackpack()
        {
            foreach (Item item in myBackpack.Values)
            {
                Console.WriteLine($"Item {item.Name} {item.Description} - Does {item.Effect}");
            }
        }

        public void GetCapacity()
        {
            Console.WriteLine("Backpack Capacity = " + Capacity);
        }
    }
}
