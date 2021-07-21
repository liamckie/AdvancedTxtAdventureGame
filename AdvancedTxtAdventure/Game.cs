using System;
using System.Collections.Generic;
using System.Text;
using AdvancedTxtAdventure.Scenes;

namespace AdvancedTxtAdventure
{
    class Game
    {
        public Player MyPlayer;
        public TitleScene MyTitleScene;
        public CreditsScene MyCreditsScene;
        public NavigationScene MyNavigationScene;
        public GarageScene MyGarageScene;
        public RoomScene MyRoomScene;

        public Game()
        {
            MyPlayer = new Player();
            MyTitleScene = new TitleScene(this);
            MyCreditsScene = new CreditsScene(this);
            MyNavigationScene = new NavigationScene(this);
            MyGarageScene = new GarageScene(this);
            MyRoomScene = new RoomScene(this);
        }

        public void Start()
        {
            MyTitleScene.Run();
            //MyCreditsScene.Run();
        }
    }
}
