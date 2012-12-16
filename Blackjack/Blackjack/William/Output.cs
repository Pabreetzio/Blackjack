﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blackjack
{
    public class Output : IOutputInput
    {
        public static void DisplayGame(IBlackjackGame game)
        {
            Console.Clear();
            foreach (IPlayer player in game.Players)
            {
                DisplayPlayer(player);

                
            }
        }

        private static void DisplayPlayer(IPlayer player)
        {

        }
    }
}
