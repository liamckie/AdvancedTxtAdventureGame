using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedTxtAdventure
{
    class Player
    {
        public bool HasFlashlight { get; set; }
        public bool HasPaint { get; private set; }
        public ConsoleColor PaintColour { get; private set; }
        
        public Player()
        {
            HasPaint = false;
            HasFlashlight = false;
        }

        public void PickUpPaint(ConsoleColor colour)
        {
            HasPaint = true;
            PaintColour = colour;

        }
    }
}
