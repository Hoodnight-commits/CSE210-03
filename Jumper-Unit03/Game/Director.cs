// Start game
using System;
using System.Collections.Generic;

namespace Jumper_Unit04
{
    public class Director
    {
        public void startGame()
        {
            Player player = new Player();
            player.checkLetter();
        }
    }
}