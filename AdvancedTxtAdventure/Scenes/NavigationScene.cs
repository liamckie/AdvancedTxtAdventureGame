using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedTxtAdventure.Scenes
{
    class NavigationScene : Scene
    {
        public NavigationScene(Game game) : base(game)
        {

        }

        public override void Run()
        {
            string prompt = "You've got the exciting responsibility of painting your room today. Where would you like to start? : ";
            string[] options = { "Garage", "Room" };
            Menu menu = new Menu(prompt, options);
            int selectedIndex = menu.Run();

            switch (selectedIndex)
            {
                case 0:
                    MyGame.MyGarageScene.Run();
                    ConsoleUtils.WaitForKey();
                    break;
                case 1:
                    MyGame.MyRoomScene.Run();
                    ConsoleUtils.WaitForKey();
                    break;
                default:
                    break;
            }
        }
    }
}
