using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedTxtAdventure.Scenes
{
    class Scene
    {
        protected Game MyGame;

        public Scene(Game game)
        {
            MyGame = game;
        }

        public virtual void Run()
        {

        }
    }
}
