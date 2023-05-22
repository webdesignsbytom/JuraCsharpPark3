
namespace JuraCsharpPark3
{
    public class Trex : IEnemy
    {
        private readonly Random random = new Random();
        public int Health { get; private set; } = 25;
        public int Attack()
        {
            int attack = random.Next(1, 10);
            return attack;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            Console.WriteLine("Your attack does " + damage + " damage");
        }

        public void Create()
        {
            Console.WriteLine("A baby Trex is hatched :) ");
        }

        public void Die()
        {
            Console.WriteLine("The Trex (Skippy) has died!");
        }

        public void RunAway()
        {
            Console.WriteLine("It ran away! How do you lose a Trex!");
        }

        public void CurrentHealth()
        {
            Console.WriteLine("Trex Health = " + Health);
            Console.WriteLine("");
        }

        public void AppearMysteriously()
        {
            Console.WriteLine("A Trex emerges from a bush!");
        }
    }
}
