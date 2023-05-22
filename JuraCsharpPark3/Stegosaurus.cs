using JuraCsharpPark3;

namespace src
{
    internal class Stegosaurus : IFriendly
    {
        public void RideDinosaur()
        {
            Console.WriteLine("You jump on top of the Animal and ride though the fog!");
            Console.WriteLine("");
            System.Threading.Thread.Sleep(500);
        }
        public void AppearMysteriously()
        {
            Console.WriteLine("A Stegosaurus emerges from a bush!");
        }

        public void Create()
        {
            Console.WriteLine("Aww look how cute a baby Stegosaurus!");
        }

        public void Defend()
        {
            Console.WriteLine("Rarr go away!");
        }

        public void Die()
        {
            Console.WriteLine("Oh no Steggy was killed :(");
        }

        public void Feed()
        {
            Console.WriteLine("Chomp chomp chomp");
        }

        public void RunAway()
        {
            Console.WriteLine("Steggy runs away");
        }
    }
}
