using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedTxtAdventure.Scenes
{
    class CreditsScene : Scene
    {
        public CreditsScene(Game game) : base(game)
        {

        }

        public override void Run()
        {
            string prompt = @"Thank you for playing Paint Drying Simulator. I hope you enjoyed it!

Would you like to play again? : ";
            string[] options = { "Yes", "No" };
            Menu menu = new Menu(prompt, options);
            int selectedIndex = menu.Run();

            switch (selectedIndex)
            {
                case 0:
                    MyGame.Start();
                    return;
                case 1:
                    Console.Clear();
                    ConsoleUtils.QuitConsole();
                    break;
                default:
                    break;
            }
        }
    }
}
