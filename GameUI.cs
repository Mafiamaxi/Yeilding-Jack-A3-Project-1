﻿using System;
using System.Numerics;

namespace Game10003
{
    class GameUI
    {
        int score;
        Player player;
        
        // functions

        //GameUI Constructor
         
        public GameUI (Player playerRef)
        {
            player = playerRef;
        }

        public void DisplayHealth()
        {
            //Displaying Text to Screen
            Text.Draw("Health; " + player.currentHealth, 5, 5);
        }

        public void DisplayScore()
        {
            Text.Draw("Score; " + score, 410, 5);
        }

        public void IncreaseScore()
        {
            score += 1;
        }

        public void Setup()
        {
            score = 0; 
        }
    }
}
