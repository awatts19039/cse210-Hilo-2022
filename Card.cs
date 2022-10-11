using System;
using System.Collections.Generic;


namespace Unit03.Game
{
    ///Card is for drawing the first card from the deck
    public class Card
    {
        private int cardnum = 0;

        private void Draw()
        {
            Random rnd = new Random();
            int cardnum = rnd.Next(1,13);
            
        }
    }
}