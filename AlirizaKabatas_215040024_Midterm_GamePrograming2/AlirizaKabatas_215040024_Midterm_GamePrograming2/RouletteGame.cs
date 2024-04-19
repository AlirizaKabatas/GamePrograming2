using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AlirizaKabatas_215040024_Midterm_GamePrograming2
{
    class RouletteGame
    {
        private Player player;
        private Bot bot;
        private Random random;

        public RouletteGame()
        {
            player = new Player();
            bot = new Bot();
            random = new Random();
        }

        // Method to start the game
        public async Task StartGame()
        {
            while (true)
            {
                // Player's turn
                Console.WriteLine("\nYour turn! Press '1' to shoot yourself or '2' to shoot the enemy:");
                int choice = int.Parse(Console.ReadLine());

                // If the player chooses to shoot themselves
                if (choice == 1)
                {
                    await player.Shoot(random, bot);
                    if (player.IsDead)
                    {
                        Console.WriteLine("You died. Game over!");
                        break;
                    }
                }
                // If the player chooses to shoot the enemy
                else if (choice == 2)
                {
                    await player.ShootAtEnemy(random, bot);
                    if (bot.IsDead)
                    {
                        Console.WriteLine("You won! Enemy died. Game over!");
                        break;
                    }
                    await bot.Shoot(random, player);
                    if (player.IsDead)
                    {
                        Console.WriteLine("You died. Game over!");
                        break;
                    }
                    if (bot.IsDead)
                    {
                        Console.WriteLine("You won! Enemy died. Game over!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice! Please press '1' or '2'.");
                    continue;
                }
            }
        }
    }

}
