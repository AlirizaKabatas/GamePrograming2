using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlirizaKabatas_215040024_Midterm_GamePrograming2
{
    class Player
    {
        public bool IsDead { get; set; }
        private int chancesLeft;

        public Player()
        {
            IsDead = false;
            chancesLeft = 2; // Initially, give 2 chances
        }

        // Method for player shooting
        public async Task Shoot(Random random, Bot bot)
        {
            Console.WriteLine("Click...");
            await Task.Delay(1000);

            // Check for the probability of misfire (1/4 chance)
            if (random.Next(4) == 0)
            {
                Console.WriteLine("BAM!! The Bullet Exploded! You died.");
                IsDead = true;
            }
            else
            {
                Console.WriteLine("The Bullet Did Not Explode!");

                // If not dead, increase chances for the next turn
                chancesLeft++;
            }
        }

        // Method for shooting at the enemy
        public async Task ShootAtEnemy(Random random, Bot bot)
        {
            Console.WriteLine("You shot at the enemy.");
            await Task.Delay(1000);

            // Check for the probability of hitting the enemy (1/4 chance)
            if (random.Next(4) == 0)
            {
                Console.WriteLine("BAM!! The Bullet Exploded! Enemy died.");
                bot.IsDead = true;
            }
            else
            {
                Console.WriteLine("The Bullet Did Not Explode!");
            }
        }
    }

}
