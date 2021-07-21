using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedTxtAdventure.Scenes
{
    class TitleScene : Scene
    {
        string Title = @" ██▓███   ▄▄▄       ██▓ ███▄    █ ▄▄▄█████▓   ▓█████▄  ██▀███ ▓██   ██▓ ██▓ ███▄    █   ▄████ 
▓██░  ██▒▒████▄    ▓██▒ ██ ▀█   █ ▓  ██▒ ▓▒   ▒██▀ ██▌▓██ ▒ ██▒▒██  ██▒▓██▒ ██ ▀█   █  ██▒ ▀█▒
▓██░ ██▓▒▒██  ▀█▄  ▒██▒▓██  ▀█ ██▒▒ ▓██░ ▒░   ░██   █▌▓██ ░▄█ ▒ ▒██ ██░▒██▒▓██  ▀█ ██▒▒██░▄▄▄░
▒██▄█▓▒ ▒░██▄▄▄▄██ ░██░▓██▒  ▐▌██▒░ ▓██▓ ░    ░▓█▄   ▌▒██▀▀█▄   ░ ▐██▓░░██░▓██▒  ▐▌██▒░▓█  ██▓
▒██▒ ░  ░ ▓█   ▓██▒░██░▒██░   ▓██░  ▒██▒ ░    ░▒████▓ ░██▓ ▒██▒ ░ ██▒▓░░██░▒██░   ▓██░░▒▓███▀▒
▒▓▒░ ░  ░ ▒▒   ▓▒█░░▓  ░ ▒░   ▒ ▒   ▒ ░░       ▒▒▓  ▒ ░ ▒▓ ░▒▓░  ██▒▒▒ ░▓  ░ ▒░   ▒ ▒  ░▒   ▒ 
░▒ ░       ▒   ▒▒ ░ ▒ ░░ ░░   ░ ▒░    ░        ░ ▒  ▒   ░▒ ░ ▒░▓██ ░▒░  ▒ ░░ ░░   ░ ▒░  ░   ░ 
░░         ░   ▒    ▒ ░   ░   ░ ░   ░          ░ ░  ░   ░░   ░ ▒ ▒ ░░   ▒ ░   ░   ░ ░ ░ ░   ░ 
               ░  ░ ░           ░                ░       ░     ░ ░      ░           ░       ░ 
                                               ░               ░ ░                            
";
        public TitleScene(Game game) : base(game)
        {

        }

        public override void Run()
        {
            string prompt = $"{Title}\nWelcome to the Paint Drying Simulation. What would you like to choose? : ";
            string[] options = { "Play", "About", "Exit" };
            Menu menu = new Menu(prompt, options);
            int selectedIndex = menu.Run();

            switch (selectedIndex)
            {
                case 0:
                    Console.Clear();
                    MyGame.MyNavigationScene.Run();
                    break;
                case 1:
                    Console.Clear();
                    DisplayAboutInfo();
                    break;
                case 2:
                    Console.Clear();
                    ConsoleUtils.QuitConsole();
                    break;
                default:
                    break;
            }
        }

        public void DisplayAboutInfo()
        {
            Console.WriteLine("This game is simply a simulator about painting walls in a specific colour that you would like, to test and see if you like the colour of the paint and want to actually paint your walls in the desired colour.");
            ConsoleUtils.WaitForKey();
            Run();
        }
    }
}
