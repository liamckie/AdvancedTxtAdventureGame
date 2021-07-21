using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedTxtAdventure.Scenes
{
    class RoomScene : Scene
    {
        string RoomArt = @"+-----------------------------------------------------------------------------------------------+
|                                                                                               |
|                                                                                               |
|                                                                                               |
|                                                                                               |
|        +-----------------+                                         +-----------------+        |
|        |                 |                                         |                 |        |
|        |                 |                                         |                 |        |
|        |                 |                                         |                 |        |
|        |                 |                                         |                 |        |
|        |                 |                                         |                 |        |
|        |                 |            +-------------------+        |                 |        |
|        +-----------------+            |                   |        +-----------------+        |
|                                       |                   |                                   |
|                                       |    WINDOWS 11     |                                   |
|                                       |                   |                                   |
|                                       |                   |                                   |
|                                       |                   |                                   |
|                                       |___________________|                                   |
|                             +---------+-------------------+---------+                         |
|                             |                                       |                         |
|                             +--------+-+-----------------+-+--------+                         |
|                                      | |                 | |                                  |
|                                      | |                 | |                                  |
|                                      | |                 | |                                  |
|                                      | |                 | |                                  |
|                                      | |                 | |                                  |
|                                      | |                 | |                                  |
+--------------------------------------+-+-----------------+-+----------------------------------+
";

        public RoomScene(Game game) : base(game)
        {

        }

        public override void Run()
        {
            string prompt = $@"{RoomArt}
Here is your room. The walls look pretty bland. What do you want to do";
            string[] options = { "Go Someplace Else", "Look Under The Desk", "Paint The Wall" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    MyGame.MyNavigationScene.Run();
                    break;
                case 1:
                    InteractWithDesk();
                    break;
                case 2:
                    InteractWithWall();
                    break;
                default:
                    break;
            }
        }

        private void InteractWithDesk()
        {
            if (!MyGame.MyPlayer.HasFlashlight)
            {
                Console.WriteLine("Ah, my flashlight. This could be handy. I'll take it.");
                MyGame.MyPlayer.HasFlashlight = true;
            }
            else
            {
                Console.WriteLine("It's empty!");
            }
            ConsoleUtils.WaitForKey();
            Run();
        }

        private void InteractWithWall()
        {
            if (!MyGame.MyPlayer.HasPaint)
            {
                Console.WriteLine("I don't have any paint yet!");
                ConsoleUtils.WaitForKey();
                Run();
            }
            else
            {
                Console.Clear();
                Console.BackgroundColor = MyGame.MyPlayer.PaintColour;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(RoomArt);
                Console.ResetColor();
                Console.WriteLine("Beautiful" +
                                  "\nChores finally complete, now back to playing video games!");
                ConsoleUtils.WaitForKey();
                MyGame.MyCreditsScene.Run();
            }
        }
    }
}

