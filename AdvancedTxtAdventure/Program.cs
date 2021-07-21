using System;

namespace AdvancedTxtAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Paint Drying";
            Console.CursorVisible = false;
            try
            {
                Console.WindowWidth = 130;
                Console.WindowHeight = 35;
            }
            catch
            {
                Console.WriteLine("Cannot create a big enough console window." +
                                  "\nTry adjusting the size of the window or the font and restart again." +
                                  "\nYou can continue to play, just be aware that some ASCII art may not render properly!");
                ConsoleUtils.WaitForKey();
            }

            Game game = new Game();
            game.Start();
        }
    }
}
