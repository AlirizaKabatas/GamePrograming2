using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AlirizaKabatas_215040024_Midterm_GamePrograming2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome to the Russian Roulette game! If you fire an empty bullet at yourself, you gain +1 firing chance. However, if you fire the empty bullet at your enemy, it is your enemy's turn and the player who dies loses.");

            // Create an instance of the game class
            RouletteGame game = new RouletteGame();

            // Call StartGame method to begin the game
            await game.StartGame();
        }
    }
}
