using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedTxtAdventure.Scenes
{
    class GarageScene : Scene
    {
        string GarageArt = @"+-----------------------------------------------------------------------------------------------+
|                                                                                               |
|                                                                                               |
|                                                                                               |
|                                                                                               |
|                  +--------------------------++-----------------------------+                  |
|                  |                          ||                             |                  |
|                  |                          ||                             |---------+        |
|                  |                          ||                             |         |        |
|                  |                          ||                             |         |        |
|                  |                          ||                             |         |        |
|                  |                          ||                             |         |        |
|                  |                          ||                             |         |        |
|                  |                          ||                             |         |        |
|                  |                          ||                             |         |        |
|                  |   +----+                 ||                             |         |        |
|                  |   |    |                 ||                           +-|---------+        |
|                  |   |    |       +---+     ||                           +-|                  |
|                  |   |    |       |   |     ||                             |                  |
|                  |---+----+-------|   |-----||                             |                  |
|                  |                |   |     ||                             |                  |
|                  |                +---+     ||                             |                  |
|                  |   +---+                  ||                             |                  |
|                  |   |   |                  ||                             |                  |
|                  |   |   |                  ||                             |                  |
|                  |   +---+                  ||                             |                  |
|                  |                          ||                             |                  |
|                  |                          ||                             |                  |
+------------------+--------------------------++-----------------------------+------------------+
";

        public GarageScene(Game game) : base(game)
        {

        }

        public override void Run()
        {
            if (!MyGame.MyPlayer.HasFlashlight)
            {
                Console.Clear();
                Console.WriteLine("You look through the garage door and you can't see any paint or anything for that matter. There is nothing to do here yet!");
                ConsoleUtils.WaitForKey();
                MyGame.MyNavigationScene.Run();
            }
            else
            {
                Console.Clear();
                string prompt = $@"{GarageArt}
You pull out your flashlight and step through the garage door to find a couple of paint cans.";
                string[] options = { "Red", "Green", "Blue" };
                Menu menu = new Menu(prompt, options);
                int selectedIndex = menu.Run();

                switch (selectedIndex)
                {
                    case 0:
                        Console.WriteLine("You pick up the Red Paint");
                        MyGame.MyPlayer.PickUpPaint(ConsoleColor.DarkRed);
                        break;
                    case 1:
                        Console.WriteLine("You pick up the Green Paint");
                        MyGame.MyPlayer.PickUpPaint(ConsoleColor.DarkGreen);
                        break;
                    case 2:
                        Console.WriteLine("You pick up the Blue Paint");
                        MyGame.MyPlayer.PickUpPaint(ConsoleColor.DarkBlue);
                        break;
                    default:
                        break;
                }
                ConsoleUtils.WaitForKey();
                MyGame.MyNavigationScene.Run();
            }
        }
    }
}
