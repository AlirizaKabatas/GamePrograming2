using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlirizaKabatas_215040024_Midterm_GamePrograming2
{
    class Bot
    {
        public bool IsDead { get; set; }

        public Bot()
        {
            IsDead = false;
        }

        // Method for bot shooting
        public async Task Shoot(Random random, Player player)
        {
            Console.WriteLine("Enemy is shooting...");

            // Determine if the bot shoots itself or the player
            bool shootAtPlayer = random.Next(2) == 0;

            await Task.Delay(1000);

            if (shootAtPlayer)
            {
                Console.WriteLine("Enemy shot at you.");
            }
            else
            {
                Console.WriteLine("Enemy shot itself.");
            }

            // Check for the probability of misfire (1/4 chance)
            if (random.Next(4) == 0)
            {
                Console.WriteLine("BAM!! The Bullet Exploded! " + (shootAtPlayer ? "You died." : "Enemy died."));
                player.IsDead = shootAtPlayer;
            }
            else
            {
                Console.WriteLine("The Bullet Did Not Explode!");
            }
        }
    }

}

