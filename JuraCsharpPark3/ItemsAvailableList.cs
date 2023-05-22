using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraCsharpPark3
{
    public class ItemsAvailableList
    {
        // Create a list for all available items you can collect
        // They are made from the Item class. 
        // The list will not be edited
        public readonly List<Item> AvailableItems = new List<Item>();
    
        public ItemsAvailableList()
        {
            AvailableItems.Add(new Item() { Name = "Cheese", Description = "Food to eat", Effect = 10 });
            AvailableItems.Add(new Item() { Name = "Dagger", Description = "Weapon to poach", Effect = 10 });
            AvailableItems.Add(new Item() { Name = "Potion", Description = "Heals +20", Effect = 20 });
            AvailableItems.Add(new Item() { Name = "Super Potion", Description = "Heals +50", Effect = 50 });
            AvailableItems.Add(new Item() { Name = "Dino Pee", Description = "Wards off dinosaurs", Effect = 10 });
            AvailableItems.Add(new Item() { Name = "Severed Hand", Description = "Possible bait?", Effect = 10 });
            AvailableItems.Add(new Item() { Name = "Pistol", Description = "Shoots a short range", Effect = 25 });
            AvailableItems.Add(new Item() { Name = "Machine Gun", Description = "The jungle will fear you!", Effect = 50 });
            AvailableItems.Add(new Item() { Name = "Gold", Description = "Money everywhere on earth", Effect = 50 });
        }

        public IQueryable<Item> GetItemsAsQueryable()
        {
            return AvailableItems.AsQueryable();
        }

        public IEnumerable<Item> GetItemsAsEnumerable()
        {
            return AvailableItems.AsEnumerable();
        }
    }
}
