using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuraCsharpPark3
{
    public class Item
    {
        // Create an item
        // Effect is i.e add 10 health
        public string Name { get; set; }
        public string Description { get; set; }
        public int Effect { get; set; }
        
        // I dont think i need this
        public void DisplayItem()
        {
            Console.WriteLine("Item: " + Name + " " + Description + " Effect: " + Effect);
        }

    }
}
